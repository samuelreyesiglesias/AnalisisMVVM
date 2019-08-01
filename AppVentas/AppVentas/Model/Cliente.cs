using System;
using System.Collections.Generic;
using System.Text;

namespace AppVentas.Model
{
    /// <summary>
    /// Clase Cliente para definir sus propiedades
    /// </summary>
    public class Cliente
    {
        //Propiedades privadas y publicas  de la clase Cliente

        private int _Dui;
        public int DUI
        {
            get { return _Dui; }
            set { _Dui = value; }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }



    }
}
