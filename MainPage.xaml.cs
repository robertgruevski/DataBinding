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
								   // MVVM is a pattern where the model (data) is separated from the view (UI)
		}

		private void buttonAddScore_Clicked(object sender, EventArgs e)
		{
            if (int.TryParse(textAddScore.Text, out int newScore) && newScore >= 0 && newScore <= 100)
            {
                TestScores.Add(newScore); // Will automatically updated the CollectionView due to data binding
                textAddScore.Text = string.Empty; // Clear the input field after adding
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid score between 0 and 100.", "OK");
			}
		}

		private void OnDeleteScore(object sender, EventArgs e)
		{
            if(sender is Button button && button.BindingContext is int score)
            {
                TestScores.Remove(score); // Remove the score from the collection
            }
            else
            {
                DisplayAlert("Error", "Unable to delete score", "OK");
            }
		}
	}
}
