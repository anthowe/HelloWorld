using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {
        [Obsolete]
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 40, 0, 0);
            else if (Device.OS == TargetPlatform.Android)
                Padding = new Thickness(200, 40, 0, 0);
            else if (Device.OS == TargetPlatform.Windows)
                Padding = new Thickness(0, 40, 0, 0);



            Device.OnPlatform(
                iOS: new Thickness(0, 40, 0, 0),
                Android: new Thickness(200, 40, 0, 0),
                WinPhone: new Thickness(0, 0, 0, 0);


        }


    }



}

