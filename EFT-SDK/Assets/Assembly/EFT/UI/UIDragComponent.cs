using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C5B RID: 11355
	[RequireComponent(typeof(Graphic))]
	[RequireComponent(typeof(RectTransform))]
	public sealed class UIDragComponent : UIBehaviour, IEventSystemHandler, IDragHandler, IBeginDragHandler
	{
		// Token: 0x0600DFDE RID: 57310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(RectTransform target, bool putOnTop)
		{
			throw null;
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(bool showError = false)
		{
			throw null;
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDragHandler.OnDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E47E RID: 58494
		[SerializeField]
		private RectTransform _target;

		// Token: 0x0400E47F RID: 58495
		[SerializeField]
		private bool _putOnTop;

		// Token: 0x0400E480 RID: 58496
		private Vector2 vector2_0;
	}
}
