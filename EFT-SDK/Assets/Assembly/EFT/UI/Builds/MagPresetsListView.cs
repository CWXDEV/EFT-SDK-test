using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI.Builds
{
	// Token: 0x02002EFA RID: 12026
	[UsedImplicitly]
	public sealed class MagPresetsListView : UIElement
	{
		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600ED7C RID: 60796 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<GClass2089> OnSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600ED7D RID: 60797 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<GClass2089> OnDelete
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600ED7E RID: 60798 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<GClass2089> OnRename
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ED7F RID: 60799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2088 storage, MongoID? currentPresetId)
		{
			throw null;
		}

		// Token: 0x0600ED80 RID: 60800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPresetAsSelected(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string text)
		{
			throw null;
		}

		// Token: 0x0600ED82 RID: 60802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(MagPresetsListView.Class2417 presetWrapper)
		{
			throw null;
		}

		// Token: 0x0600ED83 RID: 60803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(MagPresetsListView.Class2417 presetWrapper)
		{
			throw null;
		}

		// Token: 0x0600ED84 RID: 60804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(MagPresetsListView.Class2417 presetWrapper)
		{
			throw null;
		}

		// Token: 0x0600ED85 RID: 60805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600ED86 RID: 60806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600ED87 RID: 60807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600ED88 RID: 60808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_7(GClass2089 preset, out MagPresetsListView.Class2417 wrapper)
		{
			throw null;
		}

		// Token: 0x0600ED89 RID: 60809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600ED8A RID: 60810 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0400F26F RID: 62063
		[SerializeField]
		private ValidationInputField _searchField;

		// Token: 0x0400F270 RID: 62064
		[SerializeField]
		private MagPresetView _presetViewTemplate;

		// Token: 0x0400F271 RID: 62065
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400F272 RID: 62066
		[SerializeField]
		private TMP_Text _presetCountField;

		// Token: 0x0400F273 RID: 62067
		[SerializeField]
		private TMP_Text _presetMaxCountField;

		// Token: 0x0400F274 RID: 62068
		private readonly GClass3355<GClass2089> gclass3355_0;

		// Token: 0x0400F275 RID: 62069
		private readonly GClass3355<GClass2089> gclass3355_1;

		// Token: 0x0400F276 RID: 62070
		private readonly GClass3355<GClass2089> gclass3355_2;

		// Token: 0x0400F277 RID: 62071
		private GClass2088 gclass2088_0;

		// Token: 0x0400F278 RID: 62072
		private List<MagPresetsListView.Class2417> list_0;

		// Token: 0x0400F279 RID: 62073
		private List<MagPresetView> list_1;

		// Token: 0x0400F27A RID: 62074
		private MongoID? nullable_0;

		// Token: 0x02002EFB RID: 12027
		private sealed class Class2417 : GClass3017<GClass2089>
		{
			// Token: 0x170028CC RID: 10444
			// (get) Token: 0x0600ED8B RID: 60811 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ED8C RID: 60812 RVA: 0x00002050 File Offset: 0x00000250
			public MagPresetView View
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

			// Token: 0x0600ED8D RID: 60813 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose(ICollection<MagPresetView> viewPool)
			{
				throw null;
			}

			// Token: 0x0400F27B RID: 62075
			public readonly GClass763 Disposable;

			// Token: 0x0400F27C RID: 62076
			[CompilerGenerated]
			private MagPresetView magPresetView_0;
		}

		// Token: 0x02002EFC RID: 12028
		[CompilerGenerated]
		private sealed class Class2966
		{
			// Token: 0x0600ED8E RID: 60814 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600ED8F RID: 60815 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600ED90 RID: 60816 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(bool selected)
			{
				throw null;
			}

			// Token: 0x0400F27D RID: 62077
			public MagPresetsListView magPresetsListView_0;

			// Token: 0x0400F27E RID: 62078
			public MagPresetsListView.Class2417 wrapper;
		}

		// Token: 0x02002EFD RID: 12029
		[CompilerGenerated]
		private sealed class Class2967
		{
			// Token: 0x0600ED91 RID: 60817 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(MagPresetsListView.Class2417 existingWrapper)
			{
				throw null;
			}

			// Token: 0x0400F27F RID: 62079
			public GClass2089 preset;
		}
	}
}
