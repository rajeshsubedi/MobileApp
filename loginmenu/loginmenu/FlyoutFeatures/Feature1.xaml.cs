using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loginmenu;
using loginmenu.FeaturesDatabase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginmenu

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feature1 : ContentPage
    {
        public Feature1()
        {
            InitializeComponent();
        }

       
        //event handler from database

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database1.GetPeopleAsync();
        }

        //event handler in cs file for database

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                await App.Database1.SavePerson1Async(new Person1
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                nameEntry.Text = ageEntry.Text = string.Empty;

                collectionView.ItemsSource = await App.Database1.GetPeopleAsync();
            }
        }

    }
}