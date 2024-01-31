using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B2B RID: 11051
	public sealed class OverallScreen : UIElement
	{
		// Token: 0x14000303 RID: 771
		// (add) Token: 0x0600DB0A RID: 56074 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DB0B RID: 56075 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnBackButtonClick
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile currentProfile, Profile[] allProfiles, SessionCountersClass overallAccountStats, [CanBeNull] InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600DB0E RID: 56078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(OverallStatsPanel.EStatType statType, bool value)
		{
			throw null;
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DB10 RID: 56080 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool value)
		{
			throw null;
		}

		// Token: 0x0600DB11 RID: 56081 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool value)
		{
			throw null;
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool value)
		{
			throw null;
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400DE77 RID: 56951
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400DE78 RID: 56952
		private Profile[] profile_0;

		// Token: 0x0400DE79 RID: 56953
		private Profile profile_1;

		// Token: 0x0400DE7A RID: 56954
		private Profile profile_2;

		// Token: 0x0400DE7B RID: 56955
		private SessionCountersClass gclass2198_0;

		// Token: 0x0400DE7C RID: 56956
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DE7D RID: 56957
		[SerializeField]
		private UIAnimatedToggleSpawner _overallToggle;

		// Token: 0x0400DE7E RID: 56958
		[SerializeField]
		private UIAnimatedToggleSpawner _pmcToggle;

		// Token: 0x0400DE7F RID: 56959
		[SerializeField]
		private UIAnimatedToggleSpawner _scavToggle;

		// Token: 0x0400DE80 RID: 56960
		[SerializeField]
		private StatisticsSpawn _statsSpawn;

		// Token: 0x0400DE81 RID: 56961
		public InventoryPlayerModelWithStatsWindow PlayerModelWithStatsWindow;

		// Token: 0x0400DE82 RID: 56962
		public OverallStatsPanel OverallStatsPanel;

		// Token: 0x02002B2C RID: 11052
		public sealed class GClass3060 : GClass3058<OverallScreen>
		{
			// Token: 0x0600DB14 RID: 56084 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400DE83 RID: 56963
			private readonly Profile profile_0;

			// Token: 0x0400DE84 RID: 56964
			private readonly Profile[] profile_1;

			// Token: 0x0400DE85 RID: 56965
			private readonly SessionCountersClass gclass2198_0;

			// Token: 0x0400DE86 RID: 56966
			[CanBeNull]
			private readonly InventoryControllerClass gclass2757_0;
		}

		// Token: 0x02002B2D RID: 11053
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2600
		{
			// Token: 0x0600DB15 RID: 56085 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Profile value)
			{
				throw null;
			}

			// Token: 0x0600DB16 RID: 56086 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Profile value)
			{
				throw null;
			}

			// Token: 0x0400DE87 RID: 56967
			public static readonly OverallScreen.Class2600 class2600_0;

			// Token: 0x0400DE88 RID: 56968
			public static Func<Profile, bool> func_0;

			// Token: 0x0400DE89 RID: 56969
			public static Func<Profile, bool> func_1;
		}
	}
}
