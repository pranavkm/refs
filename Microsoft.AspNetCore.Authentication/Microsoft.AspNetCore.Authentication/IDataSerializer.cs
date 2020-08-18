using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Authentication
{
	public interface IDataSerializer<TModel>
	{
		byte[] Serialize(TModel model);

		[return: MaybeNull]
		TModel Deserialize(byte[] data);
	}
}
