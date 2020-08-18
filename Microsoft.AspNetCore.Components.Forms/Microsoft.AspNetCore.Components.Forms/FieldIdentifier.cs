using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// Uniquely identifies a single field that can be edited. This may correspond to a property on a
	/// model object, or can be any other named value.
	/// </summary>
	public readonly struct FieldIdentifier : IEquatable<FieldIdentifier>
	{
		/// <summary>
		/// Gets the object that owns the editable field.
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
		/// Gets the name of the editable field.
		/// </summary>
		public string FieldName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Components.Forms.FieldIdentifier" /> structure.
		/// </summary>
		/// <param name="accessor">An expression that identifies an object member.</param>
		/// <typeparam name="TField">The field <see cref="T:System.Type" />.</typeparam>
		public static FieldIdentifier Create<TField>(Expression<Func<TField>> accessor)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Components.Forms.FieldIdentifier" /> structure.
		/// </summary>
		/// <param name="model">The object that owns the field.</param>
		/// <param name="fieldName">The name of the editable field.</param>
		public FieldIdentifier(object model, string fieldName)
		{
			throw null;
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			throw null;
		}

		/// <inheritdoc />
		public override bool Equals(object? obj)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool Equals(FieldIdentifier otherIdentifier)
		{
			throw null;
		}
	}
}
