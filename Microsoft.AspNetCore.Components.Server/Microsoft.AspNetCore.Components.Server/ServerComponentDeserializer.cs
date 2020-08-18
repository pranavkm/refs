using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.Server
{
	internal class ServerComponentDeserializer
	{
		private static class Log
		{
			public static void FailedToDeserializeDescriptor(ILogger<ServerComponentDeserializer> logger, Exception e)
			{
				throw null;
			}

			public static void FailedToFindComponent(ILogger<ServerComponentDeserializer> logger, string assemblyName, string typeName)
			{
				throw null;
			}

			public static void FailedToUnprotectDescriptor(ILogger<ServerComponentDeserializer> logger, Exception e)
			{
				throw null;
			}

			public static void InvalidMarkerType(ILogger<ServerComponentDeserializer> logger, string markerType)
			{
				throw null;
			}

			public static void MissingMarkerDescriptor(ILogger<ServerComponentDeserializer> logger)
			{
				throw null;
			}

			public static void MismatchedInvocationId(ILogger<ServerComponentDeserializer> logger, string invocationId, string currentInvocationId)
			{
				throw null;
			}

			public static void OutOfSequenceDescriptor(ILogger<ServerComponentDeserializer> logger, int lastSequence, int sequence)
			{
				throw null;
			}

			public static void DescriptorSequenceMustStartAtZero(ILogger<ServerComponentDeserializer> logger, int sequence)
			{
				throw null;
			}
		}

		public ServerComponentDeserializer(IDataProtectionProvider dataProtectionProvider, ILogger<ServerComponentDeserializer> logger, ServerComponentTypeCache rootComponentTypeCache, ComponentParameterDeserializer parametersDeserializer)
		{
			throw null;
		}

		public bool TryDeserializeComponentDescriptorCollection(string serializedComponentRecords, out List<ComponentDescriptor> descriptors)
		{
			throw null;
		}
	}
}
