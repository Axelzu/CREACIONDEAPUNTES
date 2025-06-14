namespace CREACIONDEAPUNTES;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		
    }
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}
