namespace first_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string var_name;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            var_name = NameEntry.Text;

            DisplayAlert("Alert", $"Hello {var_name}", "OK");

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
