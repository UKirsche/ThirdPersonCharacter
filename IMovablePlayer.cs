using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson{

	/// <summary>
	/// Interface gibt Paramter zur CharacterSteuerung mit an
	/// </summary>
	public interface IMovablePlayer {
		void Move(Vector3 move, bool crouch, bool jump);
	}
}
