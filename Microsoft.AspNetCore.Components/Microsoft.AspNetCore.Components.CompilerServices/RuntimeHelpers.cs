using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.CompilerServices
{
	/// <summary>
	/// Used by generated code produced by the Components code generator. Not intended or supported
	/// for use in application code.
	/// </summary>
	public static class RuntimeHelpers
	{
		/// <summary>
		/// Not intended for use by application code.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value"></param>
		/// <returns></returns>
		public static T TypeCheck<T>(T value)
		{
			throw null;
		}

		/// <summary>
		/// Not intended for use by application code.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static EventCallback<T> CreateInferredEventCallback<T>(object receiver, Action<T> callback, T value)
		{
			throw null;
		}

		/// <summary>
		/// Not intended for use by application code.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="callback"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static EventCallback<T> CreateInferredEventCallback<T>(object receiver, Func<T, Task> callback, T value)
		{
			throw null;
		}
	}
}
