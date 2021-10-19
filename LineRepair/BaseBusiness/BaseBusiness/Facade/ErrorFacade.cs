
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ErrorFacade : BaseFacade
	{
		protected static ErrorFacade instance = new ErrorFacade(new ErrorModel());
		protected ErrorFacade(ErrorModel model) : base(model)
		{
		}
		public static ErrorFacade Instance
		{
			get { return instance; }
		}
		protected ErrorFacade():base() 
		{ 
		} 
	
	}
}
	