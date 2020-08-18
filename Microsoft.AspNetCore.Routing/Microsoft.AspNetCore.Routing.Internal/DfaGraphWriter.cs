using System;
using System.IO;

namespace Microsoft.AspNetCore.Routing.Internal
{
	/// <summary>
	/// <para>
	/// A singleton service that can be used to write the route table as a state machine
	/// in GraphViz DOT language https://www.graphviz.org/doc/info/lang.html
	/// </para>
	/// <para>
	/// You can use http://www.webgraphviz.com/ to visualize the results.
	/// </para>
	/// <para>
	/// This type has no support contract, and may be removed or changed at any time in
	/// a future release.
	/// </para>
	/// </summary>
	public class DfaGraphWriter
	{
		public DfaGraphWriter(IServiceProvider services)
		{
			throw null;
		}

		public void Write(EndpointDataSource dataSource, TextWriter writer)
		{
			throw null;
		}
	}
}
