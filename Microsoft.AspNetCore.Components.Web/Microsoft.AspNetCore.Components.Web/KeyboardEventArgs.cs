using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Web
{
	/// <summary>
	/// Supplies information about a keyboard event that is being raised.
	/// </summary>
	public class KeyboardEventArgs : EventArgs
	{
		/// <summary>
		/// The key value of the key represented by the event.
		/// If the value has a printed representation, this attribute's value is the same as the char attribute.
		/// Otherwise, it's one of the key value strings specified in 'Key values'.
		/// If the key can't be identified, this is the string "Unidentified"
		/// </summary>
		public string Key
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
		/// Holds a string that identifies the physical key being pressed.
		/// The value is not affected by the current keyboard layout or modifier state, so a particular key will always return the same value.
		/// </summary>
		public string Code
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
		/// The location of the key on the device.
		/// </summary>
		public float Location
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
		/// true if a key has been depressed long enough to trigger key repetition, otherwise false.
		/// </summary>
		public bool Repeat
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
		/// true if the control key was down when the event was fired. false otherwise.
		/// </summary>
		public bool CtrlKey
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
		/// true if the shift key was down when the event was fired. false otherwise.
		/// </summary>
		public bool ShiftKey
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
		/// true if the alt key was down when the event was fired. false otherwise.
		/// </summary>
		public bool AltKey
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
		/// true if the meta key was down when the event was fired. false otherwise.
		/// </summary>
		public bool MetaKey
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

		public KeyboardEventArgs()
		{
			throw null;
		}
	}
}
