using Microsoft.AspNetCore.Cors.Infrastructure;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cors
{
	/// <inheritdoc />
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class EnableCorsAttribute : Attribute, IEnableCorsAttribute, ICorsMetadata
	{
		/// <inheritdoc />
		public string PolicyName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.Cors.EnableCorsAttribute" /> with the default policy
		/// name defined by <see cref="P:Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions.DefaultPolicyName" />.
		/// </summary>
		public EnableCorsAttribute()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.Cors.EnableCorsAttribute" /> with the supplied policy name.
		/// </summary>
		/// <param name="policyName">The name of the policy to be applied.</param>
		public EnableCorsAttribute(string policyName)
		{
			throw null;
		}
	}
}
