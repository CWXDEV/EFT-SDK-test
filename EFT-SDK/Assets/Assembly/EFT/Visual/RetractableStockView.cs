using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A08 RID: 6664
	public class RetractableStockView : MonoBehaviour, GInterface152
	{
		// Token: 0x06008D98 RID: 36248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Item item, bool isAnimated)
		{
			throw null;
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deinit()
		{
			throw null;
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x040093F0 RID: 37872
		[SerializeField]
		private RetractableStockView.BonePosition[] _bonePositions;

		// Token: 0x040093F1 RID: 37873
		private FoldableComponent foldableComponent_0;

		// Token: 0x040093F2 RID: 37874
		private Action action_0;

		// Token: 0x02001A09 RID: 6665
		[Serializable]
		public struct BonePosition
		{
			// Token: 0x040093F3 RID: 37875
			public string BoneName;

			// Token: 0x040093F4 RID: 37876
			public Transform Bone;

			// Token: 0x040093F5 RID: 37877
			public Vector3 RetractedPosition;

			// Token: 0x040093F6 RID: 37878
			public Vector3 NormalPosition;
		}
	}
}
