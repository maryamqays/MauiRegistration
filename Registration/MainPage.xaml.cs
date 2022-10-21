using Registration.Models;

namespace Registration;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		btnRegister.IsEnabled = e.Value;
	}

	private void btnRegister_Clicked(object sender, EventArgs e)
	{
		User user = new User {
			FirstName = entFirstname.Text,
			LastName = entLastname.Text,
			Email = entEmail.Text,
			Age = Convert.ToInt32(entAge.Text),
			Gender = pickerGender.SelectedItem.ToString(),
			Password = entPassword.Text,
			Mobile = entMobile.Text
		};
        
		Navigation.PushAsync(new ProfilePage(user));
	}
}

