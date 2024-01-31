using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F89 RID: 12169
	public sealed class CombinedView : UIElement
	{
		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600EFF5 RID: 61429 RVA: 0x00002050 File Offset: 0x00000250
		public NodeBaseView CategoryView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600EFF6 RID: 61430 RVA: 0x00002050 File Offset: 0x00000250
		public NodeBaseView SubcategoryView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600EFF7 RID: 61431 RVA: 0x00002050 File Offset: 0x00000250
		public NodeBaseView SelectedView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EFF8 RID: 61432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] RagFairClass ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, GClass2884 node, EViewListType viewListType, EWindowType windowType, Dictionary<string, NodeBaseView> viewNodes, string forbiddenItem, Action<NodeBaseView, string> onSelection, Action<NodeBaseView, string> onConfirmedSelection = null)
		{
			throw null;
		}

		// Token: 0x0600EFF9 RID: 61433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600EFFA RID: 61434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400F572 RID: 62834
		[SerializeField]
		private CategoryView _categoryView;

		// Token: 0x0400F573 RID: 62835
		[SerializeField]
		private NodeBaseView _subcategoryView;

		// Token: 0x0400F574 RID: 62836
		private EViewListType eviewListType_0;

		// Token: 0x0400F575 RID: 62837
		private RagFairClass gclass3190_0;

		// Token: 0x02002F8A RID: 12170
		[CompilerGenerated]
		private sealed class Class3032
		{
			// Token: 0x0600EFFB RID: 61435 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400F576 RID: 62838
			public GClass2884 node;

			// Token: 0x0400F577 RID: 62839
			public CombinedView combinedView_0;
		}
	}
}
