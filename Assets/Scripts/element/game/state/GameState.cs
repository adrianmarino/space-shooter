using UnityEngine;

namespace SpaceShooter
{
	public abstract class GameState<GAME, CONTEXT>
	{
		public virtual void Begin (CONTEXT context)
		{
			throw new Error.UnimplementedGameStateBehavior (this, "begin");
		}

		public virtual void Update (CONTEXT context)
		{
		}

		public virtual void Finish (CONTEXT context)
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