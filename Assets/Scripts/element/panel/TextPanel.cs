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

		public void Clean ()
		{
			Value = "";
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		protected string Value {
			get { return Self ().text; }
			set { Self ().text = value; }
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private GUIText Self ()
		{
			return GameElement.To<GUIText> (this);
		}
	}
}
