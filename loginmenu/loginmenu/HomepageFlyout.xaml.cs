using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace loginmenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomepageFlyout : ContentPage
    {
        public ListView ListView;

        public HomepageFlyout()
        {
            InitializeComponent();
          
            BindingContext = new HomepageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class HomepageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomepageFlyoutMenuItem> MenuItems { get; set; }

            public HomepageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HomepageFlyoutMenuItem>(new[]
                {
                
                    new HomepageFlyoutMenuItem { Id = 0, Title = "Homepage" , IconSource="comp1.png" ,TargetType=typeof(Homepage) },
                    new HomepageFlyoutMenuItem { Id = 0, Title = "Feature1" , IconSource="comp1.png" ,TargetType=typeof(Feature1) },
                    new HomepageFlyoutMenuItem { Id = 1, Title = "Feature2" , IconSource="aero.png",TargetType=typeof(Feature2) },
                    new HomepageFlyoutMenuItem { Id = 2, Title = "Feature3" ,IconSource="pers.png" ,TargetType=typeof(Feature3) },
                    new HomepageFlyoutMenuItem { Id = 3, Title = "Feature4" ,IconSource="comp1.png" ,TargetType=typeof(Feature4) },
                    new HomepageFlyoutMenuItem { Id = 4, Title = "Logout" , IconSource="aero.png" ,TargetType=typeof(MainPage) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}