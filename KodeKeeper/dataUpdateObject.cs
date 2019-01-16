using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	class dataUpdateObject
	{
		Hashtable values = new Hashtable();

		public string Name = "";
		public int Values = -1;

		public bool Add(string name, string value)
		{
			try
			{
				values.Add(addName(name), addValue(value));
				return true;
			}
			catch
			{
				return false;
			}
		}

		private string addName(string name)
		{
			if (name.Contains("_"))
			{
				return name.Substring(name.IndexOf("_") + 1);
			}
			else { return name; }
		}

		private int addValue(string value)
		{
			if(int.TryParse(value, out int i))
			{
				return i;
			}
			else
			{
				return -1;
			}
		}

		public Hashtable Get()
		{
			return values;
		}

		public string Get(String name)
		{
			return values[name].ToString();
		}
	}
}
