namespace Microsoft.AspNetCore.Server.Kestrel.Core.Features
{
	public interface IHttp2StreamIdFeature
	{
		int StreamId
		{
			get;
		}
	}
}
