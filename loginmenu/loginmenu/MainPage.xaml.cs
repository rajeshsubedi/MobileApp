using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loginmenu
{
    public partial class MainPage : ContentPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "12345")
            {
                Navigation.PushAsync(new Homepage());
            }
        
           else
                  {
                    DisplayAlert("Sorry", "Username or Password is incorrect.", "OK");
                  } 
        }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
        Navigation.PushAsync(new RegisterPage());
    }
    }
}
