using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Provides information about the <see cref="E:Microsoft.AspNetCore.Components.Forms.EditContext.OnFieldChanged" /> event.
	/// </summary>
	public sealed class FieldChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Identifies the field whose value has changed.
		/// </summary>
		public FieldIdentifier FieldIdentifier
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs" />.
		/// </summary>
		/// <param name="fieldIdentifier">The <see cref="T:Microsoft.AspNetCore.Components.Forms.FieldIdentifier" /></param>
		public FieldChangedEventArgs(in FieldIdentifier fieldIdentifier)
		{
			throw null;
		}
	}
}
