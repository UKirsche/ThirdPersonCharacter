using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson{
	public interface IAttackable {
		void Attack();
		void StopAttack();
	}
}