using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x0200023C RID: 572
public class GClass345
{
	// Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPerson(IPlayer gamePerson)
	{
		throw null;
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(IPlayer gamePerson)
	{
		throw null;
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass346 GetClosest(IPlayer gamePerson)
	{
		throw null;
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GClass346> GetClosest(IPlayer gamePerson, float dist)
	{
		throw null;
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BotOwner boss)
	{
		throw null;
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass346 botsPairData, BotOwner boss)
	{
		throw null;
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(BotOwner follower, BotOwner boss, FollowerStatusChange status)
	{
		throw null;
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x04000B88 RID: 2952
	private const float float_0 = 2f;

	// Token: 0x04000B89 RID: 2953
	private Dictionary<BotOwner, List<BotOwner>> dictionary_0;

	// Token: 0x04000B8A RID: 2954
	private GClass551.GInterface13 ginterface13_0;

	// Token: 0x04000B8B RID: 2955
	private readonly Dictionary<IPlayer, Dictionary<IPlayer, GClass346>> dictionary_1;

	// Token: 0x04000B8C RID: 2956
	private readonly List<GClass346> list_0;

	// Token: 0x04000B8D RID: 2957
	private readonly HashSet<IPlayer> hashSet_0;

	// Token: 0x04000B8E RID: 2958
	private bool bool_0;

	// Token: 0x04000B8F RID: 2959
	private bool bool_1;

	// Token: 0x0200023D RID: 573
	[CompilerGenerated]
	private sealed class Class136
	{
		// Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(BotOwner follower, FollowerStatusChange status)
		{
			throw null;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(BotOwner owner)
		{
			throw null;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(BotOwner follower, FollowerStatusChange b)
		{
			throw null;
		}

		// Token: 0x04000B90 RID: 2960
		public BotOwner bot;

		// Token: 0x04000B91 RID: 2961
		public GClass345 gclass345_0;

		// Token: 0x04000B92 RID: 2962
		public Action<BotOwner, FollowerStatusChange> action_0;
	}
}
