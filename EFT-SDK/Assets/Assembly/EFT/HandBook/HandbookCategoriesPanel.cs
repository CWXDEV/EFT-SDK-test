using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI;
using EFT.UI.Ragfair;
using UnityEngine;

namespace EFT.HandBook
{
	// Token: 0x0200260E RID: 9742
	public sealed class HandbookCategoriesPanel : BrowseCategoriesPanel
	{
		// Token: 0x0600C17C RID: 49532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600C17D RID: 49533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(RagFairClass ragfair, GClass2881 handbook, GClass3354 nodes, GClass3354 filteredNodes, ItemUiContext itemUiContext, List<string> questItems, Action<NodeBaseView, string> onSelection)
		{
			throw null;
		}

		// Token: 0x0600C17E RID: 49534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void FilterHandler()
		{
			throw null;
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(string arg)
		{
			throw null;
		}

		// Token: 0x0400C396 RID: 50070
		[SerializeField]
		private EntitiesPanel _entitiesPanel;

		// Token: 0x0200260F RID: 9743
		[CompilerGenerated]
		private sealed class Class2193
		{
			// Token: 0x0600C181 RID: 49537 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal CombinedView method_0(GClass2884 arg)
			{
				throw null;
			}

			// Token: 0x0600C182 RID: 49538 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_1(GClass2884 arg)
			{
				throw null;
			}

			// Token: 0x0600C183 RID: 49539 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass2884 item, CombinedView view)
			{
				throw null;
			}

			// Token: 0x0600C184 RID: 49540 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(GClass2884 x)
			{
				throw null;
			}

			// Token: 0x0600C185 RID: 49541 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(NodeBaseView nodeView, string id)
			{
				throw null;
			}

			// Token: 0x0400C397 RID: 50071
			public HandbookCategoriesPanel handbookCategoriesPanel_0;

			// Token: 0x0400C398 RID: 50072
			public List<string> questItems;

			// Token: 0x0400C399 RID: 50073
			public Func<GClass2884, bool> func_0;

			// Token: 0x0400C39A RID: 50074
			public Action<NodeBaseView, string> action_0;
		}
	}
}
