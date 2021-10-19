
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class AFA_SPOT_DATAFacade : BaseFacade
	{
		protected static AFA_SPOT_DATAFacade instance = new AFA_SPOT_DATAFacade(new AFA_SPOT_DATAModel());
		protected AFA_SPOT_DATAFacade(AFA_SPOT_DATAModel model) : base(model)
		{
		}
		public static AFA_SPOT_DATAFacade Instance
		{
			get { return instance; }
		}
		protected AFA_SPOT_DATAFacade():base() 
		{ 
		} 
	
	}
}
	