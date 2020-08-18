using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.JSInterop.Infrastructure
{
	internal sealed class DotNetObjectReferenceJsonConverterFactory : JsonConverterFactory
	{
		public JSRuntime JSRuntime
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DotNetObjectReferenceJsonConverterFactory(JSRuntime jsRuntime)
		{
			throw null;
		}

		public override bool CanConvert(Type typeToConvert)
		{
			throw null;
		}

		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
		{
			throw null;
		}
	}
}
