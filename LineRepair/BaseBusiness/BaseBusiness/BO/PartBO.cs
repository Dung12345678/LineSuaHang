
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class PartBO : BaseBO
	{
		private PartFacade facade = PartFacade.Instance;
		protected static PartBO instance = new PartBO();

		protected PartBO()
		{
			this.baseFacade = facade;
		}

		public static PartBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	