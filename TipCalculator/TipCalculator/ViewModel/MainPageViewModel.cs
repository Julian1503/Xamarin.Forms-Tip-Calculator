using System;
using System.Collections.Generic;
using System.Text;
using TipCalculator.Models;
using Xamarin.Forms;

namespace TipCalculator.ViewModel
{
   public class MainPageViewModel
    {
        public TipModel tipModel;
        public MainPageViewModel()
        {
            OperationsCommand = new Command(DoCalculates);
            tipModel = new TipModel()
            {
                People = 2,
                Tip = 20
            };
        }
        public Command OperationsCommand { get; set; }

        private void DoCalculates()
        {

            tipModel.TipPay = (tipModel.Tip / 100m) * tipModel.Total;
            tipModel.TipPerPeople = tipModel.TipPay / tipModel.People;
            tipModel.TotalPay = tipModel.Total + tipModel.TipPay;
            tipModel.TotalPerPerson = tipModel.TotalPay / tipModel.People;
        }

    }
}
