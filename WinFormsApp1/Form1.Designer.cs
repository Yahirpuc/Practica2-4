namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxCalculadora = new ComboBox();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblNumero2 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxCalculadora
            // 
            comboBoxCalculadora.BackColor = SystemColors.GradientActiveCaption;
            comboBoxCalculadora.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCalculadora.FormattingEnabled = true;
            comboBoxCalculadora.Items.AddRange(new object[] { "Calcular MCD", "Calcular Factorial", "Generar Serie Fibonacci" });
            comboBoxCalculadora.Location = new Point(290, 79);
            comboBoxCalculadora.Name = "comboBoxCalculadora";
            comboBoxCalculadora.Size = new Size(406, 33);
            comboBoxCalculadora.TabIndex = 0;
            comboBoxCalculadora.SelectedIndexChanged += comboBoxCalculadora_SelectedIndexChanged;
            // 
            // txtNumero1
            // 
            txtNumero1.BackColor = SystemColors.InactiveCaption;
            txtNumero1.Location = new Point(413, 158);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.BackColor = SystemColors.InactiveCaption;
            txtNumero2.Location = new Point(413, 226);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.MenuHighlight;
            btnCalcular.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.Control;
            btnCalcular.Location = new Point(603, 174);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(195, 75);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Red;
            lblResultado.Location = new Point(141, 294);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(110, 30);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero2.Location = new Point(141, 226);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(259, 24);
            lblNumero2.TabIndex = 5;
            lblNumero2.Text = "Ingresa el segundo valor";
            lblNumero2.Click += lblNumero2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 157);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 6;
            label1.Text = "Ingresa el Primer Valor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 19);
            label2.Name = "label2";
            label2.Size = new Size(754, 38);
            label2.TabIndex = 7;
            label2.Text = "Bienvenido, a continuación selecciona una opcion del menú";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(935, 333);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(comboBoxCalculadora);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxCalculadora;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private Label lblNumero2;
        private Label label1;
        private Label label2;
    }
}
