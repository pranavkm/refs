namespace Microsoft.AspNetCore.Diagnostics
{
	public interface IStatusCodeReExecuteFeature
	{
		string OriginalPathBase
		{
			get;
			set;
		}

		string OriginalPath
		{
			get;
			set;
		}

		string OriginalQueryString
		{
			get;
			set;
		}
	}
}
