namespace Microsoft.AspNetCore.Antiforgery
{
	internal interface IAntiforgeryTokenSerializer
	{
		AntiforgeryToken Deserialize(string serializedToken);

		string Serialize(AntiforgeryToken token);
	}
}
