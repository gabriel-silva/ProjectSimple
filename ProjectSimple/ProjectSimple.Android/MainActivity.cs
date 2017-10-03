using System;
using Android.App;
using Android.Content.PM;
using Android.Widget;
using Android.OS;

namespace ProjectSimple.Droid
{
    [Activity(Label = "ProjectSimple", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        private EditText editText;
        private EditText editText2;
        private TextView textView;
        private Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainActivity);
            editText = FindViewById<EditText>(Resource.Id.editText1);
            editText2 = FindViewById<EditText>(Resource.Id.editText2);
            textView = FindViewById<TextView>(Resource.Id.textView3);
            button = FindViewById<Button>(Resource.Id.button);
            button.Click += delegate
            {
                int resultado = MyClass.Soma(int.Parse(editText.Text), int.Parse(editText2.Text));
                textView.Text = "O resultado da soma é: " + resultado;
            };
        }
    }
}

