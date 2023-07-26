using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAdoNetDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // veri tabanı sorgularını çekeceğimiz class'ın bir nesnesini global olarak oluşturalım.
        DailyDal _dailyDal = new DailyDal();

        //listeleme
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwDaily.DataSource = _dailyDal.Select();
        }

        private void dgwDaily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDateUpdate.Text = dgwDaily.CurrentRow.Cells[1].Value.ToString();
            tbxNameUpdate.Text = dgwDaily.CurrentRow.Cells[2].Value.ToString();
            tbxContextUpdate.Text = dgwDaily.CurrentRow.Cells[3].Value.ToString();
        }

        // ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxDateAdd.Text = DateTime.Now.ToString();

            _dailyDal.Add(new Daily
            {
                Date = Convert.ToDateTime(tbxDateAdd.Text), 
                Name = tbxNameAdd.Text.ToString(),
                Context = tbxContextAdd.Text.ToString(),
            });

            MessageBox.Show("ADDED");
            dgwDaily.DataSource = _dailyDal.Select();
        }

        // silme
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwDaily.CurrentRow.Cells[0].Value);
            _dailyDal.Delete(id);
            MessageBox.Show("DELETED");
            dgwDaily.DataSource = _dailyDal.Select();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _dailyDal.Update(new Daily
            {
                Id = Convert.ToInt32(dgwDaily.CurrentRow.Cells[0].Value),
                Date = Convert.ToDateTime(tbxDateUpdate.Text),
                Name = tbxNameUpdate.Text.ToString(),
                Context = tbxContextUpdate.Text.ToString(),
            });

            MessageBox.Show("UPDATED");
            dgwDaily.DataSource= _dailyDal.Select();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void SearchProducts(string key)
        {
            var result = _dailyDal.GetByName(key).Where(p=> p.Name.Contains(key)).ToList();
            dgwDaily.DataSource = result;
        }
    }
}
