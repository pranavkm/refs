using Microsoft.Extensions.Primitives;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Used to read an 'application/x-www-form-urlencoded' form.
	/// </summary>
	public class FormReader : IDisposable
	{
		public const int DefaultValueCountLimit = 1024;

		public const int DefaultKeyLengthLimit = 2048;

		public const int DefaultValueLengthLimit = 4194304;

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

		public FormReader(string data)
		{
			throw null;
		}

		public FormReader(string data, ArrayPool<char> charPool)
		{
			throw null;
		}

		public FormReader(Stream stream)
		{
			throw null;
		}

		public FormReader(Stream stream, Encoding encoding)
		{
			throw null;
		}

		public FormReader(Stream stream, Encoding encoding, ArrayPool<char> charPool)
		{
			throw null;
		}

		/// <summary>
		/// Reads the next key value pair from the form.
		/// For unbuffered data use the async overload instead.
		/// </summary>
		/// <returns>The next key value pair, or null when the end of the form is reached.</returns>
		public KeyValuePair<string, string>? ReadNextPair()
		{
			throw null;
		}

		/// <summary>
		/// Asynchronously reads the next key value pair from the form.
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns>The next key value pair, or null when the end of the form is reached.</returns>
		[AsyncStateMachine(typeof(_003CReadNextPairAsync_003Ed__33))]
		[DebuggerStepThrough]
		public Task<KeyValuePair<string, string>?> ReadNextPairAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Parses text from an HTTP form body.
		/// </summary>
		/// <returns>The collection containing the parsed HTTP form body.</returns>
		public Dictionary<string, StringValues> ReadForm()
		{
			throw null;
		}

		/// <summary>
		/// Parses an HTTP form body.
		/// </summary>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns>The collection containing the parsed HTTP form body.</returns>
		[AsyncStateMachine(typeof(_003CReadFormAsync_003Ed__43))]
		[DebuggerStepThrough]
		public Task<Dictionary<string, StringValues>> ReadFormAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
