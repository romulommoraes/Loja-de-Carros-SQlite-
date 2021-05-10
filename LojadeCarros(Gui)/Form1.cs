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
    public partial class Form1 : Form
    {
        Loja minhaLoja = new Loja(); //ativação da classe loja -- ela possui duas listas  minhaLoja.ListaCarros e minhaLoja.ListaDeCompras
        List<Carro> total = new List<Carro>(); //lista intermediária -- Objetos carros a serem carregados pro bd e passados pra a listview
        List<string> CodCompras = new List<string>();//lista com os códigos dos itens selecionados pra comparação com a os presentes na minhaLoja.ListaCarros
        //String[] itens; //array que carrega todas as linhas do arquivo de texto q funciona como bd.

        int totalCompras = 0;
        string marca;
        string modelo;
        string preço;
        string ano;
        string estado;
        string portas;
        string qtd;
        string codigo;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CriarListViews();//cria e configura as listviews
            DataTable data = BD.CarregarCarros();
            CarregarLista(data);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_add_lista_Click(object sender, EventArgs e) //adiciona itens selecionados pra a lista de compras
        {
            //atribui as variaveis os valores do itens e sub itens selecionados na listview1
            marca = listView1.SelectedItems[0].SubItems[0].Text;
            modelo = listView1.SelectedItems[0].SubItems[1].Text;
            preço = listView1.SelectedItems[0].SubItems[2].Text;
            ano = listView1.SelectedItems[0].SubItems[3].Text;
            estado = listView1.SelectedItems[0].SubItems[4].Text;
            portas = listView1.SelectedItems[0].SubItems[5].Text;
            qtd = listView1.SelectedItems[0].SubItems[6].Text;
            codigo = listView1.SelectedItems[0].SubItems[7].Text;


            if (minhaLoja.ListaDeCompras.Count != 0) //se a lista de compras nao estiver vazia
            {
                for (int i = 0; i < minhaLoja.ListaDeCompras.Count; i++)
                {
                    CodCompras.Add(minhaLoja.ListaDeCompras[i].Codigo); //adiciona os códigos de compras dos itens selecionados

                }


                if (int.Parse(listView1.SelectedItems[0].SubItems[6].Text) > 0) // se o item tem quantidade disponivel em estoque
                {
                    if (CodCompras.Contains(codigo) == true) //se o codigo do item selecionado já está presente nos códigos da lista de compras
                    {
                        for (int j = 0; j < minhaLoja.ListaDeCompras.Count; j++) //compara a lista de compras com o item selecionado
                        {
                            if (int.Parse(listView1.SelectedItems[0].SubItems[7].Text) == int.Parse(minhaLoja.ListaDeCompras[j].Codigo)) //se o item estiver nas duas listas
                            {
                                minhaLoja.ListaDeCompras[j].Qtd++; //adiciona 1 a quantidade do item na lista de compras
                                LoadListview2(); //recarrega a lista de compras
                            }
                        }

                        for (int j = 0; j < minhaLoja.ListaCarros.Count; j++) //compara a lista de CARROS com o item selecionado
                        {
                            if (int.Parse(listView1.SelectedItems[0].SubItems[7].Text) == int.Parse(minhaLoja.ListaCarros[j].Codigo)) //procura o item selecionado
                            {
                                minhaLoja.ListaCarros[j].Qtd--; //subtrai um da quantidade do item na da lista de carros
                                listView1.SelectedItems[0].SubItems[6].Text = minhaLoja.ListaCarros[j].Qtd.ToString(); //mostra o novo valor

                            }
                        }
                    }
                    else
                    {
                        AddListview2(); // se o item não tiver sido adicionado a lista de compras ainda, o adiciona.
                    }
                }

                else
                {
                    MessageBox.Show("Item em falta no Estoque"); //caso nao tenha mais itens no estoque -> "minhaLoja.ListaCarros.qtd == 0"
                }

            }
            else
            {
                AddListview2();//se a lista de compras estiver vazia, simplesmente adiciona o primeiro item
            }
            CalcPreço();//recalcula o preço
        }

        private void btn_calc_Click(object sender, EventArgs e) //função de calculo do desconto
        {
            decimal totalDesc;
            decimal porcent = decimal.Parse(txt_desc.Text);
            if (porcent == 0)
            {
                CalcPreço();
            }
            else
            {
                decimal desconto = totalCompras * (porcent / 100);
                totalDesc = totalCompras - desconto;
                lbl_preco.Text = totalDesc.ToString("C");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e) //limpa a lista de compras e todas as variaveis relativas a ela
        {
            listView2.Items.Clear();
            CodCompras.Clear();
            totalCompras = 0;
            lbl_preco.Text = "0";
            minhaLoja.ListaDeCompras.Clear();
            listView1.Items.Clear();
            minhaLoja.ListaCarros.Clear();
            DataTable data = BD.CarregarCarros();
            CarregarLista(data);
        }

        private void button1_Click(object sender, EventArgs e) //botão adicionar carro
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog(); // Shows Form2
        }

        private void AddListview2() //função pra adicionar item ao listview2
        {
            total.Clear();//limpa a lista intermediária
            //cria uma nova instância da classe carro com as variáveis que foram atribuidas pelo click do botão "btn_add_lista_Click"
            Carro selecionado = new Carro(marca, modelo, decimal.Parse(preço), int.Parse(ano), estado.ToString(), portas.ToString(), 0, codigo);
            minhaLoja.ListaDeCompras.Add(selecionado); //adiciona o item pra a lista de compras

            //funciona do mesmo jeito que antes só q aqui é pra mexer nas quantidades dos itens ao passar de uma lista pra outra
            for (int j = 0; j < minhaLoja.ListaDeCompras.Count; j++)//pra cada item da lista de compras
            {
                if (int.Parse(listView1.SelectedItems[0].SubItems[7].Text) == int.Parse(minhaLoja.ListaDeCompras[j].Codigo))//compara com o item selecionado
                {
                    minhaLoja.ListaDeCompras[j].Qtd++; //adiciona um a quantidade do item na lista de compras
                }
            }
            for (int j = 0; j < minhaLoja.ListaCarros.Count; j++)
            {
                if (int.Parse(listView1.SelectedItems[0].SubItems[7].Text) == int.Parse(minhaLoja.ListaCarros[j].Codigo))
                {
                    minhaLoja.ListaCarros[j].Qtd--; //subtrai um item da lista de carros
                    listView1.SelectedItems[0].SubItems[6].Text = minhaLoja.ListaCarros[j].Qtd.ToString();
                }
            }
            LoadListview2();
        }


        private void LoadListview2()
        {
            total.Clear();
            for (int j = 0; j < minhaLoja.ListaDeCompras.Count; j++)
            {
                total.Add(minhaLoja.ListaDeCompras[j]);
            }
            listView2.Items.Clear();
            foreach (var item in total)
            {
                String[] itemLinha = new string[] { item.Marca, item.Modelo.ToString(), item.Preço.ToString(), item.Ano.ToString(), item.Estado, item.Portas, item.Qtd.ToString(), item.Codigo };
                listView2.Items.Add(new ListViewItem(itemLinha));//o list view item requer um array como parametro, no caso tem que criar ele pra poder adicionar ao list view
            }
        }

        private void CriarListViews()
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
            listView1.Sorting = SortOrder.Ascending;

            listView2.Columns.Add("Marca", 75);
            listView2.Columns.Add("Modelo", 80);
            listView2.Columns.Add("Preço", 50);
            listView2.Columns.Add("Ano", 40);
            listView2.Columns.Add("Estado", 60);
            listView2.Columns.Add("Portas", 45);
            listView2.Columns.Add("QTD", 35);
            listView2.Columns.Add("Código", 70);
            listView2.View = View.Details;
            listView2.GridLines = true; //mostra linha de grades
            listView2.FullRowSelect = true; //seleciona toda a linha qdo clica
            listView2.Sorting = SortOrder.Ascending; //ordena a lista pela primeira coluna
        }
     

        private void CalcPreço()
        {

            totalCompras = 0;
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                totalCompras = totalCompras + (int.Parse(listView2.Items[i].SubItems[2].Text) * int.Parse(listView2.Items[i].SubItems[6].Text));
            }

            lbl_preco.Text = totalCompras.ToString("C");
        }

        public void CarregarLista(DataTable data)
        {
            minhaLoja.ListaCarros.Clear();
            

            string Bdmarca = "";
            string Bdmodelo = "";
            decimal Bdpreco = 0;
            int Bdano = 0;
            string Bdestado = "";
            string Bdportas = "";
            int Bdqtd = 0;
            string Bdcodigo = "";

            foreach (DataRow row in data.Rows)//acessa todos os itens e sub itens da data table
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
                Carro c = new Carro(Bdmarca, Bdmodelo, Bdpreco, Bdano, Bdestado, Bdportas, Bdqtd, Bdcodigo);//a cada iteração um objeto é criado
                minhaLoja.ListaCarros.Add(c);//e adicionado a lista de carros
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

        private void txt_busca_marca_TextChanged(object sender, EventArgs e)
        {
            string busca = txt_busca_marca.Text;
            string alvobusca = "T_MARCA";
            DataTable data = BD.BuscarCarros(alvobusca, busca);
            minhaLoja.ListaCarros.Clear();
            CarregarLista(data);

        }

        private void txt_busca_modelo_TextChanged(object sender, EventArgs e)
        {
            string busca = txt_busca_modelo.Text;
            string alvobusca = "T_MODELO";
            DataTable data = BD.BuscarCarros(alvobusca, busca);
            minhaLoja.ListaCarros.Clear();
            CarregarLista(data);
        }
    }

}
