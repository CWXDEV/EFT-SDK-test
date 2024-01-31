using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x02002696 RID: 9878
public static class GClass2920
{
	// Token: 0x0600C3DA RID: 50138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<IPlayer> GroupPlayers(this IEnumerable<IPlayer> persons, [CanBeNull] string groupId = null, [CanBeNull] string teamId = null)
	{
		throw null;
	}

	// Token: 0x0600C3DB RID: 50139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<IPlayer> Except(this IEnumerable<IPlayer> persons, [CanBeNull] IPlayer exceptPerson = null)
	{
		throw null;
	}

	// Token: 0x0600C3DC RID: 50140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<IPlayer> ExceptAI(this IEnumerable<IPlayer> persons)
	{
		throw null;
	}

	// Token: 0x0600C3DD RID: 50141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<IPlayer> CarePlayers(this IEnumerable<IPlayer> persons)
	{
		throw null;
	}

	// Token: 0x02002697 RID: 9879
	[CompilerGenerated]
	private sealed class Class2205
	{
		// Token: 0x0600C3DE RID: 50142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IPlayer person)
		{
			throw null;
		}

		// Token: 0x0400C5BF RID: 50623
		public string groupId;

		// Token: 0x0400C5C0 RID: 50624
		public string teamId;
	}

	// Token: 0x02002698 RID: 9880
	[CompilerGenerated]
	private sealed class Class2206
	{
		// Token: 0x0600C3DF RID: 50143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IPlayer person)
		{
			throw null;
		}

		// Token: 0x0400C5C1 RID: 50625
		public IPlayer exceptPerson;
	}

	// Token: 0x02002699 RID: 9881
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2207
	{
		// Token: 0x0600C3E0 RID: 50144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IPlayer person)
		{
			throw null;
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0400C5C2 RID: 50626
		public static readonly GClass2920.Class2207 class2207_0;

		// Token: 0x0400C5C3 RID: 50627
		public static Func<IPlayer, bool> func_0;

		// Token: 0x0400C5C4 RID: 50628
		public static Func<IPlayer, bool> func_1;
	}
}
