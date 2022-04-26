using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Twilio;
//using Twilio.Rest.Api.V2010.Account;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginmenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        ////// Find your Account SID and Auth Token at twilio.com/console
        ////// and set the environment variables. See http://twil.io/secure

        //string MyrecentOTP;
        public RegisterPage()
        {
            InitializeComponent();
          

        }
        
   
        private void Button_Clicked(object sender, EventArgs e)
        {
            //const string accountSid = "AC215f6a3ef3c15b0915be57524740706c";
            //const string authToken = "92c094c6fdd610a84ceef1b88890ef06";

            //TwilioClient.Init(accountSid, authToken);

            //Random generator = new Random();
            //string randomotp = generator.Next(0, 9999).ToString("D4");

            //var message = MessageResource.Create(
            //    body: "Your new otp number is  " + randomotp,
            //    from: new Twilio.Types.PhoneNumber("+19378835175"),
            //    to: new Twilio.Types.PhoneNumber("9867243818")
            //  );



            //Console.WriteLine(message.Sid);
            //MyrecentOTP = randomotp;

        }

            private void Button_Clicked_1(object sender, EventArgs e)
        {
            //if (MyOtp.Text == MyrecentOTP)
            //{
            //    //go to mainpage
            //    Navigation.PushAsync(new MainPage());
            //}
            //else
            //{
            //    App.Current.MainPage.DisplayAlert("Alert", "OTP verification error", "OK");
            //}
        }
    }
}