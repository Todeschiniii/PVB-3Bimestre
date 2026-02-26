/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 27/08/2025
* Autores do Projeto: Mateus Todeschini Monteiro
*                     Kaique Eduardo Luiz de Oliveira
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* problema_aula.cs
* ************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Label = System.Windows.Forms.Label;

namespace Projeto_Wagner_3ºBimestre
{
    public partial class Form1 : Form
    {
        decimal subTotal = 0;
        decimal valorPago = 0;
        decimal troco = 0;
        decimal valorCaixa = 0;
        string resultado = "   --------------------------------------------------" + Environment.NewLine + 
        "   LANCHONETE DELÍCIA" + Environment.NewLine + Environment.NewLine;
        string resultadoProdutos = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            string Produto = produto.Text.Replace(" ", "");
            int numeroProduto = 1;
            if (Produto.Contains("/"))
            {
                int posicao = Produto.IndexOf("/");
                numeroProduto = int.Parse(Produto.Substring(posicao + 1));
                Produto = Produto.Substring(0, posicao);
            }
            string TextoPreco = lblPrincipal.Text.Replace(".", ",").Substring(2);
            decimal Preco = decimal.Parse(TextoPreco);
            string precoFormatado = Preco.ToString("C2").Replace(",", ".");
            int pontos = 50 - (Produto.Length + precoFormatado.Length + 4);
            string pontinhos = "";
            for (int x = 0; x < pontos; x++)
            {
                pontinhos += '.';
            }
            for (int y = 0; y < numeroProduto; y++)
            {
                resultadoProdutos += "   - " + $"{Produto} {pontinhos} {precoFormatado}" + Environment.NewLine;
                subTotal += Preco;
            }
            produto.Clear();
            lblPrincipal.Text = "R$0";
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "R$0";
            lblValorCompra.Text = "VALOR DA COMPRA: ";
            resultado = "   --------------------------------------------------" + Environment.NewLine +
            "   LANCHONETE DELÍCIA" + Environment.NewLine + Environment.NewLine;
            subTotal = 0;
            lblCliente.Visible = false;
            lblCompra.Visible = true;
            lblValorCompra.Visible = false;
            lblExemplo1.Visible = true;
            lblExemplo2.Visible = true;
            produto.Visible = true;
            adicionar.Visible = true;
            finalizar.Visible = true;
            OKfinal.Visible = false;
            recibo.Visible = false;
            limpar.Visible = false;
            finalizarProcesso.Visible = false;
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "R$0";
            lblValorCompra.Text += subTotal.ToString("C2").Replace(",", ".");
            lblCompra.Visible = false;
            lblValorCompra.Visible = true;
            lblCliente.Visible = true;
            lblExemplo1.Visible = false;
            lblExemplo2.Visible = false;
            produto.Visible = false;
            adicionar.Visible = false;
            finalizar.Visible = false;
            OKfinal.Visible = true;
            lblValorProduto.Visible = false;

        }

        private void produto_TextChanged(object sender, EventArgs e)
        {
            if (produto.Text.Length > 0)
            {
                adicionar.Enabled = true;
            }
            else
            {
                adicionar.Enabled = false;
            }
        }
        private void Numero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string precoAtual = lblPrincipal.Text;

