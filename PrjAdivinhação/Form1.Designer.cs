namespace PrjAdivinhação
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
            lblJogo = new Label();
            txtNumero = new TextBox();
            lblInserir = new Label();
            btnAdivinhar = new Button();
            SuspendLayout();
            // 
            // lblJogo
            // 
            lblJogo.AutoSize = true;
            lblJogo.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblJogo.ForeColor = Color.Maroon;
            lblJogo.Location = new Point(337, 170);
            lblJogo.Name = "lblJogo";
            lblJogo.Size = new Size(502, 61);
            lblJogo.TabIndex = 0;
            lblJogo.Text = "Jogo de Adivinhação";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.InactiveCaption;
            txtNumero.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(390, 350);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(397, 38);
            txtNumero.TabIndex = 1;
            // 
            // lblInserir
            // 
            lblInserir.AutoSize = true;
            lblInserir.Font = new Font("Yu Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInserir.ForeColor = Color.DarkRed;
            lblInserir.Location = new Point(407, 309);
            lblInserir.Name = "lblInserir";
            lblInserir.Size = new Size(362, 38);
            lblInserir.TabIndex = 2;
            lblInserir.Text = "Insira a baixo o número:";
            // 
            // btnAdivinhar
            // 
            btnAdivinhar.BackColor = Color.LightPink;
            btnAdivinhar.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdivinhar.ForeColor = Color.DarkRed;
            btnAdivinhar.Location = new Point(496, 432);
            btnAdivinhar.Name = "btnAdivinhar";
            btnAdivinhar.Size = new Size(185, 50);
            btnAdivinhar.TabIndex = 3;
            btnAdivinhar.Text = "Adivinhar";
            btnAdivinhar.UseVisualStyleBackColor = false;
            btnAdivinhar.Click += btnAdivinhar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1177, 652);
            Controls.Add(btnAdivinhar);
            Controls.Add(lblInserir);
            Controls.Add(txtNumero);
            Controls.Add(lblJogo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJogo;
        private TextBox txtNumero;
        private Label lblInserir;
        private Button btnAdivinhar;
    }
}