using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// an expression with all literals.
	/// </summary>
	 [Obsolete("use nilnul.function.expr.ConstI")]
	public partial interface ConstI<out T> : ExprI<T>,  ConstI
	{

		T eval();
	}

	
}
