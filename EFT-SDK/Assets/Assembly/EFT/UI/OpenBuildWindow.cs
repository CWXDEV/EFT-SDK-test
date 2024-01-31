using System;
using System.Runtime.CompilerServices;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C7D RID: 11389
	public sealed class OpenBuildWindow : BaseUiWindow
	{
		// Token: 0x0600E05E RID: 57438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600E05F RID: 57439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(RagFairClass ragfair, GClass2881 handbook, GClass3184 storage, [CanBeNull] string selectedWeaponTemplateId, Action<GClass3183> onBuildSelected)
		{
			throw null;
		}

		// Token: 0x0600E060 RID: 57440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E061 RID: 57441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E062 RID: 57442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(NodeBaseView view, string buildId)
		{
			throw null;
		}

		// Token: 0x0600E063 RID: 57443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(NodeBaseView view, string buildId)
		{
			throw null;
		}

		// Token: 0x0400E50F RID: 58639
		[SerializeField]
		private DefaultUIButton _openButton;

		// Token: 0x0400E510 RID: 58640
		[SerializeField]
		private BuildsCategoriesPanel _categoriesPanel;

		// Token: 0x0400E511 RID: 58641
		private GClass3184 gclass3184_0;

		// Token: 0x0400E512 RID: 58642
		private NodeBaseView nodeBaseView_0;

		// Token: 0x0400E513 RID: 58643
		private Action<GClass3183> action_0;

		// Token: 0x0400E514 RID: 58644
		private string string_0;
	}
}
