using System;
using System.Collections.Generic;
using EFT;
using EFT.Hideout;
using UnityEngine;

namespace UI.Hideout
{
	// Token: 0x02000C6C RID: 3180
	[Serializable]
	public class QteHandleData : QteData
	{
		// Token: 0x04004F39 RID: 20281
		[SerializeField]
		public Vector3 PlayerPosition;

		// Token: 0x04004F3A RID: 20282
		[SerializeField]
		public Vector3 PlayerRotation;

		// Token: 0x04004F3B RID: 20283
		[SerializeField]
		[Space(10f)]
		public List<QteHandleData.PropsData> Props;

		// Token: 0x04004F3C RID: 20284
		[SerializeField]
		[Space(10f)]
		public RuntimeAnimatorController HideoutAnimatorController;

		// Token: 0x04004F3D RID: 20285
		[Space(10f)]
		public Dictionary<string, SoundBank> Sounds;

		// Token: 0x02000C6D RID: 3181
		public enum EPropsTarget
		{
			// Token: 0x04004F3F RID: 20287
			LeftPalm,
			// Token: 0x04004F40 RID: 20288
			RightPalm
		}

		// Token: 0x02000C6E RID: 3182
		[Serializable]
		public class PropsVariantData : QteHandleData.PropsData
		{
			// Token: 0x04004F41 RID: 20289
			public int Trigger;
		}

		// Token: 0x02000C6F RID: 3183
		[Serializable]
		public class PropsData
		{
			// Token: 0x04004F42 RID: 20290
			public QteHandleData.EPropsTarget Target;

			// Token: 0x04004F43 RID: 20291
			public GameObject Prefab;

			// Token: 0x04004F44 RID: 20292
			public Vector3 Position;

			// Token: 0x04004F45 RID: 20293
			public Vector3 Rotation;
		}
	}
}
