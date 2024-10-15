namespace PrjAdivinhação
{
    public partial class Form1 : Form
    {
        private int numeroSorteado;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            ReiniciarJogo();
        }

        private void btnAdivinhar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numeroAdivinhado))
            {
                if (numeroAdivinhado < 1 || numeroAdivinhado > 100)
                {
                    MessageBox.Show("Por favor, insira um número entre 1 e 100.","Número inválido",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (numeroAdivinhado == numeroSorteado)
                {
                    MessageBox.Show("Parabéns! Você acertou!", ":)", MessageBoxButtons.OK);
                    ReiniciarJogo();
                }
                else if (Math.Abs(numeroAdivinhado - numeroSorteado) <= 5)
                {
                    MessageBox.Show("Quase! O número é " + (numeroAdivinhado < numeroSorteado ? "maior" : "menor") + " do que " + numeroAdivinhado + ".","Quase!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Tente novamente! O número é " + (numeroAdivinhado < numeroSorteado ? "maior" : "menor") + " do que " + numeroAdivinhado + ".","Tente Novamente",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.","Inválido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void ReiniciarJogo()
        {
            numeroSorteado = random.Next(1, 101);
            txtNumero.Clear();
            txtNumero.Focus();
        }
    }
}