using ClasseCarro;
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


namespace LojadeCarros_Gui_
{

    public partial class Form2 : Form
    {
        Loja minhaLoja = new Loja();
        List<Carro> total = new List<Carro>();
        List<string> output = new List<string>();
        static bool itemSelecionado = false;

        Form1 form1;

        public Form2(Form1 f) //permite usar uma função do form 2 pra manipular a list view do form1 adicionando form1. antes do comando
        {
            InitializeComponent();
            form1 = f;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try //posso refinar mais isso
            {
                Carro c = new Carro(txt_Marca.Text.ToUpper(), txt_modelo.Text.ToUpper(), decimal.Parse(txt_preco.Text), int.Parse(txt_ano.Text), txt_estado.Text.ToUpper(), txt_portas.Text, int.Parse(txt_qtd.Text), txt_codigo.Text);
                BD.novoCarro(c);
                //minhaLoja.ListaCarros.Add(c);

                txt_Marca.Text = "";
                txt_modelo.Text = "";
                txt_preco.Text = "";
                txt_ano.Text = "";
                txt_estado.Text = "";
                txt_portas.Text = "";
                txt_qtd.Text = "";
                txt_codigo.Text = "";

            }
            catch
            {
                MessageBox.Show("ERRO DE INPUT");
            }
            DataTable data = BD.CarregarCarros();
            CarregarLista(data);

        }

        public void CarregarLista(DataTable data)
        {
            minhaLoja.ListaCarros.Clear();
            //DataTable data = BD.CarregarCarros();


            string Bdmarca = "";
            string Bdmodelo = "";
            decimal Bdpreco = 0;
            int Bdano = 0;
            string Bdestado = "";
            string Bdportas = "";
            int Bdqtd = 0;
            string Bdcodigo = "";

            foreach (DataRow row in data.Rows)
            {
                Bdmarca = row[0].ToString();
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    Bdmodelo = row[1].ToString();
                    Bdpreco = decimal.Parse(row[2].ToString());
                    Bdano = int.Parse(row[3].ToString());
                    Bdestado = row[4].ToString();
                    Bdportas = row[5].ToString();
                    Bdqtd = int.Parse(row[6].ToString());
                    Bdcodigo = row[7].ToString();
                }
                Carro c = new Carro(Bdmarca, Bdmodelo, Bdpreco, Bdano, Bdestado, Bdportas, Bdqtd, Bdcodigo);
                minhaLoja.ListaCarros.Add(c);
            }
            total.Clear();
            listView1.Items.Clear();

            for (int i = 0; i < minhaLoja.ListaCarros.Count; i++)
            {
                total.Add(minhaLoja.ListaCarros[i]);
            }
            foreach (var item in total)
            {
                String[] itemLinha = new string[] { item.Marca, item.Modelo.ToString(), item.Preço.ToString(), item.Ano.ToString(), item.Estado, item.Portas, item.Qtd.ToString(), item.Codigo.ToString() };
                listView1.Items.Add(new ListViewItem(itemLinha));//o list view item requer um array como parametro, no caso tem que criar ele pra poder adicionar ao list view
            }
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {

            DataTable data = BD.CarregarCarros();
            CarregarLista(data);//recarrega a listview do form 1 com os itens adicionados

        }




        private void btn_sair_Click(object sender, EventArgs e)
        {
            DataTable data = BD.CarregarCarros();
            form1.CarregarLista(data);//recarrega a listview do form 1 com os itens adicionados
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            total.Clear();
            listView1.Items.Clear();
            minhaLoja.ListaCarros.Clear();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("Marca", 75);
            listView1.Columns.Add("Modelo", 80);
            listView1.Columns.Add("Preço", 50);
            listView1.Columns.Add("Ano", 40);
            listView1.Columns.Add("Estado", 60);
            listView1.Columns.Add("Portas", 45);
            listView1.Columns.Add("QTD", 35);
            listView1.Columns.Add("Código", 70);

            listView1.View = View.Details;
            listView1.GridLines = true; //mostra linha de grades
            listView1.FullRowSelect = true; //seleciona toda a linha qdo clica
            listView1.Sorting = SortOrder.Ascending; //ordena a lista pela primeira coluna
            DataTable data = BD.CarregarCarros();
            CarregarLista(data);

        }

        private void txt_portas_TextChanged(object sender, EventArgs e)
        {
            // função pra gerar o codigo
            string codigoP1;
            string codigoP2 = txt_ano.Text;
            string codigoP3;
            string codigoP4;
            switch (txt_Marca.Text.ToUpper())
            {
                case "VW":
                    codigoP1 = "1";
                    break;
                case "FIAT":
                    codigoP1 = "2";
                    break;
                case "RENAULT":
                    codigoP1 = "3";
                    break;
                case "CHEVROLET":
                    codigoP1 = "4";
                    break;
                case "FORD":
                    codigoP1 = "5";
                    break;
                case "HYUNDAI":
                    codigoP1 = "6";
                    break;
                case "TOYOTA":
                    codigoP1 = "7";
                    break;
                case "HONDA":
                    codigoP1 = "8";
                    break;
                case "NISSAN":
                    codigoP1 = "9";
                    break;
                case "PEUJEOT":
                    codigoP1 = "0";
                    break;

                default:
                    codigoP1 = "99";
                    break;
            }
            switch (txt_portas.Text.ToUpper())
            {
                case "2":
                    codigoP3 = "2";
                    break;
                case "4":
                    codigoP3 = "4";
                    break;
                default:
                    codigoP3 = "3";
                    break;
            }

            Random r = new Random();
            int randomInt = r.Next(0, 100);
            codigoP4 = randomInt.ToString();

            txt_codigo.Text = codigoP1 + codigoP2 + codigoP3 + codigoP4;

        }


        private void btn_remover_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a Exclusão?", "Excluir Item", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string selecionado = listView1.SelectedItems[0].SubItems[7].Text;
                BD.deletarCarro(selecionado);
                DataTable data = BD.CarregarCarros();
                CarregarLista(data);
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                txt_Marca.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txt_modelo.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txt_preco.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txt_ano.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txt_estado.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txt_portas.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txt_qtd.Text = listView1.SelectedItems[0].SubItems[6].Text;
                txt_codigo.Text = listView1.SelectedItems[0].SubItems[7].Text;
                itemSelecionado = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (itemSelecionado == true)
            {
                if (txt_Marca.Text != "" && txt_modelo.Text != "" && txt_preco.Text != "" && txt_ano.Text != "" && txt_estado.Text != "" && txt_portas.Text != "" && txt_qtd.Text != "" && txt_codigo.Text != "")
                {
                    DialogResult res = MessageBox.Show("Confirma a Atualização?", "Atualizar Item", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Carro c = new Carro(txt_Marca.Text.ToUpper(), txt_modelo.Text.ToUpper(), decimal.Parse(txt_preco.Text), int.Parse(txt_ano.Text), txt_estado.Text.ToUpper(), txt_portas.Text, int.Parse(txt_qtd.Text), txt_codigo.Text);
                        BD.atualizarCarro(c);
                        DataTable data = BD.CarregarCarros();
                        CarregarLista(data);
                        itemSelecionado = false;
                        txt_Marca.Text = "";
                        txt_modelo.Text = "";
                        txt_preco.Text = "";
                        txt_ano.Text = "";
                        txt_estado.Text = "";
                        txt_portas.Text = "";
                        txt_qtd.Text = "";
                        txt_codigo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Erro de input");
                }
            }

            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }

        }
    }
}
