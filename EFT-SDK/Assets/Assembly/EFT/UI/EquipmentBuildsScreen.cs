using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Builds;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Builds;
using EFT.UI.Health;
using EFT.UI.Screens;
using EFT.Utilities;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200296E RID: 10606
	public sealed class EquipmentBuildsScreen : EftScreen<EquipmentBuildsScreen.GClass3115, EquipmentBuildsScreen>
	{
		// Token: 0x0600D325 RID: 54053 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(EquipmentBuildsScreen.GClass3115 controller)
		{
			throw null;
		}

		// Token: 0x0600D327 RID: 54055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(ISession session, GClass2759 inventoryController, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0600D328 RID: 54056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D329 RID: 54057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(EEquipmentBuildType buildType)
		{
			throw null;
		}

		// Token: 0x0600D32A RID: 54058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D32B RID: 54059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(GClass3181 selectedBuild)
		{
			throw null;
		}

		// Token: 0x0600D32C RID: 54060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_7(GClass3181 equipmentBuild)
		{
			throw null;
		}

		// Token: 0x0600D32D RID: 54061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_8(GClass3181 equipmentBuild)
		{
			throw null;
		}

		// Token: 0x0600D32E RID: 54062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(GClass3181 equipmentBuild)
		{
			throw null;
		}

		// Token: 0x0600D32F RID: 54063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(IEnumerable<Item> notFoundItems)
		{
			throw null;
		}

		// Token: 0x0600D330 RID: 54064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(PlayerVisualRepresentation visualRepresentation)
		{
			throw null;
		}

		// Token: 0x0600D331 RID: 54065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PlayerVisualRepresentation method_12()
		{
			throw null;
		}

		// Token: 0x0600D332 RID: 54066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_13(out List<Item> notFoundItems)
		{
			throw null;
		}

		// Token: 0x0600D333 RID: 54067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600D334 RID: 54068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(GClass3181 build)
		{
			throw null;
		}

		// Token: 0x0600D335 RID: 54069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(IReadOnlyCollection<Item> itemsToBuy)
		{
			throw null;
		}

		// Token: 0x0600D336 RID: 54070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_17(IEnumerable<GInterface321> results)
		{
			throw null;
		}

		// Token: 0x0600D337 RID: 54071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600D338 RID: 54072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D339 RID: 54073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D33A RID: 54074 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x0600D33B RID: 54075 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600D33C RID: 54076 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(string arg)
		{
			throw null;
		}

		// Token: 0x0600D33D RID: 54077 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_22(EquipmentBuildsScreen.Class2416 item)
		{
			throw null;
		}

		// Token: 0x0600D33E RID: 54078 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_23(GClass3181 build)
		{
			throw null;
		}

		// Token: 0x0600D33F RID: 54079 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24(EquipmentBuildsScreen.Class2416 equipmentBuildWrapper, EquipmentBuildListView view)
		{
			throw null;
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25()
		{
			throw null;
		}

		// Token: 0x0600D341 RID: 54081 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26()
		{
			throw null;
		}

		// Token: 0x0600D342 RID: 54082 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27()
		{
			throw null;
		}

		// Token: 0x0400D501 RID: 54529
		private readonly EquipmentSlot[] equipmentSlot_0;

		// Token: 0x0400D502 RID: 54530
		private readonly EquipmentSlot[] equipmentSlot_1;

		// Token: 0x0400D503 RID: 54531
		public const string EQUIPMENT_BUILD_REPLACE_WARNING = "EquipmentBuild/ReplaceMessage";

		// Token: 0x0400D504 RID: 54532
		public const string EQUIPMENT_BUILD_NAME_WINDOW_CAPTION = "EquipmentBuild/SetNameWindowCaption";

		// Token: 0x0400D505 RID: 54533
		public const string EQUIPMENT_BUILD_NAME_WINDOW_PLACEHOLDER = "EquipmentBuild/SetNameWindowPlaceholder";

		// Token: 0x0400D506 RID: 54534
		public const string EQUIPMENT_BUILD_SAVED_NOTIFICATION = "EquipmentBuilds/PresetSaved";

		// Token: 0x0400D507 RID: 54535
		private const string string_0 = "EquipmentBuild/RemoveMessage";

		// Token: 0x0400D508 RID: 54536
		private const string string_1 = "EquipmentBuilds/PresetRenamed";

		// Token: 0x0400D509 RID: 54537
		private const string string_2 = "EquipmentBuilds/PresetRemoved";

		// Token: 0x0400D50A RID: 54538
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400D50B RID: 54539
		[SerializeField]
		private Button _alternativeBackButton;

		// Token: 0x0400D50C RID: 54540
		[SerializeField]
		private TMP_InputField _searchInputField;

		// Token: 0x0400D50D RID: 54541
		[SerializeField]
		private DefaultUIButton _equipButton;

		// Token: 0x0400D50E RID: 54542
		[SerializeField]
		private TextMeshProUGUI _buildName;

		// Token: 0x0400D50F RID: 54543
		[SerializeField]
		private HealthParameterPanel _weight;

		// Token: 0x0400D510 RID: 54544
		[SerializeField]
		private RectTransform _buildsListContainer;

		// Token: 0x0400D511 RID: 54545
		[SerializeField]
		private EquipmentBuildListView _buildListViewTemplate;

		// Token: 0x0400D512 RID: 54546
		[SerializeField]
		private EquipmentBuildGear _equipmentPanel;

		// Token: 0x0400D513 RID: 54547
		[SerializeField]
		private ContainersPanel _containersPanel;

		// Token: 0x0400D514 RID: 54548
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400D515 RID: 54549
		[SerializeField]
		private XCoordRotation _rotator;

		// Token: 0x0400D516 RID: 54550
		[SerializeField]
		private DragTrigger _dragTrigger;

		// Token: 0x0400D517 RID: 54551
		[SerializeField]
		private Image _equipBuildIcon;

		// Token: 0x0400D518 RID: 54552
		[SerializeField]
		private Sprite _canEquip;

		// Token: 0x0400D519 RID: 54553
		[SerializeField]
		private Sprite _cantEquip;

		// Token: 0x0400D51A RID: 54554
		[SerializeField]
		[Header("Build tabs")]
		private Tab _standardBuildsTab;

		// Token: 0x0400D51B RID: 54555
		[SerializeField]
		private Tab _customBuildsTab;

		// Token: 0x0400D51C RID: 54556
		[SerializeField]
		[Header("Equipment tabs")]
		private TabWithValidationColors _slotsTab;

		// Token: 0x0400D51D RID: 54557
		[SerializeField]
		private TabWithValidationColors _containersTab;

		// Token: 0x0400D51E RID: 54558
		private ISession ginterface145_0;

		// Token: 0x0400D51F RID: 54559
		private GClass3182 gclass3182_0;

		// Token: 0x0400D520 RID: 54560
		private GClass2759 gclass2759_0;

		// Token: 0x0400D521 RID: 54561
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400D522 RID: 54562
		private GClass3181 gclass3181_0;

		// Token: 0x0400D523 RID: 54563
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400D524 RID: 54564
		private List<EquipmentBuildsScreen.Class2416> list_0;

		// Token: 0x0400D525 RID: 54565
		private readonly GClass763 gclass763_0;

		// Token: 0x0400D526 RID: 54566
		private string string_3;

		// Token: 0x0400D527 RID: 54567
		private GClass3065 gclass3065_0;

		// Token: 0x0400D528 RID: 54568
		private GClass2812<EquipmentClass> gclass2812_0;

		// Token: 0x0400D529 RID: 54569
		private Profile profile_0;

		// Token: 0x0400D52A RID: 54570
		private SkillManager skillManager_0;

		// Token: 0x0400D52B RID: 54571
		private float float_0;

		// Token: 0x0400D52C RID: 54572
		private float float_1;

		// Token: 0x0400D52D RID: 54573
		private bool bool_1;

		// Token: 0x0400D52E RID: 54574
		private GClass3076<EquipmentBuildsScreen.Class2416, EquipmentBuildListView> gclass3076_0;

		// Token: 0x0400D52F RID: 54575
		private GClass3065 gclass3065_1;

		// Token: 0x0400D530 RID: 54576
		private EEquipmentBuildType eequipmentBuildType_0;

		// Token: 0x0400D531 RID: 54577
		private Dictionary<EEquipmentBuildType, Tab> dictionary_0;

		// Token: 0x0400D532 RID: 54578
		private bool bool_2;

		// Token: 0x0200296F RID: 10607
		private sealed class Class2625 : GClass3057
		{
			// Token: 0x0600D343 RID: 54083 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400D533 RID: 54579
			private readonly EquipmentBuildsScreen equipmentBuildsScreen_0;

			// Token: 0x0400D534 RID: 54580
			private readonly EEquipmentBuildType eequipmentBuildType_0;
		}

		// Token: 0x02002970 RID: 10608
		public sealed class GClass3115 : GClass3107.GClass3109<EquipmentBuildsScreen.GClass3115, EquipmentBuildsScreen>
		{
			// Token: 0x1700258A RID: 9610
			// (get) Token: 0x0600D344 RID: 54084 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700258B RID: 9611
			// (get) Token: 0x0600D345 RID: 54085 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00002050 File Offset: 0x00000250
			public string LastSelectedBuildId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x1700258C RID: 9612
			// (get) Token: 0x0600D347 RID: 54087 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D348 RID: 54088 RVA: 0x00002050 File Offset: 0x00000250
			public EEquipmentBuildType LastEquipmentBuildType
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x0600D349 RID: 54089 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CloseAction(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600D34A RID: 54090 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400D535 RID: 54581
			public readonly ISession Session;

			// Token: 0x0400D536 RID: 54582
			public readonly GClass2759 InventoryController;

			// Token: 0x0400D537 RID: 54583
			public readonly IHealthController HealthController;

			// Token: 0x0400D538 RID: 54584
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400D539 RID: 54585
			[CompilerGenerated]
			private EEquipmentBuildType eequipmentBuildType_0;
		}

		// Token: 0x02002971 RID: 10609
		private sealed class Class2416 : GClass3017<GClass3181>
		{
		}

		// Token: 0x02002972 RID: 10610
		[CompilerGenerated]
		private sealed class Class2418
		{
			// Token: 0x0600D34B RID: 54091 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EquipmentBuildsScreen.Class2416 build)
			{
				throw null;
			}

			// Token: 0x0400D53A RID: 54586
			public string lastSelectedBuildId;
		}

		// Token: 0x02002973 RID: 10611
		[CompilerGenerated]
		private sealed class Class2419
		{
			// Token: 0x0600D34C RID: 54092 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool selected)
			{
				throw null;
			}

			// Token: 0x0600D34D RID: 54093 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600D34E RID: 54094 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400D53B RID: 54587
			public EquipmentBuildsScreen.Class2416 buildWrapper;

			// Token: 0x0400D53C RID: 54588
			public EquipmentBuildsScreen equipmentBuildsScreen_0;
		}

		// Token: 0x02002974 RID: 10612
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2420
		{
			// Token: 0x0600D34F RID: 54095 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal MongoID method_0(GClass3181 buildToOrder)
			{
				throw null;
			}

			// Token: 0x0600D350 RID: 54096 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EquipmentBuildsScreen.Class2416 method_1(GClass3181 build)
			{
				throw null;
			}

			// Token: 0x0600D351 RID: 54097 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600D352 RID: 54098 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0600D353 RID: 54099 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0600D354 RID: 54100 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(Item x)
			{
				throw null;
			}

			// Token: 0x0600D355 RID: 54101 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_6(Item x)
			{
				throw null;
			}

			// Token: 0x0600D356 RID: 54102 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_7(Item dictKey)
			{
				throw null;
			}

			// Token: 0x0600D357 RID: 54103 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_8(Item dictValue)
			{
				throw null;
			}

			// Token: 0x0400D53D RID: 54589
			public static readonly EquipmentBuildsScreen.Class2420 class2420_0;

			// Token: 0x0400D53E RID: 54590
			public static Func<GClass3181, MongoID> func_0;

			// Token: 0x0400D53F RID: 54591
			public static Func<GClass3181, EquipmentBuildsScreen.Class2416> func_1;

			// Token: 0x0400D540 RID: 54592
			public static Action action_0;

			// Token: 0x0400D541 RID: 54593
			public static Action action_1;

			// Token: 0x0400D542 RID: 54594
			public static Action action_2;

			// Token: 0x0400D543 RID: 54595
			public static Func<Item, string> func_2;

			// Token: 0x0400D544 RID: 54596
			public static Func<Item, int> func_3;

			// Token: 0x0400D545 RID: 54597
			public static Func<Item, string> func_4;

			// Token: 0x0400D546 RID: 54598
			public static Func<Item, int> func_5;
		}

		// Token: 0x02002976 RID: 10614
		[CompilerGenerated]
		private sealed class Class2421
		{
			// Token: 0x0600D35A RID: 54106 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EquipmentBuildsScreen.Class2416 item)
			{
				throw null;
			}

			// Token: 0x0400D54E RID: 54606
			public GClass3181 equipmentBuild;
		}

		// Token: 0x02002978 RID: 10616
		[CompilerGenerated]
		private sealed class Class2422
		{
			// Token: 0x0600D35D RID: 54109 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D35E RID: 54110 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Item itemInsideSlot)
			{
				throw null;
			}

			// Token: 0x0600D35F RID: 54111 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Item itemInsideSlot)
			{
				throw null;
			}

			// Token: 0x0400D55C RID: 54620
			public EquipmentBuildsScreen equipmentBuildsScreen_0;

			// Token: 0x0400D55D RID: 54621
			public Dictionary<string, int> notFoundDict;

			// Token: 0x0400D55E RID: 54622
			public Func<Item, bool> func_0;

			// Token: 0x0400D55F RID: 54623
			public Func<Item, bool> func_1;
		}

		// Token: 0x02002979 RID: 10617
		[CompilerGenerated]
		private sealed class Class2423
		{
			// Token: 0x0600D360 RID: 54112 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(string notFoundItemId)
			{
				throw null;
			}

			// Token: 0x0400D560 RID: 54624
			public Item itemInsideSlot;
		}

		// Token: 0x0200297A RID: 10618
		[CompilerGenerated]
		private sealed class Class2424
		{
			// Token: 0x0600D361 RID: 54113 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(string notFoundItemId)
			{
				throw null;
			}

			// Token: 0x0400D561 RID: 54625
			public Item itemInsideSlot;
		}

		// Token: 0x0200297B RID: 10619
		[CompilerGenerated]
		private sealed class Class2425
		{
			// Token: 0x0600D362 RID: 54114 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool contained)
			{
				throw null;
			}

			// Token: 0x0400D562 RID: 54626
			public List<Item> outOfCollectionItems;

			// Token: 0x0400D563 RID: 54627
			public EquipmentBuildsScreen equipmentBuildsScreen_0;
		}

		// Token: 0x0200297C RID: 10620
		[CompilerGenerated]
		private sealed class Class2426
		{
			// Token: 0x0600D363 RID: 54115 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0400D564 RID: 54628
			public Item notFoundItem;
		}
	}
}
