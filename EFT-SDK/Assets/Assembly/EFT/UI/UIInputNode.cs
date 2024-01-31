using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C62 RID: 11362
	public abstract class UIInputNode : InputNode, IShowable
	{
		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual RectTransform RectTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Display()
		{
			throw null;
		}

		// Token: 0x0600E006 RID: 57350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ShowGameObject(bool instant = false)
		{
			throw null;
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void HideGameObject()
		{
			throw null;
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CorrectPosition(GStruct55 margins = default(GStruct55))
		{
			throw null;
		}

		// Token: 0x0400E496 RID: 58518
		protected readonly GClass764 UI;

		// Token: 0x0400E497 RID: 58519
		private RectTransform rectTransform_0;
	}
}
