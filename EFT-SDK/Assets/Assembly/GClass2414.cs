using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;

// Token: 0x0200221B RID: 8731
public class GClass2414 : GClass2413
{
	// Token: 0x17001DE5 RID: 7653
	// (get) Token: 0x0600B201 RID: 45569 RVA: 0x00002050 File Offset: 0x00000250
	public override Player Player
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B202 RID: 45570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ApplyItem(Item item, EBodyPart bodyPart, float? amount = null)
	{
		throw null;
	}

	// Token: 0x0600B203 RID: 45571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CancelApplyingItem()
	{
		throw null;
	}

	// Token: 0x0600B204 RID: 45572 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PauseAllEffects()
	{
		throw null;
	}

	// Token: 0x0400B6AF RID: 46767
	private readonly ClientPlayer clientPlayer_0;

	// Token: 0x0200221C RID: 8732
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1925
	{
		// Token: 0x0600B205 RID: 45573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GInterface130> hands)
		{
			throw null;
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(Result<GInterface130> hands)
		{
			throw null;
		}

		// Token: 0x0400B6B0 RID: 46768
		public static readonly GClass2414.Class1925 class1925_0;

		// Token: 0x0400B6B1 RID: 46769
		public static Callback<GInterface130> callback_0;

		// Token: 0x0400B6B2 RID: 46770
		public static Callback<GInterface130> callback_1;
	}

	// Token: 0x0200221D RID: 8733
	[CompilerGenerated]
	private sealed class Class1926
	{
		// Token: 0x0600B207 RID: 45575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400B6B3 RID: 46771
		public List<GClass2413.GClass2416> pausedEffects;

		// Token: 0x0400B6B4 RID: 46772
		public List<GStruct344> _pausedEffectsInfo;

		// Token: 0x0400B6B5 RID: 46773
		public GClass2414 gclass2414_0;
	}
}
