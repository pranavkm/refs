using System;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// The result of <see cref="M:Microsoft.Extensions.Internal.ActivatorUtilities.CreateFactory(System.Type,System.Type[])" />.
	/// </summary>
	/// <param name="serviceProvider">The <see cref="T:System.IServiceProvider" /> to get service arguments from.</param>
	/// <param name="arguments">Additional constructor arguments.</param>
	/// <returns>The instantiated type.</returns>
	internal delegate object ObjectFactory(IServiceProvider serviceProvider, object[] arguments);
}
