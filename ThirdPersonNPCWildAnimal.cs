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

		public string nameNPC="Animal";

		public override void Start ()
		{
			base.Start ();
		}

		#region Animationen for Wild Animal
		public void Attack(){
			m_Animator.SetBool("isAttack", true);
		}

		public void StopAttack(){

			m_Animator.SetBool("isAttack", false);
		}

		public void Aggression(){

			//Trigger DialogAnimatin
			m_Animator.SetTrigger("isAggressive");
		}

		public void StopAggression(){
			m_Animator.SetTrigger("isIdle");
		}

		public void Run(){
			m_Animator.SetTrigger("isRun");
		}


		public void Sit(){
			m_Animator.SetTrigger("isSit");
		}

		public void StopSit(){
			m_Animator.SetTrigger("isIdle");
		}
		#endregion

	}
}
