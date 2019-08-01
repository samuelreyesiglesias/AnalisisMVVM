using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVentas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }
        /*
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }
        protected override void OnParentSet()
        {
            base.OnParentSet();
        }
         * protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        protected override void OnTabStopPropertyChanged(bool oldValue, bool newValue)
        {
            base.OnTabStopPropertyChanged(oldValue, newValue);
        }
        protected override void OnChildMeasureInvalidated(object sender, EventArgs e)
        {
            base.OnChildMeasureInvalidated(sender, e);
        }
        protected override void OnChildRemoved(Element child)
        {
            base.OnChildRemoved(child);
        }
        */
        public int _MyProperty;
        public int MyProperty { get { return _MyProperty; } set { _MyProperty = value; OnPropertyChanging(); } }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
        //public event PropertyChangingEventHandler PropertyChanged;
        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            DisplayAlert("cambio","cambio ","ok");
            //PropertyChanged?.Invoke(this, new PropertyChangingEventArgs(propertyName));
            base.OnPropertyChanging(propertyName);
        }
        /*
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
        }
        protected override void OnTabIndexPropertyChanged(int oldValue, int newValue)
        {
            base.OnTabIndexPropertyChanged(oldValue, newValue);
        }
        */
        private void Button_Clicked(object sender, EventArgs e)
        {
            MyProperty++;
            DisplayAlert("Datos", "num:" + MyProperty, "ok");
        }
    }
}