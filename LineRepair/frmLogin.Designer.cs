namespace BMS
{
    partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboUser = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			resources.ApplyResources(this.btnLogin, "btnLogin");
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// txtPass
			// 
			resources.ApplyResources(this.txtPass, "txtPass");
			this.txtPass.Name = "txtPass";
			this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// cboUser
			// 
			resources.ApplyResources(this.cboUser, "cboUser");
			this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboUser.FormattingEnabled = true;
			this.cboUser.Items.AddRange(new object[] {
            resources.GetString("cboUser.Items")});
			this.cboUser.Name = "cboUser";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// frmLogin
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cboUser);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmLogin";
			this.Load += new System.EventHandler(this.frmCheckPass_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label2;
    }
}