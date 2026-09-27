namespace SpelenMetMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wil je zeker deze handeling uitvoeren", "bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("De gewenste actie kan niet uitgevoerd worden.", "Foutieve handeling", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            MessageBox.Show("Alle resterende handelingen correct uitgevoerd.", "Voltooid", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
