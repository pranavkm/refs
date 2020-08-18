using System;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// Marks the constructor to be used when activating type using <see cref="T:Microsoft.Extensions.Internal.ActivatorUtilities" />.
	/// </summary>
	internal class ActivatorUtilitiesConstructorAttribute : Attribute
	{
		public ActivatorUtilitiesConstructorAttribute()
		{
			throw null;
		}
	}
}
