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
using MenaxhimiTaksit.BO;

namespace MenaxhimiTaksit.Administration
{
    public partial class CarForm : Form
    {
       private CarBLL carBll;
        public CarForm()
        {
            InitializeComponent();
            carBll = new CarBLL();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      //  grvDataShow
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (txtCarID.Text.Trim() == "")
            {
                MessageBox.Show("Ju lutem plotesoni ID");
                txtCarID.Focus();
            }

            if (txtCarID.Text.Trim() != "")
            {
                Car car = new Car();
                car.Car_ID = int.Parse(txtCarID.Text);
                car.Registration = txtRegistration.Text;
                car.Firm = txtFirm.Text;
                car.Yearofmanufacture = new DateTime(1018,02,03);
                car.Power = int.Parse(txtPower.Text);
                car.Status = bool.Parse(txtStatus.Text);
                car.InsertBy = 100;
                car.InsertDate = DateTime.Now;

                int reg = carBll.Add(car);
                ResetForm();
                if (reg >= 1)
                {
                    InitData();
                    ResetForm();
                }
                else if (reg <= 0)
                {
                    MessageBox.Show("Ju lutem kontrolloni Automjeti se a ekziston!");
                }
            }

        }

        private void ResetForm()
        {
            txtCarID.Text = txtFirm.Text = txtPower.Text = txtRegistration.Text = txtStatus.Text = txtYearOfManufacture.Text = "";
        }

        private void InitData()
        {
            var result = carBll.GetAll();
            grvDataShow.DataSource = result;
        }
    }
}
