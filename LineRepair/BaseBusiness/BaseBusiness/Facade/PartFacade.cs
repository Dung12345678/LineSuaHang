
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class PartFacade : BaseFacade
	{
		protected static PartFacade instance = new PartFacade(new PartModel());
		protected PartFacade(PartModel model) : base(model)
		{
		}
		public static PartFacade Instance
		{
			get { return instance; }
		}
		protected PartFacade():base() 
		{ 
		} 
	
	}
}
	