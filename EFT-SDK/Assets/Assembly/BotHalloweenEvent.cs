using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020005F7 RID: 1527
public sealed class BotHalloweenEvent
{
	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x060022DD RID: 8925 RVA: 0x00002050 File Offset: 0x00000250
	public HashSet<int> PlayersIdsToKill
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x060022DE RID: 8926 RVA: 0x00002050 File Offset: 0x00000250
	public AIPlaceInfoHalloweenCircle TargetCircle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(BotOwner obj)
	{
		throw null;
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartRitual()
	{
		throw null;
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToKill(IPlayer player)
	{
		throw null;
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PeaceZryachiyKilled()
	{
		throw null;
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RitualCompleted()
	{
		throw null;
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RitualFail()
	{
		throw null;
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromBoss()
	{
		throw null;
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FirstContact()
	{
		throw null;
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillFirstSectant()
	{
		throw null;
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupGroup(int ownerGroupId)
	{
		throw null;
	}

	// Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMyGroup(int ownerGroupId)
	{
		throw null;
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckOnSectantsCount()
	{
		throw null;
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400229D RID: 8861
	public const string ZRYACHIY_PEAACE_KILL = "ZryachiyPeaceKill";

	// Token: 0x0400229E RID: 8862
	public const string ZRYACHIY_SUMMON_COMPLETE = "SummonComplete";

	// Token: 0x0400229F RID: 8863
	public const string ZRYACHIY_SUMMON_FAIL = "SummonFail";

	// Token: 0x040022A0 RID: 8864
	public const string FIRST_CONTACT = "HalloweenFirstContact";

	// Token: 0x040022A1 RID: 8865
	public const string FIRST_KILL = "HalloweenFirstKill";

	// Token: 0x040022A2 RID: 8866
	public const int CULTIST_ANIMATION_LAYER = 17;

	// Token: 0x040022A3 RID: 8867
	public int ToCircle;

	// Token: 0x040022A4 RID: 8868
	public bool IsEventRaised;

	// Token: 0x040022A5 RID: 8869
	private readonly BotsEventsController _allEvents;

	// Token: 0x040022A6 RID: 8870
	private readonly BotSpawner _spawner;

	// Token: 0x040022A7 RID: 8871
	private readonly AIPlaceInfoHolder _placesInfo;

	// Token: 0x040022A8 RID: 8872
	private readonly int _eventTime;

	// Token: 0x040022A9 RID: 8873
	private AIPlaceInfoHalloweenCircle _targetCircle;

	// Token: 0x040022AA RID: 8874
	private bool _ritualStarted;

	// Token: 0x040022AB RID: 8875
	private float _endSummon;

	// Token: 0x040022AC RID: 8876
	private bool _firstContact;

	// Token: 0x040022AD RID: 8877
	private bool _firstKill;

	// Token: 0x040022AE RID: 8878
	private int _ownerSectantGroup;

	// Token: 0x040022B0 RID: 8880
	public HashSet<string> PlayersProfilesIdsToKill;

	// Token: 0x020005F8 RID: 1528
	[CompilerGenerated]
	[Serializable]
	private sealed class Class296
	{
		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotOwner x)
		{
			throw null;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(BotOwner x)
		{
			throw null;
		}

		// Token: 0x040022B1 RID: 8881
		public static readonly BotHalloweenEvent.Class296 class296_0;

		// Token: 0x040022B2 RID: 8882
		public static Func<BotOwner, bool> func_0;

		// Token: 0x040022B3 RID: 8883
		public static Func<BotOwner, bool> func_1;
	}
}
