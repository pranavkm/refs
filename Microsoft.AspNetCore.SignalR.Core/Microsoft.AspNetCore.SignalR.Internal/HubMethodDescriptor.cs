using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubMethodDescriptor
	{
		public List<Type> StreamingParameters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ObjectMethodExecutor MethodExecutor
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IReadOnlyList<Type> ParameterTypes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IReadOnlyList<Type> OriginalParameterTypes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Type NonAsyncReturnType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsStreamResponse
		{
			get
			{
				throw null;
			}
		}

		public Type StreamReturnType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IList<IAuthorizeData> Policies
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool HasSyntheticArguments
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HubMethodDescriptor(ObjectMethodExecutor methodExecutor, IEnumerable<IAuthorizeData> policies)
		{
			throw null;
		}

		public IAsyncEnumerable<object> FromReturnedStream(object stream, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
