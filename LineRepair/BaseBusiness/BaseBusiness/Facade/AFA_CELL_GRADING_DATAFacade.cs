
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class AFA_CELL_GRADING_DATAFacade : BaseFacade
	{
		protected static AFA_CELL_GRADING_DATAFacade instance = new AFA_CELL_GRADING_DATAFacade(new AFA_CELL_GRADING_DATAModel());
		protected AFA_CELL_GRADING_DATAFacade(AFA_CELL_GRADING_DATAModel model) : base(model)
		{
		}
		public static AFA_CELL_GRADING_DATAFacade Instance
		{
			get { return instance; }
		}
		protected AFA_CELL_GRADING_DATAFacade():base() 
		{ 
		} 
	
	}
}
	