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
