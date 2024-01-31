using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Diz.Binding;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x020028F0 RID: 10480
	[UsedImplicitly]
	[ExecuteInEditMode]
	public class DefaultUiButtonNewStyle : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x0600D148 RID: 53576 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface386 OnClick
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x0600D149 RID: 53577 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D14A RID: 53578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLabel(string label)
		{
			throw null;
		}

		// Token: 0x0600D14B RID: 53579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAvailability(bool interactive, string tooltip = null)
		{
			throw null;
		}

		// Token: 0x0600D14C RID: 53580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D14D RID: 53581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600D152 RID: 53586 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0400D236 RID: 53814
		[SerializeField]
		private Dictionary<DefaultUiButtonNewStyle.EButtonState, List<GameObject>> _states;

		// Token: 0x0400D237 RID: 53815
		[SerializeField]
		private List<TMP_Text> _labels;

		// Token: 0x0400D238 RID: 53816
		private bool bool_0;

		// Token: 0x0400D239 RID: 53817
		private bool bool_1;

		// Token: 0x0400D23A RID: 53818
		private bool bool_2;

		// Token: 0x0400D23B RID: 53819
		private string string_0;

		// Token: 0x0400D23C RID: 53820
		private CancellationToken cancellationToken_0;

		// Token: 0x0400D23D RID: 53821
		private BindableEvent bindableEvent_0;

		// Token: 0x020028F1 RID: 10481
		[UsedImplicitly]
		public enum EButtonState
		{
			// Token: 0x0400D23F RID: 53823
			Normal,
			// Token: 0x0400D240 RID: 53824
			Hover,
			// Token: 0x0400D241 RID: 53825
			Pressed,
			// Token: 0x0400D242 RID: 53826
			Disabled
		}
	}
}
