
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class AFA_SPOT_DATABO : BaseBO
	{
		private AFA_SPOT_DATAFacade facade = AFA_SPOT_DATAFacade.Instance;
		protected static AFA_SPOT_DATABO instance = new AFA_SPOT_DATABO();

		protected AFA_SPOT_DATABO()
		{
			this.baseFacade = facade;
		}

		public static AFA_SPOT_DATABO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	