using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x020029F2 RID: 10738
	public sealed class EditTagWindow : Window<GClass3085>, IEventSystemHandler, IPointerClickHandler, GInterface104, GInterface106
	{
		// Token: 0x0600D55C RID: 54620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color GetColor(int colorIndex)
		{
			throw null;
		}

		// Token: 0x0600D55D RID: 54621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(TagComponent tagComponent, Action onSelected, Action onClosed, Action<string, int> save)
		{
			throw null;
		}

		// Token: 0x0600D55E RID: 54622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 obj)
		{
			throw null;
		}

		// Token: 0x0600D55F RID: 54623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(string newText)
		{
			throw null;
		}

		// Token: 0x0600D560 RID: 54624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(ColorView cell, int colorIndex)
		{
			throw null;
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D563 RID: 54627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D771 RID: 55153
		private static readonly Color[] color_0;

		// Token: 0x0400D772 RID: 55154
		private const string string_0 = "{0}/{1}";

		// Token: 0x0400D773 RID: 55155
		private const string string_1 = "container tag";

		// Token: 0x0400D774 RID: 55156
		[SerializeField]
		private ValidationInputField _tagInput;

		// Token: 0x0400D775 RID: 55157
		[SerializeField]
		private TextMeshProUGUI _simbolsCounter;

		// Token: 0x0400D776 RID: 55158
		[SerializeField]
		private DefaultUIButton _saveButtonSpawner;

		// Token: 0x0400D777 RID: 55159
		[SerializeField]
		private TextMeshProUGUI _containerTagLabel;

		// Token: 0x0400D778 RID: 55160
		[SerializeField]
		private TagColorsPanel _colorsPanel;

		// Token: 0x0400D779 RID: 55161
		private TagComponent tagComponent_0;

		// Token: 0x0400D77A RID: 55162
		private IItemOwner iitemOwner_0;

		// Token: 0x0400D77B RID: 55163
		private ColorView colorView_0;

		// Token: 0x0400D77C RID: 55164
		private int int_0;

		// Token: 0x0400D77D RID: 55165
		private Action action_1;

		// Token: 0x0400D77E RID: 55166
		private Action<string, int> action_2;
	}
}
