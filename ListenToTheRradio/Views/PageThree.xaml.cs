namespace ListenToTheRradio.Views;

public partial class PageThree : ContentView
{
	public PageThree()
	{
		InitializeComponent();
        Loaded += PageThree_Loaded;
	}

    private void PageThree_Loaded(object? sender, EventArgs e)
    {
        Console.WriteLine("pageThree loaded");
    }
}