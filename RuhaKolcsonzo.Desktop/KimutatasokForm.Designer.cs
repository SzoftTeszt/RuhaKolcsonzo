namespace RuhaKolcsonzo.Desktop;

partial class KimutatasokForm
{
    private void InitializeComponent()
    {
        Label lbl = new()
        {
            AutoSize = false,
            Location = new Point(30, 30),
            Size = new Size(640, 120),
            Font = new Font("Segoe UI", 12F),
            Text = "TODO: Include(), ThenInclude() és Join() lekérdezések. 2 fős csapatban az 1. vagy 2. csapattaghoz rendelhető."
        };

        ClientSize = new Size(700, 200);
        Controls.Add(lbl);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Kimutatások";
    }
}
