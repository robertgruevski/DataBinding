using System.Collections.ObjectModel;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<int> TestScores { get; set; } = new ObservableCollection<int>
        {
            82,74,97,76,81,90
        };
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this; // Set the BindingContext to the Main Page instance to enable data binding
								   // Sometimes you want to use a ViewModel instead
		}

		private void buttonAddScore_Clicked(object sender, EventArgs e)
		{

        }
    }
}
