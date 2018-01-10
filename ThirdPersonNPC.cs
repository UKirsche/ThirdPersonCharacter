using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.ThirdPerson{
	

	public class ThirdPersonNPC : MonoBehaviour, IUpdateAnimatorMove, IUpdateAnimatorStop {

		[Range(1f, 4f)][SerializeField] protected float m_GravityMultiplier = 2f;
		[SerializeField] float m_MovingTurnSpeed = 360;
		[SerializeField] float m_StationaryTurnSpeed = 180;
		[SerializeField] float m_AnimSpeedMultiplier = 1f;

		protected const float k_Half = 0.5f;
		protected float m_TurnAmount;
		public float m_ForwardAmount;

		protected Rigidbody m_Rigidbody;
		protected Animator m_Animator;


		public virtual void Start()
		{
			m_Animator = GetComponent<Animator>();
			m_Rigidbody = GetComponent<Rigidbody>();
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
		}
			


		#region Interface-Implementations AnimationController
		public void updateAnimatorMove ()
		{
			m_Animator.SetFloat ("Forward", m_ForwardAmount);
		}

		public void updateAnimatorStop ()
		{
			m_Animator.SetFloat ("Forward", 0.0f);
		}

		public void updateAnimatorSpeed (Vector3 move)
		{
			// the anim speed multiplier allows the overall speed of walking/running to be tweaked in the inspector,
			// which affects the movement speed because of the root motion.
			if (move.magnitude > 0) {
				m_Animator.speed = m_AnimSpeedMultiplier;
			}
			else {
				// don't use that while airborne
				m_Animator.speed = 1;
			}
		}
		#endregion



		/// <summary>
		/// Updates the animator.
		/// </summary>
		/// <param name="move">Move.</param>
		public void UpdateAnimator(Vector3 move)
		{
			// update the animator parameters
			updateAnimatorMove ();
			updateAnimatorSpeed (move);
		}


		protected void ApplyExtraTurnRotation()
		{
			// help the character turn faster (this is in addition to root rotation in the animation)
			float turnSpeed = Mathf.Lerp(m_StationaryTurnSpeed, m_MovingTurnSpeed, m_ForwardAmount);
			transform.Rotate(0, m_TurnAmount * turnSpeed * Time.deltaTime, 0);
		}
	}
}
