using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	internal static class RoutePatternParser
	{
		[DebuggerDisplay("{DebuggerToString()}")]
		private class Context
		{
			public char Current
			{
				get
				{
					throw null;
				}
			}

			public int Index
			{
				get
				{
					throw null;
				}
			}

			public string Error
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public HashSet<string> ParameterNames
			{
				get
				{
					throw null;
				}
			}

			public Context(string template)
			{
				throw null;
			}

			public bool Back()
			{
				throw null;
			}

			public bool AtEnd()
			{
				throw null;
			}

			public bool MoveNext()
			{
				throw null;
			}

			public void Mark()
			{
				throw null;
			}

			public string Capture()
			{
				throw null;
			}
		}

		internal static readonly char[] InvalidParameterNameChars;

		public static RoutePattern Parse(string pattern)
		{
			throw null;
		}
	}
}
