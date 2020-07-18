namespace MenaxhimiTaksit.Administration
{
    partial class RoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleForm));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnSave = new Telerik.WinControls.UI.RadButton();
            this.bttnReset = new Telerik.WinControls.UI.RadButton();
            this.grvDataShow = new Telerik.WinControls.UI.RadGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRoleManagement = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow.MasterTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bttnSave);
            this.panel1.Controls.Add(this.bttnReset);
            this.panel1.Controls.Add(this.grvDataShow);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtRoleName);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // bttnSave
            // 
            resources.ApplyResources(this.bttnSave, "bttnSave");
            this.bttnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.ThemeName = "FluentDark";
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnReset
            // 
            resources.ApplyResources(this.bttnReset, "bttnReset");
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.ThemeName = "EvalFormTheme";
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // grvDataShow
            // 
            resources.ApplyResources(this.grvDataShow, "grvDataShow");
            // 
            // 
            // 
            this.grvDataShow.MasterTemplate.AllowAddNewRow = false;
            this.grvDataShow.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grvDataShow.Name = "grvDataShow";
            this.grvDataShow.ThemeName = "FluentDark";
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
            // txtID
            // 
            this.txtID.AcceptsReturn = true;
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.ForeColor = System.Drawing.Color.LightGray;
            this.txtID.Name = "txtID";
            // 
            // txtRoleName
            // 
            this.txtRoleName.BackColor = System.Drawing.Color.Black;
            this.txtRoleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRoleName, "txtRoleName");
            this.txtRoleName.ForeColor = System.Drawing.Color.White;
            this.txtRoleName.Name = "txtRoleName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblRoleManagement);
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
            // lblRoleManagement
            // 
            resources.ApplyResources(this.lblRoleManagement, "lblRoleManagement");
            this.lblRoleManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleManagement.ForeColor = System.Drawing.Color.White;
            this.lblRoleManagement.Name = "lblRoleManagement";
            // 
            // RoleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRoleManagement;
        private Telerik.WinControls.UI.RadButton bttnSave;
        private Telerik.WinControls.UI.RadButton bttnReset;
        private Telerik.WinControls.UI.RadGridView grvDataShow;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}