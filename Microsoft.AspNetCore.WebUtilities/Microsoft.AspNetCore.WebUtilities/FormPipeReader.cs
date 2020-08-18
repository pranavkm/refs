using Microsoft.Extensions.Primitives;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Used to read an 'application/x-www-form-urlencoded' form.
	/// Internally reads from a PipeReader.
	/// </summary>
	public class FormPipeReader
	{
		/// <summary>
		/// The limit on the number of form values to allow in ReadForm or ReadFormAsync.
		/// </summary>
		public int ValueCountLimit
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
		/// The limit on the length of form keys.
		/// </summary>
		public int KeyLengthLimit
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
		/// The limit on the length of form values.
		/// </summary>
		public int ValueLengthLimit
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

		[System.Runtime.CompilerServices.NullableContext(1)]
		public FormPipeReader(PipeReader pipeReader)
		{
			throw null;
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public FormPipeReader(PipeReader pipeReader, Encoding encoding)
		{
			throw null;
		}

		/// <summary>
		/// Parses an HTTP form body.
		/// </summary>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns>The collection containing the parsed HTTP form body.</returns>
		[AsyncStateMachine(typeof(_003CReadFormAsync_003Ed__26))]
		[DebuggerStepThrough]
		public Task<Dictionary<string, StringValues>> ReadFormAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ParseFormValues(ref ReadOnlySequence<byte> buffer, ref KeyValueAccumulator accumulator, bool isFinalBlock)
		{
			throw null;
		}
	}
}
