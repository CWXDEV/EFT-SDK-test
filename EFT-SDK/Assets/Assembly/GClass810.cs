using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using UnityEngine;

// Token: 0x02000951 RID: 2385
public sealed class GClass810 : IBotCreator
{
	// Token: 0x060035A6 RID: 13734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(GClass588 data, bool shallBeGroup, Action<BotOwner> callback, CancellationToken cancellationToken, bool withDelete)
	{
		throw null;
	}

	// Token: 0x060035A7 RID: 13735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1(Profile profile, GClass587 position, bool shallBeGroup, Action<BotOwner> callback, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x1700092E RID: 2350
	// (get) Token: 0x060035A8 RID: 13736 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060035A9 RID: 13737 RVA: 0x00002050 File Offset: 0x00000250
	public int BotsLoading
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700092F RID: 2351
	// (get) Token: 0x060035AA RID: 13738 RVA: 0x00002050 File Offset: 0x00000250
	public bool StartProfilesLoaded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000930 RID: 2352
	// (get) Token: 0x060035AB RID: 13739 RVA: 0x00002050 File Offset: 0x00000250
	public int BundlesLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060035AC RID: 13740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2(Profile profile, GClass587 bornInfo, Action<BotOwner> callback, bool isLocalGame, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060035AD RID: 13741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateBot(GClass588 data, BotZone zone, bool shallBeGroup, Func<BotOwner, BotZone, BotsGroup> groupAction, Action<BotOwner> callback, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060035AE RID: 13742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ActivateBot(Profile profile, GClass587 position, BotZone zone, bool shallBeGroup, Func<BotOwner, BotZone, BotsGroup> groupAction, Action<BotOwner> callback, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x060035AF RID: 13743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FillBackupProfilesData(GClass340 resultCache)
	{
		throw null;
	}

	// Token: 0x060035B0 RID: 13744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(BotZone zone, BotOwner bot, Action<BotOwner> callback, Func<BotOwner, BotZone, BotsGroup> groupAction)
	{
		throw null;
	}

	// Token: 0x060035B1 RID: 13745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Player player)
	{
		throw null;
	}

	// Token: 0x060035B2 RID: 13746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(BotOwner owner, bool @switch)
	{
		throw null;
	}

	// Token: 0x060035B3 RID: 13747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Profile> GenerateProfile(GClass588 data, CancellationToken cancellationToken, bool withDelete)
	{
		throw null;
	}

	// Token: 0x040036CF RID: 14031
	private readonly IBotGame ibotGame_0;

	// Token: 0x040036D0 RID: 14032
	private readonly GInterface18 ginterface18_0;

	// Token: 0x040036D1 RID: 14033
	private readonly Func<Profile, Vector3, Task<LocalPlayer>> func_0;

	// Token: 0x040036D2 RID: 14034
	private readonly Dictionary<Player, List<Renderer>> dictionary_0;

	// Token: 0x040036D3 RID: 14035
	[CompilerGenerated]
	private int int_0;

	// Token: 0x02000955 RID: 2389
	[CompilerGenerated]
	private sealed class Class500
	{
		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(BotOwner bot)
		{
			throw null;
		}

		// Token: 0x040036ED RID: 14061
		public GClass588 data;

		// Token: 0x040036EE RID: 14062
		public GClass810 gclass810_0;

		// Token: 0x040036EF RID: 14063
		public BotZone zone;

		// Token: 0x040036F0 RID: 14064
		public Action<BotOwner> callback;

		// Token: 0x040036F1 RID: 14065
		public Func<BotOwner, BotZone, BotsGroup> groupAction;
	}

	// Token: 0x02000956 RID: 2390
	[CompilerGenerated]
	private sealed class Class501
	{
		// Token: 0x060035BB RID: 13755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(BotOwner bot)
		{
			throw null;
		}

		// Token: 0x040036F2 RID: 14066
		public GClass810 gclass810_0;

		// Token: 0x040036F3 RID: 14067
		public BotZone zone;

		// Token: 0x040036F4 RID: 14068
		public Action<BotOwner> callback;

		// Token: 0x040036F5 RID: 14069
		public Func<BotOwner, BotZone, BotsGroup> groupAction;
	}

	// Token: 0x02000957 RID: 2391
	[CompilerGenerated]
	[Serializable]
	private sealed class Class502
	{
		// Token: 0x060035BC RID: 13756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Renderer x)
		{
			throw null;
		}

		// Token: 0x040036F6 RID: 14070
		public static readonly GClass810.Class502 class502_0;

		// Token: 0x040036F7 RID: 14071
		public static Func<Renderer, bool> func_0;
	}
}
