using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	public class HttpRequestStreamReader : TextReader
	{
		private readonly struct ReadLineStepResult
		{
			public static readonly ReadLineStepResult Done;

			public static readonly ReadLineStepResult Continue;

			public bool Completed
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public string? Result
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public static ReadLineStepResult FromResult(string value)
			{
				throw null;
			}
		}

		public HttpRequestStreamReader(Stream stream, Encoding encoding)
		{
			throw null;
		}

		public HttpRequestStreamReader(Stream stream, Encoding encoding, int bufferSize)
		{
			throw null;
		}

		public HttpRequestStreamReader(Stream stream, Encoding encoding, int bufferSize, ArrayPool<byte> bytePool, ArrayPool<char> charPool)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		public override int Peek()
		{
			throw null;
		}

		public override int Read()
		{
			throw null;
		}

		public override int Read(char[] buffer, int index, int count)
		{
			throw null;
		}

		public override int Read(Span<char> buffer)
		{
			throw null;
		}

		public override Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__25))]
		[DebuggerStepThrough]
		public override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadLineAsync_003Ed__26))]
		[DebuggerStepThrough]
		public override Task<string?> ReadLineAsync()
		{
			throw null;
		}

		public override string? ReadLine()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadToEndAsync_003Ed__31))]
		[DebuggerStepThrough]
		public override Task<string> ReadToEndAsync()
		{
			throw null;
		}
	}
}
