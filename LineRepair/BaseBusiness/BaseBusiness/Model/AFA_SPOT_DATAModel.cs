
using System;
namespace BMS.Model
{
	public class AFA_SPOT_DATAModel : BaseModel
	{
		private int row_id;
		private string mC_Id;
		private string jIG_ID;
		private string model_Name;
		private string cORE_PACK;
		private DateTime? wORK_DATE;
		private DateTime? sAVE_TIME;
		private string hEAD;
		private int cell_No;
		private string iTEM_NAME;
		private string iTEM_VALUE;
		public int Row_id
		{
			get { return row_id; }
			set { row_id = value; }
		}
	
		public string MC_Id
		{
			get { return mC_Id; }
			set { mC_Id = value; }
		}
	
		public string JIG_ID
		{
			get { return jIG_ID; }
			set { jIG_ID = value; }
		}
	
		public string Model_Name
		{
			get { return model_Name; }
			set { model_Name = value; }
		}
	
		public string CORE_PACK
		{
			get { return cORE_PACK; }
			set { cORE_PACK = value; }
		}
	
		public DateTime? WORK_DATE
		{
			get { return wORK_DATE; }
			set { wORK_DATE = value; }
		}
	
		public DateTime? SAVE_TIME
		{
			get { return sAVE_TIME; }
			set { sAVE_TIME = value; }
		}
	
		public string HEAD
		{
			get { return hEAD; }
			set { hEAD = value; }
		}
	
		public int Cell_No
		{
			get { return cell_No; }
			set { cell_No = value; }
		}
	
		public string ITEM_NAME
		{
			get { return iTEM_NAME; }
			set { iTEM_NAME = value; }
		}
	
		public string ITEM_VALUE
		{
			get { return iTEM_VALUE; }
			set { iTEM_VALUE = value; }
		}
	
	}
}
	