using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.Server
{
	internal class ComponentParameterDeserializer
	{
		private static class Log
		{
			internal static void ParameterValuesInvalidFormat(ILogger<ComponentParameterDeserializer> logger)
			{
				throw null;
			}

			internal static void IncompleteParameterDefinition(ILogger<ComponentParameterDeserializer> logger, string name, string typeName, string assembly)
			{
				throw null;
			}

			internal static void InvalidParameterType(ILogger<ComponentParameterDeserializer> logger, string name, string assembly, string typeName)
			{
				throw null;
			}

			internal static void InvalidParameterValue(ILogger<ComponentParameterDeserializer> logger, string name, string typeName, string assembly, Exception e)
			{
				throw null;
			}

			internal static void FailedToParseParameterDefinitions(ILogger<ComponentParameterDeserializer> logger, Exception e)
			{
				throw null;
			}

			internal static void FailedToParseParameterValues(ILogger<ComponentParameterDeserializer> logger, Exception e)
			{
				throw null;
			}

			internal static void MismatchedParameterAndDefinitions(ILogger<ComponentParameterDeserializer> logger, int definitionsLength, int valuesLength)
			{
				throw null;
			}

			internal static void MissingParameterDefinitionName(ILogger<ComponentParameterDeserializer> logger)
			{
				throw null;
			}
		}

		public ComponentParameterDeserializer(ILogger<ComponentParameterDeserializer> logger, ComponentParametersTypeCache parametersCache)
		{
			throw null;
		}

		public bool TryDeserializeParameters(IList<ComponentParameter> parametersDefinitions, IList<object> parameterValues, out ParameterView parameters)
		{
			throw null;
		}
	}
}
