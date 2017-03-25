using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class Game : GameElement
	{
		//--------------------------------------------------------------
		// Rendering Methods
		//--------------------------------------------------------------

		void Start ()
		{
			State.begin (Context);
		}

		void Update ()
		{
			State.update (Context);
		}

		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------

		public static Game Instance ()
		{
			return Core.GameElement.instance<Game> ("Game");
		}

		//--------------------------------------------------------------
		// Public Methods
		//--------------------------------------------------------------

		public void Finish ()
		{
			State.finish (Context);
		}

		public void changeToPlay ()
		{
			State = new Play (this);
		}

		public void changeToFinish ()
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

