using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// Provides programmatic configuration for Cors.
	/// </summary>
	public class CorsOptions
	{
		internal IDictionary<string, (CorsPolicy policy, Task<CorsPolicy> policyTask)> PolicyMap
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string DefaultPolicyName
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Adds a new policy and sets it as the default.
		/// </summary>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> policy to be added.</param>
		public void AddDefaultPolicy(CorsPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new policy and sets it as the default.
		/// </summary>
		/// <param name="configurePolicy">A delegate which can use a policy builder to build a policy.</param>
		public void AddDefaultPolicy(Action<CorsPolicyBuilder> configurePolicy)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new policy.
		/// </summary>
		/// <param name="name">The name of the policy.</param>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> policy to be added.</param>
		public void AddPolicy(string name, CorsPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new policy.
		/// </summary>
		/// <param name="name">The name of the policy.</param>
		/// <param name="configurePolicy">A delegate which can use a policy builder to build a policy.</param>
		public void AddPolicy(string name, Action<CorsPolicyBuilder> configurePolicy)
		{
			throw null;
		}

		/// <summary>
		/// Gets the policy based on the <paramref name="name" />
		/// </summary>
		/// <param name="name">The name of the policy to lookup.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> if the policy was added.<c>null</c> otherwise.</returns>
		public CorsPolicy GetPolicy(string name)
		{
			throw null;
		}

		public CorsOptions()
		{
			throw null;
		}
	}
}
