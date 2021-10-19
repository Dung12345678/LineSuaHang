using BMS.Business;
using BMS.Model;
using BMS.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class ucImage : UserControl
	{
		public string PathImage { get; set; }
		public string QrCode { get; set; }
		public string Part { get; set; }
		public string Error { get; set; }
		public string ErrorCode { get; set; }
		public int ErrorID { get; set; }
		public int PartID { get; set; }
		public string PartCode { get; set; }
		public string WorkerCode { get; set; }
		public string OrderCode { get; set; }
		public bool IsPattern { get; set; }
		public Image Img { get; set; }
		public TextBox txtQrCodePart { get; set; }
		public string Folder { get; set; }
		public ucImage()
		{
			InitializeComponent();
		}
		private void pcbImage_Click(object sender, EventArgs e)
		{
			if ((txtQrCodePart != null && !string.IsNullOrEmpty(txtQrCodePart.Text.Trim()) && !IsPattern) || IsPattern)
			{
				string name = "";
				if (IsPattern)
				{
					name = "ẢNH MẪU";
					if (Lib.UserLogin == 0)
					{
						frmLogin frm1 = new frmLogin();
						if (frm1.ShowDialog() != DialogResult.OK)
						{
							return;
						}
					}
				}
				else
				{
					name = "ẢNH THỰC TẾ";
				}
				frmImageRegister frm = new frmImageRegister(name, Part + " - " + lblName.Text, Part, pcbImage.Image);
				if (pcbImage.Image != null) frm.ImageReceive = pcbImage.Image;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					pcbImage.Image = frm.ImageReceive;
					Img = pcbImage.Image;
					pcbImage.SizeMode = PictureBoxSizeMode.StretchImage;
					if (IsPattern)
					{
						PathImage = "00.Sample" + @"\" + Part + @"\" + PartCode + "-" + ErrorCode + ".png";
						Folder = "00.Sample" + @"\" + Part;
					}
					else
					{
						PathImage = "01.History" + @"\" + Part + @"\" + ErrorCode + @"\" + DateTime.Now.ToString("dd-MM-yyyy")
							+ @"\" + txtQrCodePart.Text + "-" + PartCode + "-" + ErrorCode + ".png";
						Folder = "01.History" + @"\" + Part + @"\" + ErrorCode + @"\" + DateTime.Now.ToString("dd-MM-yyyy");
					}
					if (IsPattern)
					{
						if (!DocUtils.UplLoadImage(PathImage, Img, Folder)) return;
						string extSql = "";
						string sqlSelect = $"Select * from ImageRegister where PartID = {PartID} and ErrorID = {ErrorID}";
						DataTable dt = TextUtils.Select(sqlSelect);
						if (dt.Rows.Count == 0) extSql = $"Insert into ImageRegister(PartID,ErrorID,PathPatternImage) values ({PartID},{ErrorID},'{PathImage}')";
						else extSql = $"Update ImageRegister set PartID ={PartID} ,ErrorID = {ErrorID},PathPatternImage = '{PathImage}' where PartID = {PartID} and ErrorID = {ErrorID}";
						TextUtils.ExcuteSQL(extSql);
					}
				}
			}
		}
		public async void LoadImagePattern()
		{
			Task task = Task.Factory.StartNew(() =>
			{
				try
				{
					if (!IsPattern) return;
					string sqlSelect = $"Select PathPatternImage from ImageRegister where PartID = {PartID} and ErrorID = {ErrorID}";
					string path = DocUtils.FtpServerPath + "/" + TextUtils.ToString(TextUtils.ExcuteScalar(sqlSelect));

					WebRequest request = FtpWebRequest.Create(path);
					request.Credentials = new NetworkCredential(DocUtils.FtpUserID, DocUtils.FtpPassword);

					using (WebResponse response = request.GetResponse())
					{
						Stream responseStream = response.GetResponseStream();
						//MemoryStream mStream = new MemoryStream();
						//byte[] pData = blob;
						//mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
						pcbImage.Image = new Bitmap(responseStream, true);
						Img = pcbImage.Image;
					}
				}
				catch (Exception)
				{

				}
			});
			await task;

		}
		public async void LoadImageHistory()
		{
			Task task = Task.Factory.StartNew(() =>
			{
				try
				{
					if (IsPattern) return;
					string sqlSelect = $"Select Path from ImageHistory where PartID = {PartID} and ErrorID = {ErrorID} and Qrcode='{txtQrCodePart.Text.Trim()}'";
					string path = DocUtils.FtpServerPath + "/" + TextUtils.ToString(TextUtils.ExcuteScalar(sqlSelect));

					WebRequest request = FtpWebRequest.Create(path);
					request.Credentials = new NetworkCredential(DocUtils.FtpUserID, DocUtils.FtpPassword);

					using (WebResponse response = request.GetResponse())
					{
						Stream responseStream = response.GetResponseStream();
						//MemoryStream mStream = new MemoryStream();
						//byte[] pData = blob;
						//mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
						pcbImage.Image = new Bitmap(responseStream, true);
						Img = pcbImage.Image;
					}
				}
				catch (Exception)
				{

				}
			});
			await task;

		}
		public void setError()
		{
			lblName.Text = Error;
		}
		public void Save()
		{
			if (!IsPattern)
			{
				if (Img == null || txtQrCodePart.Text == "" || QrCode == "") return;
				if (!DocUtils.UplLoadImage(PathImage, Img, Folder)) return;
				ImageHistoryModel imageHistoryModel = new ImageHistoryModel();
				Expression exp1 = new Expression("PartID", PartID);
				Expression exp2 = new Expression("ErrorID", ErrorID);
				Expression exp3 = new Expression("QrCodePart", txtQrCodePart.Text.Trim());
				ArrayList arr = ImageHistoryBO.Instance.FindByExpression(exp1.And(exp2).And(exp3));
				if (arr.Count > 0)
				{
					imageHistoryModel = (ImageHistoryModel)arr[0];
				}
				imageHistoryModel.PartID = PartID;
				imageHistoryModel.ErrorID = ErrorID;
				imageHistoryModel.QrCode = QrCode;
				imageHistoryModel.Path = PathImage;
				imageHistoryModel.WorkerCode = WorkerCode;
				imageHistoryModel.OrderCode = OrderCode;
				imageHistoryModel.QrCodePart = txtQrCodePart.Text.Trim();
				imageHistoryModel.CreateDate = DateTime.Now;
				if (imageHistoryModel.ID > 0)
				{
					ImageHistoryBO.Instance.Update(imageHistoryModel);
				}
				else
				{
					ImageHistoryBO.Instance.Insert(imageHistoryModel);
				}

				//string extSql = "";
				//string sqlSelect = $"Select * from ImageHistory where PartID = {PartID} and ErrorID = {ErrorID} and Qrcode =  '{QrCode}'";
				//DataTable dt = TextUtils.Select(sqlSelect);
				//if (dt.Rows.Count == 0) extSql = $"Insert into ImageHistory(PartID,ErrorID,Path,Qrcode,WorkerCode,OrderCode,QrCodePart,CreateDate) values (N'{PartID}',N'{ErrorID}',N'{PathImage}',N'{QrCode}',N'{WorkerCode}',N'{OrderCode}',N'{txtQrCodePart.Text.Trim()}',{DateTime.Now})";
				//else extSql = $"Update ImageHistory set Path = '{PathImage}' where PartID = {PartID} and ErrorID = {ErrorID} and QrCodePart = '{txtQrCodePart.Text.Trim()}' and OrderCode ='{OrderCode}' and Qrcode='{QrCode}'";
				//TextUtils.ExcuteSQL(extSql);
			}
		}

		private void lblName_Click(object sender, EventArgs e)
		{

		}
	}
}
