using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarComboBox(); 
        }

        private void ConfigurarComboBox()
        {
          
            if (comboBoxCalculadora.Items.Count == 0)
            {
                comboBoxCalculadora.Items.Add("Calcular MCD");
                comboBoxCalculadora.Items.Add("Calcular Factorial");
                comboBoxCalculadora.Items.Add("Generar Serie Fibonacci");
                comboBoxCalculadora.SelectedIndex = 0; 
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el numero ingresado
                int numero1 = int.Parse(txtNumero1.Text);

                // Variable para almacenar el resultado
                string resultado = string.Empty;

                switch (comboBoxCalculadora.SelectedIndex)
                {
                    case 0: //MCD
                        if (string.IsNullOrEmpty(txtNumero2.Text))
                        {
                            MessageBox.Show("Ingresa los dos números");
                            return;
                        }
                        int numero2 = int.Parse(txtNumero2.Text);
                        int resultadoMCD = MCD.CalcularMCD(numero1, numero2);
                        resultado = "El MCD es: " + resultadoMCD;
                        break;

                    case 1: // Factorial
                        NumeroFactorial factorial = new NumeroFactorial(numero1);

                        resultado = "El Factorial es: "+ factorial.ObtenerResultadoFactorial();
                        break;

                    case 2: //Serie Fibonacci
                        SerieFibonacci fibonacci = new SerieFibonacci(numero1);
                        resultado = $"Serie de Fibonacci: {string.Join(", ", fibonacci.Serie)}";
                     
                        break;

                    default:
                        resultado = "Seleccione una opción valida.";
                        break;
                }

                // Resultado en el Label
                lblResultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, ingrese números válidos"); //Mensaje de error
            }
        }

        private void comboBoxCalculadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCalculadora.SelectedIndex) //Componentes visibles
            {
                case 0: //MCD
                    txtNumero2.Visible = true;
                    lblNumero2.Visible = true;
                    break;

                case 1: // Factorial
                    txtNumero2.Visible = false;
                    lblNumero2.Visible = false;
                    break;

                case 2: //Serie Fibonacci
                    txtNumero2.Visible = false;
                    lblNumero2.Visible = false;
                    break;
            }
        }

        private void lblNumero2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
