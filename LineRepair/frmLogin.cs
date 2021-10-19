using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmLogin : Form
	{
		public bool ResultCheck = false;
		string rootCode = Application.StartupPath + "\\axb.txt";
		string passWord = "";
		public frmLogin()
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
			InitializeComponent();
			passWord = File.ReadAllText(rootCode).Trim();
		}
		private void frmCheckPass_Load(object sender, EventArgs e)
		{
			cboUser.SelectedIndex = 0;
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			if (cboUser.SelectedIndex == 0)
			{
				if (txtPass.Text.Trim() != passWord.Trim())
				{
					MessageBox.Show("Password không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Lib.UserLogin = 1;
			}
			else
			{
				Lib.UserLogin = 0;
			}

			this.DialogResult = DialogResult.OK;
		}

		private void txtCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnCheck_Click(null, null);
			}
		}


	}
}
