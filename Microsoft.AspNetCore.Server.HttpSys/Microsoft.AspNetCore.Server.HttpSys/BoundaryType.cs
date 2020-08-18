namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal enum BoundaryType
	{
		None,
		Chunked,
		ContentLength,
		Close,
		PassThrough,
		Invalid
	}
}
