using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C7A RID: 11386
	public sealed class BuildsCategoriesPanel : BrowseCategoriesPanel
	{
		// Token: 0x0600E058 RID: 57432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(RagFairClass ragfair, GClass2881 handbook, GClass3354 nodes, GClass3354 filteredNodes, [CanBeNull] SimpleContextMenu contextMenu, EViewListType viewListType, EWindowType windowType, [CanBeNull] string initialNodeId, Action<NodeBaseView, string> onSelection, Action<NodeBaseView, string> onConfirmedSelection)
		{
			throw null;
		}

		// Token: 0x0400E4FB RID: 58619
		[SerializeField]
		private ScrollRectNoDrag _scrollRect;

		// Token: 0x02002C7B RID: 11387
		[CompilerGenerated]
		private sealed class Class2712
		{
			// Token: 0x0600E059 RID: 57433 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal CombinedView method_0(GClass2884 arg)
			{
				throw null;
			}

			// Token: 0x0600E05A RID: 57434 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_1(GClass2884 arg)
			{
				throw null;
			}

			// Token: 0x0600E05B RID: 57435 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass2884 node, CombinedView view)
			{
				throw null;
			}

			// Token: 0x0400E4FC RID: 58620
			public BuildsCategoriesPanel buildsCategoriesPanel_0;

			// Token: 0x0400E4FD RID: 58621
			public EViewListType viewListType;

			// Token: 0x0400E4FE RID: 58622
			public EWindowType windowType;

			// Token: 0x0400E4FF RID: 58623
			public Action<NodeBaseView, string> onConfirmedSelection;

			// Token: 0x0400E500 RID: 58624
			public string initialNodeId;
		}
	}
}
