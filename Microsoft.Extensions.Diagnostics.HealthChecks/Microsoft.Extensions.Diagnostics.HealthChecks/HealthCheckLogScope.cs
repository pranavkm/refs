using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks
{
	internal class HealthCheckLogScope : IReadOnlyList<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, object>>
	{
		public string HealthCheckName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		int IReadOnlyCollection<KeyValuePair<string, object>>.Count
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		KeyValuePair<string, object> IReadOnlyList<KeyValuePair<string, object>>.this[int index]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckLogScope" /> with the provided name.
		/// </summary>
		/// <param name="healthCheckName">The name of the health check being executed.</param>
		public HealthCheckLogScope(string healthCheckName)
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DCollections_002DGeneric_002DKeyValuePair_003CSystem_002DString_005C))]
		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
