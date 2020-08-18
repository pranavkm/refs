namespace System.Diagnostics
{
	/// <summary>
	/// Attribute to add to non-returning throw only methods, 
	/// to restore the stack trace back to what it would be if the throw was in-place
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	internal sealed class StackTraceHiddenAttribute : Attribute
	{
		public StackTraceHiddenAttribute()
		{
			throw null;
		}
	}
}
