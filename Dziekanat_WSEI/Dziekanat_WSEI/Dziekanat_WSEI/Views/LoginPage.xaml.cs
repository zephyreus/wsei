using Dziekanat_WSEI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziekanat_WSEI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void LoginProcedure(object sender, EventArgs e)
        {
            User user = new User(entryUsername.Text, entryPassword.Text);
            if (user.checkCredentials())
            {
                DisplayAlert("Login", "Login success!", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login failed. Please, check your credentials!", "Ok");
            }
        }
    }
}