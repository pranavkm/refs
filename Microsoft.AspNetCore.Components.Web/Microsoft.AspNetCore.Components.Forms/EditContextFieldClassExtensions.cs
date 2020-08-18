using System;
using System.Linq.Expressions;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Provides extension methods to describe the state of <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />
	/// fields as CSS class names.
	/// </summary>
	public static class EditContextFieldClassExtensions
	{
		/// <summary>
		/// Gets a string that indicates the status of the specified field as a CSS class. This will include
		/// some combination of "modified", "valid", or "invalid", depending on the status of the field.
		/// </summary>
		/// <param name="editContext">The <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.</param>
		/// <param name="accessor">An identifier for the field.</param>
		/// <returns>A string that indicates the status of the field.</returns>
		public static string FieldCssClass<TField>(this EditContext editContext, Expression<Func<TField>> accessor)
		{
			throw null;
		}

		/// <summary>
		/// Gets a string that indicates the status of the specified field as a CSS class. This will include
		/// some combination of "modified", "valid", or "invalid", depending on the status of the field.
		/// </summary>
		/// <param name="editContext">The <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.</param>
		/// <param name="fieldIdentifier">An identifier for the field.</param>
		/// <returns>A string that indicates the status of the field.</returns>
		public static string FieldCssClass(this EditContext editContext, in FieldIdentifier fieldIdentifier)
		{
			throw null;
		}
	}
}
