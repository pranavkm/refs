namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	public struct HttpVersionAndMethod
	{
		private ulong _versionAndMethod;

		public HttpVersion Version
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public HttpMethod Method
		{
			get
			{
				throw null;
			}
		}

		public int MethodEnd
		{
			get
			{
				throw null;
			}
		}

		public HttpVersionAndMethod(HttpMethod method, int methodEnd)
		{
			throw null;
		}
	}
}
