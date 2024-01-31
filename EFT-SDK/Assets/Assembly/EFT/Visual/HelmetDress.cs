using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A01 RID: 6657
	public class HelmetDress : MonoBehaviour, GInterface104, GInterface105, GInterface106, GInterface152
	{
		// Token: 0x06008D71 RID: 36209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Item item, bool isAnimated)
		{
			throw null;
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 obj)
		{
			throw null;
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 obj)
		{
			throw null;
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAddedOrRemoved(Slot slot, bool isAdded)
		{
			throw null;
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool initial)
		{
			throw null;
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1([CanBeNull] FaceShieldComponent faceShield, bool initial)
		{
			throw null;
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool initial)
		{
			throw null;
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deinit()
		{
			throw null;
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(float x)
		{
			throw null;
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x040093D6 RID: 37846
		public Quaternion OffRotation;

		// Token: 0x040093D7 RID: 37847
		public Quaternion OnRotation;

		// Token: 0x040093D8 RID: 37848
		public Transform HingeTransform;

		// Token: 0x040093D9 RID: 37849
		public HysteresisFilter Filter;

		// Token: 0x040093DA RID: 37850
		private GClass2632 gclass2632_0;

		// Token: 0x040093DB RID: 37851
		private Slot[] slot_0;

		// Token: 0x040093DC RID: 37852
		private IItemOwner iitemOwner_0;

		// Token: 0x040093DD RID: 37853
		private FaceShieldComponent faceShieldComponent_0;

		// Token: 0x040093DE RID: 37854
		private Action action_0;
	}
}
