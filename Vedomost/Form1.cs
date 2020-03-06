using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedomost
{
    public partial class Form1 : Form
    {
        DataTable datatable = new DataTable();
        public Form1()
        {
            //connect to gidroingeo.accdb
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
            //end of connect to gidroingeo.accdb
            InitializeComponent();

            datatable = DB.db.Query("select * from Students");
            dgvMain.DataSource = datatable;
            dgvMain.Columns[0].Visible = false;
            for(int i = 0; i < dgvMain.ColumnCount; i++)
            {
                dgvMain.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void новыйСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Student newStudent = new New_Student();
            newStudent.ShowDialog();
            if (newStudent.DialogResult == DialogResult.OK)
            {
                string sql = $"INSERT INTO Students (Имя, Фамилия, Отчества, Оценка, Курс, Факультет, Направление, Рост,Дата_рождения, Телефон)" +
                    $" VALUES('{newStudent.Imya}', '{newStudent.Famil}','{newStudent.Otches}'," +
                    $"'{newStudent.Otsenka.ToString()}', '{newStudent.Kurs.ToString()}','{newStudent.Fakul}'," +
                    $"'{newStudent.Naprav}','{newStudent.Rost.ToString()}','{newStudent.DataRoj}', '{newStudent.Tel}')";
                datatable = DB.db.Query(sql);
                datatable = DB.db.Query("select * from Students");
                dgvMain.DataSource = datatable;
            }
        }

        private void поОценкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns[1],ListSortDirection.Descending);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                datatable = DB.db.Query($"delete * from Students where Код={dgvMain.CurrentRow.Cells[0].Value.ToString()}");
                datatable = DB.db.Query($"delete * from Ranks where Код={dgvMain.CurrentRow.Cells[0].Value.ToString()}");
                datatable = DB.db.Query("select * from Students");
                dgvMain.DataSource = datatable;
            }
        }

        int textLength = 0;
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
             if(textLength > txtSearch.Text.Length)
            {
                datatable = DB.db.Query("select * from Students");
                dgvMain.DataSource = datatable;
            }
            for (int i = 0; i < dgvMain.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMain.Columns.Count; j++)
                {
                    if (!dgvMain.Rows[i].Cells[j].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        if (j == 10)
                        {
                            dgvMain.Rows.Remove(dgvMain.Rows[i]);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            textLength = txtSearch.Text.Length;
        }
        

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns[4], ListSortDirection.Ascending);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns[4], ListSortDirection.Descending);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns[4], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns[4], ListSortDirection.Ascending);
        }

        private void поФамилиюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvMain.Sort(dgvMain.Columns[4], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            New_Student newStudent = new New_Student(dgvMain.CurrentRow);
            newStudent.ShowDialog();
            if (newStudent.DialogResult == DialogResult.OK)
            {
                string sql = $"UPDATE Students SET Имя='{newStudent.Imya}', Фамилия='{newStudent.Famil}'," +
                    $" Отчества='{newStudent.Otches}', Оценка='{newStudent.Otsenka.ToString()}', " +
                    $" Курс='{newStudent.Kurs.ToString()}', Факультет='{newStudent.Fakul}'," +
                    $" Направление='{newStudent.Naprav}', Рост='{newStudent.Rost.ToString()}'," +
                    $" Дата_рождения='{newStudent.DataRoj}',Телефон='{newStudent.Tel}'" +
                    $" WHERE Код={dgvMain.CurrentRow.Cells[0].Value.ToString()}";
                datatable = DB.db.Query(sql);
                datatable = DB.db.Query("select * from Students");
                dgvMain.DataSource = datatable;
            }
        }

        private void выводитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankForm rankform = new RankForm(dgvMain.CurrentRow);
            rankform.ShowDialog();

            datatable = DB.db.Query("select * from Students");
            dgvMain.DataSource = datatable;
        }

        private void выводитьГруппыИОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datatable = DB.db.Query($"SELECT * FROM Students WHERE Курс={dgvMain.CurrentRow.Cells[5].Value.ToString()} " +
                $"AND Направление='{dgvMain.CurrentRow.Cells[7].Value.ToString()}'");
            GroupForm groupForm = new GroupForm(datatable);
            groupForm.ShowDialog();
        }
    }
}
