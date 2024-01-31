using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010E4 RID: 4324
	public abstract class Poser : MonoBehaviour
	{
		// Token: 0x06005B40 RID: 23360
		public abstract void AutoMapping();

		// Token: 0x06005B41 RID: 23361
		public abstract void StoreDefaultState();

		// Token: 0x06005B42 RID: 23362
		public abstract void FixTransforms();

		// Token: 0x040066BA RID: 26298
		public Transform poseRoot;

		// Token: 0x040066BB RID: 26299
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040066BC RID: 26300
		[Range(0f, 1f)]
		public float localRotationWeight;

		// Token: 0x040066BD RID: 26301
		[Range(0f, 1f)]
		public float localPositionWeight;

		// Token: 0x040066BE RID: 26302
		public bool fixTransforms;
	}
}
