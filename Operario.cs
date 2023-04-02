using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperarioGUI
{
    class Operario : Persona
    {
        private int categoria, horasTrabajadas;
        private double precioHora;

        public int pCategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int pHorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }

        public double pPrecioHora
        {
            get { return precioHora; }
            set { precioHora = value; }
        }

        //Constructores

        public Operario() :base() //Es la palabra clave para acceder a todo lo que se tiene por herencia. A la base se le llama al constructor por defecto
        {
            categoria = 1;
            horasTrabajadas = 0;
            precioHora = 0;

        }

        public Operario(int cat, int horas, double precio, int dni, bool sexo, string nombre, DateTime fecNac)  : base(dni, sexo, nombre, fecNac)//Parámetros de Operario y Persona
        {
            this.categoria = cat;
            this.horasTrabajadas = horas;
            this.precioHora = precio;

        }

        public string toStringOperario()
        {
            return base.toStringPersona() + "\nCategoria" + mostrarCategoria() +
                "\nPrecio Hora" + precioHora + "\nHoras Trabajadas" + horasTrabajadas;
        }
        
        private string mostrarCategoria()
        {
            string aux = "Capataz";
            if (categoria == 2)
                aux = "Oficial";
            return aux;
        }

        public double calcularSueldo()
        {

            return precioHora * horasTrabajadas;//Si voy a devolver un double. Se espera return en la accion. Es una palabra de tipo cancelativa, corta la ejecución del método y vuelve a quien lo llamó
            
        }
    }
}
