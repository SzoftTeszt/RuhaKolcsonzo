namespace RuhaKolcsonzo.Desktop;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnUgyfelek_Click(object sender, EventArgs e)
    {
        new UgyfelekForm().ShowDialog();
    }

    private void btnRuhak_Click(object sender, EventArgs e)
    {
        new RuhakForm().ShowDialog();
    }

    private void btnKolcsonzesek_Click(object sender, EventArgs e)
    {
        new KolcsonzesekForm().ShowDialog();
    }

    private void btnKimutatasok_Click(object sender, EventArgs e)
    {
        new KimutatasokForm().ShowDialog();
    }
}
