
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class AFA_REV_INSP_DATABO : BaseBO
	{
		private AFA_REV_INSP_DATAFacade facade = AFA_REV_INSP_DATAFacade.Instance;
		protected static AFA_REV_INSP_DATABO instance = new AFA_REV_INSP_DATABO();

		protected AFA_REV_INSP_DATABO()
		{
			this.baseFacade = facade;
		}

		public static AFA_REV_INSP_DATABO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	