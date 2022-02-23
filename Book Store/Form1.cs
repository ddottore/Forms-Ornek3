using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager();
        Book book = new Book();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            book.bookName = tbxName.Text;
            book.bookPage = Convert.ToInt32(tbxPage.Text);
            book.bookPrice = Convert.ToInt32(tbxPrice.Text);
            book.bookStatus = tbxStatus.Text;
            book.bookType = tbxType.Text;
            customerManager.Add(book);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            customerManager.Remove(book);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customerManager.GetAll();
        }
    }
}
