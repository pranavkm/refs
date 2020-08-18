using System;
using System.Text.Json;

namespace Microsoft.AspNetCore.Components
{
	internal static class ServerComponentSerializationSettings
	{
		public const string DataProtectionProviderPurpose = "Microsoft.AspNetCore.Components.ComponentDescriptorSerializer,V1";

		public static readonly JsonSerializerOptions JsonSerializationOptions;

		public static readonly TimeSpan DataExpiration;
	}
}
