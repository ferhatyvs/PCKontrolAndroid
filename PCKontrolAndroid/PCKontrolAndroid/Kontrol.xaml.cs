using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCKontrolAndroid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kontrol : ContentPage
	{
		public Kontrol ()
		{
			InitializeComponent ();
		}

        private void b10_Clicked(object sender, EventArgs e)
        {
            
            if (b10.Text == "Gece")
            {
                al0.BackgroundColor = Xamarin.Forms.Color.Black;
                kutuCerceve.BackgroundColor = Xamarin.Forms.Color.White;
                kutu.BackgroundColor = Xamarin.Forms.Color.Black;
                b0.BackgroundColor = Xamarin.Forms.Color.Black;
                b1.BackgroundColor = Xamarin.Forms.Color.Black;
                b2.BackgroundColor = Xamarin.Forms.Color.Black;
                b3.BackgroundColor = Xamarin.Forms.Color.Black;
                b4.BackgroundColor = Xamarin.Forms.Color.Black;
                b5.BackgroundColor = Xamarin.Forms.Color.Black;
                b6.BackgroundColor = Xamarin.Forms.Color.Black;
                b7.BackgroundColor = Xamarin.Forms.Color.Black;
                b8.BackgroundColor = Xamarin.Forms.Color.Black;
                b9.BackgroundColor = Xamarin.Forms.Color.Black;
                b10.BackgroundColor = Xamarin.Forms.Color.Black;
                b11.BackgroundColor = Xamarin.Forms.Color.Black;
                b0.TextColor = Xamarin.Forms.Color.White;
                b1.TextColor = Xamarin.Forms.Color.White;
                b2.TextColor = Xamarin.Forms.Color.White;
                b3.TextColor = Xamarin.Forms.Color.White;
                b4.TextColor = Xamarin.Forms.Color.White;
                b5.TextColor = Xamarin.Forms.Color.White;
                b6.TextColor = Xamarin.Forms.Color.White;
                b7.TextColor = Xamarin.Forms.Color.White;
                b8.TextColor = Xamarin.Forms.Color.White;
                b9.TextColor = Xamarin.Forms.Color.White;
                b10.TextColor = Xamarin.Forms.Color.White;
                b11.TextColor = Xamarin.Forms.Color.White;
                b10.Text = "Normal";
                b10.FontSize--;
            }
            else
            {
                al0.BackgroundColor = Xamarin.Forms.Color.White;
                kutuCerceve.BackgroundColor = Xamarin.Forms.Color.White;
                kutu.BackgroundColor = Xamarin.Forms.Color.Gray;
                b0.BackgroundColor = Xamarin.Forms.Color.Gray;
                b1.BackgroundColor = Xamarin.Forms.Color.Gray;
                b2.BackgroundColor = Xamarin.Forms.Color.Gray;
                b3.BackgroundColor = Xamarin.Forms.Color.Gray;
                b4.BackgroundColor = Xamarin.Forms.Color.Gray;
                b5.BackgroundColor = Xamarin.Forms.Color.Gray;
                b6.BackgroundColor = Xamarin.Forms.Color.Gray;
                b7.BackgroundColor = Xamarin.Forms.Color.Gray;
                b8.BackgroundColor = Xamarin.Forms.Color.Gray;
                b9.BackgroundColor = Xamarin.Forms.Color.Gray;
                b10.BackgroundColor = Xamarin.Forms.Color.Gray;
                b11.BackgroundColor = Xamarin.Forms.Color.Gray;
                b0.TextColor = Xamarin.Forms.Color.Black;
                b1.TextColor = Xamarin.Forms.Color.Black;
                b2.TextColor = Xamarin.Forms.Color.Black;
                b3.TextColor = Xamarin.Forms.Color.Black;
                b4.TextColor = Xamarin.Forms.Color.Black;
                b5.TextColor = Xamarin.Forms.Color.Black;
                b6.TextColor = Xamarin.Forms.Color.Black;
                b7.TextColor = Xamarin.Forms.Color.Black;
                b8.TextColor = Xamarin.Forms.Color.Black;
                b9.TextColor = Xamarin.Forms.Color.Black;
                b10.TextColor = Xamarin.Forms.Color.Black;
                b11.TextColor = Xamarin.Forms.Color.Black;
                b10.Text = "Gece";
                b10.FontSize++;
            }   
        }       
    }
}