using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.Binding;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using EFT.UI.WeaponModding;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A8B RID: 10891
	[UsedImplicitly]
	public sealed class EditBuildScreen : ItemObserveScreen<EditBuildScreen.GClass3126, EditBuildScreen>
	{
		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600D85D RID: 55389 RVA: 0x00002050 File Offset: 0x00000250
		private ItemFactory GClass1483_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600D85E RID: 55390 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x0600D85F RID: 55391 RVA: 0x00002050 File Offset: 0x00000250
		private string String_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600D860 RID: 55392 RVA: 0x00002050 File Offset: 0x00000250
		private IBindable<bool> IBindable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0600D861 RID: 55393 RVA: 0x00002050 File Offset: 0x00000250
		private IBindable<bool> IBindable_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D863 RID: 55395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(EditBuildScreen.GClass3126 controller)
		{
			throw null;
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Item itemBody, Item buildItem, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x0600D865 RID: 55397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass2825 CreateBuildManipulation()
		{
			throw null;
		}

		// Token: 0x0600D866 RID: 55398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600D867 RID: 55399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_16(Item itemToCheck)
		{
			throw null;
		}

		// Token: 0x0600D868 RID: 55400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x0600D869 RID: 55401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18()
		{
			throw null;
		}

		// Token: 0x0600D86A RID: 55402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19([CanBeNull] GClass3183 build)
		{
			throw null;
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_20(bool asNewBuild = true)
		{
			throw null;
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(bool onlyContained, List<Mod> alreadyInstalledMods)
		{
			throw null;
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Item> method_22()
		{
			throw null;
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Item> method_23(List<Mod> alreadyInstalledMods)
		{
			throw null;
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24()
		{
			throw null;
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25()
		{
			throw null;
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(bool force)
		{
			throw null;
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27()
		{
			throw null;
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_28(List<Mod> alreadyInstalledMods)
		{
			throw null;
		}

		// Token: 0x0600D874 RID: 55412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TraderControllerClass method_29(Item[] items)
		{
			throw null;
		}

		// Token: 0x0600D875 RID: 55413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WeaponUpdate()
		{
			throw null;
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CheckForVitalParts()
		{
			throw null;
		}

		// Token: 0x0600D877 RID: 55415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30(bool readyToAssemble, bool noMissingMods = false)
		{
			throw null;
		}

		// Token: 0x0600D878 RID: 55416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31(GClass3183 build)
		{
			throw null;
		}

		// Token: 0x0600D879 RID: 55417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32(Item newBody)
		{
			throw null;
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateItem(Item newItem)
		{
			throw null;
		}

		// Token: 0x0600D87B RID: 55419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_33(bool autoAccept, string message, [CanBeNull] Action acceptAction, [CanBeNull] Action cancelAction = null)
		{
			throw null;
		}

		// Token: 0x0600D87C RID: 55420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D87E RID: 55422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_35()
		{
			throw null;
		}

		// Token: 0x0600D87F RID: 55423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D880 RID: 55424 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_36(bool changed, bool missingParts, bool isSaving)
		{
			throw null;
		}

		// Token: 0x0600D881 RID: 55425 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_37(bool isAssembling, bool isAssemblingAvailable)
		{
			throw null;
		}

		// Token: 0x0600D882 RID: 55426 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_38()
		{
			throw null;
		}

		// Token: 0x0600D883 RID: 55427 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_39()
		{
			throw null;
		}

		// Token: 0x0600D884 RID: 55428 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_40()
		{
			throw null;
		}

		// Token: 0x0600D885 RID: 55429 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_41(bool arg)
		{
			throw null;
		}

		// Token: 0x0600D886 RID: 55430 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_42(bool arg)
		{
			throw null;
		}

		// Token: 0x0600D887 RID: 55431 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_43(bool arg)
		{
			throw null;
		}

		// Token: 0x0600D888 RID: 55432 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_44(bool arg)
		{
			throw null;
		}

		// Token: 0x0600D889 RID: 55433 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_45(bool anyMissing)
		{
			throw null;
		}

		// Token: 0x0600D88A RID: 55434 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_46(bool inProgress)
		{
			throw null;
		}

		// Token: 0x0600D88B RID: 55435 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_47()
		{
			throw null;
		}

		// Token: 0x0600D88C RID: 55436 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_48(GClass3183 build)
		{
			throw null;
		}

		// Token: 0x0600D88D RID: 55437 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_49(Item x)
		{
			throw null;
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_50(Weapon selectedWeapon)
		{
			throw null;
		}

		// Token: 0x0600D88F RID: 55439 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_51()
		{
			throw null;
		}

		// Token: 0x0400DB25 RID: 56101
		private const string string_1 = "Build with the same name will be replaced. Continue?";

		// Token: 0x0400DB26 RID: 56102
		private const string string_2 = "Are you sure you want to delete this build?";

		// Token: 0x0400DB27 RID: 56103
		private const string string_3 = "WeaponBuild/SetNameWindowCaption";

		// Token: 0x0400DB28 RID: 56104
		private const string string_4 = "WeaponBuild/SetNameWindowPlaceholder";

		// Token: 0x0400DB29 RID: 56105
		private const string string_5 = "Are you sure you want to discard your changes?";

		// Token: 0x0400DB2A RID: 56106
		private const string string_6 = "Weapon has been built";

		// Token: 0x0400DB2B RID: 56107
		[SerializeField]
		private Toggle _onlyAvailableToggle;

		// Token: 0x0400DB2C RID: 56108
		[SerializeField]
		private Button _newBuildButton;

		// Token: 0x0400DB2D RID: 56109
		[SerializeField]
		private Button _openBuildButton;

		// Token: 0x0400DB2E RID: 56110
		[SerializeField]
		private HoverTooltipArea _saveAsHoverArea;

		// Token: 0x0400DB2F RID: 56111
		[SerializeField]
		private Button _saveAsBuildButton;

		// Token: 0x0400DB30 RID: 56112
		[SerializeField]
		private CanvasGroup _selectItemHoverArea;

		// Token: 0x0400DB31 RID: 56113
		[SerializeField]
		private Button _selectItemButton;

		// Token: 0x0400DB32 RID: 56114
		[SerializeField]
		private CanvasGroup _findPartsHoverArea;

		// Token: 0x0400DB33 RID: 56115
		[SerializeField]
		private Button _findPartsButton;

		// Token: 0x0400DB34 RID: 56116
		[SerializeField]
		private Button _publishButton;

		// Token: 0x0400DB35 RID: 56117
		[SerializeField]
		private Button _deleteBuildButton;

		// Token: 0x0400DB36 RID: 56118
		[SerializeField]
		private CanvasGroup _deleteCanvasGroup;

		// Token: 0x0400DB37 RID: 56119
		[SerializeField]
		private ButtonWithHint _saveButton;

		// Token: 0x0400DB38 RID: 56120
		[SerializeField]
		private HoverTooltipArea _saveHoverArea;

		// Token: 0x0400DB39 RID: 56121
		[SerializeField]
		private ButtonWithHint _assembleButton;

		// Token: 0x0400DB3A RID: 56122
		[SerializeField]
		private HoverTooltipArea _assembleHoverArea;

		// Token: 0x0400DB3B RID: 56123
		[SerializeField]
		private ValidationInputField _buildName;

		// Token: 0x0400DB3C RID: 56124
		[SerializeField]
		private GameObject _itemReadyToAssemble;

		// Token: 0x0400DB3D RID: 56125
		[SerializeField]
		private Button _itemReadyToAssembleButton;

		// Token: 0x0400DB3E RID: 56126
		[SerializeField]
		private OpenBuildWindow _openBuildWindow;

		// Token: 0x0400DB3F RID: 56127
		[SerializeField]
		private SelectWeaponBodyWindow _selectWeaponBodyWindow;

		// Token: 0x0400DB40 RID: 56128
		private readonly BindableState<bool> gclass3370_0;

		// Token: 0x0400DB41 RID: 56129
		private readonly BindableState<bool> gclass3370_1;

		// Token: 0x0400DB42 RID: 56130
		private readonly BindableState<bool> gclass3370_2;

		// Token: 0x0400DB43 RID: 56131
		private readonly BindableState<bool> gclass3370_3;

		// Token: 0x0400DB44 RID: 56132
		private readonly BindableState<bool> gclass3370_4;

		// Token: 0x0400DB45 RID: 56133
		private readonly BindableState<bool> gclass3370_5;

		// Token: 0x0400DB46 RID: 56134
		[CanBeNull]
		private Item item_1;

		// Token: 0x0400DB47 RID: 56135
		private ItemFactory gclass1483_0;

		// Token: 0x0400DB48 RID: 56136
		private RagFairClass gclass3190_0;

		// Token: 0x0400DB49 RID: 56137
		private GClass2881 gclass2881_0;

		// Token: 0x0400DB4A RID: 56138
		private GClass3184 gclass3184_0;

		// Token: 0x0400DB4B RID: 56139
		[CanBeNull]
		private GClass3183 gclass3183_0;

		// Token: 0x0400DB4C RID: 56140
		private TraderControllerClass gclass2754_0;

		// Token: 0x0400DB4D RID: 56141
		private GClass2826 gclass2826_0;

		// Token: 0x0400DB4E RID: 56142
		private GClass2825 gclass2825_1;

		// Token: 0x0400DB4F RID: 56143
		private ISession ginterface145_0;

		// Token: 0x0400DB50 RID: 56144
		private List<Item> list_0;

		// Token: 0x0400DB51 RID: 56145
		private Item[] item_2;

		// Token: 0x0400DB52 RID: 56146
		private GClass2762 gclass2762_0;

		// Token: 0x0400DB53 RID: 56147
		private readonly GClass2828 gclass2828_0;

		// Token: 0x0400DB54 RID: 56148
		private Profile profile_0;

		// Token: 0x0400DB55 RID: 56149
		private GClass3089 gclass3089_0;

		// Token: 0x02002A8C RID: 10892
		public sealed class GClass3126 : GClass3107.GClass3109<EditBuildScreen.GClass3126, EditBuildScreen>
		{
			// Token: 0x1700264F RID: 9807
			// (get) Token: 0x0600D890 RID: 55440 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002650 RID: 9808
			// (get) Token: 0x0600D891 RID: 55441 RVA: 0x00002050 File Offset: 0x00000250
			public Profile Profile
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002651 RID: 9809
			// (get) Token: 0x0600D892 RID: 55442 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D893 RID: 55443 RVA: 0x00002050 File Offset: 0x00000250
			public Item Item
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17002652 RID: 9810
			// (get) Token: 0x0600D894 RID: 55444 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool QueuePreviousScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002653 RID: 9811
			// (get) Token: 0x0600D895 RID: 55445 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D896 RID: 55446 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600D897 RID: 55447 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_9(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400DB56 RID: 56150
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400DB57 RID: 56151
			public readonly ISession Session;

			// Token: 0x0400DB58 RID: 56152
			private bool bool_4;

			// Token: 0x0400DB59 RID: 56153
			private Item item_0;

			// Token: 0x0400DB5A RID: 56154
			public Item BuildItem;
		}

		// Token: 0x02002A8E RID: 10894
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2539
		{
			// Token: 0x0600D89A RID: 55450 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D89B RID: 55451 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_1(Item x)
			{
				throw null;
			}

			// Token: 0x0600D89C RID: 55452 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600D89D RID: 55453 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0600D89E RID: 55454 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0600D89F RID: 55455 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(Item y)
			{
				throw null;
			}

			// Token: 0x0600D8A0 RID: 55456 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_6(Slot slot)
			{
				throw null;
			}

			// Token: 0x0600D8A1 RID: 55457 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_7(Item x)
			{
				throw null;
			}

			// Token: 0x0600D8A2 RID: 55458 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_8()
			{
				throw null;
			}

			// Token: 0x0600D8A3 RID: 55459 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_9()
			{
				throw null;
			}

			// Token: 0x0400DB60 RID: 56160
			public static readonly EditBuildScreen.Class2539 class2539_0;

			// Token: 0x0400DB61 RID: 56161
			public static UnityAction unityAction_0;

			// Token: 0x0400DB62 RID: 56162
			public static Func<Item, Item> func_0;

			// Token: 0x0400DB63 RID: 56163
			public static Action action_0;

			// Token: 0x0400DB64 RID: 56164
			public static Action action_1;

			// Token: 0x0400DB65 RID: 56165
			public static Action action_2;

			// Token: 0x0400DB66 RID: 56166
			public static Func<Item, string> func_1;

			// Token: 0x0400DB67 RID: 56167
			public static Func<Slot, Item> func_2;

			// Token: 0x0400DB68 RID: 56168
			public static Func<Item, bool> func_3;

			// Token: 0x0400DB69 RID: 56169
			public static Action action_3;

			// Token: 0x0400DB6A RID: 56170
			public static Action action_4;
		}

		// Token: 0x02002A8F RID: 10895
		[CompilerGenerated]
		private sealed class Class2540
		{
			// Token: 0x0600D8A4 RID: 55460 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Transform _, ModdingScreenSlotView view)
			{
				throw null;
			}

			// Token: 0x0400DB6B RID: 56171
			public bool inProgress;
		}

		// Token: 0x02002A90 RID: 10896
		[CompilerGenerated]
		private sealed class Class2541
		{
			// Token: 0x0600D8A5 RID: 55461 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DB6C RID: 56172
			public GClass3183 build;

			// Token: 0x0400DB6D RID: 56173
			public EditBuildScreen editBuildScreen_0;
		}

		// Token: 0x02002A92 RID: 10898
		[CompilerGenerated]
		private sealed class Class2542
		{
			// Token: 0x0600D8A8 RID: 55464 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0400DB7A RID: 56186
			public Dictionary<string, int> buildItems;

			// Token: 0x0400DB7B RID: 56187
			public Func<Item, bool> func_0;
		}

		// Token: 0x02002A93 RID: 10899
		[CompilerGenerated]
		private sealed class Class2543
		{
			// Token: 0x0600D8A9 RID: 55465 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(string z)
			{
				throw null;
			}

			// Token: 0x0400DB7C RID: 56188
			public Item item;
		}

		// Token: 0x02002A94 RID: 10900
		[CompilerGenerated]
		private sealed class Class2544
		{
			// Token: 0x0600D8AA RID: 55466 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D8AB RID: 55467 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_1()
			{
				throw null;
			}

			// Token: 0x0400DB7D RID: 56189
			public EditBuildScreen editBuildScreen_0;

			// Token: 0x0400DB7E RID: 56190
			public MongoID buildId;

			// Token: 0x02002A95 RID: 10901
			[StructLayout(LayoutKind.Auto)]
			public struct Struct889 : IAsyncStateMachine
			{
				// Token: 0x0600D8AC RID: 55468 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600D8AD RID: 55469 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400DB7F RID: 56191
				public int int_0;

				// Token: 0x0400DB80 RID: 56192
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400DB81 RID: 56193
				public EditBuildScreen.Class2544 class2544_0;

				// Token: 0x0400DB82 RID: 56194
				private TaskAwaiter<IResult> taskAwaiter_0;
			}
		}

		// Token: 0x02002A96 RID: 10902
		[CompilerGenerated]
		private sealed class Class2545
		{
			// Token: 0x0600D8AE RID: 55470 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D8AF RID: 55471 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(bool arg)
			{
				throw null;
			}

			// Token: 0x0400DB83 RID: 56195
			public EditBuildScreen editBuildScreen_0;

			// Token: 0x0400DB84 RID: 56196
			public List<Mod> alreadyInstalledMods;
		}

		// Token: 0x02002A98 RID: 10904
		[CompilerGenerated]
		private sealed class Class2546
		{
			// Token: 0x0600D8B2 RID: 55474 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item x)
			{
				throw null;
			}

			// Token: 0x0400DB8C RID: 56204
			public Item newItem;
		}

		// Token: 0x02002A99 RID: 10905
		[CompilerGenerated]
		private sealed class Class2547
		{
			// Token: 0x0600D8B3 RID: 55475 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D8B4 RID: 55476 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DB8D RID: 56205
			public TaskCompletionSource<bool> taskSource;
		}
	}
}
