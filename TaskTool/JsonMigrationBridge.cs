using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTool
{
	[Flags]
	public enum Formatting
	{
		Indented = 31337 // heh
	}

	public static class JsonConvert
	{
		internal static string SerializeObject<T>(T config, Formatting formatting)
			where T : new()
		{
			throw new NotImplementedException();
		}

		internal static T DeserializeObject<T>(string configStr)
			where T : new()
		{
			throw new NotImplementedException();
		}

		internal static object DeserializeObject(string configStr, Type configType)
		{
			throw new NotImplementedException();
		}
	}

}
