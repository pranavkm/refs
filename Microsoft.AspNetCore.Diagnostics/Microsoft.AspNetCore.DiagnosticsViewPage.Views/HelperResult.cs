using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DiagnosticsViewPage.Views
{
	/// <summary>
	/// Represents a deferred write operation in a <see cref="T:Microsoft.AspNetCore.DiagnosticsViewPage.Views.BaseView" />.
	/// </summary>
	internal class HelperResult
	{
		public Action<TextWriter> WriteAction
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult" />.
		/// </summary>
		/// <param name="action">The delegate to invoke when <see cref="M:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult.WriteTo(System.IO.TextWriter)" /> is called.</param>
		public HelperResult(Action<TextWriter> action)
		{
			throw null;
		}

		/// <summary>
		/// Method invoked to produce content from the <see cref="T:Microsoft.AspNetCore.DiagnosticsViewPage.Views.HelperResult" />.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> instance to write to.</param>
		public void WriteTo(TextWriter writer)
		{
			throw null;
		}
	}
}
