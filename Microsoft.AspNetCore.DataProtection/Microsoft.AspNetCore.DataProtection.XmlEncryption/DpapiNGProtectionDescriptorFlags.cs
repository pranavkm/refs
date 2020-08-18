using System;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// Flags used to control the creation of protection descriptors.
	/// </summary>
	/// <remarks>
	/// These values correspond to the 'dwFlags' parameter on NCryptCreateProtectionDescriptor.
	/// See https://msdn.microsoft.com/en-us/library/windows/desktop/hh706800(v=vs.85).aspx for more information.
	/// </remarks>
	[Flags]
	public enum DpapiNGProtectionDescriptorFlags
	{
		/// <summary>
		/// No special handling is necessary.
		/// </summary>
		None = 0x0,
		/// <summary>
		/// The provided descriptor is a reference to a full descriptor stored
		/// in the system registry.
		/// </summary>
		NamedDescriptor = 0x1,
		/// <summary>
		/// When combined with <see cref="F:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiNGProtectionDescriptorFlags.NamedDescriptor" />, uses the HKLM registry
		/// instead of the HKCU registry when locating the full descriptor.
		/// </summary>
		MachineKey = 0x20
	}
}
