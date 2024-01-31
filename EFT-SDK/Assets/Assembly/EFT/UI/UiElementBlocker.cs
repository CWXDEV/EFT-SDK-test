using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C6E RID: 11374
	public sealed class UiElementBlocker : MonoBehaviour
	{
		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600E029 RID: 57385 RVA: 0x00002050 File Offset: 0x00000250
		public Transform Container
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E02A RID: 57386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBlock()
		{
			throw null;
		}

		// Token: 0x0600E02B RID: 57387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlock(bool block, string reason = null)
		{
			throw null;
		}

		// Token: 0x0600E02C RID: 57388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBlock(string reason)
		{
			throw null;
		}

		// Token: 0x0600E02D RID: 57389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveBlock()
		{
			throw null;
		}

		// Token: 0x0400E4B6 RID: 58550
		[SerializeField]
		private CanvasGroup Group;

		// Token: 0x0400E4B7 RID: 58551
		[SerializeField]
		private Graphic Graphic;

		// Token: 0x0400E4B8 RID: 58552
		[SerializeField]
		private HoverTooltipArea Tooltip;
	}
}
