using System;
using System.ComponentModel;
using TipCalculator.Models;
using TipCalculator.ViewModel;
using Xamarin.Forms;

namespace TipCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

    }
}
