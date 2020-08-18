using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Holds validation messages for an <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
	/// </summary>
	public sealed class ValidationMessageStore
	{
		/// <summary>
		/// Gets the validation messages within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" /> for the specified field.
		///
		/// To get the validation messages across all validation message stores, use <see cref="M:Microsoft.AspNetCore.Components.Forms.EditContext.GetValidationMessages(Microsoft.AspNetCore.Components.Forms.FieldIdentifier)" /> instead
		/// </summary>
		/// <param name="fieldIdentifier">The identifier for the field.</param>
		/// <returns>The validation messages for the specified field within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" />.</returns>
		public IEnumerable<string> this[FieldIdentifier fieldIdentifier]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the validation messages within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" /> for the specified field.
		///
		/// To get the validation messages across all validation message stores, use <see cref="M:Microsoft.AspNetCore.Components.Forms.EditContext.GetValidationMessages(Microsoft.AspNetCore.Components.Forms.FieldIdentifier)" /> instead
		/// </summary>
		/// <param name="accessor">The identifier for the field.</param>
		/// <returns>The validation messages for the specified field within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" />.</returns>
		public IEnumerable<string> this[Expression<Func<object>> accessor]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" />.
		/// </summary>
		/// <param name="editContext">The <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" /> with which this store should be associated.</param>
		public ValidationMessageStore(EditContext editContext)
		{
			throw null;
		}

		/// <summary>
		/// Adds a validation message for the specified field.
		/// </summary>
		/// <param name="fieldIdentifier">The identifier for the field.</param>
		/// <param name="message">The validation message.</param>
		public void Add(in FieldIdentifier fieldIdentifier, string message)
		{
			throw null;
		}

		/// <summary>
		/// Adds a validation message for the specified field.
		/// </summary>
		/// <param name="accessor">Identifies the field for which to add the message.</param>
		/// <param name="message">The validation message.</param>
		public void Add(Expression<Func<object>> accessor, string message)
		{
			throw null;
		}

		/// <summary>
		/// Adds the messages from the specified collection for the specified field.
		/// </summary>
		/// <param name="fieldIdentifier">The identifier for the field.</param>
		/// <param name="messages">The validation messages to be added.</param>
		public void Add(in FieldIdentifier fieldIdentifier, IEnumerable<string> messages)
		{
			throw null;
		}

		/// <summary>
		/// Adds the messages from the specified collection for the specified field.
		/// </summary>
		/// <param name="accessor">Identifies the field for which to add the messages.</param>
		/// <param name="messages">The validation messages to be added.</param>
		public void Add(Expression<Func<object>> accessor, IEnumerable<string> messages)
		{
			throw null;
		}

		/// <summary>
		/// Removes all messages within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" />.
		/// </summary>
		public void Clear()
		{
			throw null;
		}

		/// <summary>
		/// Removes all messages within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" /> for the specified field.
		/// </summary>
		/// <param name="accessor">Identifies the field for which to remove the messages.</param>
		public void Clear(Expression<Func<object>> accessor)
		{
			throw null;
		}

		/// <summary>
		/// Removes all messages within this <see cref="T:Microsoft.AspNetCore.Components.Forms.ValidationMessageStore" /> for the specified field.
		/// </summary>
		/// <param name="fieldIdentifier">The identifier for the field.</param>
		public void Clear(in FieldIdentifier fieldIdentifier)
		{
			throw null;
		}
	}
}
