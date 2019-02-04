using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeKeeper
{
	public class c_LogDataObject
	{
		public string name { get; set; }
		public string module { get; set; }
		public bool error { get; set; }
		public Exception exception { get; set; }
		public string exceptionType { get; set; }
		public string message { get; set; }
		public int severity { get; set; }
		public object otherData { get; set; }

		public string toString(returnType type = returnType.plain)
		{
			switch (type)
			{
				case returnType.plain:
					break;
				case returnType.json:
					break;
				case returnType.xml:
					break;
				case returnType.blocked:
					break;
				case returnType.newlines:
					break;
			}

			return "";
		}


	}

	public enum returnType
	{
		plain,
		json,
		xml,
		blocked,
		newlines
	}
}
