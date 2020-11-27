using descktop.Data;
using descktop.Services;
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
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.ListView;

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

        private void btnBck_Click(object sender, EventArgs e)
        {
            SaveToXml();

            MessageBox.Show("Comando Executado Com Sucesso");

        }

        private void SaveToXml()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(ListViewItemCollection));

            //using (FileStream stream = File.OpenWrite(myXmlFilePath))
            //{
            //    serializer.Serialize(stream, lstDB.Items);
            //}

            XElement xeRoot = new XElement(cbTabelas.SelectedItem.ToString());
            foreach (ListViewItem item in lstDB.Items)
            {
                //foreach (var item in linha)
                //{
                    XElement xeRow = new XElement("Nó");
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        XElement xeCol = new XElement("teste" + subItem.Text);
                        xeRow.Add(xeCol);
                        // To add attributes use XAttributes
                    }
                    xeRoot.Add(xeRow);

                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cbTabelas.SelectedItem.ToString());
        }
    }
}
