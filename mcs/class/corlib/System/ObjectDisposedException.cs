//
// System.ObjectDisposedException.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System.Globalization;

namespace System {

	public class ObjectDisposedException : InvalidOperationException {
		private string obj_name;
		// Constructors

		public ObjectDisposedException (string objectName)
			: base (Locale.GetText ("The object was used after being disposed"))
		{
			obj_name = objectName;
		}
		public ObjectDisposedException( string objectName, string message) 
			: base (message)
		{
			obj_name = objectName;
		}


	}
}
