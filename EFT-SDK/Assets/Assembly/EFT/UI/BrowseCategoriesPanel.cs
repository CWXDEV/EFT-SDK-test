using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BC6 RID: 11206
	public class BrowseCategoriesPanel : UIElement
	{
		// Token: 0x14000308 RID: 776
		// (add) Token: 0x0600DCEC RID: 56556 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DCED RID: 56557 RVA: 0x00002050 File Offset: 0x00000250
		private event Action Event_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000309 RID: 777
		// (add) Token: 0x0600DCEE RID: 56558 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DCEF RID: 56559 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnFiltered
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual string FilterString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600DCF1 RID: 56561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCF2 RID: 56562 RVA: 0x00002050 File Offset: 0x00000250
		private GClass3354 FilteredNodes
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600DCF3 RID: 56563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCF4 RID: 56564 RVA: 0x00002050 File Offset: 0x00000250
		private SimpleContextMenu ContextMenu
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600DCF5 RID: 56565 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCF6 RID: 56566 RVA: 0x00002050 File Offset: 0x00000250
		private RagFairClass Ragfair
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x0600DCF7 RID: 56567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCF8 RID: 56568 RVA: 0x00002050 File Offset: 0x00000250
		private GClass2881 Handbook
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool DisplayLoadingStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600DCFA RID: 56570 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCFB RID: 56571 RVA: 0x00002050 File Offset: 0x00000250
		private GClass3354 GClass3354_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600DCFC RID: 56572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCFD RID: 56573 RVA: 0x00002050 File Offset: 0x00000250
		private EViewListType EViewListType_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DCFF RID: 56575 RVA: 0x00002050 File Offset: 0x00000250
		public EWindowType WindowType
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600DD00 RID: 56576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600DD01 RID: 56577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(RagFairClass ragfair, GClass2881 handbook, GClass3354 nodes, GClass3354 filteredNodes, [CanBeNull] SimpleContextMenu contextMenu, EViewListType viewListType, EWindowType windowType, Action<NodeBaseView, string> onSelection)
		{
			throw null;
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected NodeBaseView GetNode(string id)
		{
			throw null;
		}

		// Token: 0x0600DD03 RID: 56579 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private NodeBaseView method_0(string id, [CanBeNull] IEnumerable<NodeBaseView> selection)
		{
			throw null;
		}

		// Token: 0x0600DD04 RID: 56580 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NodeBaseView SelectNode(string id)
		{
			throw null;
		}

		// Token: 0x0600DD05 RID: 56581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task Filter(string value)
		{
			throw null;
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool status)
		{
			throw null;
		}

		// Token: 0x0600DD07 RID: 56583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FilterHandler()
		{
			throw null;
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool Allowed(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DD0A RID: 56586 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(string arg)
		{
			throw null;
		}

		// Token: 0x0400E13F RID: 57663
		protected const string QUEST_CATEGORY_ID = "5b619f1a86f77450a702a6f3";

		// Token: 0x0400E140 RID: 57664
		private const int int_0 = 3;

		// Token: 0x0400E141 RID: 57665
		private const float float_0 = 1f;

		// Token: 0x0400E142 RID: 57666
		private const int int_1 = 10;

		// Token: 0x0400E143 RID: 57667
		[SerializeField]
		protected TMP_InputField SearchInputField;

		// Token: 0x0400E144 RID: 57668
		[SerializeField]
		protected CombinedView CombinedCategoryView;

		// Token: 0x0400E145 RID: 57669
		[SerializeField]
		protected RectTransform CategoryViewsContainer;

		// Token: 0x0400E146 RID: 57670
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400E147 RID: 57671
		[SerializeField]
		private GameObject _searchIcon;

		// Token: 0x0400E148 RID: 57672
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400E149 RID: 57673
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x0400E14A RID: 57674
		[CompilerGenerated]
		private GClass3354 gclass3354_0;

		// Token: 0x0400E14B RID: 57675
		[CompilerGenerated]
		private SimpleContextMenu simpleContextMenu_0;

		// Token: 0x0400E14C RID: 57676
		[CompilerGenerated]
		private RagFairClass gclass3190_0;

		// Token: 0x0400E14D RID: 57677
		[CompilerGenerated]
		private GClass2881 gclass2881_0;

		// Token: 0x0400E14E RID: 57678
		[CompilerGenerated]
		private GClass3354 gclass3354_1;

		// Token: 0x0400E14F RID: 57679
		[CompilerGenerated]
		private EViewListType eviewListType_0;

		// Token: 0x0400E150 RID: 57680
		[CompilerGenerated]
		private EWindowType ewindowType_0;

		// Token: 0x0400E151 RID: 57681
		protected readonly Dictionary<string, NodeBaseView> ViewNodes;

		// Token: 0x0400E152 RID: 57682
		protected GClass3077<GClass2884, CombinedView> ViewList;

		// Token: 0x0400E153 RID: 57683
		protected Action<NodeBaseView, string> OnSelection;

		// Token: 0x0400E154 RID: 57684
		private bool bool_0;

		// Token: 0x0400E155 RID: 57685
		private string string_0;

		// Token: 0x0400E156 RID: 57686
		private bool bool_1;

		// Token: 0x02002BC7 RID: 11207
		[CompilerGenerated]
		private sealed class Class2658
		{
			// Token: 0x0600DD0B RID: 56587 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(NodeBaseView nodeView)
			{
				throw null;
			}

			// Token: 0x0600DD0C RID: 56588 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass2884 childNode)
			{
				throw null;
			}

			// Token: 0x0400E157 RID: 57687
			public string id;

			// Token: 0x0400E158 RID: 57688
			public Func<GClass2884, bool> func_0;
		}

		// Token: 0x02002BC8 RID: 11208
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2659
		{
			// Token: 0x0600DD0D RID: 56589 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(NodeBaseView nodeView)
			{
				throw null;
			}

			// Token: 0x0600DD0E RID: 56590 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<GClass2884> method_1(GClass2884 y)
			{
				throw null;
			}

			// Token: 0x0600DD0F RID: 56591 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<GClass2884> method_2(GClass2884 x)
			{
				throw null;
			}

			// Token: 0x0400E159 RID: 57689
			public static readonly BrowseCategoriesPanel.Class2659 class2659_0;

			// Token: 0x0400E15A RID: 57690
			public static Func<NodeBaseView, bool> func_0;

			// Token: 0x0400E15B RID: 57691
			public static Func<GClass2884, IEnumerable<GClass2884>> func_1;

			// Token: 0x0400E15C RID: 57692
			public static Func<GClass2884, IEnumerable<GClass2884>> func_2;
		}

		// Token: 0x02002BC9 RID: 11209
		[CompilerGenerated]
		private sealed class Class2660
		{
			// Token: 0x0600DD10 RID: 56592 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600DD11 RID: 56593 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass2884 x)
			{
				throw null;
			}

			// Token: 0x0600DD12 RID: 56594 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2884 method_2(GClass2884 x)
			{
				throw null;
			}

			// Token: 0x0600DD13 RID: 56595 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(GClass2884 node)
			{
				throw null;
			}

			// Token: 0x0400E15D RID: 57693
			public BrowseCategoriesPanel browseCategoriesPanel_0;

			// Token: 0x0400E15E RID: 57694
			public bool searchCanceled;

			// Token: 0x0400E15F RID: 57695
			public string value;

			// Token: 0x0400E160 RID: 57696
			public Func<GClass2884, bool> func_0;
		}
	}
}
