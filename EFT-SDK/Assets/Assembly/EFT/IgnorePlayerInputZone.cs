using System;
using System.Runtime.CompilerServices;
using EFT.GlobalEvents;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001896 RID: 6294
	public class IgnorePlayerInputZone : MonoBehaviour
	{
		// Token: 0x0600874C RID: 34636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BaseEventFilter filter, GClass2885 passedEvent)
		{
			throw null;
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(BaseEventFilter filter, GClass2885 passedEvent)
		{
			throw null;
		}

		// Token: 0x04008DB8 RID: 36280
		[SerializeField]
		private BaseEventFilter _setIgnoreInputFilter;

		// Token: 0x04008DB9 RID: 36281
		[SerializeField]
		private BaseEventFilter _giveInputBackFilter;

		// Token: 0x04008DBA RID: 36282
		[SerializeField]
		private bool canRotateHead;
	}
}
