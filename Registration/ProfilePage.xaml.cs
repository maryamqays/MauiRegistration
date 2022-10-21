using Registration.Models;

namespace Registration;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(User user)
	{
		InitializeComponent();
		lbFirstName.Text = "Hi " + user.FirstName + " " + user.LastName + ", Your information is below :";
		lbEmail.Text = user.Email;
		lbAge.Text = user.Age.ToString();
		lbGender.Text = user.Gender;
		lbMobile.Text = user.Mobile;
    }
}