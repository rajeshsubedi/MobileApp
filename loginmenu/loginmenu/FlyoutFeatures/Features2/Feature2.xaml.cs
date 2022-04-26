using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using loginmenu;
using System.Collections.Generic;
using System.Collections;
using loginmenu.Models;

namespace loginmenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feature2 : ContentPage
    {
        public Feature2()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MyDatabase.ReadEmployees();
                   }
            catch { }
       
            }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmployeeDetail());
        }

        async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var emp = item.CommandParameter as EmployeeModel;
            await Navigation.PushAsync(new EmployeeDetail(emp));
        }

        // to change in data



        // to delete from database
        async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var emp = item.CommandParameter as EmployeeModel;
            var result = await DisplayAlert("Delete ", $"Delete {emp.Name} from the database", "Yes", "No");
       if(result)
            {
                await App.MyDatabase.DeleteEmployee(emp);
                //to refresh fastly
                myCollectionView.ItemsSource = await App.MyDatabase.ReadEmployees();
            }
        }

        async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            myCollectionView.ItemsSource = await App.MyDatabase.Search(e.NewTextValue);
        }
    }

}    