using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnsm.Clicked += somme;
            btnsus.Clicked += sust;
            btnmul.Clicked += mul;
        }
        private void mul(object sender,EventArgs e)
        {
            int nb1 = int.Parse(txtnb1.Text);
            int nb2 = int.Parse(txtnb2.Text);

            int res = nb1 * nb2;
            txtres.Text = res.ToString();
        }
        private void somme(object sender,EventArgs e)
        {
            int nb1 = int.Parse(txtnb1.Text);
            int nb2 = int.Parse(txtnb2.Text);

            int res = nb1 + nb2;
            txtres.Text = res.ToString();
        }
        
        private void sust(object sender,EventArgs e)
        {
            int nb1 = int.Parse(txtnb1.Text);
            int nb2 = int.Parse(txtnb2.Text);

            int res = nb1 - nb2;
            txtres.Text = res.ToString();
        }
    }
}
