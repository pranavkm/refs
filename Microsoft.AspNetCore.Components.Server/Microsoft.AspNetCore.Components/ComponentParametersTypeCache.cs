using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	internal class ComponentParametersTypeCache
	{
		private struct Key : IEquatable<Key>
		{
			public string Assembly
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public string Type
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public Key(string assembly, string type)
			{
				throw null;
			}

			public override bool Equals(object obj)
			{
				throw null;
			}

			public bool Equals(Key other)
			{
				throw null;
			}

			public override int GetHashCode()
			{
				throw null;
			}
		}

		public Type GetParameterType(string assembly, string type)
		{
			throw null;
		}

		public ComponentParametersTypeCache()
		{
			throw null;
		}
	}
}
