using System.Linq.Expressions;
using System.Security.Permissions;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        private double i = 0;
        private double contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                double temperatura = Convert.ToDouble(textBox1.Text);

                i += temperatura;
                contador++;
                double media = i / contador;

                while (temperatura > 0)
                {
                    if (temperatura <= 37.2)
                    {
                        label2.Text = "Temperatura normal";
                    }
                    else if (temperatura > 37.2 & temperatura <= 38)
                    {
                        label2.Text = "Estado febril";
                    }
                    else if (temperatura > 38 & temperatura <= 39)
                    {
                        label2.Text = "Com febre";
                    }
                    else if (temperatura > 39)
                    {
                        label2.Text = "Febre Alta";
                    }
                    label3.Text = "Temperatura média é: " + media.ToString("F2") + "° de " + contador.ToString() + " pessoas.";
                    textBox1.Clear();
                    break;
                }    
            }
            catch
            {
                MessageBox.Show("Insira valores válidos", "Atenção");
            }
        }
    }
}
