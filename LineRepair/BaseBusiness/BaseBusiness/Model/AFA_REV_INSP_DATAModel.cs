
using System;
namespace BMS.Model
{
	public class AFA_REV_INSP_DATAModel : BaseModel
	{
		private int row_id;
		private string mC_Id;
		private string jig_id;
		private string model_Name;
		private string cORE_PACK;
		private DateTime? wORK_DATE;
		private string total_RESULT;
		private string hOLE_RESULT;
		private int hOLE_CNT_SPEC;
		private DateTime? sAVE_TIME;
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
	
		public string Jig_id
		{
			get { return jig_id; }
			set { jig_id = value; }
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
	
		public string Total_RESULT
		{
			get { return total_RESULT; }
			set { total_RESULT = value; }
		}
	
		public string HOLE_RESULT
		{
			get { return hOLE_RESULT; }
			set { hOLE_RESULT = value; }
		}
	
		public int HOLE_CNT_SPEC
		{
			get { return hOLE_CNT_SPEC; }
			set { hOLE_CNT_SPEC = value; }
		}
	
		public DateTime? SAVE_TIME
		{
			get { return sAVE_TIME; }
			set { sAVE_TIME = value; }
		}
	
	}
}
	