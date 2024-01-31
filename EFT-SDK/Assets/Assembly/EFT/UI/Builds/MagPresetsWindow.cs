using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HandBook;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.Builds
{
	// Token: 0x02002EFE RID: 12030
	[UsedImplicitly]
	public sealed class MagPresetsWindow : Window<GClass3087>, GClass2816.GInterface335
	{
		// Token: 0x1400034F RID: 847
		// (add) Token: 0x0600ED92 RID: 60818 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600ED93 RID: 60819 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Item, bool> OnItemSelected
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

		// Token: 0x0600ED94 RID: 60820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 Show(GClass2819 itemContext, MongoID? presetId, GClass2088 storage, InventoryControllerClass controller)
		{
			throw null;
		}

		// Token: 0x0600ED95 RID: 60821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600ED96 RID: 60822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600ED97 RID: 60823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Item item, bool selected)
		{
			throw null;
		}

		// Token: 0x0600ED98 RID: 60824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool visible)
		{
			throw null;
		}

		// Token: 0x0600ED99 RID: 60825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_6(GClass2089 preset, bool forced = false)
		{
			throw null;
		}

		// Token: 0x0600ED9A RID: 60826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_7()
		{
			throw null;
		}

		// Token: 0x0600ED9B RID: 60827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_8(string caliber)
		{
			throw null;
		}

		// Token: 0x0600ED9C RID: 60828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600ED9D RID: 60829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_10(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600ED9E RID: 60830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11(Item item)
		{
			throw null;
		}

		// Token: 0x0600ED9F RID: 60831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(MagazineClass magazine)
		{
			throw null;
		}

		// Token: 0x0600EDA0 RID: 60832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(MagazineClass magazine, bool updateHighlight)
		{
			throw null;
		}

		// Token: 0x0600EDA1 RID: 60833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_14(BulletClass selectedAmmo)
		{
			throw null;
		}

		// Token: 0x0600EDA2 RID: 60834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600EDA3 RID: 60835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<bool> CloseInterruption()
		{
			throw null;
		}

		// Token: 0x0600EDA4 RID: 60836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x0600EDA5 RID: 60837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_17()
		{
			throw null;
		}

		// Token: 0x0600EDA6 RID: 60838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(string presetName, IReadOnlyDictionary<MongoID, int> itemsToBuy)
		{
			throw null;
		}

		// Token: 0x0600EDA7 RID: 60839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_19(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600EDA8 RID: 60840 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600EDA9 RID: 60841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_21(GClass2089 preset, bool rename)
		{
			throw null;
		}

		// Token: 0x0600EDAA RID: 60842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_22(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600EDAB RID: 60843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23()
		{
			throw null;
		}

		// Token: 0x0600EDAC RID: 60844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsActive(GClass2816 context, out string tooltip)
		{
			throw null;
		}

		// Token: 0x0600EDAD RID: 60845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsSelected(Item item)
		{
			throw null;
		}

		// Token: 0x0600EDAE RID: 60846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GClass2816.GInterface335.ToggleSelection(GClass2816 context)
		{
			throw null;
		}

		// Token: 0x0400F280 RID: 62080
		[CompilerGenerated]
		private Action<Item, bool> action_1;

		// Token: 0x0400F281 RID: 62081
		private const string string_0 = "MagPreset/DiscardCahangesDescription";

		// Token: 0x0400F282 RID: 62082
		private const string string_1 = "MagPreset/HasMissingItems";

		// Token: 0x0400F283 RID: 62083
		private const string string_2 = "MagPreset/ReplaceMessage";

		// Token: 0x0400F284 RID: 62084
		private const string string_3 = "MagPreset/SetNameWindowCaption";

		// Token: 0x0400F285 RID: 62085
		private const string string_4 = "MagPreset/SetNameWindowPlaceholder";

		// Token: 0x0400F286 RID: 62086
		private const string string_5 = "MagPreset/RemoveCaption";

		// Token: 0x0400F287 RID: 62087
		private const string string_6 = "MagPreset/RemoveMessage{0}";

		// Token: 0x0400F288 RID: 62088
		private const string string_7 = "MagPreset/PresetSaved{0}";

		// Token: 0x0400F289 RID: 62089
		private const string string_8 = "MagPreset/PresetRemoved{0}";

		// Token: 0x0400F28A RID: 62090
		private const string string_9 = "MagPreset/PresetRenamed{0}";

		// Token: 0x0400F28B RID: 62091
		private const string string_10 = "MagPreset/Tooltip/IncompatibleAmmo";

		// Token: 0x0400F28C RID: 62092
		private const string string_11 = "MagPreset/Tooltip/LoopAmmoRequired";

		// Token: 0x0400F28D RID: 62093
		private const string string_12 = "MagPreset/Tooltip/TotalLimitReached";

		// Token: 0x0400F28E RID: 62094
		private const string string_13 = "MagPreset/Tooltip/CaliberLimitReached";

		// Token: 0x0400F28F RID: 62095
		private const string string_14 = "MagPreset/Tooltip/HasNoChanges";

		// Token: 0x0400F290 RID: 62096
		private const string string_15 = "MagPreset/Tooltip/NoMagsSelected";

		// Token: 0x0400F291 RID: 62097
		[SerializeField]
		private MagPresetsListView _presetsList;

		// Token: 0x0400F292 RID: 62098
		[SerializeField]
		private GameObject _presetsContainer;

		// Token: 0x0400F293 RID: 62099
		[SerializeField]
		private MagPresetEditor _presetEditor;

		// Token: 0x0400F294 RID: 62100
		[SerializeField]
		private EntityIcon _magPreview;

		// Token: 0x0400F295 RID: 62101
		[SerializeField]
		private GameObject _emptyIcon;

		// Token: 0x0400F296 RID: 62102
		[SerializeField]
		private DefaultUiButtonNewStyle _saveButton;

		// Token: 0x0400F297 RID: 62103
		[SerializeField]
		private DefaultUiButtonNewStyle _loadMagButton;

		// Token: 0x0400F298 RID: 62104
		[SerializeField]
		private DefaultUiButtonNewStyle _showListButton;

		// Token: 0x0400F299 RID: 62105
		[SerializeField]
		private DefaultUiButtonNewStyle _hideListButton;

		// Token: 0x0400F29A RID: 62106
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400F29B RID: 62107
		private List<MagazineClass> list_0;

		// Token: 0x0400F29C RID: 62108
		private List<MagazineClass> list_1;

		// Token: 0x0400F29D RID: 62109
		private BulletClass gclass2732_0;

		// Token: 0x0400F29E RID: 62110
		private GClass2089 gclass2089_0;

		// Token: 0x0400F29F RID: 62111
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F2A0 RID: 62112
		private GClass2088 gclass2088_0;

		// Token: 0x0400F2A1 RID: 62113
		private GClass2089 gclass2089_1;

		// Token: 0x0400F2A2 RID: 62114
		private bool bool_0;

		// Token: 0x0400F2A3 RID: 62115
		private Task<bool> task_1;

		// Token: 0x0400F2A4 RID: 62116
		private bool bool_1;

		// Token: 0x02002EFF RID: 12031
		[Serializable]
		public struct CompositionGroup
		{
			// Token: 0x0400F2A5 RID: 62117
			[SerializeField]
			[UsedImplicitly]
			public GameObject View;

			// Token: 0x0400F2A6 RID: 62118
			[SerializeField]
			[UsedImplicitly]
			public RectTransform Container;

			// Token: 0x0400F2A7 RID: 62119
			[UsedImplicitly]
			[SerializeField]
			public GameObject Blocker;
		}

		// Token: 0x02002F00 RID: 12032
		[CompilerGenerated]
		private sealed class Class2968
		{
			// Token: 0x0600EDAF RID: 60847 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass2089 preset)
			{
				throw null;
			}

			// Token: 0x0600EDB0 RID: 60848 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GClass2089 preset)
			{
				throw null;
			}

			// Token: 0x0600EDB1 RID: 60849 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass2089 preset)
			{
				throw null;
			}

			// Token: 0x0600EDB2 RID: 60850 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(string caliber)
			{
				throw null;
			}

			// Token: 0x0600EDB3 RID: 60851 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0600EDB4 RID: 60852 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5()
			{
				throw null;
			}

			// Token: 0x0600EDB5 RID: 60853 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6()
			{
				throw null;
			}

			// Token: 0x0600EDB6 RID: 60854 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_7()
			{
				throw null;
			}

			// Token: 0x0400F2A8 RID: 62120
			public MagPresetsWindow magPresetsWindow_0;

			// Token: 0x0400F2A9 RID: 62121
			public InventoryControllerClass controller;
		}

		// Token: 0x02002F02 RID: 12034
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2969
		{
			// Token: 0x0600EDB9 RID: 60857 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600EDBA RID: 60858 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600EDBB RID: 60859 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(GClass2089.GClass2090 item)
			{
				throw null;
			}

			// Token: 0x0600EDBC RID: 60860 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(KeyValuePair<MongoID, int> itemData)
			{
				throw null;
			}

			// Token: 0x0600EDBD RID: 60861 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_4(KeyValuePair<MongoID, int> itemData)
			{
				throw null;
			}

			// Token: 0x0600EDBE RID: 60862 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5()
			{
				throw null;
			}

			// Token: 0x0600EDBF RID: 60863 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6()
			{
				throw null;
			}

			// Token: 0x0600EDC0 RID: 60864 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_7()
			{
				throw null;
			}

			// Token: 0x0400F2B2 RID: 62130
			public static readonly MagPresetsWindow.Class2969 class2969_0;

			// Token: 0x0400F2B3 RID: 62131
			public static Action action_0;

			// Token: 0x0400F2B4 RID: 62132
			public static Action action_1;

			// Token: 0x0400F2B5 RID: 62133
			public static Func<GClass2089.GClass2090, bool> func_0;

			// Token: 0x0400F2B6 RID: 62134
			public static Func<KeyValuePair<MongoID, int>, string> func_1;

			// Token: 0x0400F2B7 RID: 62135
			public static Func<KeyValuePair<MongoID, int>, int> func_2;

			// Token: 0x0400F2B8 RID: 62136
			public static Action action_2;

			// Token: 0x0400F2B9 RID: 62137
			public static Action action_3;

			// Token: 0x0400F2BA RID: 62138
			public static Action action_4;
		}

		// Token: 0x02002F07 RID: 12039
		[CompilerGenerated]
		private sealed class Class2970
		{
			// Token: 0x0600EDC9 RID: 60873 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2089 foundPreset)
			{
				throw null;
			}

			// Token: 0x0400F2D2 RID: 62162
			public GClass2089 preset;

			// Token: 0x0400F2D3 RID: 62163
			public GClass2089 conflictingPreset;
		}

		// Token: 0x02002F08 RID: 12040
		[CompilerGenerated]
		private sealed class Class2971
		{
			// Token: 0x0600EDCA RID: 60874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600EDCB RID: 60875 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(bool contained)
			{
				throw null;
			}

			// Token: 0x0400F2D4 RID: 62164
			public TaskCompletionSource<bool> taskSource;
		}

		// Token: 0x02002F0B RID: 12043
		[CompilerGenerated]
		private sealed class Class2972
		{
			// Token: 0x0600EDD0 RID: 60880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2089 oldPreset)
			{
				throw null;
			}

			// Token: 0x0400F2E2 RID: 62178
			public GClass2089 preset;
		}
	}
}
