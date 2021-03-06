﻿using Microsoft.Phone.Controls;
using NControl.Controls.WP81;
using NControl.WP81;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace NControl.Controls.Demo.FormsApp.WP81
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            Forms.Init();
            NControlViewRenderer.Init();
            NControls.Init();          
            
            LoadApplication(new FormsApp.MyApp());
        }      
    }
}