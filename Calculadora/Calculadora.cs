namespace Calculadora
{
    public partial class Calculadora : Form
    {

        double primero;
        double segundo;

        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.Sumar Obj = new Clases.Sumar();
        Clases.Resta Obj2 = new Clases.Resta();
        Clases.Multiplicación Obj3 = new Clases.Multiplicación();
        Clases.División Obj4 = new Clases.División();

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 500;
            Height = 700;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";

            primero = double.Parse(CajaScreen.Text);

            CajaScreen.Clear(); 
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "2";
        }

        private void CajaScreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            CajaScreen.Clear();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            CajaScreen.Text = CajaScreen.Text + "9";
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            operador = "-";

            primero = double.Parse(CajaScreen.Text);

            CajaScreen.Clear();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";

            primero = double.Parse(CajaScreen.Text);

            CajaScreen.Clear();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            operador = "/";

            primero = double.Parse(CajaScreen.Text);

            CajaScreen.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(CajaScreen.Text);

            double Sum;
            double Res;
            double Mult;
            double Div;

            if (operador == "+")
            {

                Sum = Obj.Suma((primero), (segundo));
                CajaScreen.Text = Sum.ToString();

            }
            else if (operador == "-")
            {

                Res = Obj2.Restar((primero), (segundo));
                CajaScreen.Text = Res.ToString();

            }
            else if (operador == "*")
            {

                Mult = Obj3.Multiplicar((primero), (segundo));
                CajaScreen.Text = Mult.ToString();
            } else if (operador=="/") {

                Div = Obj4.Dividir((primero), (segundo));
                CajaScreen.Text = Div.ToString();

            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (CajaScreen.Text.Length==1) {

                CajaScreen.Text = "";

            }
            else
            {

                CajaScreen.Text =CajaScreen.Text.Substring(0, CajaScreen.Text.Length-1);
            }
        }
    }
}