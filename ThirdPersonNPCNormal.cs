using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]

	/// <summary>
	/// Third person NPC character. Intefaces werden entsprechend der Animator-Parameter implementiert.
	/// </summary>
	public class ThirdPersonNPCNormal : ThirdPersonNPC, IMovable
	{

		public string nameNPC="Normal";

		public override void Start ()
		{
			base.Start ();
		}


		public void Move(Vector3 move)
		{
			// convert the world relative moveInput vector into a local-relative
			// turn amount and forward amount required to head in the desired
			// direction.
			//if (move.magnitude > 1f) move.Normalize();
			move = transform.InverseTransformDirection(move);
			m_TurnAmount = Mathf.Atan2(move.x, move.z);
			m_ForwardAmount = move.z;

			ApplyExtraTurnRotation();

			// send input and other state parameters to the animator
			UpdateAnimator(move);

		}



	}
}
