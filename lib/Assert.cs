using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class Assert
	{
		static public void True(bool x) {
			if (!x)
			{
				throw new Exception();
				
			}
		
		}

		static public void False(bool x) {
			True(!x);
		}
	}
}
