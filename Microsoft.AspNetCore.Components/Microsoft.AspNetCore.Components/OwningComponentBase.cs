using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// A base class that creates a service provider scope.
	/// </summary>
	/// <remarks>
	/// Use the <see cref="T:Microsoft.AspNetCore.Components.OwningComponentBase" /> class as a base class to author components that control
	/// the lifetime of a service provider scope. This is useful when using a transient or scoped service that
	/// requires disposal such as a repository or database abstraction. Using <see cref="T:Microsoft.AspNetCore.Components.OwningComponentBase" />
	/// as a base class ensures that the service provider scope is disposed with the component.
	/// </remarks>
	public abstract class OwningComponentBase : ComponentBase, IDisposable
	{
		/// <summary>
		/// Gets a value determining if the component and associated services have been disposed.
		/// </summary>
		protected bool IsDisposed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the scoped <see cref="T:System.IServiceProvider" /> that is associated with this component.
		/// </summary>
		protected IServiceProvider ScopedServices
		{
			get
			{
				throw null;
			}
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		/// <inheritdoc />
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		protected OwningComponentBase()
		{
			throw null;
		}
	}
	/// <summary>
	/// A base class that creates a service provider scope, and resolves a service of type <typeparamref name="TService" />.
	/// </summary>
	/// <typeparam name="TService">The service type.</typeparam>
	/// <remarks>
	/// Use the <see cref="T:Microsoft.AspNetCore.Components.OwningComponentBase`1" /> class as a base class to author components that control
	/// the lifetime of a service or multiple services. This is useful when using a transient or scoped service that
	/// requires disposal such as a repository or database abstraction. Using <see cref="T:Microsoft.AspNetCore.Components.OwningComponentBase`1" />
	/// as a base class ensures that the service and relates services that share its scope are disposed with the component.
	/// </remarks>
	public abstract class OwningComponentBase<TService> : OwningComponentBase, IDisposable where TService : notnull
	{
		/// <summary>
		/// Gets the <typeparamref name="TService" /> that is associated with this component.
		/// </summary>
		protected TService Service
		{
			get
			{
				throw null;
			}
		}

		protected OwningComponentBase()
		{
			throw null;
		}
	}
}
