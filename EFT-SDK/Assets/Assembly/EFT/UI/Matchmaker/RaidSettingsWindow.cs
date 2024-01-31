using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DF2 RID: 11762
	public sealed class RaidSettingsWindow : BaseUiWindow
	{
		// Token: 0x0600E74A RID: 59210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(RaidSettings raidSettings, InfoClass profileInfo, GClass3166 matchmaker)
		{
			throw null;
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EBanType banType = EBanType.Online)
		{
			throw null;
		}

		// Token: 0x0600E74D RID: 59213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(UpdatableToggle toggle, bool initValue)
		{
			throw null;
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(DropDownBox dropDown, IEnumerable<string> values, int initValue)
		{
			throw null;
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool value)
		{
			throw null;
		}

		// Token: 0x0600E752 RID: 59218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(bool value)
		{
			throw null;
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(bool val)
		{
			throw null;
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(bool value)
		{
			throw null;
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(int index)
		{
			throw null;
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(bool _)
		{
			throw null;
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(int _)
		{
			throw null;
		}

		// Token: 0x0400EC78 RID: 60536
		[HideInInspector]
		public readonly UnityEvent OnRaidSettingsChanged;

		// Token: 0x0400EC79 RID: 60537
		[SerializeField]
		private UpdatableToggle _coopModeToggle;

		// Token: 0x0400EC7A RID: 60538
		[SerializeField]
		private UiElementBlocker _coopModeBlocker;

		// Token: 0x0400EC7B RID: 60539
		[Header("Game settings")]
		[SerializeField]
		private UpdatableToggle _metabolismDisabledToggle;

		// Token: 0x0400EC7C RID: 60540
		[SerializeField]
		private UpdatableToggle _randomTimeToggle;

		// Token: 0x0400EC7D RID: 60541
		[SerializeField]
		private UpdatableToggle _randomWeatherToggle;

		// Token: 0x0400EC7E RID: 60542
		[SerializeField]
		private DropDownBox _playersSpawnPlaceDropdown;

		// Token: 0x0400EC7F RID: 60543
		[SerializeField]
		private DropDownBox _cloudinessDropdown;

		// Token: 0x0400EC80 RID: 60544
		[SerializeField]
		private DropDownBox _rainDropdown;

		// Token: 0x0400EC81 RID: 60545
		[SerializeField]
		private DropDownBox _windSpeedDropdown;

		// Token: 0x0400EC82 RID: 60546
		[SerializeField]
		private DropDownBox _fogDropdown;

		// Token: 0x0400EC83 RID: 60547
		[SerializeField]
		private DropDownBox _timeFlowDropdown;

		// Token: 0x0400EC84 RID: 60548
		[SerializeField]
		private DropDownBox _timeOfDayDropdown;

		// Token: 0x0400EC85 RID: 60549
		[SerializeField]
		private List<CanvasGroup> _playersSpawnPlaceCanvasGroups;

		// Token: 0x0400EC86 RID: 60550
		[SerializeField]
		private List<CanvasGroup> _randomTimeAndWeatherCanvasGroups;

		// Token: 0x0400EC87 RID: 60551
		[SerializeField]
		private List<CanvasGroup> _waterAndFoodCanvasGroups;

		// Token: 0x0400EC88 RID: 60552
		[SerializeField]
		private List<CanvasGroup> _timeCanvasGroups;

		// Token: 0x0400EC89 RID: 60553
		[SerializeField]
		private List<CanvasGroup> _weatherCanvasGroups;

		// Token: 0x0400EC8A RID: 60554
		[Header("PVE settings")]
		[SerializeField]
		private UpdatableToggle _enableBosses;

		// Token: 0x0400EC8B RID: 60555
		[SerializeField]
		private UpdatableToggle _taggedAndCursed;

		// Token: 0x0400EC8C RID: 60556
		[SerializeField]
		private UpdatableToggle _scavWars;

		// Token: 0x0400EC8D RID: 60557
		[SerializeField]
		private DropDownBox _bossPickDropdown;

		// Token: 0x0400EC8E RID: 60558
		[SerializeField]
		private DropDownBox _aiDifficultyDropdown;

		// Token: 0x0400EC8F RID: 60559
		[SerializeField]
		private DropDownBox _aiAmountDropdown;

		// Token: 0x0400EC90 RID: 60560
		[SerializeField]
		private CanvasGroup _aiAmountCanvasGroup;

		// Token: 0x0400EC91 RID: 60561
		[SerializeField]
		private CanvasGroup _aiDifficultyCanvasGroup;

		// Token: 0x0400EC92 RID: 60562
		[SerializeField]
		private List<CanvasGroup> _wavesCanvasGroups;

		// Token: 0x0400EC93 RID: 60563
		private readonly List<CanvasGroup> list_0;

		// Token: 0x0400EC94 RID: 60564
		private RaidSettings raidSettings_0;

		// Token: 0x0400EC95 RID: 60565
		private RaidSettings raidSettings_1;

		// Token: 0x0400EC96 RID: 60566
		private InfoClass gclass1757_0;

		// Token: 0x0400EC97 RID: 60567
		private GClass3166 gclass3166_0;

		// Token: 0x0400EC98 RID: 60568
		private GClass1756 gclass1756_0;

		// Token: 0x02002DF3 RID: 11763
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2867
		{
			// Token: 0x0600E75A RID: 59226 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string difficulty)
			{
				throw null;
			}

			// Token: 0x0600E75B RID: 59227 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(string amount)
			{
				throw null;
			}

			// Token: 0x0600E75C RID: 59228 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(string place)
			{
				throw null;
			}

			// Token: 0x0600E75D RID: 59229 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(string clouds)
			{
				throw null;
			}

			// Token: 0x0600E75E RID: 59230 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_4(string rain)
			{
				throw null;
			}

			// Token: 0x0600E75F RID: 59231 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(string wind)
			{
				throw null;
			}

			// Token: 0x0600E760 RID: 59232 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_6(string fog)
			{
				throw null;
			}

			// Token: 0x0600E761 RID: 59233 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_7(string timeFlow)
			{
				throw null;
			}

			// Token: 0x0600E762 RID: 59234 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_8(string bossType)
			{
				throw null;
			}

			// Token: 0x0400EC99 RID: 60569
			public static readonly RaidSettingsWindow.Class2867 class2867_0;

			// Token: 0x0400EC9A RID: 60570
			public static Func<string, string> func_0;

			// Token: 0x0400EC9B RID: 60571
			public static Func<string, string> func_1;

			// Token: 0x0400EC9C RID: 60572
			public static Func<string, string> func_2;

			// Token: 0x0400EC9D RID: 60573
			public static Func<string, string> func_3;

			// Token: 0x0400EC9E RID: 60574
			public static Func<string, string> func_4;

			// Token: 0x0400EC9F RID: 60575
			public static Func<string, string> func_5;

			// Token: 0x0400ECA0 RID: 60576
			public static Func<string, string> func_6;

			// Token: 0x0400ECA1 RID: 60577
			public static Func<string, string> func_7;

			// Token: 0x0400ECA2 RID: 60578
			public static Func<string, string> func_8;
		}
	}
}
