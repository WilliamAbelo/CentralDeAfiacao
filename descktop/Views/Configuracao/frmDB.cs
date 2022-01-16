using descktop.Data;
using descktop.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.ListView;
using descktop.Utils;

namespace descktop.Views.Configuracao
{
    public partial class frmDB : Form
    {

        DBService DBService;
        frmInicio frmInicio;
        public frmDB(frmInicio frmIn)
        {
            DBService = new DBService();
            frmInicio = frmIn;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            buscaTabelas();
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        public void buscaTabelas()
        {
            string[] tabelas = DBService.listTables();
            foreach (string linha in tabelas)
            {
                cbTabelas.Items.Add((linha));
            }
            cbTabelas.SelectedIndex = 0;
        }

        private void btnExecutarQuery_Click(object sender, EventArgs e)
        {
            lstDB.Clear();
            DBModel result = DBService.executarQuery(txtQuery.Text);
            if (result == null)
            {
                return;
            }

            montarColuna(result.colunas.nome);

            foreach (Linha linha in result.linhas.linhas)
            {
                List<string> row = new List<string>();
                foreach (var valor in linha.item)
                {
                    row.Add(valor);
                }

                ListViewItem item = new ListViewItem(row.ToArray());
                lstDB.Items.Add(item);
            }
            lstDB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void montarColuna(List<string> colunas)
        {
            foreach (var coluna in colunas)
            {

                lstDB.Columns.Add(coluna, -2);
            }

            lstDB.View = View.Details;
            lstDB.FullRowSelect = true;
        }

        private void fazerBackUp()
        {
            string[] tabelas = DBService.listTables();
            foreach (string tabela in tabelas)
            {
                string query = "select * from " + tabela;
                ListView listView = new ListView();
                DBModel result = DBService.executarQuery(query);

                if (result == null)
                {
                    return;
                }

                foreach (var coluna in result.colunas.nome)
                {

                    listView.Columns.Add(coluna, -2);
                }

                foreach (Linha linha in result.linhas.linhas)
                {
                    List<string> row = new List<string>();
                    foreach (var valor in linha.item)
                    {
                        row.Add(valor);
                    }

                    ListViewItem item = new ListViewItem(row.ToArray());
                    listView.Items.Add(item);
                }

                SaveToJSON(listView, tabela);
            }
        }

        private void restaurarBackUp()
        {

            string[] tabelas = DBService.listTables();
            for (int i = 0; i < tabelas.Length; i++)
            {
                if (execao(tabelas[i]))
                {
                    MessageBox.Show(tabelas[i], "Restaurando tabela");
                    buscarArquivos(tabelas[i]);
                    MessageBox.Show(tabelas[i], "Concluido");
                }
            }
        }

        private bool execao(string nomeTablea)
        {
            switch (nomeTablea)
            {
                case "TB_CA_Dividas_div":
                    return false;
                case "TB_CA_ParcelaDividas_par":
                    return false;
                case "TB_CA_TipoDivida_tdv":
                    return false;
                default:
                    return true;
            }
        }

        private void buscarArquivos(string nomeTabela)
        {

            string BackUp = ConfigurationManager.AppSettings["BackUp"];
            string path = BackUp + nomeTabela + ".txt";
            string s = File.ReadAllText(path, System.Text.Encoding.Default);

            JObject json1 = JObject.Parse(s);


            var tabela = json1[nomeTabela];

            switch (nomeTabela)
            {
                case "TB_CA_Categorias_ctg":
                    CategoriaService categoriaService = new CategoriaService();
                    categoriaService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_Clientes_cli":
                    ClienteService clienteService = new ClienteService();
                    clienteService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_Condicao_con":
                    CondicaoService condicaoService = new CondicaoService();
                    condicaoService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_Dividas_div":
                    DividaService dividaService = new DividaService();
                    dividaService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_Empresas_emp":
                    UsuarioService usuarioService = new UsuarioService();
                    usuarioService.restoreBackEmpresa(nomeTabela, tabela);

                    break;
                case "TB_CA_Frete_frt":
                    FreteService freteService = new FreteService();
                    freteService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_ItensPedido_itp":
                    ItemPedidoService itemPedidoService = new ItemPedidoService();
                    itemPedidoService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_ParcelaDividas_par":
                    ParcelasDividaServices parcelasDividaServices = new ParcelasDividaServices();
                    parcelasDividaServices.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_Pedidos_ped":
                    PedidoService pedidoService = new PedidoService();
                    pedidoService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_Produtos_prd":
                    ProdutoService produtoService = new ProdutoService();
                    produtoService.restoreBackUp(nomeTabela, tabela);

                    break;
                case "TB_CA_TipoDivida_tdv":

                    break;
                case "TB_CA_Usuarios_usu":
                    UsuarioService usuarioService2 = new UsuarioService();
                    usuarioService2.restoreBackUpUsuario(nomeTabela, tabela);

                    break;
                default:
                    break;
            }

        }




        private void SaveToJSON(ListView listView, string nomeTabela, string query = "")
        {
            string json = "";
            string nomeArquivo = "";
            if (query != "")
            {
                json = "{'" + query + "': [";
                nomeArquivo = "query-" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'_'mm'_'ss");
            }
            else
            {
                json = "{'" + nomeTabela + "': [";
                nomeArquivo = nomeTabela;
            }

            List<string> colunas = new List<string>();
            foreach (ColumnHeader column in listView.Columns)
            {
                colunas.Add(column.Text);
            }

            int count = 0;
            foreach (ListViewItem item in listView.Items) //linha
            {

                string itens = "[";
                int countSub = 0;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems) //cada coluna da linha
                {
                    if (countSub == item.SubItems.Count - 1)
                    {

                        if (count == listView.Items.Count - 1)
                        {
                            itens += "{'" + colunas[countSub] + "' : '" + subItem.Text + "'}]";
                            json += itens;
                            json += "]}";

                        }
                        else
                        {
                            itens += "{'" + colunas[countSub] + "' : '" + subItem.Text + "'}],";
                            json += itens;
                        }
                    }
                    else
                    {
                        itens += "{'" + colunas[countSub] + "' : '" + subItem.Text + "'},";
                    }
                    countSub++;
                }
                count++;
            }
            gravarArquivo(json, nomeArquivo);
        }

        private void gravarArquivo(string texto, string nomeTabela)
        {
            string BackUp = ConfigurationManager.AppSettings["BackUp"];
            bool exists = Directory.Exists(BackUp);

            if (!exists)
            {
                Directory.CreateDirectory(BackUp);
            };

            string texoLimpo = texto.Replace("\r\n", "");
            using (StreamWriter writer = new StreamWriter(BackUp + nomeTabela + ".txt"))
            {
                try
                {
                    writer.AutoFlush = true;
                    //MessageBox.Show("using" + localPath + BackUp + nomeTabela + ".txt");
                    writer.WriteLine(texoLimpo);
                    writer.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("IOException:\r\n\r\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception:\r\n\r\n" + ex.Message);
                }

            }
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            if (lstDB.Items.Count == 0)
            {
                MessageBox.Show("O Resultado da consulta esta nula");
            }
            else
            {
                SaveToJSON(lstDB, cbTabelas.SelectedItem.ToString(), txtQuery.Text);

                MessageBox.Show("Comando Executado Com Sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cbTabelas.SelectedItem.ToString());
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string message = "Confirma o BackUp do Banco de Dados?";
            string caption = "EBackUp do Banco de Dados";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                fazerBackUp();
                MessageBox.Show("BackUp Executado Com Sucesso");
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            string message = "Confirma a Restauração do Banco de Dados?";
            string caption = "Restauração do Banco de Dados";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                restaurarBackUp();
                MessageBox.Show("BackUp Restaurado Com Sucesso");
            }
        }
    }
}
