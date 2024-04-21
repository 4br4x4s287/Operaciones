namespace EjercicioOperaciones
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
            cmbOperaciones = new ComboBox();
            label1 = new Label();
            txtNum1 = new TextBox();
            txtnum2 = new TextBox();
            txtresultado = new TextBox();
            btnCalcular = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(26, 40);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(182, 33);
            cmbOperaciones.TabIndex = 0;
            cmbOperaciones.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "Operaciones";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(58, 126);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(327, 129);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(150, 31);
            txtnum2.TabIndex = 3;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(104, 235);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(150, 31);
            txtresultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(209, 123);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 96);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Numero1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 95);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Numero2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 210);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 8;
            label4.Text = "resultado";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(txtresultado);
            Controls.Add(txtnum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Controls.Add(cmbOperaciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperaciones;
        private Label label1;
        private TextBox txtNum1;
        private TextBox txtnum2;
        private TextBox txtresultado;
        private Button btnCalcular;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
