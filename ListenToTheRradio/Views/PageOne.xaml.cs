namespace ListenToTheRradio.Views;

public partial class PageOne : ContentView
{
	public PageOne()
	{
		InitializeComponent();
        Loaded += PageOne_Loaded;
	}

    private void PageOne_Loaded(object? sender, EventArgs e)
    {
        Console.WriteLine("pageOne loaded");
    }
}