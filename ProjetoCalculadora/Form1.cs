namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        private double Resultado { get; set; }
        private double Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text == "0")
                visor_calculo_resultado.Text = "";

            visor_calculo_resultado.Text += "9";
        }

        private void button_soma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDouble(visor_calculo_resultado.Text);
            visor_calculo_resultado.Text = "";
            lbl_operador.Text = "+";
        }

        private void button_subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDouble(visor_calculo_resultado.Text);
            visor_calculo_resultado.Text = "";
            lbl_operador.Text = "-";
        }

        private void button_divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDouble(visor_calculo_resultado.Text);
            visor_calculo_resultado.Text = "";
            lbl_operador.Text = "/";
        }

        private void button_multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDouble(visor_calculo_resultado.Text);
            visor_calculo_resultado.Text = "";
            lbl_operador.Text = "X";
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDouble(visor_calculo_resultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDouble(visor_calculo_resultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDouble(visor_calculo_resultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDouble(visor_calculo_resultado.Text);
                    break;
            }
            visor_calculo_resultado.Text = Resultado.ToString();
            lbl_operador.Text = "=";
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            if (!visor_calculo_resultado.Text.Contains(","))
                visor_calculo_resultado.Text += ",";
        }

        private void button_limparTudo_Click(object sender, EventArgs e)
        {
            visor_calculo_resultado.Text = "";
            lbl_operador.Text = "";
        }

        private void button_apagar_Click(object sender, EventArgs e)
        {
            if (visor_calculo_resultado.Text.Length > 1)
            {
                visor_calculo_resultado.Text = visor_calculo_resultado.Text.Substring(0, visor_calculo_resultado.Text.Length - 1);
            }
            else
            {
                visor_calculo_resultado.Text = "0";
            }
        }
    }
}
