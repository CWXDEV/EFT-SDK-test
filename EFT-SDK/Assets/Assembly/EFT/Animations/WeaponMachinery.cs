using System;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001F11 RID: 7953
	public abstract class WeaponMachinery : MonoBehaviour
	{
		// Token: 0x0600A485 RID: 42117
		public abstract void SetTransforms(TransformLinks hierarchy);

		// Token: 0x0600A486 RID: 42118
		public abstract void UpdateJoints();

		// Token: 0x0600A487 RID: 42119
		public abstract void OnRotation();
	}
}
