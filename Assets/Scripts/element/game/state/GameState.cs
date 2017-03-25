using UnityEngine;

namespace SpaceShooter
{
	public abstract class GameState<GAME, CONTEXT>
	{
		public virtual void begin (CONTEXT context)
		{
			throw new Error.UnimplementedGameStateBehavior (this, "begin");
		}

		public virtual void update (CONTEXT context)
		{
			Debug.Log (Error.Messages.unimplementedGameStateBehavior (this, "update"));
		}

		public virtual void finish (CONTEXT context)
		{
			throw new Error.UnimplementedGameStateBehavior (this, "begin");
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		protected GAME game;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public GameState (GAME game)
		{
			this.game = game;
		}
	}
}