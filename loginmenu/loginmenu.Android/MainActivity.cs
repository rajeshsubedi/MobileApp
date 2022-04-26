using System;
using Android.Views;
using Android.Content;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Android.Widget;
using Android;

namespace loginmenu.Droid
{
    [Activity(Label = "loginmenu", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        //<===============================using seession=================================>

        //    EditText Liscence, Token;
        //    Button VERIFY;
        //    public static string userSessionPref = "userPrefs";
        //    public static string User_Liscence = "UserLiscence";
        //    public static string User_Token = "UserToken";
        //    ISharedPreferences session;
        //    int SESSION_LISCENCE, SESSION_PASS;

        //    protected override void OnCreate(Bundle savedInstanceState)
        //    {
        //        base.OnPostCreate(savedInstanceState);

        //        SetContentView(Resource.Layout.Activationpage);
        //        checkCredentials();
        //        initialize();
        //        session = GetSharedPreferences(userSessionPref, FileCreationMode.Private);
        //    }
        //    public void initialize()
        //    {
        //        Liscence = (EditText)FindViewById(Resource.Id.userLiscence);
        //        Token = (EditText)FindViewById(Resource.Id.userToken);
        //        VERIFY = (Button)FindViewById(Resource.Id.VERIFYInBtn);
        //        VERIFY.SetOnClickListener(this);
        //    }
        //    public void OnClick(View v)
        //    {
        //        switch (v.Id)
        //        {
        //            case Resource.Id.VERIFYInBtn:
        //                SESSION_LISCENCE = Liscence.Text.ToString();
        //                SESSION_PASS = Token.Text.ToString();
        //                ISharedPreferencesEditor session_editor = session.Edit();
        //                session_editor.PutString("Liscence", SESSION_LISCENCE);
        //                session_editor.PutString("Token", SESSION_PASS);
        //                session_editor.Commit();
        //                Intent n = new Intent(this, typeof(MainPage));
        //                StartActivity(n);
        //                Finish();
        //                break;
        //        }
        //    }

        //    public void checkCredentails()
        //    {
        //        ISharedPreferences preferences = GetSharedPreferences(userSessionPref, FileCreationMode.Private);
        //        string Liscence = preferences.GetString("Liscence", "");
        //        Toast.MakeText(this, Liscence, ToastLength.Short).Show();
        //        string Token = preferences.GetString("Token", "");
        //        if (!Liscence.Equals("") && !Token.Equals(""))
        //        {
        //            Intent n = new Intent(this, typeof(MainPage));
        //            StartActivity(n);
        //            Finish();
        //        }
        //    }

        //}


        //<---------------------------------------------using cookies----------------------------------------------------------------->






















        //<=============================For image circle======================================>

        //protected override void oncreate(bundle savedinstancestate)
        //{
        //    base.oncreate(savedinstancestate);

        //    xamarin.essentials.platform.init(this, savedinstancestate);
        //    global::xamarin.forms.forms.init(this, savedinstancestate);
        //    imagecirclerenderer.init();
        //    loadapplication(new app());
        //}


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            ImageCircleRenderer.Init();
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}