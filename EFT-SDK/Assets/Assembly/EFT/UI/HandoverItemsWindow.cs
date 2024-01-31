using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020029AA RID: 10666
	public abstract class HandoverItemsWindow : MessageWindow
	{
		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600D424 RID: 54308 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D425 RID: 54309 RVA: 0x00002050 File Offset: 0x00000250
		protected GClass2809 ItemContext
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

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600D426 RID: 54310 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D427 RID: 54311 RVA: 0x00002050 File Offset: 0x00000250
		protected ItemUiContext ItemUiContext
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

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x00002050 File Offset: 0x00000250
		protected Item[] ItemsToHandover
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x0600D429 RID: 54313 RVA: 0x00002050 File Offset: 0x00000250
		protected GridView GridView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x0600D42A RID: 54314 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual int GridWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x0600D42B RID: 54315 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual int GridHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool CanStretchVertically
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600D42D RID: 54317 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool CanStretchHorizontally
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D42E RID: 54318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D42F RID: 54319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GClass3087 Show(string title, string message, GInterface312 profile, TraderControllerClass itemController, GClass2809 itemContext, Action acceptAction, [CanBeNull] Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateItems(IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Clear()
		{
			throw null;
		}

		// Token: 0x0400D681 RID: 54913
		[SerializeField]
		protected GridView _itemsToHandover;

		// Token: 0x0400D682 RID: 54914
		protected StashClass _stashUpdate;

		// Token: 0x0400D683 RID: 54915
		protected TraderControllerClass _itemController;

		// Token: 0x0400D684 RID: 54916
		[CompilerGenerated]
		private GClass2809 gclass2809_0;

		// Token: 0x0400D685 RID: 54917
		[CompilerGenerated]
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400D686 RID: 54918
		protected readonly List<Item> ItemsList;
	}
}
