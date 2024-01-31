using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x020019FF RID: 6655
	public class FoldableStockView : MonoBehaviour, GInterface152
	{
		// Token: 0x06008D6E RID: 36206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Item item, bool isAnimated)
		{
			throw null;
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deinit()
		{
			throw null;
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x040093CF RID: 37839
		[SerializeField]
		private FoldableStockView.BonePosition[] _bonePositions;

		// Token: 0x040093D0 RID: 37840
		private FoldableComponent foldableComponent_0;

		// Token: 0x040093D1 RID: 37841
		private Action action_0;

		// Token: 0x02001A00 RID: 6656
		[Serializable]
		public class BonePosition
		{
			// Token: 0x040093D2 RID: 37842
			public string BoneName;

			// Token: 0x040093D3 RID: 37843
			public Transform Bone;

			// Token: 0x040093D4 RID: 37844
			public Quaternion FoldedRotation;

			// Token: 0x040093D5 RID: 37845
			public Quaternion UnfoldedRotation;
		}
	}
}
