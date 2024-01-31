using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F8B RID: 12171
	public class NodeBaseView : UIElement, IEventSystemHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600EFFC RID: 61436 RVA: 0x00002050 File Offset: 0x00000250
		protected bool CanBeSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600EFFD RID: 61437 RVA: 0x00002050 File Offset: 0x00000250
		protected bool CanBeExpanded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600EFFE RID: 61438 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600EFFF RID: 61439 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600F000 RID: 61440 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual Color DefaultBackgroundColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600F001 RID: 61441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F002 RID: 61442 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600F003 RID: 61443 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F004 RID: 61444 RVA: 0x00002050 File Offset: 0x00000250
		private Dictionary<string, NodeBaseView> ViewNodes
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

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600F005 RID: 61445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F006 RID: 61446 RVA: 0x00002050 File Offset: 0x00000250
		private Action<NodeBaseView, string> OnCategorySelected
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

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600F007 RID: 61447 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F008 RID: 61448 RVA: 0x00002050 File Offset: 0x00000250
		private Action<NodeBaseView, string> OnCategoryConfirmed
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

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600F009 RID: 61449 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F00A RID: 61450 RVA: 0x00002050 File Offset: 0x00000250
		private string ForbiddenItemId
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

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600F00B RID: 61451 RVA: 0x00002050 File Offset: 0x00000250
		protected bool IsForbidden
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600F00C RID: 61452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F00D RID: 61453 RVA: 0x00002050 File Offset: 0x00000250
		private NodeBaseView CategoryView
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

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600F00E RID: 61454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F00F RID: 61455 RVA: 0x00002050 File Offset: 0x00000250
		private NodeBaseView SubcategoryView
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

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600F010 RID: 61456 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F011 RID: 61457 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
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

		// Token: 0x0600F012 RID: 61458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show([CanBeNull] RagFairClass ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, GClass2884 node, EViewListType viewListType, EWindowType windowType, Dictionary<string, NodeBaseView> viewNodes, string forbiddenItem, Action<NodeBaseView, string> onCategorySelected, Action<NodeBaseView, string> onCategoryConfirmed = null)
		{
			throw null;
		}

		// Token: 0x0600F013 RID: 61459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PointerEnterHandler([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F014 RID: 61460 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PointerExitHandler([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F015 RID: 61461 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F016 RID: 61462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F017 RID: 61463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F018 RID: 61464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectView()
		{
			throw null;
		}

		// Token: 0x0600F019 RID: 61465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectView()
		{
			throw null;
		}

		// Token: 0x0600F01A RID: 61466 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OffersCountUpdatedHandler(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600F01B RID: 61467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool isNew)
		{
			throw null;
		}

		// Token: 0x0600F01C RID: 61468 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F01D RID: 61469 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600F01E RID: 61470 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Sprite arg)
		{
			throw null;
		}

		// Token: 0x0400F578 RID: 62840
		private const float float_0 = 0.3f;

		// Token: 0x0400F579 RID: 62841
		[SerializeField]
		protected TextMeshProUGUI CategoryElementName;

		// Token: 0x0400F57A RID: 62842
		[SerializeField]
		protected TextMeshProUGUI CategoryChildCount;

		// Token: 0x0400F57B RID: 62843
		[SerializeField]
		private bool _canBeSelected;

		// Token: 0x0400F57C RID: 62844
		[SerializeField]
		private GameObject _newNodeObject;

		// Token: 0x0400F57D RID: 62845
		[SerializeField]
		private Image _background;

		// Token: 0x0400F57E RID: 62846
		[SerializeField]
		private HorizontalLayoutGroup _layoutGroup;

		// Token: 0x0400F57F RID: 62847
		[SerializeField]
		private int _layoutLeftPadding;

		// Token: 0x0400F580 RID: 62848
		[SerializeField]
		private Image _icon;

		// Token: 0x0400F581 RID: 62849
		[SerializeField]
		private Image _iconBack;

		// Token: 0x0400F582 RID: 62850
		[SerializeField]
		private GameObject _iconPanel;

		// Token: 0x0400F583 RID: 62851
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400F584 RID: 62852
		[SerializeField]
		private Color _selectedBackgroundColor;

		// Token: 0x0400F585 RID: 62853
		[SerializeField]
		private Color32 _defaultTextColor;

		// Token: 0x0400F586 RID: 62854
		[SerializeField]
		private Color32 _defaultChildCountColor;

		// Token: 0x0400F587 RID: 62855
		[SerializeField]
		private Color32 _hoverTextColor;

		// Token: 0x0400F588 RID: 62856
		public GClass2884 Node;

		// Token: 0x0400F589 RID: 62857
		protected EViewListType ViewListType;

		// Token: 0x0400F58A RID: 62858
		protected EWindowType WindowType;

		// Token: 0x0400F58B RID: 62859
		private HoverTrigger hoverTrigger_0;

		// Token: 0x0400F58C RID: 62860
		private bool bool_0;

		// Token: 0x0400F58D RID: 62861
		private bool bool_1;

		// Token: 0x0400F58E RID: 62862
		private float float_1;

		// Token: 0x0400F58F RID: 62863
		[CompilerGenerated]
		private RagFairClass gclass3190_0;

		// Token: 0x0400F590 RID: 62864
		[CompilerGenerated]
		private Dictionary<string, NodeBaseView> dictionary_0;

		// Token: 0x0400F591 RID: 62865
		[CompilerGenerated]
		private Action<NodeBaseView, string> action_0;

		// Token: 0x0400F592 RID: 62866
		[CompilerGenerated]
		private Action<NodeBaseView, string> action_1;

		// Token: 0x0400F593 RID: 62867
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400F594 RID: 62868
		[CompilerGenerated]
		private NodeBaseView nodeBaseView_0;

		// Token: 0x0400F595 RID: 62869
		[CompilerGenerated]
		private NodeBaseView nodeBaseView_1;

		// Token: 0x0400F596 RID: 62870
		[CompilerGenerated]
		private bool bool_2;
	}
}
