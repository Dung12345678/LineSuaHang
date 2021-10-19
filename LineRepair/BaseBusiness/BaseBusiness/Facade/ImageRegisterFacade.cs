
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ImageRegisterFacade : BaseFacade
	{
		protected static ImageRegisterFacade instance = new ImageRegisterFacade(new ImageRegisterModel());
		protected ImageRegisterFacade(ImageRegisterModel model) : base(model)
		{
		}
		public static ImageRegisterFacade Instance
		{
			get { return instance; }
		}
		protected ImageRegisterFacade():base() 
		{ 
		} 
	
	}
}
	