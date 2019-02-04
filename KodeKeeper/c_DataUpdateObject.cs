using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	public class c_DataUpdateObject
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
		List<c_DataUpdateObject> data = new List<c_DataUpdateObject>();
		
		public void Add(c_DataUpdateObject d)
		{
			data.Add(d);
		}

		public List<c_DataUpdateObject> GetAll()
		{
			return data;
		}

		public c_DataUpdateObject[] get(string Name)
		{
			return data.Where(x=>x.Name == Name).Select(x=>x).ToArray();
		}

	}
}
