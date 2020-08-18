using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.DiagnosticsViewPage.Views
{
	internal abstract class BaseView
	{
		/// <summary>
		/// The request context
		/// </summary>
		protected HttpContext Context
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The request
		/// </summary>
		protected HttpRequest Request
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The response
		/// </summary>
		protected HttpResponse Response
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The output stream
		/// </summary>
		protected StreamWriter Output
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Html encoder used to encode content.
		/// </summary>
		protected HtmlEncoder HtmlEncoder
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

		/// <summary>
		/// Url encoder used to encode content.
		/// </summary>
		protected UrlEncoder UrlEncoder
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

		/// <summary>
		/// JavaScript encoder used to encode content.
		/// </summary>
		protected JavaScriptEncoder JavaScriptEncoder
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

		/// <summary>
		/// Execute an individual request
		/// </summary>
		/// <param name="context"></param>
		[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__28))]
		[DebuggerStepThrough]
		public Task ExecuteAsync(HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Execute an individual request
		/// </summary>
		public abstract Task ExecuteAsync();

		/// <summary>
		/// Write the given value directly to the output
		/// </summary>
		/// <param name="value"></param>
		protected void WriteLiteral(string value)
		{
			throw null;
		}

		/// <summary>
		/// Write the given value directly to the output
		/// </summary>
		/// <param name="value"></param>
		protected void WriteLiteral(object value)
		{
			throw null;
		}

		protected void WriteAttributeValue(string thingy, int startPostion, object value, int endValue, int dealyo, bool yesno)
		{
			throw null;
		}

		protected void BeginWriteAttribute(string name, string beginning, int startPosition, string ending, int endPosition, int thingy)
		{
			throw null;
		}

		protected void EndWriteAttribute()
		{
			throw null;
		}

		/// <summary>
		/// Writes the given attribute to the given writer
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> instance to write to.</param>
		/// <param name="name">The name of the attribute to write</param>
		/// <param name="leader">The value of the prefix</param>
		/// <param name="trailer">The value of the suffix</param>
		/// <param name="values">The <see cref="T:Microsoft.AspNetCore.DiagnosticsViewPage.Views.AttributeValue" />s to write.</param>
		protected void WriteAttributeTo(TextWriter writer, string name, string leader, string trailer, params AttributeValue[] values)
		{
			throw null;
		}

		/// <summary>
		/// Convert to string and html encode
		/// </summary>
		/// <param name="value"></param>
		protected void Write(object value)
		{
			throw null;
		}

		/// <summary>
		/// Html encode and write
		/// </summary>
		/// <param name="value"></param>
		protected void Write(string value)
		{
			throw null;
		}

		/// <summary>
		/// <see cref="M:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult.WriteTo(System.IO.TextWriter)" /> is invoked
		/// </summary>
		/// <param name="result">The <see cref="T:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult" /> to invoke</param>
		protected void Write(HelperResult result)
		{
			throw null;
		}

		/// <summary>
		/// Writes the specified <paramref name="value" /> to <paramref name="writer" />.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> instance to write to.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to write.</param>
		/// <remarks>
		/// <see cref="M:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult.WriteTo(System.IO.TextWriter)" /> is invoked for <see cref="T:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult" /> types.
		/// For all other types, the encoded result of <see cref="M:System.Object.ToString" /> is written to the
		/// <paramref name="writer" />.
		/// </remarks>
		protected void WriteTo(TextWriter writer, object value)
		{
			throw null;
		}

		/// <summary>
		/// Writes the specified <paramref name="value" /> with HTML encoding to <paramref name="writer" />.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> instance to write to.</param>
		/// <param name="value">The <see cref="T:System.String" /> to write.</param>
		protected void WriteTo(TextWriter writer, string value)
		{
			throw null;
		}

		/// <summary>
		/// Writes the specified <paramref name="value" /> without HTML encoding to the <paramref name="writer" />.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> instance to write to.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to write.</param>
		protected void WriteLiteralTo(TextWriter writer, object value)
		{
			throw null;
		}

		/// <summary>
		/// Writes the specified <paramref name="value" /> without HTML encoding to <see cref="P:Microsoft.AspNetCore.DiagnosticsViewPage.Views.BaseView.Output" />.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> instance to write to.</param>
		/// <param name="value">The <see cref="T:System.String" /> to write.</param>
		protected void WriteLiteralTo(TextWriter writer, string value)
		{
			throw null;
		}

		protected string HtmlEncodeAndReplaceLineBreaks(string input)
		{
			throw null;
		}

		protected BaseView()
		{
			throw null;
		}
	}
}
