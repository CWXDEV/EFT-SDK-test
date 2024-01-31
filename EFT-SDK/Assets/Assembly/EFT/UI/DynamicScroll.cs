using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BC0 RID: 11200
	public class DynamicScroll : MonoBehaviour
	{
		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x00002050 File Offset: 0x00000250
		private float? Nullable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DCB9 RID: 56505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600DCBA RID: 56506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DCBB RID: 56507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DCBC RID: 56508 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DynamicScrollElement method_1()
		{
			throw null;
		}

		// Token: 0x0600DCBD RID: 56509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private KeyValuePair<bool, bool> method_2(DynamicScrollElement element)
		{
			throw null;
		}

		// Token: 0x0600DCBE RID: 56510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Disable(DynamicScrollElement scrollElement, EArrangement arrangement)
		{
			throw null;
		}

		// Token: 0x0600DCBF RID: 56511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Enable(DynamicScrollElement scrollElement, EArrangement arrangement)
		{
			throw null;
		}

		// Token: 0x0600DCC0 RID: 56512 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector2 arg)
		{
			throw null;
		}

		// Token: 0x0400E125 RID: 57637
		[SerializeField]
		private int _visibleCount;

		// Token: 0x0400E126 RID: 57638
		[SerializeField]
		private VerticalLayoutGroup _layoutGroup;

		// Token: 0x0400E127 RID: 57639
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400E128 RID: 57640
		[SerializeField]
		private List<DynamicScrollElement> _activeElements;

		// Token: 0x0400E129 RID: 57641
		[SerializeField]
		private List<DynamicScrollElement> _disabledElements;

		// Token: 0x0400E12A RID: 57642
		private readonly SortedList<int, DynamicScrollElement> sortedList_0;

		// Token: 0x0400E12B RID: 57643
		private int int_0;

		// Token: 0x0400E12C RID: 57644
		private float? nullable_0;
	}
}
