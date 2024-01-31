using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.Interactive;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000D36 RID: 3382
public sealed class GClass972 : Singleton<GClass972>
{
	// Token: 0x060047F0 RID: 18416 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterPropagationVolume GetPlayerCurrentPropagationVolume()
	{
		throw null;
	}

	// Token: 0x060047F1 RID: 18417 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPlayerCurrentPropagationVolume(BetterPropagationVolume volume)
	{
		throw null;
	}

	// Token: 0x060047F2 RID: 18418 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlayerCurrentVolume(BetterPropagationVolume volume)
	{
		throw null;
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterVolume(BetterPropagationVolume volume)
	{
		throw null;
	}

	// Token: 0x060047F4 RID: 18420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveVolume(BetterPropagationVolume volume)
	{
		throw null;
	}

	// Token: 0x060047F5 RID: 18421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterGroup(BetterPropagationGroups group)
	{
		throw null;
	}

	// Token: 0x060047F6 RID: 18422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayersInDifferentVolumes(Player listenerPlayer, Player sourcePlayer)
	{
		throw null;
	}

	// Token: 0x060047F7 RID: 18423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(List<BetterPropagationVolume> listenerVolumes, List<BetterPropagationVolume> sourceVolumes)
	{
		throw null;
	}

	// Token: 0x060047F8 RID: 18424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPositionsInDifferentVolume(Vector3 firstPos, Vector3 secondPos)
	{
		throw null;
	}

	// Token: 0x060047F9 RID: 18425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerAndSourceInSameVolume(Vector3 sourcePos)
	{
		throw null;
	}

	// Token: 0x060047FA RID: 18426 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterPropagationVolume GetVolumeByPosition(Vector3 position)
	{
		throw null;
	}

	// Token: 0x060047FB RID: 18427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BetterPropagationVolume> GetVolumesByPosition(Vector3 position)
	{
		throw null;
	}

	// Token: 0x060047FC RID: 18428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3 position, List<BetterPropagationVolume> volumesBuffer)
	{
		throw null;
	}

	// Token: 0x060047FD RID: 18429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Vector3 position, BetterPropagationVolume propagationVolume)
	{
		throw null;
	}

	// Token: 0x060047FE RID: 18430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Vector3 position, List<BetterPropagationVolume> volumesBuffer)
	{
		throw null;
	}

	// Token: 0x060047FF RID: 18431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BetterPropagationVolume> GetAdjustedAndIsolatedVolumes(Vector3 position, List<BetterPropagationVolume> volumesBuffer)
	{
		throw null;
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BetterPropagationVolume> GetIsolatedVolumes()
	{
		throw null;
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(string errorCaption, BetterPropagationVolume vol, Vector3 position)
	{
		throw null;
	}

	// Token: 0x040052C5 RID: 21189
	private readonly List<BetterPropagationVolume> list_0;

	// Token: 0x040052C6 RID: 21190
	private readonly List<BetterPropagationVolume> list_1;

	// Token: 0x040052C7 RID: 21191
	private readonly List<BetterPropagationVolume> list_2;

	// Token: 0x040052C8 RID: 21192
	private readonly List<BetterPropagationVolume> list_3;

	// Token: 0x040052C9 RID: 21193
	private readonly List<BetterPropagationVolume> list_4;

	// Token: 0x040052CA RID: 21194
	private static bool bool_0;

	// Token: 0x040052CB RID: 21195
	private BetterPropagationGroups betterPropagationGroups_0;

	// Token: 0x02000D37 RID: 3383
	[CompilerGenerated]
	private sealed class Class680
	{
		// Token: 0x06004802 RID: 18434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BetterPropagationVolume volume)
		{
			throw null;
		}

		// Token: 0x040052CC RID: 21196
		public Vector3 firstPos;

		// Token: 0x040052CD RID: 21197
		public Vector3 secondPos;
	}

	// Token: 0x02000D38 RID: 3384
	[CompilerGenerated]
	[Serializable]
	private sealed class Class681
	{
		// Token: 0x06004803 RID: 18435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(BetterPropagationVolume x)
		{
			throw null;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(BetterPropagationVolume x)
		{
			throw null;
		}

		// Token: 0x040052CE RID: 21198
		public static readonly GClass972.Class681 class681_0;

		// Token: 0x040052CF RID: 21199
		public static Func<BetterPropagationVolume, string> func_0;

		// Token: 0x040052D0 RID: 21200
		public static Func<BetterPropagationVolume, string> func_1;
	}
}
