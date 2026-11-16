namespace RuhaKolcsonzo.Desktop;

partial class RuhakForm
{
    private void InitializeComponent()
    {
        Label lbl = new()
        {
            AutoSize = false,
            Location = new Point(30, 30),
            Size = new Size(640, 120),
            Font = new Font("Segoe UI", 12F),
            Text = "TODO: Ruhák CRUD modul. Ezt a fájlt a 2. csapattag készíti."
        };

        ClientSize = new Size(700, 200);
        Controls.Add(lbl);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Ruhák";
    }
}
