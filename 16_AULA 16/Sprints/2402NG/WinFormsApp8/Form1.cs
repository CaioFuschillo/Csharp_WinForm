using System.ComponentModel;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pares = textBoxDados.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string resultados = "";
                for (int i = 0; i < pares.Length; i++)
                {
                    string[] valores = pares[i].Split(',');
                    if (valores.Length != 2)
                    {
                        MessageBox.Show("Por favor, insira pares de peso e altura válidos.");
                        return;
                    }
                    double peso = Convert.ToDouble(valores[0]);
                    double altura = Convert.ToDouble(valores[1]);

                    double imc = peso / ((altura / 100) * (altura / 100));

                    //Categoria
                    string categoria = "";
                    if (imc <= 18.5)
                    {
                        categoria = "Abaixo do peso";
                    }
                    else if (imc > 18.5 && imc <= 24.9)
                    {
                        categoria = "Peso normal";
                    }
                    else if (imc > 24.9 && imc <= 29.9)
                    {
                        categoria = "Sobrepeso";
                    }
                    else if (imc > 29.9 && imc <= 34.9)
                    {
                        categoria = "Obesidade Grau 1";
                    }
                    else if (imc > 34.9 && imc <= 39.9)
                    {
                        categoria = "Obesidade Grau 2";
                    }
                    else if (imc > 39.9)
                    {
                        categoria = "Obesidade Grau 3";
                    }
                    resultados += $"Par {i + 1}: IMC = {imc:F2}, Categoria = {categoria}\n";
                }
                label1.Text = "Resultado do IMC:\n" + resultados;
                MessageBox.Show(resultados, "Resultado do IMC");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para a altura");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDados.Clear();
            label1.Text = "Resultado:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
