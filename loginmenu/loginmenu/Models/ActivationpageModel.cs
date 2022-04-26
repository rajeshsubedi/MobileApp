using loginmenu.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace loginmenu.Models
{
    class ActivationpageModel
    {
        private readonly ApiServices _apiServices = new ApiServices();
        
        public int Liscence { get; set; }

        public int Token { get; set; }

        public string Message { get; set; }

        //public ICommand ActivationCommand
        //{
        //    //get
        //    //{
        //    //    return new Command(async() =>
        //    //    //{
        //    //    //    //var isSuccess = await _apiServices.ActivationpageAsync()
        //    //    //}
        //    //}
        //}

    }
}
