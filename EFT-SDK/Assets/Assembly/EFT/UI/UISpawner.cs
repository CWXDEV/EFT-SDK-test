using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C6B RID: 11371
	public class UISpawner<T> : UIElement where T : MonoBehaviour
	{
		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600E01F RID: 57375 RVA: 0x00002050 File Offset: 0x00000250
		public T SpawnedObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E020 RID: 57376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual T SpawnObject()
		{
			throw null;
		}

		// Token: 0x0600E021 RID: 57377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_0(string caption, int size)
		{
			throw null;
		}

		// Token: 0x0600E022 RID: 57378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetMinWidth(float minWidth)
		{
			throw null;
		}

		// Token: 0x0600E023 RID: 57379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetEllipsis(bool useEllipsis)
		{
			throw null;
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E026 RID: 57382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400E4AE RID: 58542
		[SerializeField]
		protected T _object;

		// Token: 0x0400E4AF RID: 58543
		[SerializeField]
		protected string _headerCaption;

		// Token: 0x0400E4B0 RID: 58544
		[SerializeField]
		protected int _headerFontSize;

		// Token: 0x0400E4B1 RID: 58545
		[SerializeField]
		protected List<Transform> _preservedChildren;

		// Token: 0x0400E4B2 RID: 58546
		[SerializeField]
		protected float _minWidth;

		// Token: 0x0400E4B3 RID: 58547
		[SerializeField]
		protected bool _useEllipsis;

		// Token: 0x0400E4B4 RID: 58548
		private Action action_0;

		// Token: 0x0400E4B5 RID: 58549
		private T gparam_0;
	}
}
