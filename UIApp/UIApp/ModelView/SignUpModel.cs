using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UIApp.ModelView
{
    class SignUpModel
    {
        public ICommand back => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
}
