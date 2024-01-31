using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000756 RID: 1878
public sealed class ProfileStats
{
	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00002050 File Offset: 0x00000250
	public ProfileStats.ESurvivorClass SurvivorClass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002C63 RID: 11363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateOnStart()
	{
		throw null;
	}

	// Token: 0x04002AD0 RID: 10960
	public SessionCountersClass SessionCounters;

	// Token: 0x04002AD1 RID: 10961
	public SessionCountersClass OverallCounters;

	// Token: 0x04002AD2 RID: 10962
	public float SessionExperienceMult;

	// Token: 0x04002AD3 RID: 10963
	public float ExperienceBonusMult;

	// Token: 0x04002AD4 RID: 10964
	public int TotalSessionExperience;

	// Token: 0x04002AD5 RID: 10965
	public int LastSessionDate;

	// Token: 0x04002AD6 RID: 10966
	public AggressorStats Aggressor;

	// Token: 0x04002AD7 RID: 10967
	public readonly List<DroppedItem> DroppedItems;

	// Token: 0x04002AD8 RID: 10968
	public readonly List<FoundInRaidItem> FoundInRaidItems;

	// Token: 0x04002AD9 RID: 10969
	public readonly GClass3364<VictimStats> Victims;

	// Token: 0x04002ADA RID: 10970
	public readonly List<string> CarriedQuestItems;

	// Token: 0x04002ADB RID: 10971
	public DamageHistory DamageHistory;

	// Token: 0x04002ADC RID: 10972
	public DeathCause DeathCause;

	// Token: 0x04002ADD RID: 10973
	public PlayerVisualRepresentation LastPlayerState;

	// Token: 0x04002ADE RID: 10974
	public long TotalInGameTime;

	// Token: 0x02000757 RID: 1879
	public sealed class GClass690
	{
		// Token: 0x04002ADF RID: 10975
		public string Caption;

		// Token: 0x04002AE0 RID: 10976
		public object Value;

		// Token: 0x04002AE1 RID: 10977
		public ProfileStats.EStatType Type;
	}

	// Token: 0x02000758 RID: 1880
	public enum ESurvivorClass
	{
		// Token: 0x04002AE3 RID: 10979
		Unknown,
		// Token: 0x04002AE4 RID: 10980
		Neutralizer,
		// Token: 0x04002AE5 RID: 10981
		Marauder,
		// Token: 0x04002AE6 RID: 10982
		Paramedic,
		// Token: 0x04002AE7 RID: 10983
		Survivor
	}

	// Token: 0x02000759 RID: 1881
	public enum EStatType
	{
		// Token: 0x04002AE9 RID: 10985
		Date,
		// Token: 0x04002AEA RID: 10986
		DateTime,
		// Token: 0x04002AEB RID: 10987
		Experience,
		// Token: 0x04002AEC RID: 10988
		Litres,
		// Token: 0x04002AED RID: 10989
		Number,
		// Token: 0x04002AEE RID: 10990
		BodyPart,
		// Token: 0x04002AEF RID: 10991
		Health,
		// Token: 0x04002AF0 RID: 10992
		SurvivorClass,
		// Token: 0x04002AF1 RID: 10993
		Text
	}
}
