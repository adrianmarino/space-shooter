using UnityEngine;
using SpaceShooter.Core;
using UnityEngine.UI;

namespace SpaceShooter
{
	public abstract class TextPanel : GameElement
	{
		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public void clean ()
		{
			self ().text = "";
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		protected string Text {
			get { return self ().text; }
			set { self ().text = value; }
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private GUIText self ()
		{
			return GameElement.to<GUIText> (this);
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public TextPanel ()
		{
			Text = "";
		}
	}
}
