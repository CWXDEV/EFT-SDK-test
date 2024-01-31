using System;
using System.Runtime.CompilerServices;
using System.Threading;
using JetBrains.Annotations;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C5C RID: 11356
	public class UIElement : SerializedMonoBehaviour, IDisposable, IShowable, IUIView
	{
		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600DFE6 RID: 57318 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		public GameObject GameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600DFE7 RID: 57319 RVA: 0x00002050 File Offset: 0x00000250
		protected RectTransform RectTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600DFE8 RID: 57320 RVA: 0x00002050 File Offset: 0x00000250
		protected CancellationToken CancellationToken
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600DFE9 RID: 57321 RVA: 0x00002050 File Offset: 0x00000250
		public Transform Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CorrectPosition(GStruct55 margins = default(GStruct55))
		{
			throw null;
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddDisposable(Action action)
		{
			throw null;
		}

		// Token: 0x0600DFEC RID: 57324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Display()
		{
			throw null;
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowGameObject()
		{
			throw null;
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideGameObject()
		{
			throw null;
		}

		// Token: 0x0400E481 RID: 58497
		protected readonly GClass764 UI;

		// Token: 0x0400E482 RID: 58498
		private RectTransform rectTransform_0;
	}
}
