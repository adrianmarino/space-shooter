using UnityEngine;
using System.Collections;
using System;

namespace SpaceShooter
{
	namespace Error
	{
		public class Messages
		{
			public static string UnimplementedGameStateBehavior (object obj, string methodName)
			{
				return "'" + methodName + "' method not implemented on '" + obj.GetType ().Name + "' game state!";
			}
		}

		public class UnimplementedGameStateBehavior : Exception
		{
			public UnimplementedGameStateBehavior (object obj, string methodName) : base (Error.Messages.UnimplementedGameStateBehavior (obj, methodName))
			{
			}
		}
	}
}