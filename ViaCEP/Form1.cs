using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ViaCEP
{
    public partial class Form1 : Form
    {
        Endereco endereco = new Endereco();

        string CepSelecionado = "";
        bool CellClick = false;

        public Form1()
        {
            InitializeComponent();

            txbCep.MaxLength = 8; //Quantidade de digitos CEP

            dgvFavoritos.DataSource = endereco.Listar(); //Preenchendo o DGV
        }

        public void Atualizar()
        {
            dgvFavoritos.DataSource = endereco.Listar();
            btnApagarTudo.Enabled = false;
            btnRemoverSelecionado.Enabled = false;
            grbInfo.Enabled = false;
            lblFav.Enabled = false;
            lblFav.Visible = false;
            btnFavoritar.Visible = false;
            btnFavoritar.Enabled = false;
            txbCep.Clear();
            txbLogradouro.Clear();
            txbComplemento.Clear();
            txbBairro.Clear();
            txbLocalidade.Clear();
            txbDDD.Clear();
            txbUF.Clear();

            CellClick = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txbCep.Text == "")
            {   //Impedir caso o campo esteja vazio
                MessageBox.Show("Preencha o campo", "Alerta", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(txbCep.Text.Length < 8) //Caso o CEP tenha menos digitos que o padrão
                    {
                        MessageBox.Show("CEP Inválido", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbCep.Clear();
                    }
                    else
                    {
                        //Habilitando os campos
                        grbInfo.Enabled = true;
                        lblFav.Enabled = true;
                        lblFav.Visible = true;
                        btnFavoritar.Visible = true;
                        btnFavoritar.Enabled = true;

                        string cep = txbCep.Text;

                        string link = "https://viacep.com.br/ws/" + cep + "/json/";

                        WebClient navegador = new WebClient();
                        string r = navegador.DownloadString(link);

                        r = Encoding.UTF8.GetString(Encoding.Default.GetBytes(r));

                        endereco = JsonConvert.DeserializeObject<Endereco>(r);

                        txbLogradouro.Text = endereco.logradouro;
                        txbComplemento.Text = endereco.complemento;
                        txbBairro.Text = endereco.bairro;
                        txbLogradouro.Text = endereco.localidade;
                        txbUF.Text = endereco.uf;
                        txbDDD.Text = endereco.ddd;
                    }

                    if (txbLogradouro.Text == "" && txbBairro.Text == "" && txbUF.Text == "" && txbDDD.Text == "")
                    {
                        MessageBox.Show("CEP Não possui informações registradas", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Atualizar();
                    }

                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Atualizar();
                }
            }
        }
        private void dgvFavoritos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvFavoritos.CurrentCell.RowIndex;
            var l = dgvFavoritos.Rows[Selecao];

            btnApagarTudo.Enabled = true;
            btnRemoverSelecionado.Enabled = true;

            CepSelecionado = l.Cells[1].Value.ToString();

            txbCep.ReadOnly = true;
            btnBuscar.Enabled = false;
            txbCep.Text = CepSelecionado;
            btnBuscar.PerformClick();

            CellClick = true;
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            endereco.cep = txbCep.Text;

            if (endereco.Verificar().Rows.Count > 0)
            {
                MessageBox.Show("CEP já está nos favoritos", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Atualizar();
            }
            else
            {
                try
                {
                    endereco.cep = txbCep.Text;
                    endereco.logradouro = txbLogradouro.Text;
                    endereco.complemento = txbComplemento.Text;
                    endereco.bairro = txbBairro.Text;
                    endereco.localidade = txbLocalidade.Text;
                    endereco.uf = txbUF.Text;
                    endereco.ddd = txbDDD.Text;

                    if (endereco.Favoritar())
                    {
                        MessageBox.Show("Adicionado aos favoritos", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Atualizar();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao favoritar", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Atualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Atualizar();
                }
            }
        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            endereco.cep = CepSelecionado;

            var r = MessageBox.Show("Tem certeza que deseja remover o CEP " + CepSelecionado + " dos favoritos?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                try
                {
                    if (endereco.RemoverSelecionado())
                    {
                        MessageBox.Show("CEP Removido com sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Atualizar();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Atualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao remover", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Atualizar();
                }
            }
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja remover todos os favoritos?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                try
                {
                    if (endereco.RemoverTudo())
                    {
                        MessageBox.Show("Favoritos removidos", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Atualizar();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Atualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao remover", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Atualizar();
                }
            }
        }

        private void txbCep_KeyPress(object sender, KeyPressEventArgs e) //Método para apenas ser possível digitar números no txb
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e) //Método para cancelar exclusão
        {
            if (CellClick == true)
            {
                btnApagarTudo.Enabled = false;
                btnRemoverSelecionado.Enabled = false;
                txbCep.ReadOnly = false;
                btnBuscar.Enabled = true;

                Atualizar();
            }
        }
    }
}
