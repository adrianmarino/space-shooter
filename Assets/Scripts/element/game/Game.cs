using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class Game : GameElement
	{
		//--------------------------------------------------------------
		// Engine Events
		//--------------------------------------------------------------

		void Start ()
		{
			State.Begin (Context);
		}

		void Update ()
		{
			State.Update (Context);
		}

		void OnApplicationQuit ()
		{
			ChangeToFinish ();
		}
	
		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------

		public static Game Instance ()
		{
			return Core.GameElement.Instance<Game> ("Game");
		}

		//--------------------------------------------------------------
		// Public Methods
		//--------------------------------------------------------------

		public void Finish ()
		{
			State.Finish (Context);
		}

		public void ChangeToPlay ()
		{
			State = new Play (this);
		}

		public void ChangeToFinish ()
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
				state.Begin (context);
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

