using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Associates an event argument type with an event attribute name.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class EventHandlerAttribute : Attribute
	{
		/// <summary>
		/// Gets the attribute name.
		/// </summary>
		public string AttributeName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the event argument type.
		/// </summary>
		public Type EventArgsType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the event's ability to stop propagation.
		/// </summary>
		public bool EnableStopPropagation
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the event's ability to prevent default event flow.
		/// </summary>
		public bool EnablePreventDefault
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.EventHandlerAttribute" />.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <param name="eventArgsType"></param>
		public EventHandlerAttribute(string attributeName, Type eventArgsType)
		{
			throw null;
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.EventHandlerAttribute" />.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <param name="eventArgsType"></param>
		/// <param name="enableStopPropagation"></param>
		/// <param name="enablePreventDefault"></param>
		public EventHandlerAttribute(string attributeName, Type eventArgsType, bool enableStopPropagation, bool enablePreventDefault)
		{
			throw null;
		}
	}
}
