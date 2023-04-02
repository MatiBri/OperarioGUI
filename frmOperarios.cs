using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperarioGUI
{
    public partial class frmOperarios : Form
    {
        private int cCapataz, cOficiales; //Contador de capataces y oficiales
        private double totSueldos;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Operario op = new Operario(); //Se lo crea con el constuctor "()" sin parámetros
            op.pNombre = txtNombre.Text; //Text es una propiedad
            op.pCategoria = cboCategorias.SelectedIndex + 1; //Dice cual es el índice seleccionado en la lista. Entonces es el índice + 1
            op.pFechaNacimiento = dtpFecNac.Value;
            op.pSexo = rbMasculino.Checked;
            op.pDocumento = Convert.ToInt32(txtDni.Text);
            op.pPrecioHora = Convert.ToDouble(txtPrecioHora.Text);
            op.pHorasTrabajadas = Convert.ToInt32(txtPrecioHora.Text);

            //Completar

            if (op.pCategoria == 1)
                cCapataz++;
            else
                cOficiales++;
            totSueldos += op.calcularSueldo();//totalSueldo= totalSueldo + calcularSueldo()
            lblCtdCapa.Text = "Cantidad capataces" + cCapataz;
            lblTotOfi.Text = "Cantidad oficiales" + cOficiales;
            lblSueldo.Text = "Sueldos" + op.calcularSueldo();
            lblTotSueldos.Text= "Total Sueldos: "+totSueldos;  

            MessageBox.Show(op.toStringOperario());
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        public frmOperarios()
        {
            InitializeComponent();
            cCapataz = 0;
            cOficiales = 0;
            totSueldos = 0;
        }

        
    }
}
