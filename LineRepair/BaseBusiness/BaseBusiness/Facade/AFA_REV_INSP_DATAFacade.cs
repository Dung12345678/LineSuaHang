
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class AFA_REV_INSP_DATAFacade : BaseFacade
	{
		protected static AFA_REV_INSP_DATAFacade instance = new AFA_REV_INSP_DATAFacade(new AFA_REV_INSP_DATAModel());
		protected AFA_REV_INSP_DATAFacade(AFA_REV_INSP_DATAModel model) : base(model)
		{
		}
		public static AFA_REV_INSP_DATAFacade Instance
		{
			get { return instance; }
		}
		protected AFA_REV_INSP_DATAFacade():base() 
		{ 
		} 
	
	}
}
	