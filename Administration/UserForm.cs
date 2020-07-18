using MenaxhimiTaksit.BLL;
using MenaxhimiTaksit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiTaksit.Administration
{
    public partial class User_Form : Form
    {
        UserBLL userBLL;
       
        public User_Form()
        {
            InitializeComponent();
           userBLL= new UserBLL();
          
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //buttoni save
        private void radButton4_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim() == "")
            {
                MessageBox.Show("Ju lutem plotesoni ID");
                txtUserId.Focus();
            }

            if (txtUserId.Text.Trim() != "")
            {
                User user = new User();
                user.ID = txtUserId.Text;
                user.Username = txtUserName.Text;
                if(txtPassword.Text== txtRetypePasword.Text)
                {
                    user.Password = txtPassword.Text;
                }
                else
                {
                    MessageBox.Show("Shkruani perseri Passwordin njesoj!","Korigjim",MessageBoxButtons.OK);
                }
                user.ExpiresDate =new  DateTime(2021,02,02);
                user.InsertBy =100;
                user.InsertDate = DateTime.Now;

                int reg = userBLL.Add(user);
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
        }
        private void ResetForm()
        {
            txtUserId.Text = txtUserName.Text = txtPassword.Text = txtRetypePasword.Text = txtRoleID.Text= "";
        }
        private void InitData()
        {
            var result = userBLL.GetAll();
            grvDataShow.DataSource = result;
        }
        #region
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            //int index =SelectedRow;
            //if (index < 0) return;
            //User user = (User)dgv_DataShow.Rows[index].DataBoundItem;
            //user = GetRoleFromDataGrid(index);
            //if (user != null)
            //{
            //    int isDeleted = userBLL.Remove(user.ID);
            //    if (isDeleted == 1)
            //    {
            //        MessageBox.Show($"{user.Username} - User-i eshte fshier me sukses!");
            //        InitData();
            //        ResetForm();
            //    }
            //}


        }
        //private User GetRoleFromDataGrid(int index)
        //{
        //    if (index < 0) return null;
        //    return (User)grvDataShow.Rows[index].DataBoundItem;
        //}

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            //User user = new User();
            //user.ID = txtUserId.Text;
            //user.Username = txtUserName.Text;
            //user.Password = txtPassword.Text;
            //user.ExpiresDate = new DateTime(2021, 02, 02);
            ////user.InsertDate =(DateTime) dtp_InsertDate.Value;
            //user.RoleID = 100;
            //user.InsertBy = 100;
            //user.LastUpdateBy ="100A";
            //user.LastUpdateDate = new DateTime(2021, 02, 02);
            //user.LastUpdateNo = +1;

            //int reg = userBLL.Modify(user);

            //if (reg >= 1)
            //{
            //    InitData();
            //    ResetForm();
            //}
            //else if (reg <= 0)
            //{
            //    MessageBox.Show("Update nuk eshte kryer!");
            //}
        }
        #endregion
        //Reset Form button event
        private void radButton1_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim() != "" || txtUserName.Text != "" || txtPassword.Text != "")
            {
                if (MessageBox.Show("A jeni i sigurt per reset !", "Vemendje", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    ResetForm();
                }
            }
        }

        private void bttnShow_Click(object sender, EventArgs e)
        {
          
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            InitData();
        }

        #region
        private void grvDataShow_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //SelectedRow = e.RowIndex;
            //if (SelectedRow < 0) return;
            //User user = new User();
            //user.ID = grvDataShow.Rows[SelectedRow].Cells[0].Value.ToString();
        }
        #endregion

        //Show grid of data.

    }
}
