using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	/// <summary>
	/// Provides a custom binary serializer for <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderBatch" /> instances.
	/// This is designed with both server-side and client-side perf in mind:
	///
	///  * Array-like regions always have a fixed size per entry (even if some entry types
	///    don't require as much space as others) so the recipient can index directly.
	///  * The indices describing where field data starts, where each string value starts,
	///    etc., are written *after* that data, so when writing the data we don't have to
	///    compute the locations up front or seek back to an earlier point in the stream.
	///    The recipient can only process the data after reading it all into a buffer,
	///    so it's no disadvantage for the location info to be at the end.
	///  * We only serialize the data that the JS side will need. For example, we don't
	///    emit frame sequence numbers, or any representation of nonstring attribute
	///    values, or component instances, etc.
	///
	/// We don't have or need a .NET reader for this format. We only read it from JS code.
	/// </summary>
	internal class RenderBatchWriter : IDisposable
	{
		[System.Runtime.CompilerServices.NullableContext(1)]
		public RenderBatchWriter(Stream output, bool leaveOpen)
		{
			throw null;
		}

		public void Write(in RenderBatch renderBatch)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
