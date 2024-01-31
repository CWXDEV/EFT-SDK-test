using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AchievementsSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using EFT.UI.Screens;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AAC RID: 10924
	public sealed class OtherPlayerProfileScreen : EftScreen<OtherPlayerProfileScreen.GClass3127, OtherPlayerProfileScreen>
	{
		// Token: 0x0600D91F RID: 55583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D920 RID: 55584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(OtherPlayerProfileScreen.GClass3127 controller)
		{
			throw null;
		}

		// Token: 0x0600D921 RID: 55585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(GClass1208 profile, InventoryControllerClass inventoryController, EItemViewType viewType, ISession session)
		{
			throw null;
		}

		// Token: 0x0600D922 RID: 55586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IEnumerable<Item> items, TraderControllerClass itemController, ref GClass3078<Item, ItemView> viewList, GridLayoutGroup container)
		{
			throw null;
		}

		// Token: 0x0600D923 RID: 55587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D924 RID: 55588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IEnumerable<Item> favoriteItems, TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x0600D925 RID: 55589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(IEnumerable<Item> favoriteItems, TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x0600D926 RID: 55590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowAchievementTooltip(PointerEventData eventData, GClass3255 template)
		{
			throw null;
		}

		// Token: 0x0600D927 RID: 55591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideAchievementTooltip(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D928 RID: 55592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D929 RID: 55593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D92A RID: 55594 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(bool value)
		{
			throw null;
		}

		// Token: 0x0600D92B RID: 55595 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool value)
		{
			throw null;
		}

		// Token: 0x0600D92C RID: 55596 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400DBF0 RID: 56304
		private GClass1208 gclass1208_0;

		// Token: 0x0400DBF1 RID: 56305
		private ISession ginterface145_0;

		// Token: 0x0400DBF2 RID: 56306
		private EItemViewType eitemViewType_0;

		// Token: 0x0400DBF3 RID: 56307
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DBF4 RID: 56308
		[SerializeField]
		private UIAnimatedToggleSpawner _arenaToggle;

		// Token: 0x0400DBF5 RID: 56309
		[SerializeField]
		private UIAnimatedToggleSpawner _eftToggle;

		// Token: 0x0400DBF6 RID: 56310
		[SerializeField]
		private InventoryPlayerModelWithStatsWindow _playerModelWithStatsWindow;

		// Token: 0x0400DBF7 RID: 56311
		[SerializeField]
		private OverallStatsPanel _overallStatsPanel;

		// Token: 0x0400DBF8 RID: 56312
		[SerializeField]
		private List<AchievementIconView> _achievementViews;

		// Token: 0x0400DBF9 RID: 56313
		[SerializeField]
		private LocalizedText _achievementsProgressLabelText;

		// Token: 0x0400DBFA RID: 56314
		[SerializeField]
		private TMP_Text _achievementsProgressValueText;

		// Token: 0x0400DBFB RID: 56315
		[SerializeField]
		private Image _achievementsProgressBarImage;

		// Token: 0x0400DBFC RID: 56316
		[SerializeField]
		private GameObject _achievementsProgressBlock;

		// Token: 0x0400DBFD RID: 56317
		[SerializeField]
		private GameObject _achievementsBlockPlaceholder;

		// Token: 0x0400DBFE RID: 56318
		[SerializeField]
		private GameObject _weaponsBlockPlaceholder;

		// Token: 0x0400DBFF RID: 56319
		[SerializeField]
		private GameObject _nonWeaponItemsBlockPlaceholder;

		// Token: 0x0400DC00 RID: 56320
		[Space]
		[SerializeField]
		private GridLayoutGroup _weaponsGridLayoutGroup;

		// Token: 0x0400DC01 RID: 56321
		[SerializeField]
		private GridLayoutGroup _nonWeaponItemsGridLayoutGroup;

		// Token: 0x0400DC02 RID: 56322
		private GClass3078<Item, ItemView> gclass3078_0;

		// Token: 0x0400DC03 RID: 56323
		private GClass3078<Item, ItemView> gclass3078_1;

		// Token: 0x0400DC04 RID: 56324
		private ItemUiContext itemUiContext_0;

		// Token: 0x02002AAD RID: 10925
		public sealed class GClass3127 : GClass3107.GClass3109<OtherPlayerProfileScreen.GClass3127, OtherPlayerProfileScreen>
		{
			// Token: 0x17002659 RID: 9817
			// (get) Token: 0x0600D92D RID: 55597 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700265A RID: 9818
			// (get) Token: 0x0600D92E RID: 55598 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700265B RID: 9819
			// (get) Token: 0x0600D92F RID: 55599 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D930 RID: 55600 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CloseAction(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400DC05 RID: 56325
			private readonly GClass3166 gclass3166_0;

			// Token: 0x0400DC06 RID: 56326
			public readonly GClass1208 Profile;

			// Token: 0x0400DC07 RID: 56327
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400DC08 RID: 56328
			public readonly EItemViewType ViewType;

			// Token: 0x0400DC09 RID: 56329
			public readonly ISession Session;
		}

		// Token: 0x02002AAE RID: 10926
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2555
		{
			// Token: 0x0600D931 RID: 55601 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0600D932 RID: 55602 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1(GClass3255 a)
			{
				throw null;
			}

			// Token: 0x0400DC0A RID: 56330
			public static readonly OtherPlayerProfileScreen.Class2555 class2555_0;

			// Token: 0x0400DC0B RID: 56331
			public static Func<Item, bool> func_0;

			// Token: 0x0400DC0C RID: 56332
			public static Func<GClass3255, float> func_1;
		}

		// Token: 0x02002AAF RID: 10927
		[CompilerGenerated]
		private sealed class Class2556
		{
			// Token: 0x0600D933 RID: 55603 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ItemView method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0600D934 RID: 55604 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Item item, ItemView itemView)
			{
				throw null;
			}

			// Token: 0x0400DC0D RID: 56333
			public OtherPlayerProfileScreen otherPlayerProfileScreen_0;

			// Token: 0x0400DC0E RID: 56334
			public TraderControllerClass itemController;

			// Token: 0x0400DC0F RID: 56335
			public GridLayoutGroup container;
		}

		// Token: 0x02002AB0 RID: 10928
		[CompilerGenerated]
		private sealed class Class2557
		{
			// Token: 0x0600D935 RID: 55605 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass3255 a)
			{
				throw null;
			}

			// Token: 0x0400DC10 RID: 56336
			public KeyValuePair<string, int> unlockedAchievement;
		}

		// Token: 0x02002AB1 RID: 10929
		[CompilerGenerated]
		private sealed class Class2558
		{
			// Token: 0x0600D936 RID: 55606 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(PointerEventData e)
			{
				throw null;
			}

			// Token: 0x0400DC11 RID: 56337
			public GClass3255 template;

			// Token: 0x0400DC12 RID: 56338
			public OtherPlayerProfileScreen otherPlayerProfileScreen_0;
		}
	}
}
