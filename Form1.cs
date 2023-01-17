using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace eseguiquerysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //creazione lista
            List<ClassQuery> query = new List<ClassQuery>();
            string titolo = "";
            string sql = "";
            int c = 0;

            /*comboBox.DataSource = query;
            comboBox.DisplayMember = "Titolo";
            comboBox.ValueMember = "Contenuto";*/

            String line;
            //Passa il file allo StreamReader
            StreamReader sr = new StreamReader("C:\\query.txt");
            //Legge la prima riga del testo
            line = sr.ReadLine();
            
            //Continua a leggere fino alla fine delle righe
            while (line != null)
            {
                
                if (line.StartsWith("#"))
                {
                    //comboBox.Items.Add(line.Remove(0, 1));
                    //titolo della query
                    titolo = line;
                    c = c + 1;
                }
                else
                {
                    //contenuto della query
                    sql = line;
                    comboBox.Items.Add(line);
                    c = c + 1;
                }
                if (c % 2 == 0)
                {
                    query.Add(new ClassQuery(titolo, sql));
                }

                //Legge la prossima riga
                line = sr.ReadLine();
            }
            //chiude il file
                
             sr.Close();
             Console.ReadLine();
        }

        private void btnApriFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();

            Db.InitialDirectory = Application.StartupPath;
            Db.Filter = "sqlite files (*.db)|*.db|Mdb files (*.mdb|xls files8*.xls";
            Db.FilterIndex = 1;
            Db.RestoreDirectory = true;

            DialogResult result = Db.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile.Text = Db.FileName;
            }

        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data source=" + txtFile.Text + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = txtQuery.Text;
            
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvSql.DataSource = dtDati;
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtQuery.Text = comboBox.SelectedValue;
            txtQuery.Text = comboBox.Text;                                  
        }
    }
}
