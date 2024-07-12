namespace WinFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_addcal = new Button();
            btn_resetar = new Button();
            btn_sair = new Button();
            txt_dados = new TextBox();
            lbl_numeros = new Label();
            SuspendLayout();
            // 
            // btn_addcal
            // 
            btn_addcal.Location = new Point(246, 206);
            btn_addcal.Name = "btn_addcal";
            btn_addcal.Size = new Size(162, 29);
            btn_addcal.TabIndex = 0;
            btn_addcal.Text = "Adicionar e Calcular";
            btn_addcal.UseVisualStyleBackColor = true;
            btn_addcal.Click += btn_addcal_Click;
            // 
            // btn_resetar
            // 
            btn_resetar.Location = new Point(428, 206);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(94, 29);
            btn_resetar.TabIndex = 1;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = true;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(762, 12);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(26, 29);
            btn_sair.TabIndex = 2;
            btn_sair.Text = "X";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // txt_dados
            // 
            txt_dados.Location = new Point(356, 173);
            txt_dados.Name = "txt_dados";
            txt_dados.Size = new Size(125, 27);
            txt_dados.TabIndex = 3;
            txt_dados.TextChanged += txt_dados_TextChanged;
            txt_dados.KeyPress += txt_dados_KeyPress_1;
            // 
            // lbl_numeros
            // 
            lbl_numeros.AutoSize = true;
            lbl_numeros.Location = new Point(130, 334);
            lbl_numeros.Name = "lbl_numeros";
            lbl_numeros.Size = new Size(146, 20);
            lbl_numeros.TabIndex = 4;
            lbl_numeros.Text = "Média dos Números:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_numeros);
            Controls.Add(txt_dados);
            Controls.Add(btn_sair);
            Controls.Add(btn_resetar);
            Controls.Add(btn_addcal);
            Name = "Form1";
            Text = "Form1";
            KeyPress += txt_dados_Keypress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addcal;
        private Button btn_resetar;
        private Button btn_sair;
        private TextBox txt_dados;
        private Label lbl_numeros;
    }
}
