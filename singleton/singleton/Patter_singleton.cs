using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class MySingleton
	{
		private static MySingleton _instance;
		private MySingleton()
		{
			
		}

		public static MySingleton Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new MySingleton();
				}
				return _instance;
			}
		}
	}
}
