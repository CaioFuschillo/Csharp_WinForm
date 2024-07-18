using System.Linq.Expressions;

namespace Calculadora_de_área
{
    public partial class Form1 : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private double resultado = 0;

        public Form1()
        {
            InitializeComponent();
                                   
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string objeto = comboBox1.Text.ToString();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecione uma opção");
            }
            else
            {
                if (objeto == "Circulo")
                {
                    label3.Visible = true;
                    label3.Text = "Raio:";
                    label4.Visible = false;
                    label5.Text = "";

                    textBox1.Clear();
                    textBox1.Visible = true;
                    textBox2.Clear();
                    textBox2.Visible = false;
                }
                else if (objeto == "Quadrado")
                {
                    label3.Visible = true;
                    label3.Text = "Lado:";
                    label4.Visible = false;
                    label5.Text = "";

                    textBox1.Clear();
                    textBox1.Visible = true;
                    textBox2.Clear();
                    textBox2.Visible = false;
                }
                else if (objeto == "Triangulo")
                {
                    label3.Visible = true;
                    label3.Text = "Base:";
                    label4.Visible = true;
                    label4.Text = "Altura:";
                    label5.Text = "";

                    textBox1.Clear();
                    textBox1.Visible = true;
                    textBox2.Clear();
                    textBox2.Visible = true;
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string objeto = comboBox1.Text.ToString();

            switch (objeto)
            {
                case "Circulo":
                    {
                        CalcularAreaCirculo();
                        break;
                    }
                case "Quadrado":
                    {
                        CalcularAreaQuadrado();
                        break;
                    }
                case "Triangulo":
                    {
                        CalcularAreaTriangulo();
                        break;
                    }
            }
        }

        public void CalcularAreaCirculo()
        {
            try
            {
                valor1 = Convert.ToDouble(textBox1.Text);
                resultado = Math.PI * valor1 * valor1;
                label5.Visible = true;
                label5.Text = "A área do círculo é: " + resultado.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Insira valores válidos");
            }
        }

        public void CalcularAreaQuadrado()
        {
            try
            {
                valor1 = Convert.ToDouble(textBox1.Text);
                resultado = valor1 * valor1;
                label5.Visible = true;
                label5.Text = "A área do quadrado é: " + resultado;
            }
            catch
            {
                MessageBox.Show("Insira valores válidos");
            }
        }

        public void CalcularAreaTriangulo()
        {
            try
            {
                valor1 = Convert.ToDouble(textBox1.Text);
                valor2 = Convert.ToDouble(textBox2.Text);
                resultado = (valor1 * valor2) / 2;
                label5.Visible = true;
                label5.Text = "A área do triângulo é: " + resultado.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Insira valores válidos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;

            label3.Text = "";
            label3.Visible = false;
            label4.Text = "";
            label4.Visible = false;
            label5.Text = "";
            label5.Visible = false;

            textBox1.Clear();
            textBox1.Visible = false;
            textBox2.Clear();
            textBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicação encerrando...", "Atenção");
            Application.Exit();
        }
    }
}
