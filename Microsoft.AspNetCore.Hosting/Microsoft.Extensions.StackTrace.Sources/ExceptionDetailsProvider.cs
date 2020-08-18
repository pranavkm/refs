using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.StackTrace.Sources
{
	internal class ExceptionDetailsProvider
	{
		public ExceptionDetailsProvider(IFileProvider fileProvider, ILogger logger, int sourceCodeLineCount)
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CGetDetails_003Ed__4))]
		public IEnumerable<ExceptionDetails> GetDetails(Exception exception)
		{
			throw null;
		}

		internal StackFrameSourceCodeInfo GetStackFrameSourceCodeInfo(string method, string filePath, int lineNumber)
		{
			throw null;
		}

		internal void ReadFrameContent(StackFrameSourceCodeInfo frame, IEnumerable<string> allLines, int errorStartLineNumberInFile, int errorEndLineNumberInFile)
		{
			throw null;
		}
	}
}
