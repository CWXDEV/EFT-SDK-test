using System;
using UnityEngine;

// Token: 0x02000B66 RID: 2918
public class SpotLightFakeGI : MonoBehaviour
{
	// Token: 0x04004723 RID: 18211
	public float GILightOffsetA;

	// Token: 0x04004724 RID: 18212
	public float GILightOffsetB;

	// Token: 0x04004725 RID: 18213
	public float GILightScale;

	// Token: 0x04004726 RID: 18214
	public float GILightIntensity;

	// Token: 0x04004727 RID: 18215
	public LayerMask CheckLayerMask;

	// Token: 0x04004728 RID: 18216
	public SpotLightFakeGI.Circle[] CheckCircles;

	// Token: 0x04004729 RID: 18217
	public AnimationCurve GIIntensityByDistanceMultyplier;

	// Token: 0x02000B67 RID: 2919
	[Serializable]
	public class Circle
	{
		// Token: 0x0400472A RID: 18218
		[Range(0f, 1f)]
		public float Radius;

		// Token: 0x0400472B RID: 18219
		public int Count;
	}
}
