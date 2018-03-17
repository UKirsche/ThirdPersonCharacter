using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]

	/// <summary>
	/// Third person NPC character. Intefaces werden entsprechend der Animator-Parameter implementiert.
	/// </summary>
	public class ThirdPersonNPCWildAnimal : ThirdPersonNPC, ISitable
	{

		public string nameNPC="Normal";

		public override void Start ()
		{
			base.Start ();
		}


		/// <summary>
		/// Talk for n-Seconds, where n is random
		/// </summary>
		public void Sit(){

			//stopMovingAnimation
			Move (Vector3.zero);
			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isSitting");
		}

		/// <summary>
		/// Talk for n-Seconds, where n is random
		/// </summary>
		public void StopSit(){

			//Trigger DialogAnimatin
			m_Animator.SetBool("isSitting",false);
		}


	}
}
