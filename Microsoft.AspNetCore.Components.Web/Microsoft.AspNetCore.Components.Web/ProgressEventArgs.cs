using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Web
{
	/// <summary>
	/// Supplies information about a progress event that is being raised.
	/// </summary>
	public class ProgressEventArgs : EventArgs
	{
		/// <summary>
		/// Whether or not the total size of the transfer is known.
		/// </summary>
		public bool LengthComputable
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
		/// The number of bytes transferred since the beginning of the operation.
		/// This doesn't include headers and other overhead, but only the content itself.
		/// </summary>
		public long Loaded
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
		/// The total number of bytes of content that will be transferred during the operation.
		/// If the total size is unknown, this value is zero.
		/// </summary>
		public long Total
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
		/// Gets or sets the type of the event.
		/// </summary>
		public string Type
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

		public ProgressEventArgs()
		{
			throw null;
		}
	}
}
