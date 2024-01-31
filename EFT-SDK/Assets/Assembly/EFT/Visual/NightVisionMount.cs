using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A07 RID: 6663
	public class NightVisionMount : MonoBehaviour, GInterface104, GInterface105, GInterface106, GInterface152
	{
		// Token: 0x06008D8F RID: 36239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Item item, bool isAnimated)
		{
			throw null;
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 obj)
		{
			throw null;
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 obj)
		{
			throw null;
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAddedOrRemoved(Slot slot, bool isAdded)
		{
			throw null;
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool initial)
		{
			throw null;
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1([CanBeNull] TogglableComponent togglableComponent, bool initial)
		{
			throw null;
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool initial)
		{
			throw null;
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deinit()
		{
			throw null;
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x040093EA RID: 37866
		[SerializeField]
		private CurveRotator _rotator;

		// Token: 0x040093EB RID: 37867
		private Item item_0;

		// Token: 0x040093EC RID: 37868
		private Slot[] slot_0;

		// Token: 0x040093ED RID: 37869
		private IItemOwner iitemOwner_0;

		// Token: 0x040093EE RID: 37870
		private TogglableComponent togglableComponent_0;

		// Token: 0x040093EF RID: 37871
		private Action action_0;
	}
}
