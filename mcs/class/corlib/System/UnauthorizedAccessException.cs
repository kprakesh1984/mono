//
// System.UnauthorizedAccessException.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System.Globalization;
namespace System {

	public class UnauthorizedAccessException : SystemException {
		// Constructors
		public UnauthorizedAccessException ()
			: base (Locale.GetText ("Access to the requested resource is not authorized"))
		{
		}

		public UnauthorizedAccessException (string message)
			: base (message)
		{
		}

		public UnauthorizedAccessException (string message, Exception inner)
			: base (message, inner)
		{
		}
	}
}
