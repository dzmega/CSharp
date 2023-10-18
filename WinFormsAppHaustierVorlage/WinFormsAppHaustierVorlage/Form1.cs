namespace WinFormsAppHaustierVorlage
{
    public partial class Form1 : Form
    {
        Mensch mensch;
        Haustier haustier;
        public Form1()
        {
            InitializeComponent();
            mensch = new Mensch();
            haustier = new Haustier();
            mensch.OnArbeiten += haustier.MenschArbeitet;
            mensch.OnHomeOffice += haustier.MenschHomeOffice;
            mensch.OnUrlaub += haustier.MenschUrlaub;
            haustier.OnEssen += mensch.TierGefüttert;
            haustier.OnWaschen += mensch.TierSaubermachen;
        }

        private void buttonArbeiten_Click(object sender, EventArgs e)
        {
            mensch.ArbeitenGehen();
            aktualisieren();
        }

        private void aktualisieren()
        {
            if(mensch.Laune)
            {
                labelMenschLaune.Text = "gut";
                labelMenschLaune.BackColor = Color.Green;
            }
            else
            {
                labelMenschLaune.Text = "schlecht";
                labelMenschLaune.BackColor= Color.Red;
            }

            if (haustier.Laune)
            {
                labelTierLaune.Text = "gut";
                labelTierLaune.BackColor = Color.Green;
            }
            else
            {
                labelTierLaune.Text = "schlecht";
                labelTierLaune.BackColor = Color.Red;
            }
        }

        private void buttonHomeoffice_Click(object sender, EventArgs e)
        {
            mensch.HomeOfficeArbeiten();
            aktualisieren();
        }

        private void buttonUrlaub_Click(object sender, EventArgs e)
        {
            mensch.UrlaubFahren();
            aktualisieren();
        }

        private void buttonFuettern_Click(object sender, EventArgs e)
        {
            haustier.Fuettern();
            aktualisieren();
        }

        private void buttonSaubermachen_Click(object sender, EventArgs e)
        {
            haustier.Saubermachen();
            aktualisieren();
        }
    }
}