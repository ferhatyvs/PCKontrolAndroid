﻿using System;
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
            App.Current.MainPage = new Kontrol();
        }
    }
}
