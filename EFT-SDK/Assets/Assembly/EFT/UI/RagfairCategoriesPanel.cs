using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002BCC RID: 11212
	public sealed class RagfairCategoriesPanel : BrowseCategoriesPanel
	{
		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600DD18 RID: 56600 RVA: 0x00002050 File Offset: 0x00000250
		protected override string FilterString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600DD19 RID: 56601 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool DisplayLoadingStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(string forbiddenItem, RagFairClass ragfair, GClass2881 handbook, [CanBeNull] GClass3354 originalNodes, GClass3354 nodes, GClass3354 filteredNodes, SimpleContextMenu contextMenu, EViewListType viewListType, EWindowType windowType, Action<NodeBaseView, string> onSelection, Action<NodeBaseView, string> onCreation = null, Action<string> onFindById = null)
		{
			throw null;
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearIdFilter()
		{
			throw null;
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass3192 cancellableFilter)
		{
			throw null;
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInputFieldText(string text)
		{
			throw null;
		}

		// Token: 0x0600DD23 RID: 56611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(string arg)
		{
			throw null;
		}

		// Token: 0x0600DD25 RID: 56613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool Allowed(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600DD26 RID: 56614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DD27 RID: 56615 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E16F RID: 57711
		private Action<string> action_2;

		// Token: 0x0400E170 RID: 57712
		private string string_1;

		// Token: 0x02002BCD RID: 11213
		[CompilerGenerated]
		private sealed class Class2661
		{
			// Token: 0x0600DD28 RID: 56616 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E171 RID: 57713
			public string buffer;

			// Token: 0x0400E172 RID: 57714
			public RagfairCategoriesPanel ragfairCategoriesPanel_0;
		}

		// Token: 0x02002BCE RID: 11214
		[CompilerGenerated]
		private sealed class Class2662
		{
			// Token: 0x0600DD29 RID: 56617 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal CombinedView method_0(GClass2884 arg)
			{
				throw null;
			}

			// Token: 0x0600DD2A RID: 56618 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_1(GClass2884 arg)
			{
				throw null;
			}

			// Token: 0x0600DD2B RID: 56619 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass2884 node, CombinedView view)
			{
				throw null;
			}

			// Token: 0x0600DD2C RID: 56620 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0600DD2D RID: 56621 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0400E173 RID: 57715
			public RagfairCategoriesPanel ragfairCategoriesPanel_0;

			// Token: 0x0400E174 RID: 57716
			public EViewListType viewListType;

			// Token: 0x0400E175 RID: 57717
			public EWindowType windowType;

			// Token: 0x0400E176 RID: 57718
			public string forbiddenItem;

			// Token: 0x0400E177 RID: 57719
			public Action<NodeBaseView, string> onCreation;

			// Token: 0x0400E178 RID: 57720
			public GClass3354 originalNodes;

			// Token: 0x0400E179 RID: 57721
			public RagFairClass ragfair;
		}

		// Token: 0x02002BCF RID: 11215
		[CompilerGenerated]
		private sealed class Class2663
		{
			// Token: 0x0600DD2E RID: 56622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E17A RID: 57722
			public GClass2884 value;

			// Token: 0x0400E17B RID: 57723
			public RagfairCategoriesPanel.Class2662 class2662_0;
		}

		// Token: 0x02002BD1 RID: 11217
		[CompilerGenerated]
		private sealed class Class2664
		{
			// Token: 0x0600DD31 RID: 56625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<string, GClass2884> x)
			{
				throw null;
			}

			// Token: 0x0400E18D RID: 57741
			public GClass2884 node;
		}
	}
}
