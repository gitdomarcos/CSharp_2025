using CSharp_2025.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSharp_2025
{
    public partial class frmXML_CRUD : Form
    {
        public frmXML_CRUD()
        {
            InitializeComponent();
        }

        private void frmXML_CRUD_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            Consultar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string codigo, nome, rua, bairro;

                try
                {
                    codigo = txtCodigo.Text;
                    if (VerificarCodigo(codigo))
                    {
                        nome = txtNome.Text;
                        rua = txtRua.Text;
                        bairro = txtBairro.Text;

                        Cadastrar(codigo, nome, rua, bairro);
                        LimparCampos();
                        Consultar();
                        Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
                        MessageBox.Show("Pessoa cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("O código ja existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar a pessoa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nome, rua, bairro, codigo;

                try
                {
                    codigo = txtCodigo.Text;
                    nome = txtNome.Text;
                    rua = txtRua.Text;
                    bairro = txtBairro.Text;

                    Alterar(codigo, nome, rua, bairro);
                    LimparCampos();
                    Consultar();
                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);

                    MessageBox.Show("Cadastro alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar o cadastro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o arquivo!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string codigo;

                try
                {
                    codigo = txtCodigo.Text;

                    Excluir(codigo);
                    LimparCampos();
                    Consultar();
                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);

                    MessageBox.Show("Cadastro excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir o arquivo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdPessoa.RowCount > 0)
            {
                var objLinhaClicada = (DataRowView)grdPessoa.CurrentRow.DataBoundItem;

                txtCodigo.Text = objLinhaClicada.Row["codigo"].ToString();
                txtNome.Text = objLinhaClicada.Row["nome"].ToString();
                txtRua.Text = objLinhaClicada.Row["rua"].ToString();
                txtBairro.Text = objLinhaClicada.Row["bairro"].ToString();

                txtCodigo.Enabled = false;

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);

            }
        }


        #region Métodos do Formulário

        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtCodigo.Text.Trim() == string.Empty
                || txtNome.Text.Trim() == string.Empty
                || txtRua.Text.Trim() == string.Empty
                || txtBairro.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencher todos os campos!");
            }

            return flag;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }

        private void Cadastrar(string codigo, string nome, string rua, string bairro)
        {
            XmlDocument xml = new XmlDocument();

            //Verifica se o arquivo não existe
            if (!File.Exists(Util.pathFileXml))
            {
                XmlElement noPessoa = xml.CreateElement("pessoa");
                xml.AppendChild(noPessoa);
            }
            else
            {
                xml.Load(Util.pathFileXml);
            }

            //Cria o nó item
            XmlElement noItem = xml.CreateElement("item");

            //Cria o nó Código
            XmlElement noCodigo = xml.CreateElement("codigo");
            //Armazena a informação
            noCodigo.InnerText = codigo;
            //Adiciona no nó pai
            noItem.AppendChild(noCodigo);

            //Cria o nó Nome
            XmlElement noNome = xml.CreateElement("nome");
            //Armazena a informação
            noNome.InnerText = nome;
            //Adiciona no nó pai
            noItem.AppendChild(noNome);

            //Cria o nó Rua
            XmlElement noRua = xml.CreateElement("rua");
            //Armazena a informação
            noRua.InnerText = rua;
            //Adiciona no nó pai
            noItem.AppendChild(noRua);

            //Cria o nó Bairro
            XmlElement noBairro = xml.CreateElement("bairro");
            //Armazena a informação
            noBairro.InnerText = bairro;
            //Adiciona no nó pai
            noItem.AppendChild(noBairro);

            //Selecionar o nó Pessoa
            XmlNode xmlPessoa = xml.SelectSingleNode("pessoa");
            xmlPessoa.AppendChild(noItem);

            //Salvar
            xml.Save(Util.pathFileXml);
        }

        private void Consultar()
        {
            try
            {
                grdPessoa.DataSource = null;

                if (File.Exists(Util.pathFileXml))
                {
                    //Criar meu DATA SET(obj) para receber o conteúdo do XML
                    DataSet ds = new DataSet();
                    //Carregar o conteúdo do meu arquivo
                    ds.ReadXml(Util.pathFileXml);

                    //Verifica se encontrou o conteúdo
                    if (ds.Tables.Count > 0)
                    {
                        grdPessoa.DataSource = ds.Tables[0];

                        //Personalizar nomes colunas da tabela
                        grdPessoa.Columns["codigo"].HeaderText = "CÓDIGO";
                        grdPessoa.Columns["nome"].HeaderText = "NOME";
                        grdPessoa.Columns["rua"].HeaderText = "RUA";
                        grdPessoa.Columns["bairro"].HeaderText = "BAIRRO";
                    }
                }

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarCodigo(string codigo)
        {

            XmlDocument xml = new XmlDocument();

            if (File.Exists(Util.pathFileXml))
            {
                xml.Load(Util.pathFileXml);

                XmlNode noCodigo = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                return noCodigo != null ? false : true;

                //if (noCodigo != null)
                //    return false;
                //else
                //    return true;


            }

            return true;
        }

        private void Alterar(string codigo, string nome, string rua, string bairro)
        {
            XmlDocument xml = new XmlDocument();

            if (File.Exists(Util.pathFileXml))
            {
                xml.Load(Util.pathFileXml);

                XmlNode noInformacao = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                if(noInformacao != null)
                {
                    XmlNode noNome = noInformacao.SelectSingleNode("nome");
                    noNome.InnerText = nome;

                    XmlNode noRua = noInformacao.SelectSingleNode("rua");
                    noRua.InnerText = rua;

                    XmlNode noBairro = noInformacao.SelectSingleNode("bairro");
                    noBairro.InnerText = bairro;

                    xml.Save(Util.pathFileXml);
                }  
            }
        }

        private void Excluir(string codigo)
        {
            XmlDocument xml = new XmlDocument();

            if (File.Exists(Util.pathFileXml))
            {
                xml.Load(Util.pathFileXml);

                XmlNode noInformacao = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                if (noInformacao != null)
                {
                    noInformacao.ParentNode.RemoveChild(noInformacao);
                    xml.Save(Util.pathFileXml);
                }
            }
            
        }

        #endregion

    }
}
