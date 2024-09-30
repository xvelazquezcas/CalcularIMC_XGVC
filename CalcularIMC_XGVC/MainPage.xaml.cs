using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularIMC_XGVC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var imc = peso / (altura * altura);

                IMC.Text = imc.ToString();

                string resultado = "";
                if (imc < 18.5)
                {
                    resultado = "Te hace falta comer";
                }
                else if (imc <= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc < 25 && imc <= 29.9)
                {
                    resultado = "Estas pasado de kilos";
                }
                else
                {
                    resultado = "Tienes obesidad, cuuidate";
                }
                DisplayAlert("Rango de peso:", resultado, "Ya vete");
            }
            else
            {
                DisplayAlert("Datos incompletos", "Ingresa todos los datos", "Ya vete");

            }
        }

    }
}
