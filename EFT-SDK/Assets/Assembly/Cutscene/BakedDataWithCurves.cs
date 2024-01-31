using System;
using System.Collections.Generic;
using uLipSync;
using UnityEngine;

namespace Cutscene
{
	// Token: 0x02000CA1 RID: 3233
	[CreateAssetMenu(menuName = "uLipSync/Backed data with curves")]
	public class BakedDataWithCurves : BakedData
	{
		// Token: 0x0400503E RID: 20542
		[SerializeField]
		public List<BakedDataWithCurves.CurveData> curves;

		// Token: 0x02000CA2 RID: 3234
		[Serializable]
		public class CurveData
		{
			// Token: 0x0400503F RID: 20543
			public bool isBlendShape;

			// Token: 0x04005040 RID: 20544
			public int blendShapeIndex;

			// Token: 0x04005041 RID: 20545
			public string paramName;

			// Token: 0x04005042 RID: 20546
			public AnimationCurve curve;

			// Token: 0x04005043 RID: 20547
			public float resetValue;
		}
	}
}
