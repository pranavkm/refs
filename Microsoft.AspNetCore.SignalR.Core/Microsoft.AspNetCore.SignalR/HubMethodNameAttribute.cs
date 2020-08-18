using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Customizes the name of a hub method.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class HubMethodNameAttribute : Attribute
	{
		/// <summary>
		/// The customized name of the hub method.
		/// </summary>
		public string Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.SignalR.HubMethodNameAttribute" /> class.
		/// </summary>
		/// <param name="name">The customized name of the hub method.</param>
		public HubMethodNameAttribute(string name)
		{
			throw null;
		}
	}
}
