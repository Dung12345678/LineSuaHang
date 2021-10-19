
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class AFA_CELL_GRADING_DATABO : BaseBO
	{
		private AFA_CELL_GRADING_DATAFacade facade = AFA_CELL_GRADING_DATAFacade.Instance;
		protected static AFA_CELL_GRADING_DATABO instance = new AFA_CELL_GRADING_DATABO();

		protected AFA_CELL_GRADING_DATABO()
		{
			this.baseFacade = facade;
		}

		public static AFA_CELL_GRADING_DATABO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	