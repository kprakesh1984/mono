//
// System.ArgumentNullException.cs
//
// Author:
//   Joe Shaw (joe@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System.Globalization;

namespace System {

	public class ArgumentNullException : ArgumentException {
		// Constructors
		public ArgumentNullException ()
			: base (Locale.GetText ("Argument cannot be null"))
		{
		}

		public ArgumentNullException (string param_name)
			: base (Locale.GetText ("Argument {0} cannot be null"), param_name)
		{
		}

		public ArgumentNullException (string param_name, string message)
			: base (message, param_name)
		{
		}
	}
}
