namespace AddMasterPro;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Title = "Add Master Pro";
    }


    private void Clear(object sender, EventArgs e)
    {
        txtFirstNumber.Text = string.Empty;
        txtSecondNumber.Text = string.Empty;
        lblDisplay.Text = "0";
    }

    private void Add(object sender, EventArgs e)
    {
        Double dblFirst, dblSecond;
        Double.TryParse(txtFirstNumber.Text, out dblFirst);
        Double.TryParse(txtSecondNumber.Text, out dblSecond);
        lblDisplay.Text = (dblFirst + dblSecond).ToString();
    }
}