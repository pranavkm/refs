using System.IO;
using System.Text.Encodings.Web;

namespace Microsoft.Extensions.WebEncoders.Testing
{
	/// <summary>
	/// Encoder used for unit testing.
	/// </summary>
	public sealed class HtmlTestEncoder : HtmlEncoder
	{
		public override int MaxOutputCharactersPerInputCharacter
		{
			get
			{
				throw null;
			}
		}

		public override string Encode(string value)
		{
			throw null;
		}

		public override void Encode(TextWriter output, char[] value, int startIndex, int characterCount)
		{
			throw null;
		}

		public override void Encode(TextWriter output, string value, int startIndex, int characterCount)
		{
			throw null;
		}

		public override bool WillEncode(int unicodeScalar)
		{
			throw null;
		}

		public unsafe override int FindFirstCharacterToEncode(char* text, int textLength)
		{
			throw null;
		}

		public unsafe override bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten)
		{
			throw null;
		}

		public HtmlTestEncoder()
		{
			throw null;
		}
	}
}
