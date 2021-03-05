using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apppruebaa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tercera : ContentPage
    {
        public Tercera()
        {
            InitializeComponent();
        }

        private void GO_Clicked(object sender, EventArgs e)
        {
            int dia = Int32.Parse(lbldia.Text);
            int mes = Int32.Parse(lblmes.Text);
            int res;
            
            dia = dia * 20;
            dia = dia + 73;
            dia = dia * 5;
            dia = dia + mes;
            res = dia-365;

            resultado.Text = res.ToString();
            resultado.Text = res + " ";

        }

    }
}