using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001540 RID: 5440
[StructLayout(LayoutKind.Auto)]
public struct GStruct186
{
	// Token: 0x17001253 RID: 4691
	// (get) Token: 0x06007469 RID: 29801 RVA: 0x00002050 File Offset: 0x00000250
	internal bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001254 RID: 4692
	// (get) Token: 0x0600746A RID: 29802 RVA: 0x00002050 File Offset: 0x00000250
	internal bool Boolean_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600746B RID: 29803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeserializeDiffUsing(GInterface76 reader, ref GStruct186 firearmPacket, GStruct186 prevFrame)
	{
		throw null;
	}

	// Token: 0x0600746C RID: 29804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeDiffUsing(GInterface79 writer, GStruct186 current, GStruct186 prevFrame)
	{
		throw null;
	}

	// Token: 0x0600746D RID: 29805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(GStruct178 firedShotInfo)
	{
		throw null;
	}

	// Token: 0x0600746E RID: 29806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasShotsRealShots()
	{
		throw null;
	}

	// Token: 0x0600746F RID: 29807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04007ADC RID: 31452
	private const int int_0 = -1;

	// Token: 0x04007ADD RID: 31453
	private const int int_1 = 15;

	// Token: 0x04007ADE RID: 31454
	public GStruct179 ChangeFireMode;

	// Token: 0x04007ADF RID: 31455
	public bool ChangeCalibrationPoint;

	// Token: 0x04007AE0 RID: 31456
	public bool ToggleAim;

	// Token: 0x04007AE1 RID: 31457
	public int AimingIndex;

	// Token: 0x04007AE2 RID: 31458
	public bool ExamineWeapon;

	// Token: 0x04007AE3 RID: 31459
	public bool CheckAmmo;

	// Token: 0x04007AE4 RID: 31460
	public bool CheckChamber;

	// Token: 0x04007AE5 RID: 31461
	public bool CheckFireMode;

	// Token: 0x04007AE6 RID: 31462
	public bool ToggleLauncher;

	// Token: 0x04007AE7 RID: 31463
	public bool ReloadBoltAction;

	// Token: 0x04007AE8 RID: 31464
	public GStruct181 ToggleTacticalCombo;

	// Token: 0x04007AE9 RID: 31465
	public GStruct184 ChangeSightsMode;

	// Token: 0x04007AEA RID: 31466
	public GStruct183 LauncherRangeStatePacket;

	// Token: 0x04007AEB RID: 31467
	public GStruct178? FiredShotInfos;

	// Token: 0x04007AEC RID: 31468
	public GStruct321 FlareShotInfo;

	// Token: 0x04007AED RID: 31469
	public GStruct329 LauncherReloadInfo;

	// Token: 0x04007AEE RID: 31470
	public GStruct318 EnableInventoryPacket;

	// Token: 0x04007AEF RID: 31471
	public GStruct324 HideWeaponPacket;

	// Token: 0x04007AF0 RID: 31472
	public GStruct188 ReloadMagPacket;

	// Token: 0x04007AF1 RID: 31473
	public GStruct189 QuickReloadMagPacket;

	// Token: 0x04007AF2 RID: 31474
	public GStruct193 ReloadWithAmmoPacket;

	// Token: 0x04007AF3 RID: 31475
	public GStruct190 ReloadBarrelsPacket;

	// Token: 0x04007AF4 RID: 31476
	public GStruct330<GStruct332> ShotsForApprovement;

	// Token: 0x04007AF5 RID: 31477
	public GStruct313 CompassPacket;

	// Token: 0x04007AF6 RID: 31478
	public GStruct212 RadioTransmitterPacket;

	// Token: 0x04007AF7 RID: 31479
	public GStruct131 LighthouseTraderZoneDataPacket;

	// Token: 0x04007AF8 RID: 31480
	public GStruct192 CylinderMagStatusPacket;

	// Token: 0x04007AF9 RID: 31481
	public GStruct191 RollCylinderPacket;

	// Token: 0x04007AFA RID: 31482
	public bool IsInImportantState;

	// Token: 0x04007AFB RID: 31483
	public EGesture Gesture;

	// Token: 0x04007AFC RID: 31484
	public float TimeStamp;

	// Token: 0x04007AFD RID: 31485
	public GStruct187 SetLeftStancePacket;
}
