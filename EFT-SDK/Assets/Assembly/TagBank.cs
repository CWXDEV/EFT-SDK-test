using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200076C RID: 1900
public class TagBank : ScriptableObject
{
	// Token: 0x06002CA0 RID: 11424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TaggedClip Match(ETagStatus combat = ETagStatus.Unaware | ETagStatus.Aware | ETagStatus.Combat, ETagStatus speakerGroup = ETagStatus.Solo | ETagStatus.Coop, ETagStatus targetGroup = ETagStatus.TargetSolo | ETagStatus.TargetMultiple, ETagStatus health = ETagStatus.Healthy | ETagStatus.Injured | ETagStatus.BadlyInjured | ETagStatus.Dying, ETagStatus side = ETagStatus.Bear | ETagStatus.Usec | ETagStatus.Scav, ETagStatus exUsecBoss = ETagStatus.Birdeye | ETagStatus.Knight | ETagStatus.BigPipe)
	{
		throw null;
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TaggedClip Match(int mask)
	{
		throw null;
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValidate()
	{
		throw null;
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Compare(int mask1, int @event)
	{
		throw null;
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetBits(int mask, int offset, int width)
	{
		throw null;
	}

	// Token: 0x04002B4D RID: 11085
	public EPhraseTrigger Trigger;

	// Token: 0x04002B4E RID: 11086
	public SpreadGroup[] SpreadGroups;

	// Token: 0x04002B4F RID: 11087
	public TaggedClip[] Clips;

	// Token: 0x04002B50 RID: 11088
	public Chain ChainEvent;

	// Token: 0x04002B51 RID: 11089
	public static int[] Sizes;

	// Token: 0x04002B52 RID: 11090
	public int Importance;

	// Token: 0x04002B53 RID: 11091
	public float Blocker;

	// Token: 0x04002B54 RID: 11092
	public bool IgnoreTags;

	// Token: 0x04002B55 RID: 11093
	private List<TaggedClip> list_0;

	// Token: 0x04002B56 RID: 11094
	private List<TaggedClip> list_1;

	// Token: 0x0200076D RID: 1901
	[CompilerGenerated]
	[Serializable]
	private sealed class Class388
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<TaggedClip> method_0(SpreadGroup g)
		{
			throw null;
		}

		// Token: 0x04002B57 RID: 11095
		public static readonly TagBank.Class388 class388_0;

		// Token: 0x04002B58 RID: 11096
		public static Func<SpreadGroup, IEnumerable<TaggedClip>> func_0;
	}
}
