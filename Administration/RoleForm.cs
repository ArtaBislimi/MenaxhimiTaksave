using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiTaksit.App_Code;
using MenaxhimiTaksit.BLL;
using MenaxhimiTaksit.BO;

namespace MenaxhimiTaksit.Administration
{
    public partial class RoleForm : Form
    {
        private readonly RoleBLL roleBll;
        public RoleForm()
        {
            InitializeComponent();
            roleBll = new RoleBLL();
        }

        
       
        private void RoleForm_Load(object sender, EventArgs e)
        {
            this.Text += " - " + UserSession.LoggedUser.Username;
            InitData();
        }

        private void InitData()
        {
            var result = roleBll.GetAll();
            grvDataShow.DataSource = result;
        }


        private void ResetForm()
        {
            txtID.Text = txtRoleName.Text = "";
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Ju lutem plotesoni ID");
                txtID.Focus();
            }

            if (txtID.Text.Trim() != " ")
            {   
                Role role = new Role();
                role.ID = txtID.Text;
                role.Name = txtRoleName.Text;
                role.InsertBy = 100;
                role.InsertDate = DateTime.Now;
                
                int reg = roleBll.Add(role);
                ResetForm();

                if (reg >= 1)
                {
                    InitData();
                    ResetForm();
                }
                else if (reg <= 0)
                {
                    MessageBox.Show("Ju lutem kontrolloni rolin se a ekziston!");
                }

            }

        


            //private void btnReset_Click(object sender, EventArgs e)
            //{
            //    if (txtName.Text.Trim() != "" || txtID.Text!="")
            //    {
            //        if (MessageBox.Show("A jeni i sigurt", "Vemendje", MessageBoxButtons.OKCancel)
            //            == DialogResult.OK)
            //        {
            //            ResetForm();
            //        }
            //    }

            //}

            //private void groupBox1_Enter(object sender, EventArgs e)
            //{

            //}
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "" || txtRoleName.Text != ""  )
            {
                if (MessageBox.Show("A jeni i sigurt per reset !", "Vemendje", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    ResetForm();
                }
            }
        }
    }
}
