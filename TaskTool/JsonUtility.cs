using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TaskTool
{
	public static class JsonUtility
	{
		public static string SerializeObject(object t)
		{
			var s = JsonSerializer.Serialize(t, t.GetType(), new JsonSerializerOptions{WriteIndented = true});
			return s;
		}

		public static T DeserializeObject<T>(string json)
			where T : new()
		{
			var t = JsonSerializer.Deserialize<T>(json);
			return t;
		}

		public static object DeserializeObject(string json, Type type)
		{
			var t = JsonSerializer.Deserialize(json, type);
			return t;
		}
	}
}
