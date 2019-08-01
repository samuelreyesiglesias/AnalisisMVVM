using System;
using System.Collections.Generic;
using System.Text;
using AppVentas.Model;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace AppVentas.ViewModel
{

    //heredamos de la Interfaz INotifyPropertyChanging
    class ClienteVM: INotifyPropertyChanging
    {

        //COMMAND SUSTITUYE EN EL XAML AL EVENTO CLICKED
        public Command Accion { get; set; }

        //INSTANCIA
        public ClienteFrecuente TheClienttt { get; set; }
        //CONSTRUCTOR
        public ClienteVM()
        {
            //INSTANCIA
            ClienteFrecuente NuevoC = new ClienteFrecuente();
            //ASIGNACION DE DATOS
            NuevoC.DUI = 045220768;
            NuevoC.Nombre = "Samuel";
            NuevoC.Apellido = "Reyes";
            //ASIGNACION DEL OBJETO AL OBJETO PUBLICO DEL MISMO TIPO PARA QUE SEA ACCESIBLE DESDE EL MEDOTO ShowData
            TheClienttt = NuevoC;
            //Asignamos el metodo al Command
            Accion = new Command(ShowData);
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; Cambio(); }
        }
        
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        public virtual void Cambio([CallerMemberName] string propiedad=null)
        {
            PropertyChanging?.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(propiedad));
        }
        public void ShowData()
        {
            //INSTANCIA D LA CLASE Y ENVIAMOS UN OBJETO
            funciones Accionar= new funciones(TheClienttt);
            //LLAMAMOS AL METODO PARA MOSTRAR LOS DATOS
            Accionar.MostrarDatos(myVar);
        }
        //creamos una clase Anidada dentro de otra clase...
        // esto solo es un test para ver esta caracteristica de c#
        public class funciones
        {
            //creamos una propiedad publica para que podamos accederla desde el meotod en que
            //mostramos los datos..
            public ClienteFrecuente Cliente { get; set; }
            public funciones(ClienteFrecuente cliente)
            {
                
                //realizamos instancia de la clase
                Cliente = new ClienteFrecuente();
                //Asignando datos a propiedad Cliente para que tome todos los datos qe le
                //transferimos en el constructor
                Cliente = cliente;
            }
            //Metodo para mostrar datos
            public void MostrarDatos(int varr)
            {
                //MOSTRAR DATOS DE EN UN DisplayAlert..
                App.Current.MainPage.DisplayAlert("Mensaje","Nombre:"+Cliente.Nombre+"\nApellido:"+Cliente.Apellido+"\nDUI:"+Cliente.DUI+"\nnum:"+varr,"ok");
            }
        }
    }
 
}
