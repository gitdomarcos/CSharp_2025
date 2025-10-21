using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2025
{
    public partial class frmListGenerics2_1_ : Form
    {
        public frmListGenerics2_1_()
        {
            InitializeComponent();
        }

        private enum Classificacao
        {
            MoscaLigeiro,
            Mosca,
            Galo,
            Pena,
            Leve,
            Desclassificado
        }

        private enum Direcao
        {
            Acima,
            Abaixo,
            Igual
        }

        List<double> lstMoscaLigeiro = new List<double>();
        List<double> lstMosca = new List<double>();
        List<double> lstGalo = new List<double>();
        List<double> lstPena = new List<double>();
        List<double> lstLeve = new List<double>();
        List<double> lstDesclassificado = new List<double>();
        List<double> lstListaResultado = new List<double>();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampo() == true)
            {
                double peso;
                try
                {
                    peso = Convert.ToDouble(txtPeso.Text);

                    VerificarClassificacao(peso);
                    LimparCampo();
                }
                catch
                {
                    MessageBox.Show("Preencher os campos corretamente!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private bool ValidarCampo()
        {
            bool flag;

            if (txtPeso.Text.Trim() == string.Empty)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            if (flag == false)
            {
                MessageBox.Show("Preencher o campo com o peso!");
            }

            return flag;
        }

        private void AddLista(double peso, Classificacao classificacao)
        {
            switch (classificacao)
            {
                case Classificacao.MoscaLigeiro:
                    lstMoscaLigeiro.Add(peso);
                    break;
                case Classificacao.Mosca:
                    lstMosca.Add(peso);
                    break;
                case Classificacao.Galo:
                    lstGalo.Add(peso);
                    break;
                case Classificacao.Pena:
                    lstPena.Add(peso);
                    break;
                case Classificacao.Leve:
                    lstLeve.Add(peso);
                    break;
                case Classificacao.Desclassificado:
                    lstDesclassificado.Add(peso);
                    break;
            }
        }

        private void CarregarLista(Classificacao classificacao)
        {
            switch (classificacao)
            {
                case Classificacao.MoscaLigeiro:
                    listBoxMoscaLig.DataSource = null;
                    listBoxMoscaLig.DataSource = lstMoscaLigeiro;
                    break;
                case Classificacao.Mosca:
                    listBoxMosca.DataSource = null;
                    listBoxMosca.DataSource = lstMosca;
                    break;
                case Classificacao.Galo:
                    listBoxGalo.DataSource = null;
                    listBoxGalo.DataSource = lstGalo;
                    break;
                case Classificacao.Pena:
                    listBoxPena.DataSource = null;
                    listBoxPena.DataSource = lstPena;
                    break;
                case Classificacao.Leve:
                    listBoxLeve.DataSource = null;
                    listBoxLeve.DataSource = lstLeve;
                    break;
                case Classificacao.Desclassificado:
                    listBoxDesclassificado.DataSource = null;
                    listBoxDesclassificado.DataSource = lstDesclassificado;
                    break;
            }
        }

        private void VerificarClassificacao(double peso)
        {
            if (peso >= 0 && peso <= 48)
            {
                AddLista(peso, Classificacao.MoscaLigeiro);
                CarregarLista(Classificacao.MoscaLigeiro);
            }
            else if (peso > 48 && peso <= 51)
            {
                AddLista(peso, Classificacao.Mosca);
                CarregarLista(Classificacao.Mosca);
            }
            else if (peso > 51 && peso <= 54)
            {
                AddLista(peso, Classificacao.Galo);
                CarregarLista(Classificacao.Galo);
            }
            else if (peso > 54 && peso <= 57)
            {
                AddLista(peso, Classificacao.Pena);
                CarregarLista(Classificacao.Pena);
            }
            else if (peso > 57 && peso <= 60)
            {
                AddLista(peso, Classificacao.Leve);
                CarregarLista(Classificacao.Leve);
            }
            else if (peso > 60)
            {
                AddLista(peso, Classificacao.Desclassificado);
                CarregarLista(Classificacao.Desclassificado);
            }
        }

        private void LimparCampo()
        {
            txtPeso.Clear();
            txtPeso.Focus();
        }

        private void LimparTela()
        {
            listBoxMoscaLig.DataSource = null;
            listBoxMosca.DataSource = null;
            listBoxGalo.DataSource = null;
            listBoxPena.DataSource = null;
            listBoxLeve.DataSource = null;
            listBoxDesclassificado.DataSource = null;
            LimparCampo();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            //como fazer a chamada do botão?
        }


        private void FiltrarClassificacao(double peso, Direcao direcao, Classificacao classificacao)
        {
            switch (classificacao)
            {
                case Classificacao.MoscaLigeiro:
                    for (int i = 0; i < lstMoscaLigeiro.Count; i++)
                    {
                        if (direcao == Direcao.Acima)
                        {
                            if (lstMoscaLigeiro[i] > peso)
                            {
                                AdicionarListaResultado(lstMoscaLigeiro[i]);
                            }
                        }
                        else if (direcao == Direcao.Abaixo)
                        {
                            if (lstMoscaLigeiro[i] < peso)
                            {
                                AdicionarListaResultado(lstMoscaLigeiro[i]);
                            }
                        }
                        else if (direcao == Direcao.Igual)
                        {
                            if (peso == lstMoscaLigeiro[i])
                            {
                                AdicionarListaResultado(lstMoscaLigeiro[i]);
                            }
                        }
                    }
                    break;

                case Classificacao.Mosca:
                    for (int i = 0; i < lstMosca.Count; i++)
                    {
                        if (direcao == Direcao.Acima)
                        {
                            if (lstMosca[i] > peso)
                            {
                                AdicionarListaResultado(lstMosca[i]);
                            }
                        }
                        else if (direcao == Direcao.Abaixo)
                        {
                            if (lstMosca[i] < peso)
                            {
                                AdicionarListaResultado(lstMosca[i]);
                            }
                        }
                        else if (direcao == Direcao.Igual)
                        {
                            if (peso == lstMosca[i])
                            {
                                AdicionarListaResultado(lstMosca[i]);
                            }
                        }
                    }
                    break;

                case Classificacao.Galo:
                    for (int i = 0; i < lstGalo.Count; i++)
                    {
                        if (direcao == Direcao.Acima)
                        {
                            if (lstGalo[i] > peso)
                            {
                                AdicionarListaResultado(lstGalo[i]);
                            }
                        }
                        else if (direcao == Direcao.Abaixo)
                        {
                            if (lstGalo[i] < peso)
                            {
                                AdicionarListaResultado(lstGalo[i]);
                            }
                        }
                        else if (direcao == Direcao.Igual)
                        {
                            if (peso == lstGalo[i])
                            {
                                AdicionarListaResultado(lstGalo[i]);
                            }
                        }
                    }
                    break;

                case Classificacao.Pena:
                    for (int i = 0; i < lstPena.Count; i++)
                    {
                        if (direcao == Direcao.Acima)
                        {
                            if (lstPena[i] > peso)
                            {
                                AdicionarListaResultado(lstPena[i]);
                            }
                        }
                        else if (direcao == Direcao.Abaixo)
                        {
                            if (lstPena[i] < peso)
                            {
                                AdicionarListaResultado(lstPena[i]);
                            }
                        }
                        else if (direcao == Direcao.Igual)
                        {
                            if (peso == lstPena[i])
                            {
                                AdicionarListaResultado(lstPena[i]);
                            }
                        }
                    }
                    break;

                case Classificacao.Leve:
                    for (int i = 0; i < lstLeve.Count; i++)
                    {
                        if (direcao == Direcao.Acima)
                        {
                            if (lstLeve[i] > peso)
                            {
                                AdicionarListaResultado(lstLeve[i]);
                            }
                        }
                        else if (direcao == Direcao.Abaixo)
                        {
                            if (lstLeve[i] < peso)
                            {
                                AdicionarListaResultado(lstLeve[i]);
                            }
                        }
                        else if (direcao == Direcao.Igual)
                        {
                            if (peso == lstLeve[i])
                            {
                                AdicionarListaResultado(lstLeve[i]);
                            }
                        }
                    }
                    break;

                case Classificacao.Desclassificado:
                    for (int i = 0; i < lstDesclassificado.Count; i++)
                    {
                        if (direcao == Direcao.Acima)
                        {
                            if (lstDesclassificado[i] > peso)
                            {
                                AdicionarListaResultado(lstDesclassificado[i]);
                            }
                        }
                        else if (direcao == Direcao.Abaixo)
                        {
                            if (lstDesclassificado[i] < peso)
                            {
                                AdicionarListaResultado(lstDesclassificado[i]);
                            }
                        }
                        else if (direcao == Direcao.Igual)
                        {
                            if (peso == lstDesclassificado[i])
                            {
                                AdicionarListaResultado(lstDesclassificado[i]);
                            }
                        }
                    }
                    break;
            }
        }

        private void AdicionarListaResultado(double peso)
        {
            lstListaResultado.Add(peso);
        }

        private void CarregarListaResultado(double peso)
        {
            listBoxResultado.DataSource = null;
            listBoxResultado.DataSource = lstListaResultado;
        }
    }
}
