using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal static class ILEmitTrieFactory
	{
		private class Locals
		{
			/// <summary>
			/// Holds current character when processing a character at a time.
			/// </summary>
			public LocalBuilder UInt16Value
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Holds current character when processing 4 characters at a time.
			/// </summary>
			public LocalBuilder UInt64Value
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Used to covert casing. See comments where it's used.
			/// </summary>
			public LocalBuilder UInt64LowerIndicator
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Used to covert casing. See comments where it's used.
			/// </summary>
			public LocalBuilder UInt64UpperIndicator
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Holds a 'ref byte' reference to the current character (in bytes).
			/// </summary>
			public LocalBuilder P
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Holds the relevant portion of the path as a Span[byte].
			/// </summary>
			public LocalBuilder Span
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public Locals(ILGenerator il, bool vectorize)
			{
				throw null;
			}
		}

		private class Labels
		{
			/// <summary>
			/// Label to goto that will return the default destination (not a match).
			/// </summary>
			public Label ReturnDefault
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
			/// Label to goto that will return a sentinel value for non-ascii text.
			/// </summary>
			public Label ReturnNotAscii
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

			public Labels()
			{
				throw null;
			}
		}

		private class Methods
		{
			public static readonly Methods Instance;

			/// <summary>
			/// <see cref="M:System.Runtime.CompilerServices.Unsafe.Add``1(``0@,System.Int32)" /> - Add[ref byte]
			/// </summary>
			public MethodInfo Add
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// <see cref="M:System.Runtime.CompilerServices.Unsafe.As``2(``0@)" /> - As[char, byte]
			/// </summary>
			public MethodInfo As
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// <see cref="M:System.MemoryExtensions.AsSpan(System.String,System.Int32,System.Int32)" />
			/// </summary>
			public MethodInfo AsSpan
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// <see cref="M:System.Runtime.InteropServices.MemoryMarshal.GetReference``1(System.ReadOnlySpan{``0})" /> - GetReference[char]
			/// </summary>
			public MethodInfo GetReference
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// <see cref="M:System.Runtime.CompilerServices.Unsafe.ReadUnaligned``1(System.Byte@)" /> - ReadUnaligned[ulong]
			/// </summary>
			public MethodInfo ReadUnalignedUInt64
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// <see cref="M:System.Runtime.CompilerServices.Unsafe.ReadUnaligned``1(System.Byte@)" /> - ReadUnaligned[ushort]
			/// </summary>
			public MethodInfo ReadUnalignedUInt16
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}
		}

		public const int NotAscii = int.MinValue;

		public static Func<string, int, int, int> Create(int defaultDestination, int exitDestination, (string text, int destination)[] entries, bool? vectorize)
		{
			throw null;
		}

		internal static bool ShouldVectorize((string text, int destination)[] entries)
		{
			throw null;
		}

		public static void EmitReturnDestination(ILGenerator il, (string text, int destination)[] entries)
		{
			throw null;
		}
	}
}
