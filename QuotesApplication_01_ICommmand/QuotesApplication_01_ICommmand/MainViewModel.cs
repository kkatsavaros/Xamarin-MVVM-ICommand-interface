using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;
using Xamarin.Forms;


namespace QuotesApplication_01_ICommmand
{
    public class MainViewModel
    {
        public ICommand LoginCommand { get; set; }

        private string _userName;   //propfull + Tab.

        public string UserName      // 'Οτι γράφω στο Entry πηγαίνει στο property UserName.
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public MainViewModel()
        {
            LoginCommand = new Command(Login);
        }

        private void Login()
        {
            App.Current.MainPage.DisplayAlert("Hi", _userName, "Alright");
        }
    }
}
