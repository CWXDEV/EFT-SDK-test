using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020002E6 RID: 742
public class BotMalfunctionData : GClass362
{
	// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidateMalfunction(Weapon.EMalfunctionState malfState)
	{
		throw null;
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveMalfunction()
	{
		throw null;
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Weapon.EMalfunctionState MalfunctionType()
	{
		throw null;
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCustomBotInfoData()
	{
		throw null;
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000EFB RID: 3835
	private const float END_OPERATION_DURATION = 8.5f;

	// Token: 0x04000EFC RID: 3836
	private BotMalfunctionData.EInnerMalfunctionState _malfState;

	// Token: 0x04000EFD RID: 3837
	private float _nextOperationTime;

	// Token: 0x04000EFE RID: 3838
	private bool _malfFixed;

	// Token: 0x04000EFF RID: 3839
	private bool _ignoreMalfunction;

	// Token: 0x04000F00 RID: 3840
	private bool _preFixed;

	// Token: 0x04000F01 RID: 3841
	private bool _weaponExamined;

	// Token: 0x020002E7 RID: 743
	private enum EInnerMalfunctionState
	{
		// Token: 0x04000F03 RID: 3843
		None,
		// Token: 0x04000F04 RID: 3844
		UnknownMalfunction,
		// Token: 0x04000F05 RID: 3845
		KnownMalfunction,
		// Token: 0x04000F06 RID: 3846
		MalfunctionFixInProgress,
		// Token: 0x04000F07 RID: 3847
		MalfunctionFixed
	}
}
