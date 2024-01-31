using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002CAF RID: 11439
	[UsedImplicitly]
	public sealed class TraderDialogHistoryView : UIElement
	{
		// Token: 0x0600E148 RID: 57672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2052 history)
		{
			throw null;
		}

		// Token: 0x0600E149 RID: 57673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass2052.GStruct248 line)
		{
			throw null;
		}

		// Token: 0x0600E14B RID: 57675 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400E608 RID: 58888
		[SerializeField]
		private TraderDialogBubble _traderBubbleTemplate;

		// Token: 0x0400E609 RID: 58889
		[SerializeField]
		private TraderDialogBubble _playerBubbleTemplate;

		// Token: 0x0400E60A RID: 58890
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400E60B RID: 58891
		[SerializeField]
		private Scrollbar _scrollBar;

		// Token: 0x0400E60C RID: 58892
		private GClass2052 gclass2052_0;

		// Token: 0x0400E60D RID: 58893
		private readonly Queue<TraderDialogBubble> queue_0;

		// Token: 0x0400E60E RID: 58894
		private readonly Queue<TraderDialogBubble> queue_1;

		// Token: 0x0400E60F RID: 58895
		private readonly GClass763 gclass763_0;

		// Token: 0x02002CB0 RID: 11440
		[CompilerGenerated]
		private sealed class Class2728
		{
			// Token: 0x0600E14C RID: 57676 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E610 RID: 58896
			public TraderDialogBubble bubble;

			// Token: 0x0400E611 RID: 58897
			public Queue<TraderDialogBubble> pool;
		}
	}
}
