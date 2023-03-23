using NavigateByRole.ViewModels;

namespace NavigateByRole.Views;

public partial class StudentView : ContentPage
{
	public StudentView()
	{
		InitializeComponent();
        BindingContext = new StudentViewModel();
	}

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}