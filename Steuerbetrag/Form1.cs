using System.Drawing.Text;

namespace Steuerbetrag
{
    public partial class Steuerbetrag : Form
    {
        public Steuerbetrag()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmdSwitchcase_Click(object sender, EventArgs e)
        {
            // Gehalt einlesen und in eine Zahl umwandeln
            int gehalteingabe;
            bool isNumeric = int.TryParse(textBoxGehalt.Text, out gehalteingabe);
            if (!isNumeric)
            {
                LblSteuerbetrag.Text = "Bitte geben Sie eine gültige Zahl ein.";
                return;
            }


            decimal steuerbetrag;

            // Annahme: Die Gehaltsbereiche werden als Ganzzahlen gehandhabt.
            switch (gehalteingabe)
            {
                case int n when (n >= 0 && n <= 12000):
                    steuerbetrag = n * 0.12m;
                    break;
                case int n when (n > 12000 && n <= 20000):
                    steuerbetrag = n * 0.15m;
                    break;
                case int n when (n > 20000 && n <= 30000):
                    steuerbetrag = n * 0.20m;
                    break;
                case int n when (n > 30000):
                    steuerbetrag = n * 0.25m;
                    break;
                default:
                    steuerbetrag = 0;
                    break;
            }

            LblSteuerbetrag.Text = $"Steuerbetrag: {steuerbetrag:C}";
        }


        private void Cmdifelse_Click(object sender, EventArgs e)
        {
            int gehalteingabe;



            bool isNumeric = int.TryParse(textBoxGehalt.Text, out gehalteingabe);



            if (!isNumeric)
            {
                LblSteuerbetrag.Text = "Bitte geben Sie eine gültige Zahl ein.";
                return;
            }



            decimal steuersatz = 0;
            decimal steuerbetrag;



            if (gehalteingabe >= 0 && gehalteingabe <= 12000)
            {
                steuersatz = 0.12m;
            }
            else if (gehalteingabe > 12000 && gehalteingabe <= 20000)
            {
                steuersatz = 0.15m;
            }
            else if (gehalteingabe > 20000 && gehalteingabe <= 30000)
            {
                steuersatz = 0.20m;
            }
            else if (gehalteingabe > 30000)
            {
                steuersatz = 0.25m;
            }



            steuerbetrag = gehalteingabe * steuersatz;



            LblSteuerbetrag.Text = $"Steuerbetrag: {steuerbetrag:C}";
        }

        private void textBoxGehalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSteuerbetrag_Click(object sender, EventArgs e)
        {
            LblSteuerbetrag.Text = "$Steuerbetrag:{}";
        }
    }
}
