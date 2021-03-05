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
    public partial class Segunda : ContentPage
    {
        public Segunda()
        {
            InitializeComponent();
        }

        private void btnxd_Clicked(object sender, EventArgs e)
        {
            int num = Int32.Parse(lblnum.Text);
            int resul, o1, o2, o3, o4, o5,re;
            

            resul = num * 2;
            resul = resul + 8;
            resul = resul * 5;
           
            if (resul <= 9999)
            {
                o1 = resul / 1000;
                o2 = resul % 1000;
                o3 = o2 / 100;
                o4 = o2 % 100;
                o5 = o4 / 10;
                re = (o1 * 100) + (o3 * 10) + (o5);
                resul = re- 4;

            }
            lblL.Text = resul.ToString();
            lblL.Text = resul + " ";
        }
    }
}