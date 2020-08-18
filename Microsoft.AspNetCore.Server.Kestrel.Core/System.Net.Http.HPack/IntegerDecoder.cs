namespace System.Net.Http.HPack
{
	internal class IntegerDecoder
	{
		/// <summary>
		/// Decodes the first byte of the integer.
		/// </summary>
		/// <param name="b">
		/// The first byte of the variable-length encoded integer.
		/// </param>
		/// <param name="prefixLength">
		/// The number of lower bits in this prefix byte that the
		/// integer has been encoded into. Must be between 1 and 8.
		/// Upper bits must be zero.
		/// </param>
		/// <param name="result">
		/// If decoded successfully, contains the decoded integer.
		/// </param>
		/// <returns>
		/// If the integer has been fully decoded, true.
		/// Otherwise, false -- <see cref="M:System.Net.Http.HPack.IntegerDecoder.TryDecode(System.Byte,System.Int32@)" /> must be called on subsequent bytes.
		/// </returns>
		/// <remarks>
		/// The term "prefix" can be confusing. From the HPACK spec:
		/// An integer is represented in two parts: a prefix that fills the current octet and an
		/// optional list of octets that are used if the integer value does not fit within the prefix.
		/// </remarks>
		public bool BeginTryDecode(byte b, int prefixLength, out int result)
		{
			throw null;
		}

		/// <summary>
		/// Decodes subsequent bytes of an integer.
		/// </summary>
		/// <param name="b">The next byte.</param>
		/// <param name="result">
		/// If decoded successfully, contains the decoded integer.
		/// </param>
		/// <returns>If the integer has been fully decoded, true. Otherwise, false -- <see cref="M:System.Net.Http.HPack.IntegerDecoder.TryDecode(System.Byte,System.Int32@)" /> must be called on subsequent bytes.</returns>
		public bool TryDecode(byte b, out int result)
		{
			throw null;
		}

		public IntegerDecoder()
		{
			throw null;
		}
	}
}
