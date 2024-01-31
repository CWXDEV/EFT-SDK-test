using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B82 RID: 11138
	public class Tooltip : UIElement
	{
		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600DBE1 RID: 56289 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DBE2 RID: 56290 RVA: 0x00002050 File Offset: 0x00000250
		public bool Displayed
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

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600DBE6 RID: 56294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CancellationToken Show(Vector2 offset = default(Vector2), float delay = 0f)
		{
			throw null;
		}

		// Token: 0x0600DBE7 RID: 56295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Display()
		{
			throw null;
		}

		// Token: 0x0600DBE8 RID: 56296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DBE9 RID: 56297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x0600DBEA RID: 56298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0400DFE2 RID: 57314
		[SerializeField]
		private RectTransform _mainTransform;

		// Token: 0x0400DFE3 RID: 57315
		[SerializeField]
		private RectTransform _boundsTransform;

		// Token: 0x0400DFE4 RID: 57316
		private Coroutine coroutine_0;

		// Token: 0x0400DFE5 RID: 57317
		private Vector2 vector2_0;

		// Token: 0x0400DFE6 RID: 57318
		[CompilerGenerated]
		private bool bool_0;
	}
}
