using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularPorcentajeDePropina_Cesar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }




        private void Calcular(object sender, EventArgs e)
        {
            //variables
            var precioPagar = float.Parse(monto.Text);
            var porcentajeXd = float.Parse(porcentaje.Text);
            var compartenCuentaXd = float.Parse(compartenCuenta.Text);

            //respuesta
            var respuesta = precioPagar / compartenCuentaXd;


            

            Respuesta.Text = respuesta.ToString();

            string mensaje = " ";

            if (porcentajeXd < 10)
            {

                mensaje = "Eres bien codo" + respuesta;
                Triste.IsVisible = true;
                Feliz.IsVisible = false;
            }
            else if (porcentajeXd >= 10)
            {
                mensaje = "No eres codo" + respuesta;
                Triste.IsVisible = false;
                Feliz.IsVisible = true;
            }
            DisplayAlert("Respuesta", mensaje, "Quitar");
        }

        

    }


}
