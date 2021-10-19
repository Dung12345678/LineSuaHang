
using System;
namespace BMS.Model
{
	public class ProductionPlanModel : BaseModel
	{
		private long iD;
		private string assemblyProduct;
		private int stt;
		private DateTime? jgDate;
		private string orderCode;
		private int cnt;
		private string productCode;
		private string description;
		private int realQty;
		private int qty;
		private string salesOrder;
		private string shipTo;
		private string sVia;
		private string note;
		private string note1;
		private string cycloDick;
		private string maMoto;
		private DateTime? updatedAt;
		private DateTime? createdAt;
		private int status;
		private bool priority;
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string AssemblyProduct
		{
			get { return assemblyProduct; }
			set { assemblyProduct = value; }
		}
	
		public int Stt
		{
			get { return stt; }
			set { stt = value; }
		}
	
		public DateTime? JgDate
		{
			get { return jgDate; }
			set { jgDate = value; }
		}
	
		public string OrderCode
		{
			get { return orderCode; }
			set { orderCode = value; }
		}
	
		public int Cnt
		{
			get { return cnt; }
			set { cnt = value; }
		}
	
		public string ProductCode
		{
			get { return productCode; }
			set { productCode = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
		public int RealQty
		{
			get { return realQty; }
			set { realQty = value; }
		}
	
		public int Qty
		{
			get { return qty; }
			set { qty = value; }
		}
	
		public string SalesOrder
		{
			get { return salesOrder; }
			set { salesOrder = value; }
		}
	
		public string ShipTo
		{
			get { return shipTo; }
			set { shipTo = value; }
		}
	
		public string SVia
		{
			get { return sVia; }
			set { sVia = value; }
		}
	
		public string Note
		{
			get { return note; }
			set { note = value; }
		}
	
		public string Note1
		{
			get { return note1; }
			set { note1 = value; }
		}
	
		public string CycloDick
		{
			get { return cycloDick; }
			set { cycloDick = value; }
		}
	
		public string MaMoto
		{
			get { return maMoto; }
			set { maMoto = value; }
		}
	
		public DateTime? UpdatedAt
		{
			get { return updatedAt; }
			set { updatedAt = value; }
		}
	
		public DateTime? CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}
	
		public int Status
		{
			get { return status; }
			set { status = value; }
		}
	
		public bool Priority
		{
			get { return priority; }
			set { priority = value; }
		}
	
	}
}
	