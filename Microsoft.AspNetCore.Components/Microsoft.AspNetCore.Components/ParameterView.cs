using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Represents a collection of parameters supplied to an <see cref="T:Microsoft.AspNetCore.Components.IComponent" />
	/// by its parent in the render tree.
	/// </summary>
	public readonly struct ParameterView
	{
		/// <summary>
		/// An enumerator that iterates through a <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.
		/// </summary>
		public struct Enumerator
		{
			private RenderTreeFrameParameterEnumerator _directParamsEnumerator;

			private CascadingParameterEnumerator _cascadingParameterEnumerator;

			private bool _isEnumeratingDirectParams;

			/// <summary>
			/// Gets the current value of the enumerator.
			/// </summary>
			public ParameterValue Current
			{
				get
				{
					throw null;
				}
			}

			[System.Runtime.CompilerServices.NullableContext(1)]
			internal Enumerator(RenderTreeFrame[] frames, int ownerIndex, IReadOnlyList<CascadingParameterState> cascadingParameters)
			{
				throw null;
			}

			/// <summary>
			/// Instructs the enumerator to move to the next value in the sequence.
			/// </summary>
			/// <returns>A flag to indicate whether or not there is a next value.</returns>
			public bool MoveNext()
			{
				throw null;
			}
		}

		private struct RenderTreeFrameParameterEnumerator
		{
			private readonly RenderTreeFrame[] _frames;

			private readonly int _ownerIndex;

			private readonly int _ownerDescendantsEndIndexExcl;

			private int _currentIndex;

			private ParameterValue _current;

			public ParameterValue Current
			{
				get
				{
					throw null;
				}
			}

			internal RenderTreeFrameParameterEnumerator(RenderTreeFrame[] frames, int ownerIndex)
			{
				throw null;
			}

			public bool MoveNext()
			{
				throw null;
			}
		}

		private struct CascadingParameterEnumerator
		{
			private readonly IReadOnlyList<CascadingParameterState> _cascadingParameters;

			private int _currentIndex;

			private ParameterValue _current;

			public ParameterValue Current
			{
				get
				{
					throw null;
				}
			}

			public CascadingParameterEnumerator(IReadOnlyList<CascadingParameterState> cascadingParameters)
			{
				throw null;
			}

			public bool MoveNext()
			{
				throw null;
			}
		}

		private const string GeneratedParameterViewElementName = "__ARTIFICIAL_PARAMETER_VIEW";

		private static readonly RenderTreeFrame[] _emptyFrames;

		private static readonly ParameterView _empty;

		private readonly ParameterViewLifetime _lifetime;

		private readonly RenderTreeFrame[] _frames;

		private readonly int _ownerIndex;

		private readonly IReadOnlyList<CascadingParameterState> _cascadingParameters;

		/// <summary>
		/// Gets an empty <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.
		/// </summary>
		public static ParameterView Empty
		{
			get
			{
				throw null;
			}
		}

		internal ParameterViewLifetime Lifetime
		{
			get
			{
				throw null;
			}
		}

		internal ParameterView(in ParameterViewLifetime lifetime, RenderTreeFrame[] frames, int ownerIndex)
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through the <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.
		/// </summary>
		/// <returns>The enumerator.</returns>
		public Enumerator GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Gets the value of the parameter with the specified name.
		/// </summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="parameterName">The name of the parameter.</param>
		/// <param name="result">Receives the result, if any.</param>
		/// <returns>True if a matching parameter was found; false otherwise.</returns>
		public bool TryGetValue<TValue>(string parameterName, [MaybeNullWhen(false)] out TValue result)
		{
			throw null;
		}

		/// <summary>
		/// Gets the value of the parameter with the specified name, or a default value
		/// if no such parameter exists in the collection.
		/// </summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="parameterName">The name of the parameter.</param>
		/// <returns>The parameter value if found; otherwise the default value for the specified type.</returns>
		[return: MaybeNull]
		public TValue GetValueOrDefault<TValue>(string parameterName)
		{
			throw null;
		}

		/// <summary>
		/// Gets the value of the parameter with the specified name, or a specified default value
		/// if no such parameter exists in the collection.
		/// </summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="parameterName">The name of the parameter.</param>
		/// <param name="defaultValue">The default value to return if no such parameter exists in the collection.</param>
		/// <returns>The parameter value if found; otherwise <paramref name="defaultValue" />.</returns>
		public TValue GetValueOrDefault<TValue>(string parameterName, TValue defaultValue)
		{
			throw null;
		}

		/// <summary>
		/// Returns a dictionary populated with the contents of the <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.
		/// </summary>
		/// <returns>A dictionary populated with the contents of the <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.</returns>
		public IReadOnlyDictionary<string, object> ToDictionary()
		{
			throw null;
		}

		internal ParameterView WithCascadingParameters(IReadOnlyList<CascadingParameterState> cascadingParameters)
		{
			throw null;
		}

		internal bool DefinitelyEquals(ParameterView oldParameters)
		{
			throw null;
		}

		internal void CaptureSnapshot(ArrayBuilder<RenderTreeFrame> builder)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Components.ParameterView" /> from the given <see cref="T:System.Collections.Generic.IDictionary`2" />.
		/// </summary>
		/// <param name="parameters">The <see cref="T:System.Collections.Generic.IDictionary`2" /> with the parameters.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.</returns>
		public static ParameterView FromDictionary(IDictionary<string, object> parameters)
		{
			throw null;
		}

		/// <summary>
		/// For each parameter property on <paramref name="target" />, updates its value to
		/// match the corresponding entry in the <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />.
		/// </summary>
		/// <param name="target">An object that has a public writable property matching each parameter's name and type.</param>
		public void SetParameterProperties(object target)
		{
			throw null;
		}
	}
}
