using System;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027D3 RID: 10195
	[Serializable]
	public class VolumeConnection
	{
		// Token: 0x0400CC5B RID: 52315
		public BetterPropagationVolume Volume;

		// Token: 0x0400CC5C RID: 52316
		public EVolumeRelations Relations;

		// Token: 0x0400CC5D RID: 52317
		[Range(0f, 1f)]
		public float ConnectionAudibility;

		// Token: 0x0400CC5E RID: 52318
		public bool UseManualAudibilitySettings;

		// Token: 0x0400CC5F RID: 52319
		[HideInInspector]
		public EVolumeRelationsMask RelationsMask;
	}
}
