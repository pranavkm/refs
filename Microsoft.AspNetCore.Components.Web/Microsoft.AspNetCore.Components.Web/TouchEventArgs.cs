using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Web
{
	/// <summary>
	/// Supplies information about a touch event that is being raised.
	/// </summary>
	public class TouchEventArgs : EventArgs
	{
		/// <summary>
		/// A count of consecutive clicks that happened in a short amount of time, incremented by one.
		/// </summary>
		public long Detail
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
		/// A list of <see cref="T:Microsoft.AspNetCore.Components.Web.TouchPoint" /> for every point of contact currently touching the surface.
		/// </summary>
		public TouchPoint[] Touches
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
		/// A list of <see cref="T:Microsoft.AspNetCore.Components.Web.TouchPoint" /> for every point of contact that is touching the surface and started on the element that is the target of the current event.
		/// </summary>
		public TouchPoint[] TargetTouches
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
		/// A list of Touches for every point of contact which contributed to the event.
		/// For the touchstart event this must be a list of the touch points that just became active with the current event.
		/// For the touchmove event this must be a list of the touch points that have moved since the last event.
		/// For the touchend and touchcancel events this must be a list of the touch points that have just been removed from the surface.
		/// </summary>
		public TouchPoint[] ChangedTouches
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

		public TouchEventArgs()
		{
			throw null;
		}
	}
}
