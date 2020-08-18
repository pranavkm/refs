using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace Microsoft.Extensions.WebEncoders
{
	/// <summary>
	/// Specifies options common to all three encoders (HtmlEncode, JavaScriptEncode, UrlEncode).
	/// </summary>
	public sealed class WebEncoderOptions
	{
		/// <summary>
		/// Specifies which code points are allowed to be represented unescaped by the encoders.
		/// </summary>
		/// <remarks>
		/// If this property is null, then the encoders will use their default allow lists.
		/// </remarks>
		public TextEncoderSettings? TextEncoderSettings
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public WebEncoderOptions()
		{
			throw null;
		}
	}
}
