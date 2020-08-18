namespace System.Net.Http.HPack
{
	/// <summary>
	/// Hint for how the header should be encoded as HPack. This value can be overriden.
	/// For example, a header that is larger than the dynamic table won't be indexed.
	/// </summary>
	internal enum HeaderEncodingHint
	{
		Index,
		IgnoreIndex,
		NeverIndex
	}
}
