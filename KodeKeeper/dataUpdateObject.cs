using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	public class dataUpdateObject
	{
		Hashtable values = new Hashtable();
		public string Name { get; set; } = "";

		public bool Add(string name, string value)
		{
			try
			{
				values.Add(name, addValue(value));
				return true;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
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

		private string addValue(string value)
		{
			if (int.TryParse(value, out int i))
			{
				return i.ToString();
			}
			else
			{
				return value;
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

	class dataObject
	{
		List<dataUpdateObject> data = new List<dataUpdateObject>();
		
		public void Add(dataUpdateObject d)
		{
			data.Add(d);
		}

		public List<dataUpdateObject> GetAll()
		{
			return data;
		}

		public dataUpdateObject[] get(string Name)
		{
			return data.Where(x=>x.Name == Name).Select(x=>x).ToArray();
		}

	}
}
