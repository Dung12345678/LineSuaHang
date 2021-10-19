
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ImageRegisterBO : BaseBO
	{
		private ImageRegisterFacade facade = ImageRegisterFacade.Instance;
		protected static ImageRegisterBO instance = new ImageRegisterBO();

		protected ImageRegisterBO()
		{
			this.baseFacade = facade;
		}

		public static ImageRegisterBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	