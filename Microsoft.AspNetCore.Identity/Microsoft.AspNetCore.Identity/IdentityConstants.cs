namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Represents all the options you can use to configure the cookies middleware used by the identity system.
	/// </summary>
	public class IdentityConstants
	{
		/// <summary>
		/// The scheme used to identify application authentication cookies.
		/// </summary>
		public static readonly string ApplicationScheme;

		/// <summary>
		/// The scheme used to identify external authentication cookies.
		/// </summary>
		public static readonly string ExternalScheme;

		/// <summary>
		/// The scheme used to identify Two Factor authentication cookies for saving the Remember Me state.
		/// </summary>
		public static readonly string TwoFactorRememberMeScheme;

		/// <summary>
		/// The scheme used to identify Two Factor authentication cookies for round tripping user identities.
		/// </summary>
		public static readonly string TwoFactorUserIdScheme;

		public IdentityConstants()
		{
			throw null;
		}
	}
}
