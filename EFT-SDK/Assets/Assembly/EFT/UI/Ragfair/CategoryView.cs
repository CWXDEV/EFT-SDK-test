using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HandBook;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F87 RID: 12167
	public class CategoryView : NodeBaseView
	{
		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600EFE5 RID: 61413 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject ToggleObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x00002050 File Offset: 0x00000250
		protected override Color DefaultBackgroundColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EFE7 RID: 61415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EFE8 RID: 61416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(RagFairClass ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, GClass2884 node, EViewListType viewListType, EWindowType windowType, Dictionary<string, NodeBaseView> viewNodes, string forbiddenItem, Action<NodeBaseView, string> onCategorySelected, Action<NodeBaseView, string> onCategoryConfirmed = null)
		{
			throw null;
		}

		// Token: 0x0600EFE9 RID: 61417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PointerEnterHandler(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EFEA RID: 61418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PointerExitHandler(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EFEB RID: 61419 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<NodeBaseView> OpenCategory()
		{
			throw null;
		}

		// Token: 0x0600EFEC RID: 61420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private NodeBaseView method_4(ENodeType type)
		{
			throw null;
		}

		// Token: 0x0600EFED RID: 61421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual RectTransform GetSubcategoryContainer()
		{
			throw null;
		}

		// Token: 0x0600EFEE RID: 61422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseCategory()
		{
			throw null;
		}

		// Token: 0x0600EFEF RID: 61423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OffersCountUpdatedHandler(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600EFF0 RID: 61424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EFF1 RID: 61425 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool value)
		{
			throw null;
		}

		// Token: 0x0600EFF2 RID: 61426 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private NodeBaseView method_6(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EFF3 RID: 61427 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_7(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EFF4 RID: 61428 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(GClass2884 item, NodeBaseView view)
		{
			throw null;
		}

		// Token: 0x0400F566 RID: 62822
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x0400F567 RID: 62823
		[SerializeField]
		private Transform _subcategoryContainer;

		// Token: 0x0400F568 RID: 62824
		[SerializeField]
		private Image _toggleImage;

		// Token: 0x0400F569 RID: 62825
		[SerializeField]
		private Sprite _closeSprite;

		// Token: 0x0400F56A RID: 62826
		[SerializeField]
		private Sprite _openSprite;

		// Token: 0x0400F56B RID: 62827
		[SerializeField]
		private List<NodeBaseView> _views;

		// Token: 0x0400F56C RID: 62828
		private bool bool_3;

		// Token: 0x0400F56D RID: 62829
		private GClass3080<GClass2884, NodeBaseView> gclass3080_0;
	}
}
