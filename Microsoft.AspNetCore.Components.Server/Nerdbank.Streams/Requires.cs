namespace Nerdbank.Streams
{
	internal static class Requires
	{
		internal static void NotNull(object arg, string paramName)
		{
			throw null;
		}

		internal static void Argument(bool condition, string paramName, string message)
		{
			throw null;
		}

		internal static void Range(bool condition, string paramName)
		{
			throw null;
		}
	}
}
