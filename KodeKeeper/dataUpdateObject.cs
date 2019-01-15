using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	class dataUpdateObject
	{
		public string Name = "";
		public int Values = -1;

		public void addName(string name)
		{
			if (name.Contains("_"))
			{
				Name = name.Substring(name.IndexOf("_") + 1);
			}
			else { Name = name; }
		}

		public bool addValue(string value)
		{
			if(int.TryParse(value, out int i))
			{
				Values = i;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
