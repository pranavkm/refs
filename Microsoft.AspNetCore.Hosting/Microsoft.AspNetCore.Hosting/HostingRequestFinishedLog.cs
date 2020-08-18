using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class HostingRequestFinishedLog : IReadOnlyList<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, object>>
	{
		internal static readonly Func<object, Exception, string> Callback;

		public TimeSpan Elapsed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

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

		public HostingRequestFinishedLog(HostingApplication.Context context, TimeSpan elapsed)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__12))]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
