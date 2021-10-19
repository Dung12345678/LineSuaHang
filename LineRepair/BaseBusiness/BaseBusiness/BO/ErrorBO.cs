
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ErrorBO : BaseBO
	{
		private ErrorFacade facade = ErrorFacade.Instance;
		protected static ErrorBO instance = new ErrorBO();

		protected ErrorBO()
		{
			this.baseFacade = facade;
		}

		public static ErrorBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	