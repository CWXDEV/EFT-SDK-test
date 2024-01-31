using System;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using EFT.InventoryLogic;
using EFT.UI;
using EFT.UI.Settings;

// Token: 0x020019E5 RID: 6629
public sealed class GClass956 : GClass952<GClass956>
{
	// Token: 0x06008D1A RID: 36122 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass956 Clone()
	{
		throw null;
	}

	// Token: 0x04009360 RID: 37728
	public const int MIN_FIELD_OF_VIEW = 50;

	// Token: 0x04009361 RID: 37729
	public const int MAX_FIELD_OF_VIEW = 75;

	// Token: 0x04009362 RID: 37730
	public readonly GameSetting<string> Language;

	// Token: 0x04009363 RID: 37731
	public readonly GameSetting<EVisibilityMode> QuickSlotsVisibility;

	// Token: 0x04009364 RID: 37732
	public readonly GameSetting<EVisibilityMode> StaminaVisibility;

	// Token: 0x04009365 RID: 37733
	public readonly GameSetting<EVisibilityMode> HealthVisibility;

	// Token: 0x04009366 RID: 37734
	public readonly GameSetting<EHealthColorScheme> HealthColor;

	// Token: 0x04009367 RID: 37735
	public readonly GameSetting<ENotificationTransportType> NotificationTransportType;

	// Token: 0x04009368 RID: 37736
	public readonly GameSetting<GClass557.EConnectionType> ConnectionType;

	// Token: 0x04009369 RID: 37737
	public readonly GameSetting<EHighlightScope> HighlightScope;

	// Token: 0x0400936A RID: 37738
	public readonly GameSetting<int> FieldOfView;

	// Token: 0x0400936B RID: 37739
	public readonly GameSetting<float> HeadBobbing;

	// Token: 0x0400936C RID: 37740
	public readonly GameSetting<bool> AutoEmptyWorkingSet;

	// Token: 0x0400936D RID: 37741
	public readonly GameSetting<bool> SetAffinityToLogicalCores;

	// Token: 0x0400936E RID: 37742
	public readonly GameSetting<bool> EnableHideoutPreload;

	// Token: 0x0400936F RID: 37743
	public readonly GameSetting<bool> StreamerModeEnabled;

	// Token: 0x04009370 RID: 37744
	public readonly GameSetting<bool> BlockGroupInvites;

	// Token: 0x04009371 RID: 37745
	public readonly GameSetting<GClass956.EItemQuickUseMode> ItemQuickUseMode;

	// Token: 0x04009372 RID: 37746
	public readonly GameSetting<GClass956.EAutoVaultingUseMode> AutoVaultingMode;

	// Token: 0x04009373 RID: 37747
	public readonly GameSetting<bool> MalfunctionVisability;

	// Token: 0x04009374 RID: 37748
	public readonly GameSetting<bool> TradingIntermediateScreen;

	// Token: 0x04009375 RID: 37749
	public readonly GameSetting<int> RagfairLinesCount;

	// Token: 0x04009376 RID: 37750
	public readonly GameSetting<EnvironmentUI.EEnvironmentUIType> EnvironmentUiType;

	// Token: 0x020019E6 RID: 6630
	public enum EItemQuickUseMode
	{
		// Token: 0x04009378 RID: 37752
		Disabled,
		// Token: 0x04009379 RID: 37753
		InRaidOnly,
		// Token: 0x0400937A RID: 37754
		InRaidAndInLobby
	}

	// Token: 0x020019E7 RID: 6631
	public enum EAutoVaultingUseMode
	{
		// Token: 0x0400937C RID: 37756
		Automatic,
		// Token: 0x0400937D RID: 37757
		Hotkey
	}

	// Token: 0x020019E8 RID: 6632
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1551
	{
		// Token: 0x06008D1B RID: 36123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(int x)
		{
			throw null;
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(float x)
		{
			throw null;
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(int x)
		{
			throw null;
		}

		// Token: 0x0400937E RID: 37758
		public static readonly GClass956.Class1551 class1551_0;

		// Token: 0x0400937F RID: 37759
		public static Func<int, int> func_0;

		// Token: 0x04009380 RID: 37760
		public static Func<float, float> func_1;

		// Token: 0x04009381 RID: 37761
		public static Func<int, int> func_2;
	}
}
