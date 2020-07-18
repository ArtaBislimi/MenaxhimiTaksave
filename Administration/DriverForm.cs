using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiTaksit.BLL;

namespace MenaxhimiTaksit.Administration
{
    public partial class DriverForm : Form
    {
        DriverBLL driverBLL;
       
        public DriverForm()
        {
            InitializeComponent();
            driverBLL = new DriverBLL();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnSave_Click(object sender, EventArgs e)
        {

            resetForm();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            if (txtDriverID.Text.Trim() != "" || txtName.Text != "" || txtUserID.Text != ""||txtLastName.Text!="")
            {
                if (MessageBox.Show("A jeni i sigurt per reset !", "Vemendje", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    resetForm();
                }
            }
           
        }
    
        private void resetForm()
        {

            txtDriverID.Text = txtAdress.Text = txtMobileNo.Text = txtLastName.Text = txtName.Text = txtUserID.Text =  "";
        }
        private void InitData()
        {
            var result = driverBLL.GetAll();
            rgvDataShow.DataSource = result;
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
