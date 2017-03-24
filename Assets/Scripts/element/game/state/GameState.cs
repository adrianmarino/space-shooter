using System;

namespace SpaceShooter
{
	public abstract class GameState<TARGET>
	{
		public virtual void begin ()
		{
			throw new NotImplementedException ();
		}

		public virtual void update ()
		{
		}

		public virtual void finish ()
		{
			throw new NotImplementedException ();
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		protected TARGET target;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public GameState (TARGET target)
		{
			this.target = target;
		}
	}
}