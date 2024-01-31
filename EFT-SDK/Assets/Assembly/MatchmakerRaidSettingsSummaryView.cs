using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.UI;
using EFT.UI.Matchmaker;
using UnityEngine;

// Token: 0x020009C9 RID: 2505
public sealed class MatchmakerRaidSettingsSummaryView : UIElement
{
	// Token: 0x060037D9 RID: 14297 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Show(RaidSettings raidSettings)
	{
		throw null;
	}

	// Token: 0x0400397E RID: 14718
	private const string string_0 = "Enabled";

	// Token: 0x0400397F RID: 14719
	private const string string_1 = "Disabled";

	// Token: 0x04003980 RID: 14720
	[SerializeField]
	private List<CanvasGroup> _labelsCanvasGroups;

	// Token: 0x04003981 RID: 14721
	[SerializeField]
	private MatchmakerRaidSettingView _coopEnabledSetting;

	// Token: 0x04003982 RID: 14722
	[SerializeField]
	private MatchmakerRaidSettingView _playerSpawnSetting;

	// Token: 0x04003983 RID: 14723
	[SerializeField]
	private MatchmakerRaidSettingView _FoodAndWaterSetting;

	// Token: 0x04003984 RID: 14724
	[SerializeField]
	private MatchmakerRaidSettingView _weatherSettings;

	// Token: 0x04003985 RID: 14725
	[SerializeField]
	private MatchmakerRaidSettingView _dayTimeSettings;

	// Token: 0x04003986 RID: 14726
	[SerializeField]
	private MatchmakerRaidSettingView _randomWeatherSettings;

	// Token: 0x04003987 RID: 14727
	[SerializeField]
	private MatchmakerRaidSettingView _randomTimeSettings;

	// Token: 0x04003988 RID: 14728
	[SerializeField]
	private MatchmakerRaidSettingView _timeFlowSettings;

	// Token: 0x04003989 RID: 14729
	[SerializeField]
	private MatchmakerRaidSettingView _freeCameraSettings;

	// Token: 0x0400398A RID: 14730
	[SerializeField]
	private MatchmakerRaidSettingView _openedDoorsSettings;

	// Token: 0x0400398B RID: 14731
	[SerializeField]
	private MatchmakerRaidSettingView _healthSettings;

	// Token: 0x0400398C RID: 14732
	[SerializeField]
	private MatchmakerRaidSettingView _overloadSettings;

	// Token: 0x0400398D RID: 14733
	[SerializeField]
	private MatchmakerRaidSettingView _armsStaminaSettings;

	// Token: 0x0400398E RID: 14734
	[SerializeField]
	private MatchmakerRaidSettingView _legsStaminaSettings;

	// Token: 0x0400398F RID: 14735
	[SerializeField]
	private MatchmakerRaidSettingView _aiAmountSettings;

	// Token: 0x04003990 RID: 14736
	[SerializeField]
	private MatchmakerRaidSettingView _aiDifficultySettings;

	// Token: 0x04003991 RID: 14737
	[SerializeField]
	private MatchmakerRaidSettingView _silentBotsSettings;

	// Token: 0x04003992 RID: 14738
	[SerializeField]
	private MatchmakerRaidSettingView _bossesEnabledSettings;

	// Token: 0x04003993 RID: 14739
	[SerializeField]
	private MatchmakerRaidSettingView _bossPickSettings;

	// Token: 0x04003994 RID: 14740
	[SerializeField]
	private MatchmakerRaidSettingView _friendlyScavsSettings;

	// Token: 0x04003995 RID: 14741
	[SerializeField]
	private MatchmakerRaidSettingView _scavWarSettings;

	// Token: 0x04003996 RID: 14742
	[SerializeField]
	private MatchmakerRaidSettingView _cursedSettings;
}
