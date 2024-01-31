using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001BFE RID: 7166
	public sealed class SelectItemContextMenu : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600966A RID: 38506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<ValueTuple<Item, bool>> GetItem(IEnumerable<Item> availableItems, Func<Item, string> getDetails, bool showEmptyCell, SelectingItemView itemTemplate, RectTransform parentPosition, Vector2 offset, EContextPriorDirection direction)
		{
			throw null;
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Item selectedItem)
		{
			throw null;
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(RectTransform parentPosition, Vector2 offset, EContextPriorDirection direction)
		{
			throw null;
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009D45 RID: 40261
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04009D46 RID: 40262
		private TaskCompletionSource<ValueTuple<Item, bool>> taskCompletionSource_0;

		// Token: 0x04009D47 RID: 40263
		private GridLayoutGroup gridLayoutGroup_0;

		// Token: 0x04009D48 RID: 40264
		private readonly Vector3[] vector3_0;

		// Token: 0x04009D49 RID: 40265
		private static readonly Dictionary<EContextPriorDirection, SelectItemContextMenu.Struct542> dictionary_0;

		// Token: 0x02001BFF RID: 7167
		[StructLayout(LayoutKind.Auto)]
		public struct Struct542
		{
			// Token: 0x1700173C RID: 5948
			// (get) Token: 0x06009670 RID: 38512 RVA: 0x00002050 File Offset: 0x00000250
			public Vector2 DirectionAnchor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04009D4A RID: 40266
			public int CornerIndex;

			// Token: 0x04009D4B RID: 40267
			public GridLayoutGroup.Corner StartCorner;
		}

		// Token: 0x02001C00 RID: 7168
		[CompilerGenerated]
		private sealed class Class1690
		{
			// Token: 0x06009671 RID: 38513 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Item item, SelectingItemView view)
			{
				throw null;
			}

			// Token: 0x04009D4C RID: 40268
			public SelectItemContextMenu selectItemContextMenu_0;

			// Token: 0x04009D4D RID: 40269
			public Func<Item, string> getDetails;
		}

		// Token: 0x02001C01 RID: 7169
		[CompilerGenerated]
		private sealed class Class1691
		{
			// Token: 0x06009672 RID: 38514 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009D4E RID: 40270
			public SelectingItemView emptyItem;
		}
	}
}
