using System;

namespace Microsoft.AspNetCore.DataProtection.Internal
{
	/// <summary>
	/// An interface into <see cref="M:System.Activator.CreateInstance``1" /> that also supports
	/// limited dependency injection (of <see cref="T:System.IServiceProvider" />).
	/// </summary>
	public interface IActivator
	{
		/// <summary>
		/// Creates an instance of <paramref name="implementationTypeName" /> and ensures
		/// that it is assignable to <paramref name="expectedBaseType" />.
		/// </summary>
		object CreateInstance(Type expectedBaseType, string implementationTypeName);
	}
}
