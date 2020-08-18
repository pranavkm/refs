using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace System.Net
{
	/// <summary>Provides logging facilities for System.Net libraries.</summary>
	internal sealed class NetEventSource : EventSource
	{
		public class Keywords
		{
			public const EventKeywords Default = (EventKeywords)1L;

			public const EventKeywords Debug = (EventKeywords)2L;

			public const EventKeywords EnterExit = (EventKeywords)4L;

			public Keywords()
			{
				throw null;
			}
		}

		/// <summary>The single event source instance to use for all logging.</summary>
		public static readonly NetEventSource Log;

		public new static bool IsEnabled
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Logs entrance to a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="formattableString">A description of the entrance, including any arguments to the call.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Enter(object? thisOrContextObject, FormattableString? formattableString = null, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs entrance to a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="arg0">The object to log.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Enter(object? thisOrContextObject, object arg0, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs entrance to a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="arg0">The first object to log.</param>
		/// <param name="arg1">The second object to log.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Enter(object? thisOrContextObject, object arg0, object arg1, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs entrance to a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="arg0">The first object to log.</param>
		/// <param name="arg1">The second object to log.</param>
		/// <param name="arg2">The third object to log.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Enter(object? thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs exit from a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="formattableString">A description of the exit operation, including any return values.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Exit(object? thisOrContextObject, FormattableString? formattableString = null, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs exit from a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="arg0">A return value from the member.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Exit(object? thisOrContextObject, object arg0, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs exit from a method.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="arg0">A return value from the member.</param>
		/// <param name="arg1">A second return value from the member.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Exit(object? thisOrContextObject, object arg0, object arg1, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs an information message.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="formattableString">The message to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Info(object? thisOrContextObject, FormattableString? formattableString = null, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs an information message.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="message">The message to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Info(object? thisOrContextObject, object? message, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs an error message.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="formattableString">The message to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Error(object? thisOrContextObject, FormattableString formattableString, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs an error message.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="message">The message to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Error(object? thisOrContextObject, object message, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs a fatal error and raises an assert.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="formattableString">The message to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Fail(object? thisOrContextObject, FormattableString formattableString, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs a fatal error and raises an assert.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="message">The message to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Fail(object? thisOrContextObject, object message, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs the contents of a buffer.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="buffer">The buffer to be logged.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void DumpBuffer(object? thisOrContextObject, byte[] buffer, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs the contents of a buffer.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="buffer">The buffer to be logged.</param>
		/// <param name="offset">The starting offset from which to log.</param>
		/// <param name="count">The number of bytes to log.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void DumpBuffer(object? thisOrContextObject, byte[] buffer, int offset, int count, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs the contents of a buffer.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="bufferPtr">The starting location of the buffer to be logged.</param>
		/// <param name="count">The number of bytes to log.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void DumpBuffer(object? thisOrContextObject, IntPtr bufferPtr, int count, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs a relationship between two objects.</summary>
		/// <param name="first">The first object.</param>
		/// <param name="second">The second object.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Associate(object first, object second, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		/// <summary>Logs a relationship between two objects.</summary>
		/// <param name="thisOrContextObject">`this`, or another object that serves to provide context for the operation.</param>
		/// <param name="first">The first object.</param>
		/// <param name="second">The second object.</param>
		/// <param name="memberName">The calling member.</param>
		[NonEvent]
		public static void Associate(object? thisOrContextObject, object first, object second, [CallerMemberName] string? memberName = null)
		{
			throw null;
		}

		[NonEvent]
		public static string IdOf(object? value)
		{
			throw null;
		}

		[NonEvent]
		public static int GetHashCode(object value)
		{
			throw null;
		}

		[NonEvent]
		public static object Format(object? value)
		{
			throw null;
		}

		public NetEventSource()
		{
			throw null;
		}
	}
}
