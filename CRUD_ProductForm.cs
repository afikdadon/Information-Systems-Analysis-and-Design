using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_1
{
    public partial class CRUD_ProductForm : Form
    {
        public CRUD_ProductForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteProductForm udpf = new UpdateOrDeleteProductForm();
            udpf.Show();
            this.Hide();
        }

        private void updatePictureBox_Click(object sender, EventArgs e)
        {
        }

        public void viewPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void createPictureBox_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteProductForm udpf = new UpdateOrDeleteProductForm();
            udpf.Show();
            this.Hide();
        }

        private void productLabel_Click(object sender, EventArgs e)
        {

        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            skuCodeForProductForm skuf = new skuCodeForProductForm();
            skuf.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createProductForm cpf = new createProductForm();
            cpf.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AllFunctionForm lif = new AllFunctionForm();
            lif.Show();
            this.Hide();
        }

        private void CRUD_ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
