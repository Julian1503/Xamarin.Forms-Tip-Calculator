using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TipCalculator.Models
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal totalPerPerson;
        private decimal totalPay;
        private decimal tipPerPeople;
        private decimal tipPay;

     
        public decimal Total { get; set; }
        public decimal Tip { get; set; }
        public decimal People { get; set; }

        public decimal TipPay { get => tipPay; set { tipPay = value  ; OnPropertyChanged(); } }
        public decimal TipPerPeople { get => tipPerPeople; set { tipPerPeople = value; OnPropertyChanged(); } }
        public decimal TotalPay { get => totalPay; set { totalPay = value; OnPropertyChanged(); } }
        public decimal TotalPerPerson
        {
            get => totalPerPerson; set
            {
                totalPerPerson = value;
                OnPropertyChanged();
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

       

    }
}
