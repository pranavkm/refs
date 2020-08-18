namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal enum SslStatus : byte
	{
		Insecure,
		NoClientCert,
		ClientCert
	}
}
