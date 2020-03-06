using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vedomost
{
    public partial class RankForm : Form
    {
        DataGridViewRow dgvRow;
        DataTable datatable = new DataTable();
        int[] Otsenki = new int[3] { 55, 71, 86 };
        int Otsenka = 0;

        public RankForm()
        {
            InitializeComponent();
        }

        public RankForm(DataGridViewRow dgvRow)
        {
            try
            {
                DB.db = new Data();
                DB.db.Data_init(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza.accdb;Persist Security Info=False;");
                DB.db.Connect();
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                MessageBox.Show(exp.ToString());
            }

            InitializeComponent();
            this.dgvRow = dgvRow;
            datatable = DB.db.Query("select * from Ranks");
            for(int i = 0; i < datatable.Rows.Count; i++)
            {
                if (datatable.Rows[i].ItemArray[0].ToString() == dgvRow.Cells[0].Value.ToString())
                {
                    txtEng.Text = datatable.Rows[i].ItemArray[1].ToString();
                    txtMat.Text = datatable.Rows[i].ItemArray[2].ToString();
                    txtPhy.Text = datatable.Rows[i].ItemArray[3].ToString();
                    txtProg.Text = datatable.Rows[i].ItemArray[4].ToString();
                    txtChe.Text = datatable.Rows[i].ItemArray[5].ToString();
                    txtHis.Text = datatable.Rows[i].ItemArray[6].ToString();
                    txtGeo.Text = datatable.Rows[i].ItemArray[7].ToString();
                    txtBio.Text = datatable.Rows[i].ItemArray[8].ToString();
                    txtEko.Text = datatable.Rows[i].ItemArray[9].ToString();
                    txtEng.Enabled = txtMat.Enabled= txtPhy.Enabled= txtProg.Enabled = txtChe.Enabled 
                        = txtHis.Enabled = txtGeo.Enabled = txtBio.Enabled = txtEko.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
        }

        private void FillList()
        {
            listBox1.Items.Add($"Дата: {DateTime.UtcNow}");
            listBox1.Items.Add("");
            listBox1.Items.Add($"{"Код студента:".PadRight(40, ' ')} \t {dgvRow.Cells[0].Value.ToString()}");
            listBox1.Items.Add($"{"Имя студента:".PadRight(40, ' ')} \t {dgvRow.Cells[1].Value.ToString()} {dgvRow.Cells[2].Value.ToString()}");
            listBox1.Items.Add("\r\n");
            listBox1.Items.Add($"{"Английский:".PadRight(40, ' ')} \t{txtEng.Text}");
            listBox1.Items.Add($"{"Математика:".PadRight(40, ' ')} \t{txtMat.Text}");
            listBox1.Items.Add($"{"Физика:".PadRight(40, ' ')} \t{txtPhy.Text}");
            listBox1.Items.Add($"{"Программирование:".PadRight(40, ' ')} \t{txtProg.Text}");
            listBox1.Items.Add($"{"Химия:".PadRight(40, ' ')}    \t{txtChe.Text}");
            listBox1.Items.Add($"{"История:".PadRight(40, ' ')} \t{txtHis.Text}");
            listBox1.Items.Add($"{"География:".PadRight(40, ' ')} \t{txtGeo.Text}");
            listBox1.Items.Add($"{"Биология:".PadRight(40, ' ')} \t{txtBio.Text}");
            listBox1.Items.Add($"{"Экономика:".PadRight(40, ' ')} \t{txtEko.Text}");
            listBox1.Items.Add("\r\n");
            for(int i = 0; i < 3; i++)
            {
                if (Convert.ToInt32(txtBio.Text) < Otsenki[i] ||
                    Convert.ToInt32(txtChe.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtEko.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtEng.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtGeo.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtHis.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtMat.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtPhy.Text) < Otsenki[i] ||
                   Convert.ToInt32(txtProg.Text) < Otsenki[i])
                {
                    switch (i)
                    {
                        case 0: Otsenka = 2; break;
                        case 1: Otsenka = 3; break;
                        case 2: Otsenka = 4; break;
                    }
                    break;
                }
                else
                {
                    if (i == 2)
                    {
                        Otsenka = 5;
                    }
                }
            }
            listBox1.Items.Add($"{"Общая оценка:".PadRight(40, ' ')} \t {Otsenka}");
            listBox1.Items.Add("\r\n");
            listBox1.Items.Add($"Подпис декана: _______________");

            datatable = DB.db.Query($"UPDATE Students SET Оценка={Otsenka} WHERE Код={dgvRow.Cells[0].Value.ToString()}");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtBio.Text != "" && txtChe.Text != "" && txtEko.Text != "" && txtEng.Text != "" && txtGeo.Text != ""
                && txtHis.Text != "" && txtMat.Text != "" && txtPhy.Text != "" && txtProg.Text != "")
            {
                FillList();
                btnExport.Enabled = true;
                btnShow.Enabled = false;
            }
            else
            {
                MessageBox.Show("Переполните оценки!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            datatable = DB.db.Query($"INSERT INTO Ranks" +
                    $" VALUES('{dgvRow.Cells[0].Value.ToString()}','{txtEng.Text}', '{txtMat.Text}'," +
                    $"'{txtPhy.Text}','{txtProg.Text}','{txtChe.Text}'," +
                    $"'{txtHis.Text}','{txtGeo.Text}','{txtBio.Text}', '{txtEko.Text}')");
            MessageBox.Show("Оценки добавлено!");
            btnSave.Enabled = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fpath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Оценка_{dgvRow.Cells[0].Value.ToString()}.doc";
            File.WriteAllText(fpath,"");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                File.AppendAllText(fpath, listBox1.Items[i].ToString()+'\n',Encoding.Default);
            }
            MessageBox.Show( "Данные сохранено в рабочий столь!","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
