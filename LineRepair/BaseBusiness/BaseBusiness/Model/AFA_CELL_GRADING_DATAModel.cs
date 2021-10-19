
using System;
namespace BMS.Model
{
	public class AFA_CELL_GRADING_DATAModel : BaseModel
	{
		private int row_id;
		private string mc_id;
		private string model_Name;
		private string cell_id;
		private DateTime? work_Date;
		private string grade;
		private string class_Rate;
		private decimal ocv;
		private decimal ocv_Upper;
		private decimal ocv_Low;
		private decimal ir;
		private decimal ir_Upper;
		private decimal ir_Low;
		private decimal k_Val;
		private decimal k_Val_Spec;
		private string k_Val_Result_Mes;
		private decimal lg_Cell_Ocv;
		private DateTime? cell_Date;
		private DateTime? save_Date;
		public int Row_id
		{
			get { return row_id; }
			set { row_id = value; }
		}
	
		public string Mc_id
		{
			get { return mc_id; }
			set { mc_id = value; }
		}
	
		public string Model_Name
		{
			get { return model_Name; }
			set { model_Name = value; }
		}
	
		public string Cell_id
		{
			get { return cell_id; }
			set { cell_id = value; }
		}
	
		public DateTime? Work_Date
		{
			get { return work_Date; }
			set { work_Date = value; }
		}
	
		public string Grade
		{
			get { return grade; }
			set { grade = value; }
		}
	
		public string Class_Rate
		{
			get { return class_Rate; }
			set { class_Rate = value; }
		}
	
		public decimal Ocv
		{
			get { return ocv; }
			set { ocv = value; }
		}
	
		public decimal Ocv_Upper
		{
			get { return ocv_Upper; }
			set { ocv_Upper = value; }
		}
	
		public decimal Ocv_Low
		{
			get { return ocv_Low; }
			set { ocv_Low = value; }
		}
	
		public decimal Ir
		{
			get { return ir; }
			set { ir = value; }
		}
	
		public decimal Ir_Upper
		{
			get { return ir_Upper; }
			set { ir_Upper = value; }
		}
	
		public decimal Ir_Low
		{
			get { return ir_Low; }
			set { ir_Low = value; }
		}
	
		public decimal K_Val
		{
			get { return k_Val; }
			set { k_Val = value; }
		}
	
		public decimal K_Val_Spec
		{
			get { return k_Val_Spec; }
			set { k_Val_Spec = value; }
		}
	
		public string K_Val_Result_Mes
		{
			get { return k_Val_Result_Mes; }
			set { k_Val_Result_Mes = value; }
		}
	
		public decimal Lg_Cell_Ocv
		{
			get { return lg_Cell_Ocv; }
			set { lg_Cell_Ocv = value; }
		}
	
		public DateTime? Cell_Date
		{
			get { return cell_Date; }
			set { cell_Date = value; }
		}
	
		public DateTime? Save_Date
		{
			get { return save_Date; }
			set { save_Date = value; }
		}
	
	}
}
	