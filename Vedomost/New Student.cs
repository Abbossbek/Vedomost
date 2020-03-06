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
    public partial class New_Student : Form
    {
        public string Imya { get; private set; }
        public string Famil { get; private set; }
        public string Otches { get; private set; }
        public string DataRoj { get; private set; }
        public int Otsenka { get; private set; }
        public int Rost { get; private set; }
        public int Kurs { get; private set; }
        public string Fakul { get; private set; }
        public string Naprav { get; private set; }
        public string Tel { get; private set; }

        public New_Student()
        {
            InitializeComponent();
        }

        public New_Student(DataGridViewRow dgvRow)
        {
            InitializeComponent();
            txtImya.Text = dgvRow.Cells[1].Value.ToString();
            txtFamil.Text= dgvRow.Cells[2].Value.ToString();
            txtOtches.Text= dgvRow.Cells[3].Value.ToString();
            cmbOtsenka.Text= dgvRow.Cells[4].Value.ToString();
            cmbKurs.Text= dgvRow.Cells[5].Value.ToString();
            cmbFakul.Text= dgvRow.Cells[6].Value.ToString();
            cmbNaprav.Text= dgvRow.Cells[7].Value.ToString();
            txtRost.Text= dgvRow.Cells[8].Value.ToString();
            dtpDataRoj.Text= dgvRow.Cells[9].Value.ToString();
            txtTel.Text= dgvRow.Cells[10].Value.ToString();
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Imya = txtImya.Text;
                Famil = txtFamil.Text;
                Otches = txtOtches.Text;
                DataRoj = dtpDataRoj.Text.Substring(dtpDataRoj.Text.LastIndexOf('.') + 1) +
                    dtpDataRoj.Text.Substring(dtpDataRoj.Text.IndexOf('.'), 4) +
                    dtpDataRoj.Text.Substring(0, dtpDataRoj.Text.IndexOf('.'));
                Otsenka = Convert.ToInt32(cmbOtsenka.SelectedItem.ToString());
                Rost = Convert.ToInt32(txtRost.Text);
                Kurs = Convert.ToInt32(cmbKurs.SelectedItem.ToString());
                Fakul = cmbFakul.Text;
                Naprav = cmbNaprav.SelectedItem.ToString();
                Convert.ToUInt64(txtTel.Text);
                Tel = txtTel.Text;
            }
            catch
            {
                MessageBox.Show("Неверный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
        
        

        private void cmbFakul_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNaprav.Items.Clear();
            switch (cmbFakul.SelectedIndex)
            {
                case 0:
                    cmbNaprav.Items.AddRange(new string[6] { "ИИТ", "ПМИ", "Математика", "Механика", "Информационная Безопасность", "МПОИ" });
                    break;
            }
        }
    }
}
