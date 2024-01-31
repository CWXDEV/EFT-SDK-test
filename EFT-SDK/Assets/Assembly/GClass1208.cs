using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EFT;
using Newtonsoft.Json;

// Token: 0x02000FE3 RID: 4067
public class GClass1208 : IProfileDataContainer
{
	// Token: 0x17000D58 RID: 3416
	// (get) Token: 0x0600554E RID: 21838 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600554F RID: 21839 RVA: 0x00002050 File Offset: 0x00000250
	public SessionCountersClass OverallCounters
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

	// Token: 0x17000D59 RID: 3417
	// (get) Token: 0x06005550 RID: 21840 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005551 RID: 21841 RVA: 0x00002050 File Offset: 0x00000250
	public StashClass FavoriteItems
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

	// Token: 0x17000D5A RID: 3418
	// (get) Token: 0x06005552 RID: 21842 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005553 RID: 21843 RVA: 0x00002050 File Offset: 0x00000250
	public TraderControllerClass ItemController
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

	// Token: 0x17000D5B RID: 3419
	// (get) Token: 0x06005554 RID: 21844 RVA: 0x00002050 File Offset: 0x00000250
	public PlayerVisualRepresentation PlayerVisualRepresentation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D5C RID: 3420
	// (get) Token: 0x06005555 RID: 21845 RVA: 0x00002050 File Offset: 0x00000250
	public string ProfileId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D5D RID: 3421
	// (get) Token: 0x06005556 RID: 21846 RVA: 0x00002050 File Offset: 0x00000250
	public string Nickname
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D5E RID: 3422
	// (get) Token: 0x06005557 RID: 21847 RVA: 0x00002050 File Offset: 0x00000250
	public EPlayerSide Side
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005558 RID: 21848 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDeserialized(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x04006109 RID: 24841
	[JsonProperty("favoriteItems")]
	private GClass1186[] gclass1186_0;

	// Token: 0x0400610A RID: 24842
	[JsonProperty("aid")]
	public string AccountId;

	// Token: 0x0400610B RID: 24843
	[JsonProperty("id")]
	public string Id;

	// Token: 0x0400610C RID: 24844
	[JsonProperty("info")]
	public GClass1208.GClass1209 Info;

	// Token: 0x0400610D RID: 24845
	[JsonProperty("customization")]
	public GClass1752 Customization;

	// Token: 0x0400610E RID: 24846
	[JsonProperty("equipment")]
	public EquipmentClass Equipment;

	// Token: 0x0400610F RID: 24847
	[JsonProperty("achievements")]
	public Dictionary<string, int> AchievementsData;

	// Token: 0x04006110 RID: 24848
	[JsonProperty("pmcStats")]
	public GClass691 PmcStats;

	// Token: 0x04006111 RID: 24849
	[JsonProperty("scavStats")]
	public GClass691 ScavStats;

	// Token: 0x04006112 RID: 24850
	[JsonProperty("skills")]
	public SkillManager Skills;

	// Token: 0x04006113 RID: 24851
	[CompilerGenerated]
	private SessionCountersClass gclass2198_0;

	// Token: 0x04006114 RID: 24852
	[CompilerGenerated]
	private StashClass gclass2698_0;

	// Token: 0x04006115 RID: 24853
	[CompilerGenerated]
	private TraderControllerClass gclass2754_0;

	// Token: 0x04006116 RID: 24854
	private PlayerVisualRepresentation playerVisualRepresentation_0;

	// Token: 0x02000FE4 RID: 4068
	public class GClass1209
	{
		// Token: 0x04006117 RID: 24855
		public string Nickname;

		// Token: 0x04006118 RID: 24856
		public EPlayerSide Side;

		// Token: 0x04006119 RID: 24857
		public int Experience;

		// Token: 0x0400611A RID: 24858
		public EMemberCategory MemberCategory;

		// Token: 0x0400611B RID: 24859
		public bool BannedState;

		// Token: 0x0400611C RID: 24860
		public int BannedUntil;

		// Token: 0x0400611D RID: 24861
		public int RegistrationDate;
	}
}
