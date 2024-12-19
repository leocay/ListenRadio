namespace ListenToTheRradio.Views;

public partial class PageTwo : ContentView
{
	public PageTwo()
	{
		InitializeComponent();
        Loaded += PageTwo_Loaded;
	}

    private void PageTwo_Loaded(object? sender, EventArgs e)
    {
        Console.WriteLine("pageTwo loaded");
    }
}