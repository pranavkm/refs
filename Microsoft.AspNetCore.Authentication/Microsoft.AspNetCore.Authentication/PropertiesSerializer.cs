using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	public class PropertiesSerializer : IDataSerializer<AuthenticationProperties>
	{
		public static PropertiesSerializer Default
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public virtual byte[] Serialize(AuthenticationProperties model)
		{
			throw null;
		}

		public virtual AuthenticationProperties? Deserialize(byte[] data)
		{
			throw null;
		}

		public virtual void Write(BinaryWriter writer, AuthenticationProperties properties)
		{
			throw null;
		}

		public virtual AuthenticationProperties? Read(BinaryReader reader)
		{
			throw null;
		}

		public PropertiesSerializer()
		{
			throw null;
		}
	}
}
