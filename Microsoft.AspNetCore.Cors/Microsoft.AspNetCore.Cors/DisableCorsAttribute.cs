using Microsoft.AspNetCore.Cors.Infrastructure;
using System;

namespace Microsoft.AspNetCore.Cors
{
	/// <inheritdoc />
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public class DisableCorsAttribute : Attribute, IDisableCorsAttribute, ICorsMetadata
	{
		public DisableCorsAttribute()
		{
			throw null;
		}
	}
}
