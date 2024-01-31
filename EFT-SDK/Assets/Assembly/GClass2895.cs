using System;
using System.Runtime.CompilerServices;
using EFT.PrefabSettings;

// Token: 0x0200263A RID: 9786
public class GClass2895 : GClass2885
{
	// Token: 0x170022A8 RID: 8872
	// (get) Token: 0x0600C23F RID: 49727 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2895.EZoneEventType ZoneEventType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170022A9 RID: 8873
	// (get) Token: 0x0600C240 RID: 49728 RVA: 0x00002050 File Offset: 0x00000250
	public string PlayerProfileID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170022AA RID: 8874
	// (get) Token: 0x0600C241 RID: 49729 RVA: 0x00002050 File Offset: 0x00000250
	public FlareEventType FlareEventType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170022AB RID: 8875
	// (get) Token: 0x0600C242 RID: 49730 RVA: 0x00002050 File Offset: 0x00000250
	public string ZoneID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C243 RID: 49731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Invoke(FlareEventType flareType, GClass2895.EZoneEventType eventType, string playerProfileID, string zoneID)
	{
		throw null;
	}

	// Token: 0x0600C244 RID: 49732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0400C407 RID: 50183
	private GClass2895.EZoneEventType ezoneEventType_0;

	// Token: 0x0400C408 RID: 50184
	private string string_0;

	// Token: 0x0400C409 RID: 50185
	private FlareEventType flareEventType_0;

	// Token: 0x0400C40A RID: 50186
	private string string_1;

	// Token: 0x0200263B RID: 9787
	public enum EZoneEventType
	{
		// Token: 0x0400C40C RID: 50188
		None,
		// Token: 0x0400C40D RID: 50189
		PlayerEnteredZone,
		// Token: 0x0400C40E RID: 50190
		PlayerExitedZone,
		// Token: 0x0400C40F RID: 50191
		FiredPlayerAddedInShotList,
		// Token: 0x0400C410 RID: 50192
		PlayerByPartyAddedInShotList
	}
}
