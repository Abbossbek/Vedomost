using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vedomost
{
    public partial class GroupForm : Form
    {
        DataTable datatable, tableRanks;

        public GroupForm(DataTable datatable)
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
            this.datatable = datatable;
            tableRanks = DB.db.Query("select * from Ranks");

            comboBox2.SelectedIndex = 0;
        }

        private void FillList()
        {
            listBox1.Items.Add($"Дата: {DateTime.UtcNow}");
            listBox1.Items.Add("");
            listBox1.Items.Add($"{"Курс группы:".PadRight(40, ' ')} \t {datatable.Rows[0].ItemArray[5].ToString()}");
            listBox1.Items.Add($"{"Факультет группы:".PadRight(40, ' ')} \t {datatable.Rows[0].ItemArray[6].ToString()}");
            listBox1.Items.Add($"{"Направление группы:".PadRight(40, ' ')} \t {datatable.Rows[0].ItemArray[7].ToString()}");
            listBox1.Items.Add($"{"Предмет:".PadRight(40, ' ')} \t {comboBox1.SelectedItem.ToString()}");
            listBox1.Items.Add("\r\n");
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                int rank = 0;
                for (int j = 0; j < tableRanks.Rows.Count; j++)
                {
                    if ((int)datatable.Rows[i].ItemArray[0] == (int)tableRanks.Rows[j].ItemArray[0])
                    {
                        rank = (int)tableRanks.Rows[j].ItemArray[comboBox1.SelectedIndex + 1];
                    }
                }
                if (comboBox2.SelectedIndex != 0)
                {
                    if (comboBox2.SelectedIndex == 1 && rank < 55 ||
                        comboBox2.SelectedIndex == 2 && rank >= 55 && rank < 71 ||
                        comboBox2.SelectedIndex == 3 && rank >= 71 && rank < 86 ||
                        comboBox2.SelectedIndex == 4 && rank >= 86)
                    {
                        listBox1.Items.Add($"{(datatable.Rows[i].ItemArray[1].ToString() + " " + datatable.Rows[i].ItemArray[2].ToString()).PadRight(40, ' ')} \t {rank}");
                    }
                }
                else
                {
                    listBox1.Items.Add($"{(datatable.Rows[i].ItemArray[1].ToString() + " " + datatable.Rows[i].ItemArray[2].ToString()).PadRight(40, ' ')} \t {rank}");
                }
            }
            listBox1.Items.Add("\r\n");
            listBox1.Items.Add($"Подпис декана: _______________");
        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            string fpath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Оценка_{datatable.Rows[0].ItemArray[5].ToString()}_" +
                $"{datatable.Rows[0].ItemArray[7].ToString()}.doc";
            File.WriteAllText(fpath, "");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                File.AppendAllText(fpath, listBox1.Items[i].ToString() + '\n', Encoding.Default);
            }
            MessageBox.Show("Данные сохранено в рабочий столь!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex != -1)
            {
                FillList();
                btnExport.Enabled = true;
            }
        }
    }
}