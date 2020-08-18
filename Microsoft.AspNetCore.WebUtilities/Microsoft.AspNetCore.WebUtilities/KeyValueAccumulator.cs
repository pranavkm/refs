using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.WebUtilities
{
	public struct KeyValueAccumulator
	{
		private Dictionary<string, StringValues> _accumulator;

		private Dictionary<string, List<string>> _expandingAccumulator;

		public bool HasValues
		{
			get
			{
				throw null;
			}
		}

		public int KeyCount
		{
			get
			{
				throw null;
			}
		}

		public int ValueCount
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public void Append(string key, string value)
		{
			throw null;
		}

		public Dictionary<string, StringValues> GetResults()
		{
			throw null;
		}
	}
}
