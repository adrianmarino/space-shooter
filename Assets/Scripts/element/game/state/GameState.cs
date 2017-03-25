using UnityEngine;

namespace SpaceShooter
{
	public abstract class GameState<TARGET>
	{
		public virtual void begin ()
		{
			throw new Error.UnimplementedGameStateBehavior (this, "begin");
		}

		public virtual void update ()
		{
			Debug.Log (Error.Messages.unimplementedGameStateBehavior (this, "update"));
		}

		public virtual void finish ()
		{
			throw new Error.UnimplementedGameStateBehavior (this, "begin");
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