            if (precoAtual != "R$0")
            {
                precoAtual += botao.Text;
                if (precoAtual.Length > 16)
                {
                    precoAtual = precoAtual.Substring(16);
                }

            }
            else
            {
                precoAtual = precoAtual.Substring(0, 2) + botao.Text;
            }
            lblPrincipal.Text = precoAtual;
        }
        private void ponto_Click(object sender, EventArgs e)
        {
            if (!lblPrincipal.Text.Contains("."))
            {
                lblPrincipal.Text += ".";
            }
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            if (lblPrincipal.Text.Length > 3)
            {
                lblPrincipal.Text = lblPrincipal.Text.Substring(0, lblPrincipal.Text.Length - 1);
            }
            else
            {
                lblPrincipal.Text = lblPrincipal.Text.Substring(0, 2) + "0";
            }
        }
        private void OKStart_Click(object sender, EventArgs e)
        {
            string TextoPreco = lblPrincipal.Text.Replace(".", ",").Substring(2);
            decimal precoCaixa = decimal.Parse(TextoPreco);
            valorCaixa = precoCaixa;
            adicionar.Visible = true;
            finalizar.Visible = true;
            produto.Visible = true;
            OKStart.Visible = false;
            lblCompra.Visible = true;
            lblCaixa.Visible = false;
            lblExemplo1.Visible = true;
            lblExemplo2.Visible = true;
            lblValorProduto.Visible = true;
            lblPrincipal.Text = "R$0";
        }

        private void OKfinal_Click(object sender, EventArgs e)
        { 
            string TextoPreco = lblPrincipal.Text.Replace(".", ",").Substring(2);
            decimal precoCliente = decimal.Parse(TextoPreco);
            valorPago = precoCliente;
            troco = valorPago - subTotal;
            if ( troco < 0 )
            {
                MessageBox.Show("O valor pago é menor que o subtotal.\nPor favor, insira um valor válido.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                

                valorCaixa += subTotal;

                DateTime data = DateTime.Now;
                int dia = (int)data.DayOfWeek;
                resultado +=
                "   Data: " + data.ToString("dddd, dd 'de' MMM 'de' yyyy") + Environment.NewLine +
                "   Hora: " + data.ToString("HH:mm:ss") + Environment.NewLine +
                "   --------------------------------------------------" + Environment.NewLine + Environment.NewLine +
                "   PRODUTOS:" + Environment.NewLine +
                resultadoProdutos +
                Environment.NewLine + "   --------------------------------------------------" + Environment.NewLine;

                string precoFormatado = subTotal.ToString("C2").Replace(",", ".");
                int pontos = 50 - (11 + precoFormatado.Length);
                string pontinhos = "";
                for (int x = 0; x < pontos; x++)
                {
                    pontinhos += '.';
                }

                resultado += $"   SUBTOTAL: {pontinhos} {precoFormatado}" + Environment.NewLine;

                precoFormatado = valorPago.ToString("C2").Replace(",", ".");
                pontos = 50 - ( 10 + precoFormatado.Length + 2);
                pontinhos = "";
                for (int x = 0; x < pontos; x++)
                {
                    pontinhos += '.';
                }

                resultado += $"   VALORPAGO: {pontinhos} {precoFormatado}" + Environment.NewLine;

                precoFormatado = troco.ToString("C2").Replace(",", ".");
                pontos = 50 - (8 + produto.Text.Length + precoFormatado.Length);
                pontinhos = "";
                for (int x = 0; x < pontos; x++)
                {
                    pontinhos += '.';
                }
                // Trocar $ por .Format
                resultado += $"   TROCO: {pontinhos} {precoFormatado}" + Environment.NewLine +

                "   --------------------------------------------------" + Environment.NewLine + Environment.NewLine +
                "   OBRIGADO PELA PREFERÊNCIA!" + Environment.NewLine +
                "   --------------------------------------------------" + Environment.NewLine;


                recibo.Text = resultado;
                recibo.Visible = true;
                limpar.Visible = true;
                finalizarProcesso.Visible = true;

                resultado = "   --------------------------------------------------" + Environment.NewLine + 
                "   LANCHONETE DELÍCIA" + Environment.NewLine + Environment.NewLine;
                resultadoProdutos = "";
            }
        }
        private void finalizarProcesso_Click(object sender, EventArgs e)
        {
            string valorCaixaFormatado = valorCaixa.ToString("C2").Replace(",", ".");
            MessageBox.Show($"Obrigado por utilizar o sistema da Lanchonete Delícia!\nAté a próxima!\nDinheiro Final do Caixa: {valorCaixaFormatado}", "Encerrando");
            Form1.ActiveForm.Close();
        }
    }
}
