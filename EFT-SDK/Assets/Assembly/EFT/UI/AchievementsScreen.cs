using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002885 RID: 10373
	public sealed class AchievementsScreen : UIElement
	{
		// Token: 0x0600CF20 RID: 53024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile profile, AbstractAchievementControllerClass achievementsController, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowAchievements(EAchievementsSortType sortType, bool sortAscend)
		{
			throw null;
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<GClass1248> GetSortedAchievements(EAchievementsSortType sortType, bool sortAscend)
		{
			throw null;
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupHiddenAchievementsPanel(List<GClass1248> achievements)
		{
			throw null;
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupOverallPanel(List<GClass1248> achievements)
		{
			throw null;
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Sort(EAchievementsSortType sortType, bool sortDirection)
		{
			throw null;
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400CFEE RID: 53230
		[SerializeField]
		private LocalizedText _overallLabelText;

		// Token: 0x0400CFEF RID: 53231
		[SerializeField]
		private TMP_Text _currentProgressValueText;

		// Token: 0x0400CFF0 RID: 53232
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0400CFF1 RID: 53233
		[SerializeField]
		private TMP_Text _commonAchievementsCountText;

		// Token: 0x0400CFF2 RID: 53234
		[SerializeField]
		private TMP_Text _rareAchievementsCountText;

		// Token: 0x0400CFF3 RID: 53235
		[SerializeField]
		private TMP_Text _legendaryAchievementsCountText;

		// Token: 0x0400CFF4 RID: 53236
		[SerializeField]
		private GameObject _hiddenAchPanel;

		// Token: 0x0400CFF5 RID: 53237
		[SerializeField]
		private TMP_Text _hiddenAchPanelTotalText;

		// Token: 0x0400CFF6 RID: 53238
		[SerializeField]
		private LocalizedText _hiddenAchPanelDescriptionText;

		// Token: 0x0400CFF7 RID: 53239
		[SerializeField]
		private GInterface382 _achievementViewTemplate;

		// Token: 0x0400CFF8 RID: 53240
		[SerializeField]
		private GameObject _taskDescriptionTemplate;

		// Token: 0x0400CFF9 RID: 53241
		[SerializeField]
		private GameObject _taskDescription;

		// Token: 0x0400CFFA RID: 53242
		[SerializeField]
		private RectTransform _achievementsRoot;

		// Token: 0x0400CFFB RID: 53243
		[SerializeField]
		private AchievementsSortPanel _achievementsSortPanel;

		// Token: 0x0400CFFC RID: 53244
		private AbstractAchievementControllerClass _achievementsController;

		// Token: 0x0400CFFD RID: 53245
		private ISession _session;

		// Token: 0x0400CFFE RID: 53246
		public InventoryPlayerModelWithStatsWindow PlayerModelWithStatsWindow;

		// Token: 0x02002886 RID: 10374
		public sealed class AchievementsTabController : GClass3058<AchievementsScreen>
		{
			// Token: 0x0600CF27 RID: 53031 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400CFFF RID: 53247
			private readonly AbstractAchievementControllerClass _achievementsController;

			// Token: 0x0400D000 RID: 53248
			private readonly ISession _session;

			// Token: 0x0400D001 RID: 53249
			private readonly Profile _profile;

			// Token: 0x0400D002 RID: 53250
			[CanBeNull]
			private readonly InventoryControllerClass _inventoryController;
		}

		// Token: 0x02002887 RID: 10375
		[CompilerGenerated]
		private sealed class Class2349
		{
			// Token: 0x0400D003 RID: 53251
			public AchievementsScreen achievementsScreen_0;

			// Token: 0x0400D004 RID: 53252
			public NotesTaskDescriptionShort description;
		}

		// Token: 0x02002888 RID: 10376
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2350
		{
			// Token: 0x0400D005 RID: 53253
			public static readonly AchievementsScreen.Class2350 class2350_0;

			// Token: 0x0400D006 RID: 53254
			public static Func<GClass1248, float> func_0;

			// Token: 0x0400D007 RID: 53255
			public static Func<GClass1248, bool> func_1;

			// Token: 0x0400D008 RID: 53256
			public static Func<GClass1248, DateTime> func_2;

			// Token: 0x0400D009 RID: 53257
			public static Func<GClass1248, int> func_3;

			// Token: 0x0400D00A RID: 53258
			public static Func<GClass1248, bool> func_4;

			// Token: 0x0400D00B RID: 53259
			public static Func<GClass1248, bool> func_5;

			// Token: 0x0400D00C RID: 53260
			public static Func<GClass1248, bool> func_6;

			// Token: 0x0400D00D RID: 53261
			public static Func<GClass1248, bool> func_7;

			// Token: 0x0400D00E RID: 53262
			public static Func<GClass1248, bool> func_8;
		}
	}
}
