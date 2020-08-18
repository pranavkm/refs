using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Holds metadata related to a data editing process, such as flags to indicate which
	/// fields have been modified and the current set of validation messages.
	/// </summary>
	public sealed class EditContext
	{
		/// <summary>
		/// Gets the model object for this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
		/// </summary>
		public object Model
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// An event that is raised when a field value changes.
		/// </summary>
		public event EventHandler<FieldChangedEventArgs>? OnFieldChanged
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// An event that is raised when validation is requested.
		/// </summary>
		public event EventHandler<ValidationRequestedEventArgs>? OnValidationRequested
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// An event that is raised when validation state has changed.
		/// </summary>
		public event EventHandler<ValidationStateChangedEventArgs>? OnValidationStateChanged
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
		/// </summary>
		/// <param name="model">The model object for the <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />. This object should hold the data being edited, for example as a set of properties.</param>
		public EditContext(object model)
		{
			throw null;
		}

		/// <summary>
		/// Supplies a <see cref="T:Microsoft.AspNetCore.Components.Forms.FieldIdentifier" /> corresponding to a specified field name
		/// on this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />'s <see cref="P:Microsoft.AspNetCore.Components.Forms.EditContext.Model" />.
		/// </summary>
		/// <param name="fieldName">The name of the editable field.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Components.Forms.FieldIdentifier" /> corresponding to a specified field name on this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />'s <see cref="P:Microsoft.AspNetCore.Components.Forms.EditContext.Model" />.</returns>
		public FieldIdentifier Field(string fieldName)
		{
			throw null;
		}

		/// <summary>
		/// Signals that the value for the specified field has changed.
		/// </summary>
		/// <param name="fieldIdentifier">Identifies the field whose value has been changed.</param>
		public void NotifyFieldChanged(in FieldIdentifier fieldIdentifier)
		{
			throw null;
		}

		/// <summary>
		/// Signals that some aspect of validation state has changed.
		/// </summary>
		public void NotifyValidationStateChanged()
		{
			throw null;
		}

		/// <summary>
		/// Clears any modification flag that may be tracked for the specified field.
		/// </summary>
		/// <param name="fieldIdentifier">Identifies the field whose modification flag (if any) should be cleared.</param>
		public void MarkAsUnmodified(in FieldIdentifier fieldIdentifier)
		{
			throw null;
		}

		/// <summary>
		/// Clears all modification flags within this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
		/// </summary>
		public void MarkAsUnmodified()
		{
			throw null;
		}

		/// <summary>
		/// Determines whether any of the fields in this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" /> have been modified.
		/// </summary>
		/// <returns>True if any of the fields in this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" /> have been modified; otherwise false.</returns>
		public bool IsModified()
		{
			throw null;
		}

		/// <summary>
		/// Gets the current validation messages across all fields.
		///
		/// This method does not perform validation itself. It only returns messages determined by previous validation actions.
		/// </summary>
		/// <returns>The current validation messages.</returns>
		[IteratorStateMachine(typeof(_003CGetValidationMessages_003Ed__20))]
		public IEnumerable<string> GetValidationMessages()
		{
			throw null;
		}

		/// <summary>
		/// Gets the current validation messages for the specified field.
		///
		/// This method does not perform validation itself. It only returns messages determined by previous validation actions.
		/// </summary>
		/// <param name="fieldIdentifier">Identifies the field whose current validation messages should be returned.</param>
		/// <returns>The current validation messages for the specified field.</returns>
		[IteratorStateMachine(typeof(_003CGetValidationMessages_003Ed__21))]
		public IEnumerable<string> GetValidationMessages(FieldIdentifier fieldIdentifier)
		{
			throw null;
		}

		/// <summary>
		/// Gets the current validation messages for the specified field.
		///
		/// This method does not perform validation itself. It only returns messages determined by previous validation actions.
		/// </summary>
		/// <param name="accessor">Identifies the field whose current validation messages should be returned.</param>
		/// <returns>The current validation messages for the specified field.</returns>
		public IEnumerable<string> GetValidationMessages(Expression<Func<object>> accessor)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the specified fields in this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" /> has been modified.
		/// </summary>
		/// <returns>True if the field has been modified; otherwise false.</returns>
		public bool IsModified(in FieldIdentifier fieldIdentifier)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the specified fields in this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" /> has been modified.
		/// </summary>
		/// <param name="accessor">Identifies the field whose current validation messages should be returned.</param>
		/// <returns>True if the field has been modified; otherwise false.</returns>
		public bool IsModified(Expression<Func<object>> accessor)
		{
			throw null;
		}

		/// <summary>
		/// Validates this <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
		/// </summary>
		/// <returns>True if there are no validation messages after validation; otherwise false.</returns>
		public bool Validate()
		{
			throw null;
		}
	}
}
