using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void btn_SignIn_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabbedPage1());
        }

    }
}