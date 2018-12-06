using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PCKontrolAndroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            App.Bagla(IPadd.Text, Int32.Parse(Port.Text));
            IPadd.IsVisible = false;
            Port.IsVisible = false;
            PIN.IsVisible = true;
            Baglan.IsVisible = false;
            Onay.IsVisible = true;
            
            
        }

        private void Onay_Clicked(object sender, EventArgs e)
        {
            App.Gonder(PIN.Text);
            Task.Delay(1000);
            if (App.client.Client.Connected == true)
            {
                App.Current.MainPage = new Kontrol();
            }
            else
            {
                App.Bagla(IPadd.Text, Int32.Parse(Port.Text));
                PIN.Text = "";
            }
        }
    }
}
