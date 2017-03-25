using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class Game : GameElement
	{
		void Start ()
		{
			State.begin (Context);
		}

		void Update ()
		{
			State.update (Context);
		}

		public void Finish ()
		{
			State.finish (Context);
		}

		public void play ()
		{
			State = new Play (this);
		}

		public void finish ()
		{
			State = new Finish (this);
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public GameContext Context {
			get { return context; }
			set { context = value; }
		}

		public GameState<Game, GameContext> State {
			get { 
				if (state == null)
					state = new Initial (this);
				return state;
			}
			set { 
				state = value;
				state.begin (context);
			}
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private GameContext context;

		private GameState<Game, GameContext> state;
	}
}

