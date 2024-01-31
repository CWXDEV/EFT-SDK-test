using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002CAD RID: 11437
	[ExecuteInEditMode]
	[UsedImplicitly]
	public sealed class ToggleButton : UIElement, IEventSystemHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600E13E RID: 57662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E13F RID: 57663 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsOn
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

		// Token: 0x0600E140 RID: 57664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetValueSilently(bool isOn)
		{
			throw null;
		}

		// Token: 0x0600E141 RID: 57665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool notify = false)
		{
			throw null;
		}

		// Token: 0x0600E142 RID: 57666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600E143 RID: 57667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600E144 RID: 57668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E145 RID: 57669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E146 RID: 57670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E5FF RID: 58879
		[SerializeField]
		private Image _image;

		// Token: 0x0400E600 RID: 58880
		[SerializeField]
		private Sprite _onSprite;

		// Token: 0x0400E601 RID: 58881
		[SerializeField]
		private Sprite _offSprite;

		// Token: 0x0400E602 RID: 58882
		[SerializeField]
		private Graphic _labelOn;

		// Token: 0x0400E603 RID: 58883
		[SerializeField]
		private Graphic _labelOff;

		// Token: 0x0400E604 RID: 58884
		[SerializeField]
		private bool _isOn;

		// Token: 0x0400E605 RID: 58885
		[NonSerialized]
		public readonly GClass3355<bool> OnToggle;
	}
}
