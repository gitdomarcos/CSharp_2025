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

        private void btnCadastrar_Click(object sender, EventArgs e)
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

                    Cadastrar(codigo, nome, rua, bairro);
                    LimparCampos();
                    MessageBox.Show("Pessoa cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Erro ao cadastrar a pessoa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void frmXML_CRUD_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnCancelar, btnAlterar, btnExcluir);
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
            txtCodigo.Focus();
        }

        private void Cadastrar(string codigo,string nome, string rua, string bairro)
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

        #endregion
    }
}
