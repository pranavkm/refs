using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class HostingRequestStartingLog : IReadOnlyList<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, object>>
	{
		internal static readonly Func<object, Exception, string> Callback;

		public int Count
		{
			get
			{
				throw null;
			}
		}

		public KeyValuePair<string, object> this[int index]
		{
			get
			{
				throw null;
			}
		}

		public HostingRequestStartingLog(HttpContext httpContext)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__11))]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		internal string ToStringWithoutPreamble()
		{
			throw null;
		}

		internal static string EscapedValueOrEmptyMarker(string potentialValue)
		{
			throw null;
		}

		internal static string ValueOrEmptyMarker<T>(T? potentialValue) where T : struct, IFormattable
		{
			throw null;
		}
	}
}
