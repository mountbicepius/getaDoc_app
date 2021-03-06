﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace getaDoc_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Patients : Page
    {
        public Patients()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void appoint_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(appointments));
        }

        private void disease_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Disease));
        }

        private void doctorList_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(listDoctors));
        }
    }
}
