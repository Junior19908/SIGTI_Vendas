using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FormularioVendas : MetroFramework.Forms.MetroForm
    {
        public FormularioVendas()
        {

            InitializeComponent();
            carregarPedidos();
            txtCodBarras.Focus();
            carregarGridVendas();
            CarregarComboBoxCliente();
            CarregarComboBoxVendedor();
            txtStatusBarCaixa.Text = nomeCaixa;
        }
        OleDbCommand command, commandUpdate;
        string nomeCaixa = System.Environment.MachineName;
        Int64 numeroPedido;
        private void carregarPedidos()
        {
            try
            {
                OleDbCommand pedidosN = new OleDbCommand("SELECT TOP 1 col_codVendaProduto FROM TB_VendasDBSCV WHERE col_statusPedido = 1 ORDER BY col_codItemVendaProduto DESC", ClassConexao.DBSCV());
                OleDbDataReader readerPedido = pedidosN.ExecuteReader();
                while (readerPedido.Read())
                {
                    txtVendaCod.Text = readerPedido.GetValue(0).ToString();
                    break;
                }
                readerPedido.Close();

                numeroPedido = Int64.Parse(txtVendaCod.Text);
                numeroPedido += 1;
                txtVendaCod.Text = numeroPedido.ToString();
            }
            catch (Exception ErroEx)
            {
                MessageBox.Show("Erro ao carregar número de pedidos. " + ErroEx.Message, "SIGTI - Erro", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }
        }
        Int64 IDCliente;
        private void CarregarComboBoxCliente()
        {
            try
            {
                try
                {
                    IDCliente = Convert.ToInt32(datagridVenda.Rows[0].Cells[12].Value);
                }
                catch
                {
                    IDCliente = 0;
                }
                if(IDCliente == 0)
                {
                    OleDbCommand command = new OleDbCommand("SELECT Código, col_nomeCompleto FROM TB_ClienteDBSCV", ClassConexao.DBSCV());
                    OleDbDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DataRow row = dt.NewRow();
                    this.cbCliente.DataSource = dt;
                    this.cbCliente.ValueMember = "Código";
                    this.cbCliente.DisplayMember = "col_nomeCompleto";
                    reader.Close();
                }
                else
                {
                    OleDbCommand command = new OleDbCommand("SELECT Código, col_nomeCompleto FROM TB_ClienteDBSCV WHERE Código="+IDCliente+"", ClassConexao.DBSCV());
                    OleDbDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DataRow row = dt.NewRow();
                    this.cbCliente.DataSource = dt;
                    this.cbCliente.ValueMember = "Código";
                    this.cbCliente.DisplayMember = "col_nomeCompleto";
                    reader.Close();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n"+ Error.Message, "SIGTI - Erro",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }
        }
        private void CarregarComboBoxVendedor()
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT col_id, col_usuario FROM TB_LoginDBSCV WHERE col_id="+ ClassDadosGEt.IDUsuario.ToString() +"", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();
                //row["col_id"] = 0;
                //dt.Rows.InsertAt(row, 0);
            
                this.cbVendedor.DataSource = dt;
                this.cbVendedor.ValueMember = "col_id";
                this.cbVendedor.DisplayMember = "col_usuario";
            
                reader.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n" + Error.Message, "SIGTI - Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }
        }

        private void btnClienteNovo_Click(object sender, EventArgs e)
        {
            //string novaJanela = "1";
            ////var clientes = new CadastroClientes(novaJanela);
            ////clientes.Show();
            //
            //CadastroClientes cadastro = new CadastroClientes(novaJanela);
            //cadastro.Show();
            MessageBox.Show("Não Implementado!");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio menu = new TelaInicio();
            menu.Show();
            this.Dispose();
        }
        Int64 IDCelula;
        Int64 IDPedido;
        Int64 IDItemPedido;
        double valorProdutoUnidade;
        double valorProdutoTotal;
        double valorDescontoProduto;
        string valorPorcentagem;
        double valorLiquidoVenda;
        double vlTotal;
        int codigoBarrasID;
        Int64 cbCli;
        private void adicionarProdutos()
        {
            if (string.IsNullOrEmpty(txtQtde.Text))
            {
                txtQtde.Text = "1";
            }
            try
            {
                double result;
                result = Convert.ToDouble(txtVendaCod.Text);
                result += 1;
                double valorA = Convert.ToDouble(vlTotal);
                double valorB = Convert.ToDouble(txtDescontoPorcent.Text.Replace("%", "").Replace(" %", "").Replace("% ", "").Trim());
                double valorC = (valorA * valorB) / 100;
                double valorD = valorA - valorC;

                try
                {
                    OleDbCommand commandTotalProduto = new OleDbCommand("SELECT COUNT(col_codigoProduto) FROM TB_ProdutosDBSCV WHERE col_codigoProduto = " + txtCodBarras.Text + "", ClassConexao.DBSCV());
                    commandTotalProduto.ExecuteNonQuery();
                    double consultTotalBruto = Convert.ToDouble(commandTotalProduto.ExecuteScalar());
                    if (consultTotalBruto > 0)
                    {
                        OleDbCommand comandoBuscaCliente = new OleDbCommand("SELECT * FROM TB_VendasDBSCV WHERE col_codCliente="+ cbCliente.SelectedValue + " AND col_statusPedido = 0 ", ClassConexao.DBSCV());
                        OleDbDataReader dreader = comandoBuscaCliente.ExecuteReader();
                        int _CodigoCliente = 0;
                        while (dreader.Read())
                        {
                            _CodigoCliente = int.Parse(dreader["col_codCliente"].ToString());
                            break;
                        }

                        try
                        {
                            IDCliente = Convert.ToInt32(datagridVenda.Rows[0].Cells[12].Value);
                        }
                        catch
                        {
                            IDCliente = 0;
                        }



                        if (_CodigoCliente == IDCliente)
                        {
                            command = ClassConexao.DBSCV().CreateCommand();
                            command.CommandType = CommandType.Text;
                            command.CommandText = "INSERT INTO TB_VendasDBSCV (col_codVendaProduto, col_codProduto, col_quantidadeVendaProduto, col_valorProdutoUnidade, col_valorTotalProduto, col_porcentagemProduto, col_valorDesconto, col_valorLiquidoProduto, col_descricaoProduto, col_unidadeMedida,col_codCliente,col_dataVenda,col_codigoVendedor,col_maquinaCaixa) VALUES" +
                                "(" + txtVendaCod.Text + "," + txtCodBarras.Text + ",'" + txtQtde.Text + "','" + txtPrecoVenda.Text.Replace("R$ ", "") + "','" + vlTotal.ToString("N2") + "', '" + txtDescontoPorcent.Text.Replace("%", "").Replace(" %", "").Replace("% ", "").Trim() + "', '" + valorC.ToString("N2") + "', '" + valorD.ToString("N2") + "','" + txtDescricaoItem.Text + "','" + txtUm.Text + "','" + cbCliente.SelectedValue + "', NOW(), '" + ClassDadosGEt.IDUsuario + "','"+ nomeCaixa +"')";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Pedido Referente a outro Cliente!..");
                        }
                        limparText();
                        comandoBuscaCliente.Connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Produto não Cadastrado", "SIGTI - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limparText();
                    }
                    commandTotalProduto.Connection.Close();
                }
                catch (Exception)
                {

                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao inserir Item! - Contate o Desenvolvedor\r\n" + Erro.Message, "SIGTI - Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void limparText()
        {
            txtQtde.Clear();
            txtCodBarras.Clear();
            txtDescricaoItem.Clear();
            txtUm.Clear();
            txtPrecoVenda.Clear();
        }
        private void limparTexto()
        {
            txtTotalBruto.Clear();
            txtDescontoPorcent.Text = "0%";
            txtLiquido.Clear();
            txtItensDoPedido.Text = "0";
            txtTotalPago.Clear();
            txtTroco.Clear();
            txtValorPago1.Clear();
            txtValorPago2.Clear();
            cmbFormaPagamento1.Text = "";
            cmbFormaPagamento2.Text = "";
        }
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            carregarCodigoDeBarras();
            adicionarProdutos();
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //OleDbCommand command = new OleDbCommand("SELECT col_precoAtual FROM TB_EstoqueDBSCV WHERE col_IdProduto = "+ cmbProduto.SelectedValue + "",ClassConexao.DBSCV());
                //OleDbDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    //txtResultValor.Text = reader.GetValue(0).ToString();
                //    //double vlTotal = Convert.ToDouble(txtResultValor.Text) * Convert.ToDouble(txtQuantidade.Text);
                //    //txtResultValor.Text = vlTotal.ToString();
                //}
            }
        }
        double vlLiquido;
        private void carregarCodigoDeBarras()
        {
            OleDbCommand command = new OleDbCommand("SELECT Código,col_descricaoItem,col_unidadeMedida,col_precoVenda,col_margemLucro,col_lucroValor FROM TB_ProdutosDBSCV WHERE col_codigoProduto = " + txtCodBarras.Text + "", ClassConexao.DBSCV());
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                codigoBarrasID = Int16.Parse(reader.GetValue(0).ToString());
                txtDescricaoItem.Text = reader.GetValue(1).ToString();
                txtUm.Text = reader.GetValue(2).ToString();
                txtPrecoVenda.Text = Decimal.Parse(reader.GetValue(3).ToString()).ToString("C");
                double margLucro = Double.Parse(reader.GetValue(4).ToString());
                double vlLucro = Double.Parse(reader.GetValue(5).ToString());
                if (string.IsNullOrEmpty(txtQtde.Text))
                {
                    txtQtde.Text = "1";
                }
                vlTotal = Convert.ToDouble(txtPrecoVenda.Text.Replace("R$ ","")) * Convert.ToDouble(txtQtde.Text);
                vlLiquido = Convert.ToDouble(txtPrecoVenda.Text.Replace("R$ ","")) * Convert.ToDouble(txtQtde.Text);

                //txtResultValor.Text = vlTotal.ToString();
            }
        }
        private void carregarGridVendas()
        {
            try
            {
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    OleDbCommand selectCMD = new OleDbCommand("SELECT col_codProduto,col_descricaoProduto,col_unidadeMedida,col_quantidadeVendaProduto,col_valorProdutoUnidade,col_valorTotalProduto,col_porcentagemProduto,col_valorDesconto,col_valorLiquidoProduto,col_codVendaProduto,col_statusPedido,col_codItemVendaProduto,col_codCliente FROM TB_VendasDBSCV WHERE col_codVendaProduto=" + txtVendaCod.Text + " AND col_statusPedido = 0 ORDER BY col_codItemVendaProduto DESC", ClassConexao.DBSCV());
                    OleDbDataAdapter daAdapter = new OleDbDataAdapter(selectCMD);
                    DataSet tableGridVendas = new DataSet();
                    daAdapter.Fill(tableGridVendas);
                    datagridVenda.DataSource = tableGridVendas.Tables[0];
                }
                else
                {
                    MessageBox.Show("Erro ao conectar!", "SIGTI - Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro relacionado ao banco de dados " + ex.Message + " !", "SIGTI - Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }
            try
            {
                OleDbCommand commandItensPedido = new OleDbCommand("SELECT COUNT(col_codVendaProduto) FROM TB_VendasDBSCV WHERE col_codVendaProduto = " + txtVendaCod.Text + " AND col_statusPedido = 0", ClassConexao.DBSCV());
                commandItensPedido.ExecuteNonQuery();
                double consultItensPedido = Convert.ToDouble(commandItensPedido.ExecuteScalar());
                if (consultItensPedido > 0)
                {
                    txtItensDoPedido.Text = consultItensPedido.ToString();
                }
                commandItensPedido.Connection.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                OleDbCommand commandTotalProduto = new OleDbCommand("SELECT SUM(col_valorTotalProduto) FROM TB_VendasDBSCV WHERE col_codVendaProduto = " + txtVendaCod.Text + " AND col_statusPedido = 0", ClassConexao.DBSCV());
                commandTotalProduto.ExecuteNonQuery();
                double consultTotalBruto = Convert.ToDouble(commandTotalProduto.ExecuteScalar());
                if (consultTotalBruto > 0)
                {
                    txtTotalBruto.Text = consultTotalBruto.ToString("C2");
                }
                commandTotalProduto.Connection.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                OleDbCommand commandTotalLiquido = new OleDbCommand("SELECT SUM(col_valorLiquidoProduto) FROM TB_VendasDBSCV WHERE col_codVendaProduto = " + txtVendaCod.Text + " AND col_statusPedido = 0", ClassConexao.DBSCV());
                commandTotalLiquido.ExecuteNonQuery();
                double consultTotalLiquido = Convert.ToDouble(commandTotalLiquido.ExecuteScalar());
                if (consultTotalLiquido > 0)
                {
                    txtLiquido.Text = consultTotalLiquido.ToString("C2");
                }
                commandTotalLiquido.Connection.Close();
            }
            catch (Exception)
            {

            }
        }
        private void txtCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM TB_ClienteDBSCV WHERE Código = " + cbCliente.SelectedValue + " ", ClassConexao.DBSCV());
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int statusDes = Convert.ToInt16(dataReader["col_status"].ToString());
                    if (statusDes == 0)
                    {
                        limparText();
                        limparTexto();
                        MessageBox.Show("Cliente Desativado!", "SIGTI - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if (statusDes == 1)
                    {
                        carregarCodigoDeBarras();
                        adicionarProdutos();
                    }
                }
            }else if(e.KeyCode == Keys.F1)
            {

            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            carregarGridVendas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                refreshTimer.Enabled = false;
            }
            else
            {
                refreshTimer.Enabled = true;
            }
        }
        double _ValorPagoReultado;
        double _ValorPagoReultadoTroco;
        double _ValorPagoTratamento;
        private void txtValorPago1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtValorPago2.Text))
                {
                    try
                    {
                        _ValorPagoReultado = Convert.ToDouble(txtValorPago1.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        txtTotalPago.Text = _ValorPagoReultado.ToString("C2");


                        _ValorPagoReultadoTroco = _ValorPagoReultado - Convert.ToDouble(txtLiquido.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        if (_ValorPagoReultadoTroco < 0)
                        {

                        }
                        else
                        {
                            txtTroco.Text = _ValorPagoReultadoTroco.ToString("C2");
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    try
                    {

                        _ValorPagoReultado = Convert.ToDouble(txtValorPago1.Text.Replace("R$ ", "").Replace("R$", "").Trim()) + Convert.ToDouble(txtValorPago2.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        txtTotalPago.Text = _ValorPagoReultado.ToString("C2");

                        _ValorPagoReultadoTroco = _ValorPagoReultado - Convert.ToDouble(txtLiquido.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        if (_ValorPagoReultadoTroco < 0)
                        {

                        }
                        else
                        {
                            txtTroco.Text = _ValorPagoReultadoTroco.ToString("C2");
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void txtValorPago2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtValorPago2.Text))
                {
                    try
                    {
                        _ValorPagoReultado = Convert.ToDouble(txtValorPago1.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        txtTotalPago.Text = _ValorPagoReultado.ToString("C2");


                        _ValorPagoReultadoTroco = _ValorPagoReultado - Convert.ToDouble(txtLiquido.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        if (_ValorPagoReultadoTroco < 0)
                        {

                        }
                        else
                        {
                            txtTroco.Text = _ValorPagoReultadoTroco.ToString("C2");
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    try
                    {

                        _ValorPagoReultado = Convert.ToDouble(txtValorPago1.Text.Replace("R$ ", "").Replace("R$", "").Trim()) + Convert.ToDouble(txtValorPago2.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        txtTotalPago.Text = _ValorPagoReultado.ToString("C2");

                        _ValorPagoReultadoTroco = _ValorPagoReultado - Convert.ToDouble(txtLiquido.Text.Replace("R$ ", "").Replace("R$", "").Trim());
                        if (_ValorPagoReultadoTroco < 0)
                        {

                        }
                        else
                        {
                            txtTroco.Text = _ValorPagoReultadoTroco.ToString("C2");
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void FormularioVendas_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificaCliente_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não Implementado!", "SIGTI - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Deseja Excluir o item "+ IDCelula + " ?", "SIGTI - Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    OleDbCommand oleDbCommand = new OleDbCommand("DELETE * FROM TB_VendasDBSCV WHERE col_codItemVendaProduto=" + IDItemPedido + " AND col_codVendaProduto = " + IDPedido + " AND col_codProduto = " + IDCelula + "", ClassConexao.DBSCV());
                    oleDbCommand.ExecuteNonQuery();
                    carregarGridVendas();
                    MessageBox.Show("Exclusão realizada com sucesso!", "SIGTI - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagridVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCelula = Convert.ToInt64(datagridVenda.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            IDItemPedido = Convert.ToInt64(datagridVenda.Rows[e.RowIndex].Cells[11].FormattedValue.ToString());
            IDPedido = Convert.ToInt64(txtVendaCod.Text);
        }

        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Excluir o Pedido " + IDPedido + " ?", "SIGTI - Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    OleDbCommand oleDbCommand = new OleDbCommand("DELETE * FROM TB_VendasDBSCV WHERE col_codVendaProduto = " + IDPedido + "", ClassConexao.DBSCV());
                    oleDbCommand.ExecuteNonQuery();
                    carregarGridVendas();
                    MessageBox.Show("Exclusão realizada com sucesso!", "SIGTI - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            try
            {
                commandUpdate = ClassConexao.DBSCV().CreateCommand();
                commandUpdate.CommandType = CommandType.Text;
                commandUpdate.CommandText = "UPDATE TB_VendasDBSCV SET col_statusPedido = 1  WHERE col_codCliente = "+ cbCliente.SelectedValue +" AND col_maquinaCaixa = '"+ nomeCaixa +"' ";
                commandUpdate.ExecuteNonQuery();

                if (string.IsNullOrEmpty(txtValorPago1.Text))
                {
                    txtValorPago1.Text = "0";
                }
                if (string.IsNullOrEmpty(txtValorPago2.Text))
                {
                    txtValorPago2.Text = "0";
                }
                if(string.IsNullOrEmpty(cmbFormaPagamento2.Text))
                {
                    cmbFormaPagamento2.Text = "Nada";
                }
                    
                command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_FormaPagamentoDBSCV (col_codVendaProduto, col_codCliente,col_codigoVendedor,col_valorFinanceiroVenda1,col_valorFinanceiroVenda2,col_formaDePagamento1,col_formaDePagamento2,col_valorDoPedido) VALUES" +
                    "(" + txtVendaCod.Text + "," + cbCliente.SelectedValue + ",'"+ cbVendedor.SelectedValue +"','"+ txtValorPago1.Text.Replace("R$ ", "").Replace("R$", "").Trim() + "','"+ txtValorPago2.Text.Replace("R$ ", "").Replace("R$", "").Trim() + "','"+ cmbFormaPagamento1.Text +"','"+ cmbFormaPagamento2.Text +"','"+ txtLiquido.Text.Replace("R$ ", "").Replace("R$", "").Trim() + "')";
                command.ExecuteNonQuery();

                MessageBox.Show("Venda realizada com sucesso!", "SIGTI - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparText();
                limparTexto();
                carregarPedidos();
                IDCliente = 0;
                CarregarComboBoxCliente();
            }
            catch
            {

            }
        }
    }
}
