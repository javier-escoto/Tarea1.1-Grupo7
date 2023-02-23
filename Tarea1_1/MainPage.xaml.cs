using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);

            int result = n1 + n2;
            string oper = "Suma";

            await Application.Current.MainPage.Navigation.PushModalAsync(new Resultado(result, oper));
            //DisplayAlert("Mensaje", res.ToString(), "total");
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);

            int result = n1 - n2;
            string oper = "Resta";

            await Application.Current.MainPage.Navigation.PushModalAsync(new Resultado(result, oper));
            //DisplayAlert("Mensaje", resta.ToString(), "total");
        }

        private async void btnultiplicacion_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);

            int result = n1 * n2;

            string oper = "Multiplicación";

            await Application.Current.MainPage.Navigation.PushModalAsync(new Resultado(result, oper));
            //DisplayAlert("Mensaje", multiplicacion.ToString(), "total");
        }

        private async void btnDivision_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);

            int result = n1 / n2;
            string oper = "División";

            await Application.Current.MainPage.Navigation.PushModalAsync(new Resultado(result, oper));
            //DisplayAlert("Mensaje", division.ToString(), "total");
        }
    }
}
