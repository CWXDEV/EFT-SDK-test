using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diz.Binding;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B02 RID: 11010
	[UsedImplicitly]
	public sealed class EquipmentBuildPanel : UIElement
	{
		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface386 OnShowEquipmentBuilds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3182 buildsStorage, GClass2759 inventoryController, Profile profile)
		{
			throw null;
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0()
		{
			throw null;
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400DD80 RID: 56704
		[SerializeField]
		private Button _presetSaveButton;

		// Token: 0x0400DD81 RID: 56705
		[SerializeField]
		private Button _presetLoadButton;

		// Token: 0x0400DD82 RID: 56706
		[SerializeField]
		private TextMeshProUGUI _lastPresetName;

		// Token: 0x0400DD83 RID: 56707
		private readonly BindableEvent bindableEvent_0;

		// Token: 0x0400DD84 RID: 56708
		private GClass2759 gclass2759_0;

		// Token: 0x0400DD85 RID: 56709
		private GClass3182 gclass3182_0;

		// Token: 0x0400DD86 RID: 56710
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400DD87 RID: 56711
		private Profile profile_0;

		// Token: 0x02002B03 RID: 11011
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2583
		{
			// Token: 0x0600DA88 RID: 55944 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DD88 RID: 56712
			public static readonly EquipmentBuildPanel.Class2583 class2583_0;

			// Token: 0x0400DD89 RID: 56713
			public static Action action_0;
		}
	}
}
