namespace SegundoParcialCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        bool punto = true;
        string operacion;
        string delete;
        double Num1; 
        double Num2;
        double resultado;

        private void IngresoNum(String num)
        {
            if (secuencia == true)
            {
                txtIngresoRespuesta.Text = num;
                secuencia = false;
            }
            else
            {
                txtIngresoRespuesta.Text += num;
            }
        }

        private void IngresoOperacion(String signo)
        {
            operacion = signo;
            Num1 = double.Parse(txtIngresoRespuesta.Text);
            secuencia = true;
            txtIngresoRespuesta.Text += " "+signo;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            IngresoNum("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            IngresoNum("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            IngresoNum("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            IngresoNum("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            IngresoNum("5");
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            IngresoNum("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            IngresoNum("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            IngresoNum("8");
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            IngresoNum("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtIngresoRespuesta.Text == "0")
            {
                return;
            }
            else
            {
                txtIngresoRespuesta.Text += "0";
            }
        }

        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            IngresoOperacion("+");

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            IngresoOperacion("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            IngresoOperacion("*");
        }

        private void bntDiv_Click(object sender, EventArgs e)
        {
            IngresoOperacion("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Num2 = double.Parse(txtIngresoRespuesta.Text);
            if(operacion == "+")
            {
                resultado = Num1 + Num2; 
                txtIngresoRespuesta.Text = resultado.ToString();
                secuencia = true;
            }
            if(operacion == "-")
            {
                resultado = Num1 - Num2;
                txtIngresoRespuesta.Text = resultado.ToString();
                secuencia = true;
            }
            if(operacion == "*")
            {
                resultado = Num1 * Num2;
                txtIngresoRespuesta.Text = resultado.ToString();
                secuencia = true;
            }
            if(operacion == "/")
            {
                resultado = Num1 / Num2;
                txtIngresoRespuesta.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int valor = 0;
            delete = txtIngresoRespuesta.Text;
            valor = delete.Length - 1;
            delete = delete.Substring(valor);
            txtIngresoRespuesta.Text = delete;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtIngresoRespuesta.Text = "0";
            Num1 = 0;
            Num2 = 0;
            secuencia = true;

        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(punto == true)
            {
                txtIngresoRespuesta.Text = txtIngresoRespuesta.Text + ".";
                punto = true;
            }
            else
            {
                return;
            }
            
        }
    }
}