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
	public class ThirdPersonNPCWildAnimal : ThirdPersonNPC, ISitable, IAttackable, IAggressive
	{

		public string nameNPC="Normal";

		public override void Start ()
		{
			base.Start ();
		}

		#region Interfaces for Wild Animal
		/// <summary>
		/// Attack
		/// </summary>
		public void Attack(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isAttack");
		}

		/// <summary>
		/// Stop Attack Animation
		/// </summary>
		public void StopAttack(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isIdle");
		}

		public void Aggression(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isAttack");
		}

		/// <summary>
		/// Stop Attack Animation
		/// </summary>
		public void StopAggression(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isIdle");
		}

		/// <summary>
		/// Play Sit Animation
		/// </summary>
		public void Sit(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isSit");
		}

		/// <summary>
		/// Stop Sit Animation
		/// </summary>
		public void StopSit(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isIdle");
		}
		#endregion

	}
}
