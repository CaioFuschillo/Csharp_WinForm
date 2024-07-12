using System.Security.Permissions;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        private double soma = 0;
        private int contador = 0;
        bool continuar = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_dados_Keypress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_addcal_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(txt_dados.Text);

                soma += numero;
                contador++;

                while (continuar)
                {
                    double media = soma / contador;

                    lbl_numeros.Text = "Média dos números: " + media.ToString("F2");
                    MessageBox.Show("A média é: " + media.ToString("F2"), "Média");
                    txt_dados.Clear();
                    break;
                }
            }
            catch
            {
                MessageBox.Show("Insira um número correto");
            }
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            soma = 0;
            contador = 0;
            txt_dados.Clear();
            lbl_numeros.Text = "Média dos Números:";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_dados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dados_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ('p') || e.KeyChar == ('P'))
            {
                continuar = false;
                MessageBox.Show("Tchaaaaau");
                Close();
            }
        }
    }
}
