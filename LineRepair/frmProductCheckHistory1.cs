using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmProductCheckHistory1 : Form
	{
		private List<RadioButton> LstPart;
		private List<ucImage> LstUcPatternImage;
		private List<ucImage> LstUcCurrentImage;
		private DataTable DtPart;
		private DataTable DtError;
		bool lockEvents = false;
		private string Qrcode;
		public static string QRCode;
		public frmProductCheckHistory1()
		{
			InitializeComponent();
		}
		private void frmProductCheckHistory1_Load(object sender, EventArgs e)
		{
			loadPart();
			txtWorker.Focus();
			cboWorkingStep.SelectedIndex = 0;
		}
		/// <summary>
		/// 1. Khởi tạo các biến toàn cục
		/// 2. Load các bộ phận của sản phẩm
		/// 3. Load Uc control của ảnh mẫu
		/// 4. Vẽ Lưới
		/// 5. Quy tắc đặt tên RadioButton = rd+Part+PartID
		/// </summary>
		private void loadPart()
		{
			Lib.BeginControlUpdate(tblPart);
			//Khởi tạo các biến toàn cục
			int numberColumn = 0;
			LstPart = new List<RadioButton>();
			LstUcPatternImage = new List<ucImage>();
			LstUcCurrentImage = new List<ucImage>();
			DocUtils.InitFTPQLSX();

			//Clear Bảng chứa các radion Button
			tblPart.RowStyles.Clear();
			tblPart.ColumnStyles.Clear();
			tblPart.Controls.Clear();

			//Load danh sách bộ phận và danh sách lỗi
			DtPart = TextUtils.Select("Select * from Part");
			DtError = TextUtils.Select("Select * from Error");
			//Tính toán chia cột
			if (DtPart.Rows.Count == 0) return;
			if (DtPart.Rows.Count % 2 == 0) numberColumn = DtPart.Rows.Count / 2; else numberColumn = DtPart.Rows.Count / 2 + 1;
			tblPart.ColumnCount = numberColumn;
			for (int i = 0; i < 2; i++) tblPart.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			for (int i = 0; i < numberColumn; i++) tblPart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			for (int i = 0; i < DtPart.Rows.Count; i++)
			{
				RadioButton rd = new RadioButton();
				rd.CheckedChanged += Rd_CheckedChanged;
				rd.Name = "rd" + Lib.ToString(DtPart.Rows[i]["Name"]).Replace(" ", "") + Lib.ToString(DtPart.Rows[i]["ID"]);
				rd.Text = Lib.ToString(DtPart.Rows[i]["Name"]);
				rd.TextAlign = ContentAlignment.MiddleCenter;
				rd.ForeColor = Color.Black;
				//rd.BackColor = Color.FromArgb(54, 75, 109);
				rd.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
				LstPart.Add(rd);
				if (i < numberColumn)
				{
					tblPart.Controls.Add(rd, i, 0);
					rd.Dock = DockStyle.Fill;
					rd.Margin = new Padding(1, 1, 1, 1);
				}
				else
				{
					tblPart.Controls.Add(rd, i - numberColumn, 1);
					rd.Dock = DockStyle.Fill;
					rd.Margin = new Padding(1, 1, 1, 1);
				}
			}
			//Load UC Control của ảnh mẫu
			loadUc(true);
			Lib.EndControlUpdate(tblPart);
		}
		/// <summary>
		/// 1. Hàm Tạo UC CONTROL
		/// </summary>
		/// <param name="isPattern"></param>
		private void loadUc(bool isPattern)
		{
			if (!isPattern) LstUcCurrentImage.Clear();
			for (int i = 0; i < DtPart.Rows.Count; i++)
			{
				if (DtError.Rows.Count > 0)
				{
					for (int j = 0; j < DtError.Rows.Count; j++)
					{
						ucImage uc = new ucImage();
						uc.PartCode = TextUtils.ToString(DtPart.Rows[i]["Code"]);
						uc.PartID = TextUtils.ToInt(DtPart.Rows[i]["ID"]);
						uc.ErrorCode = TextUtils.ToString(DtError.Rows[j]["Code"]);
						uc.Error = TextUtils.ToString(DtError.Rows[j]["Name"]);
						uc.ErrorID = TextUtils.ToInt(DtError.Rows[j]["ID"]);
						uc.txtQrCodePart = txtQrCodePart;
						uc.IsPattern = isPattern;
						uc.QrCode = txtQRCode.Text.Trim();
						uc.WorkerCode = txtWorker.Text.Trim();
						uc.OrderCode = txtOrder.Text.Trim();
						uc.setError();
						if (isPattern) LstUcPatternImage.Add(uc); else LstUcCurrentImage.Add(uc);
					}
				}
			}
		}
		/// <summary>
		/// 1. Show các UC control từ các list
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		private void showPatternImage(int id, string name)
		{
			tblPatternImage.RowStyles.Clear();
			tblPatternImage.ColumnStyles.Clear();
			tblPatternImage.Controls.Clear();
			var lstUc = LstUcPatternImage.Where(o => o.PartID == id).ToList();
			if (lstUc == null) return;
			tblPatternImage.RowCount = 1;
			tblPatternImage.ColumnCount = lstUc.Count;

			for (int i = 0; i < lstUc.Count; i++)
			{
				tblPatternImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			}
			for (int i = 0; i < lstUc.Count; i++)
			{
				tblPatternImage.Controls.Add(lstUc[i], i, 0);
				lstUc[i].Dock = DockStyle.Fill;
				lstUc[i].Part = name;
				lstUc[i].Margin = new Padding(1, 1, 1, 1);
				lstUc[i].LoadImagePattern();
			}
		}
		private void showCurrentImage(int id, string name)
		{
			Lib.EndControlUpdate(tblCurrentImage);
			tblCurrentImage.RowStyles.Clear();
			tblCurrentImage.ColumnStyles.Clear();
			tblCurrentImage.Controls.Clear();

			var lstUcCurrent = LstUcCurrentImage.Where(o => o.PartID == id).ToList();
			if (lstUcCurrent == null) return;
			tblCurrentImage.RowCount = 1;
			tblCurrentImage.ColumnCount = lstUcCurrent.Count;

			for (int i = 0; i < lstUcCurrent.Count; i++)
			{
				tblCurrentImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			}
			for (int i = 0; i < lstUcCurrent.Count; i++)
			{
				tblCurrentImage.Controls.Add(lstUcCurrent[i], i, 0);
				lstUcCurrent[i].Dock = DockStyle.Fill;
				lstUcCurrent[i].Part = name;
				lstUcCurrent[i].Margin = new Padding(1, 1, 1, 1);
				lstUcCurrent[i].QrCode = txtQRCode.Text.Trim();
				lstUcCurrent[i].txtQrCodePart.Text = txtQrCodePart.Text.Trim();
				lstUcCurrent[i].LoadImageHistory();
			}
			Lib.EndControlUpdate(tblCurrentImage);
		}
		private void Rd_CheckedChanged(object sender, EventArgs e)
		{
			if (lockEvents)
			{
				lockEvents = false;
				return;
			}
			try
			{
				//Pattern
				lockEvents = true;
				RadioButton rd = (RadioButton)sender;
				string name = $"rd{rd.Text}";
				int id = TextUtils.ToInt(rd.Name.Replace(name, ""));
				showPatternImage(id, rd.Text);
				//Currrent
				if (txtQrCodePart.Text == "") return;
				RadioButton rdCurrent = (RadioButton)sender;
				string nameCurrent = $"rd{rdCurrent.Text}";
				int idCurrent = TextUtils.ToInt(rdCurrent.Name.Replace(nameCurrent, ""));
				showCurrentImage(idCurrent, rd.Text);
			}
			catch (Exception)
			{

				throw;
			}

		}
		private void txtQrCodePart_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			if (txtQrCodePart.Text.Trim() == Qrcode) return;
			loadUc(false);
			//Check what radio button is checking
			RadioButton checkedButton = tblPart.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
			if (checkedButton == null) return;
			string nameCurrent = $"rd{checkedButton.Text}";
			int idCurrent = TextUtils.ToInt(checkedButton.Name.Replace(nameCurrent, ""));
			showCurrentImage(idCurrent, checkedButton.Text);
			Qrcode = txtQrCodePart.Text.Trim();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?", "Cất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			for (int i = 0; i < LstUcCurrentImage.Count; i++)
			{
				LstUcCurrentImage[i].Save();
			}
			Reset();
		}
		public void Reset()
		{
			txtQRCode.Text = "";
			txtOrder.Text = "";
			txtGroupCode.Text = "";
			txtWorker.Text = "";
			txtSalesOrder.Text = "";
			txtQty.Text = "";
			txtGoal.Text = "";
			cboWorkingStep.Text = "";
			txtStepName.Text = "";
			cboSub.Text = "";
			txtGroupCode.Text = "";
			txtName.Text = "";
			txtProductTypeCode.Text = "";
		}

		private void btnNotUseCD8_Click(object sender, EventArgs e)
		{

		}

		private void txtWorker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtQRCode.Focus();
				txtQRCode.SelectAll();
			}
		}

		private void txtQRCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtOrder.Focus();
				txtOrder.SelectAll();
			}
		}

		private void txtOrder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtQrCodePart.SelectAll();
				txtQrCodePart.Focus();
			}
		}
	}
}

