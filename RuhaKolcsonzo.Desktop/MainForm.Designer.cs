namespace RuhaKolcsonzo.Desktop;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private Button btnUgyfelek = null!;
    private Button btnRuhak = null!;
    private Button btnKolcsonzesek = null!;
    private Button btnKimutatasok = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        Label lblCim = new();
        btnUgyfelek = new();
        btnRuhak = new();
        btnKolcsonzesek = new();
        btnKimutatasok = new();
        SuspendLayout();

        lblCim.AutoSize = true;
        lblCim.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblCim.Location = new Point(58, 28);
        lblCim.Text = "Ruha- és alkalmi viselet kölcsönző";

        btnUgyfelek.Location = new Point(70, 95);
        btnUgyfelek.Size = new Size(180, 48);
        btnUgyfelek.Text = "Ügyfelek";
        btnUgyfelek.Click += btnUgyfelek_Click;

        btnRuhak.Location = new Point(270, 95);
        btnRuhak.Size = new Size(180, 48);
        btnRuhak.Text = "Ruhák";
        btnRuhak.Click += btnRuhak_Click;

        btnKolcsonzesek.Location = new Point(70, 165);
        btnKolcsonzesek.Size = new Size(180, 48);
        btnKolcsonzesek.Text = "Kölcsönzések";
        btnKolcsonzesek.Click += btnKolcsonzesek_Click;

        btnKimutatasok.Location = new Point(270, 165);
        btnKimutatasok.Size = new Size(180, 48);
        btnKimutatasok.Text = "Kimutatások";
        btnKimutatasok.Click += btnKimutatasok_Click;

        ClientSize = new Size(520, 270);
        Controls.Add(lblCim);
        Controls.Add(btnUgyfelek);
        Controls.Add(btnRuhak);
        Controls.Add(btnKolcsonzesek);
        Controls.Add(btnKimutatasok);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "RuhaKölcsönző";
        ResumeLayout(false);
        PerformLayout();
    }
}
