using loginmenu.FeaturesDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginmenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomepageDetail : ContentPage
    {
        public HomepageDetail()
        {
            InitializeComponent();
        }



        //event handler from database

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }
        
                      //event handler in cs file for database

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Subscribed = subscribed.IsChecked
                });

                nameEntry.Text = string.Empty;
                subscribed.IsChecked = false;

                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }

   
        
        
    }
}