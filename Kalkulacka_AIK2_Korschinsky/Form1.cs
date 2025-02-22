namespace kalkuládora
{
    public partial class kalkulacka : Form
    {
        public kalkulacka()
        {
            InitializeComponent();
            zadanitextBox.Text = "0";
            prikladTextBox.Text = "";
        }

        int prvnicislo;
        int druhecislo;
        string funkce;
        int vysledek = 0;

        private void kalkulacka_Load(object sender, EventArgs e)
        {

        }

        private void nulabutton_Click(object sender, EventArgs e)
        {
            if (zadanitextBox.Text != "0") 
            {
                zadanitextBox.Text = zadanitextBox.Text + ((Button)sender).Text;
                
                
            }
            else
            {
                zadanitextBox.Text = ((Button)sender).Text;
                
            }
            prikladTextBox.Text = prikladTextBox.Text + ((Button)sender).Text;
        }

        private void scitanibutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(zadanitextBox.Text, out prvnicislo))
            {
                zadanitextBox.Text = "0";
                funkce = "+";
                prikladTextBox.Text = prvnicislo.ToString() + " +";
            }
            else
            {
                MessageBox.Show("Zadejte platné číslo.");
            }
        }

        private void odcitanibutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(zadanitextBox.Text, out prvnicislo))
            {
                zadanitextBox.Text = "0";
                funkce = "-";
                prikladTextBox.Text = prvnicislo.ToString() + " -";
            }
            else
            {
                MessageBox.Show("Zadejte platné číslo.");
            }
        }

        private void nasobenibutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(zadanitextBox.Text, out prvnicislo))
            {
                zadanitextBox.Text = "0";
                funkce = "*";
                prikladTextBox.Text = prvnicislo.ToString() + " *";
            }
            else
            {
                MessageBox.Show("Zadejte platné číslo.");
            }

        }

        private void delenibutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(zadanitextBox.Text, out prvnicislo))
            {
                zadanitextBox.Text = "0";
                funkce = "/";
                prikladTextBox.Text = prvnicislo.ToString() + " /";
            }
            else
            {
                MessageBox.Show("Zadejte platné číslo.");
            }
        }

        private void rovnasebutton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(zadanitextBox.Text, out druhecislo))
            {
                switch (funkce)
                {
                    case "+":
                        vysledek = prvnicislo + druhecislo;
                        break;
                    case "-":
                        vysledek = prvnicislo - druhecislo;
                        break;
                    case "*":
                        vysledek = prvnicislo * druhecislo;
                        break;
                    case "/":
                        if (druhecislo != 0) 
                        {
                            vysledek = prvnicislo / druhecislo;
                        }
                        else
                        {
                            MessageBox.Show("Dělení nulou není povoleno.");
                            return; 
                        }
                        break;
                    default:
                        MessageBox.Show("Neznámá funkce.");
                        return;
                }
            }
            zadanitextBox.Text = vysledek.ToString();
            prikladTextBox.Text = "";
            funkce = "";
            
        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            zadanitextBox.Text = "0";
            prikladTextBox.Text = "";
            funkce = "";
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            zadanitextBox.Text = "0";

            if (funkce == "")
            {
                prikladTextBox.Text = "";
            }
            else
            {
                prikladTextBox.Text = prvnicislo.ToString() + (" ") + funkce;
            }
    
        }

        
    }
}
