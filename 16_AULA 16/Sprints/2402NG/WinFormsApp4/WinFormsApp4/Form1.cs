namespace WinFormsApp4
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
                //Conversão dos valores dos TextBoxes
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                //Cálculo da média
                double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                //Aprovado ou Reprovado
                if (media >= 7)
                {
                    labelResultado.Text = "Aprovado = " + media;
                    MessageBox.Show("O Aluno está aprovado!", "Resultado");
                }
                else
                {
                    labelResultado.Text = "Reprovado = " + media;
                    MessageBox.Show("O Aluno está reprovado!", "Resultado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resetar os campos
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            labelResultado.Text = "Resultado";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fechar o programa
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Conversão dos TextBoxes
                double nota1 = Convert.ToDouble(textBox1.Text) * 10;
                double nota2 = Convert.ToDouble(textBox2.Text) * 20;
                double nota3 = Convert.ToDouble(textBox3.Text) * 40;
                double nota4 = Convert.ToDouble(textBox4.Text) * 20;
                double nota5 = Convert.ToDouble(textBox5.Text) * 10;

                //Cálculo da média
                double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 100;

                //Aprovado ou Reprovado
                if (media >= 7)
                {
                    labelResultado.Text = "Aprovado = " + media;
                    MessageBox.Show("O Aluno está aprovado!", "Resultado");
                }
                else
                {
                    labelResultado.Text = "Reprovado = " + media;
                    MessageBox.Show("O Aluno está reprovado!", "Resultado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos");
            }
        }
        


}
    }

