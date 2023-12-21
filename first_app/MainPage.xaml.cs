namespace first_app
{
    public partial class MainPage : ContentPage
    {
        string var_username;
        string var_passname;

        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void OnAuthenticationClicked(object sender, EventArgs e)
        {
            var_username = UsernameEntry.Text;
            var_passname = PasswordEntry.Text;

            if (var_username == "admin" && var_passname == "passwd")
            {
                await DisplayAlert("Notice", "Access allowed", "OK");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Notice", "Access denied", "OK");
            }
        }
    }
}
