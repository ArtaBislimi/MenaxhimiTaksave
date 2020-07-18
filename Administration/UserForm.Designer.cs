namespace MenaxhimiTaksit.Administration
{
    partial class User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvDataShow = new Telerik.WinControls.UI.RadGridView();
            this.dgv_DataShow = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRetypePasword = new System.Windows.Forms.TextBox();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataShow.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.grvDataShow);
            this.panel1.Controls.Add(this.dgv_DataShow);
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRoleID);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtRetypePasword);
            this.panel1.Controls.Add(this.radButton4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grvDataShow
            // 
            this.grvDataShow.AutoGenerateHierarchy = true;
            resources.ApplyResources(this.grvDataShow, "grvDataShow");
            // 
            // 
            // 
            this.grvDataShow.MasterTemplate.AllowAddNewRow = false;
            this.grvDataShow.MasterTemplate.EnableFiltering = true;
            this.grvDataShow.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.grvDataShow.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grvDataShow.Name = "grvDataShow";
            this.grvDataShow.SynchronizeCurrentRowInSplitMode = true;
            this.grvDataShow.ThemeName = "FluentDark";
            this.grvDataShow.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grvDataShow_CellDoubleClick);
            // 
            // dgv_DataShow
            // 
            resources.ApplyResources(this.dgv_DataShow, "dgv_DataShow");
            // 
            // 
            // 
            this.dgv_DataShow.MasterTemplate.AllowAddNewRow = false;
            this.dgv_DataShow.MasterTemplate.AllowColumnReorder = false;
            this.dgv_DataShow.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgv_DataShow.Name = "dgv_DataShow";
            this.dgv_DataShow.ReadOnly = true;
            this.dgv_DataShow.ThemeName = "ControlDefault";
            // 
            // radButton1
            // 
            resources.ApplyResources(this.radButton1, "radButton1");
            this.radButton1.Name = "radButton1";
            this.radButton1.ThemeName = "EvalFormTheme";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Name = "label3";
            // 
            // txtRoleID
            // 
            this.txtRoleID.AcceptsReturn = true;
            this.txtRoleID.BackColor = System.Drawing.Color.Black;
            this.txtRoleID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRoleID, "txtRoleID");
            this.txtRoleID.ForeColor = System.Drawing.Color.LightGray;
            this.txtRoleID.Name = "txtRoleID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Name = "label2";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtPassword.Name = "txtPassword";
            // 
            // txtRetypePasword
            // 
            this.txtRetypePasword.BackColor = System.Drawing.Color.Black;
            this.txtRetypePasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRetypePasword, "txtRetypePasword");
            this.txtRetypePasword.ForeColor = System.Drawing.Color.White;
            this.txtRetypePasword.Name = "txtRetypePasword";
            // 
            // radButton4
            // 
            resources.ApplyResources(this.radButton4, "radButton4");
            this.radButton4.BackColor = System.Drawing.Color.DarkGreen;
            this.radButton4.ForeColor = System.Drawing.Color.White;
            this.radButton4.Name = "radButton4";
            this.radButton4.ThemeName = "FluentDark";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Name = "label7";
            // 
            // txtUserId
            // 
            this.txtUserId.AcceptsReturn = true;
            this.txtUserId.BackColor = System.Drawing.Color.Black;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtUserId, "txtUserId");
            this.txtUserId.ForeColor = System.Drawing.Color.LightGray;
            this.txtUserId.Name = "txtUserId";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Black;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Name = "txtUserName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblUserManagement);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUserManagement
            // 
            resources.ApplyResources(this.lblUserManagement, "lblUserManagement");
            this.lblUserManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblUserManagement.ForeColor = System.Drawing.Color.White;
            this.lblUserManagement.Name = "lblUserManagement";
            // 
            // User_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "User_Form";
            this.Load += new System.EventHandler(this.User_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataShow.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserManagement;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRetypePasword;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadGridView dgv_DataShow;
        private Telerik.WinControls.UI.RadGridView grvDataShow;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}