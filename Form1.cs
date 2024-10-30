namespace calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + 0;
        }


        int operation;

        float valeur1;
        float valeur2;


        private void button10_Click(object sender, EventArgs e)
        {
            operation = 1;
            string a = textvaleur.Text;
            float.TryParse(a, out valeur1);

            textvaleur.Text = "";
            textbox1.Text = a + "+";


        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                string b = textvaleur.Text;
                string c = b;
                float.TryParse(b, out valeur2);
                float a = valeur1 + valeur2;
                textvaleur.Text = "" + a;
                textbox1.Text = valeur1 + "+" + valeur2 + "=";
            }
            if (operation == 2)
            {
                string b = textvaleur.Text;
                string c = b;
                float.TryParse(b, out valeur2);
                float a = valeur1 - valeur2;
                textvaleur.Text = "" + a;
                textbox1.Text = valeur1 + "-" + valeur2 + "=";
            }
            if (operation == 3)
            {
                string b = textvaleur.Text;
                string c = b;
                float.TryParse(b, out valeur2);
                float a = valeur1 * valeur2;
                textvaleur.Text = "" + a;
                textbox1.Text = valeur1 + "x" + valeur2 + "=";
            }
            if (operation == 4)
            {
                string b = textvaleur.Text;
                string c = b;
                float.TryParse(b, out valeur2);
                float a = valeur1 / valeur2;
                textvaleur.Text = "" + a;
                textbox1.Text = valeur1 + "/" + valeur2 + "=";
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textvaleur.Text = string.Empty;
            textbox1.Text = string.Empty;



        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = 2;
            string a = textvaleur.Text;
            float.TryParse(a, out valeur1);

            textvaleur.Text = "";
            textbox1.Text = a + "-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = 4;
            string a = textvaleur.Text;
            float.TryParse(a, out valeur1);

            textvaleur.Text = "";
            textbox1.Text = a + "x";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = 3;
            string a = textvaleur.Text;
            float.TryParse(a, out valeur1);

            textvaleur.Text = "";
            textbox1.Text = a + "÷";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            string a = textvaleur.Text;

            double.TryParse(a, out double valeur2);
            double b = valeur2 * valeur2;
            textbox1.Text = "sqr(" + a + ")";

            textvaleur.Text = "" + b;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textvaleur.Text = textvaleur.Text + ",";
        }
    }
}
