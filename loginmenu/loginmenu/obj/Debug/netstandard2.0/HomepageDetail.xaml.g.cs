//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("loginmenu.HomepageDetail.xaml", "HomepageDetail.xaml", typeof(global::loginmenu.HomepageDetail))]

namespace loginmenu {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("HomepageDetail.xaml")]
    public partial class HomepageDetail : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry nameEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.CheckBox subscribed;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.CollectionView collectionView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(HomepageDetail));
            nameEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "nameEntry");
            subscribed = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.CheckBox>(this, "subscribed");
            collectionView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.CollectionView>(this, "collectionView");
        }
    }
}
