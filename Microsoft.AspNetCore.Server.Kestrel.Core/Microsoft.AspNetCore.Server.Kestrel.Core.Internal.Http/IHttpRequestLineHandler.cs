using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	public interface IHttpRequestLineHandler
	{
		void OnStartLine(HttpVersionAndMethod versionAndMethod, TargetOffsetPathLength targetPath, Span<byte> startLine);
	}
}
