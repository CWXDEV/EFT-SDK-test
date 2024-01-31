using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x02002310 RID: 8976
	public sealed class StackSlot : IContainer
	{
		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600B5B5 RID: 46517 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B5B6 RID: 46518 RVA: 0x00002050 File Offset: 0x00000250
		public string ID
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

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600B5B7 RID: 46519 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B5B8 RID: 46520 RVA: 0x00002050 File Offset: 0x00000250
		public ItemFilter[] Filters
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

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600B5B9 RID: 46521 RVA: 0x00002050 File Offset: 0x00000250
		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x0600B5BA RID: 46522 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<Item> Items
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Item FindItem(string itemId)
		{
			throw null;
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x0600B5BC RID: 46524 RVA: 0x00002050 File Offset: 0x00000250
		public Item ParentItem
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600B5BD RID: 46525 RVA: 0x00002050 File Offset: 0x00000250
		public EParentMergeType MergeContainerWithChildren
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAtPosition(Item item, int position)
		{
			throw null;
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FinalizeDeserialization()
		{
			throw null;
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddOrMerge(Item item, TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600B5C1 RID: 46529 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		public Item Last
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<int> GetMaxAddCount(Item item)
		{
			throw null;
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckCompatibility(Item item)
		{
			throw null;
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<int> Add(Item item, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600B5C5 RID: 46533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<bool> Remove(Item item, string visitorId, bool simulate = false)
		{
			throw null;
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GInterface322> PopTo(TraderControllerClass itemController, ItemAddress to)
		{
			throw null;
		}

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GInterface322> PopToNowhere(TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Item Peek()
		{
			throw null;
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Item GetItemAtPosition(int index)
		{
			throw null;
		}

		// Token: 0x0600B5CB RID: 46539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetItemPosition(Item testedItem)
		{
			throw null;
		}

		// Token: 0x0600B5CC RID: 46540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600B5CD RID: 46541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashSum()
		{
			throw null;
		}

		// Token: 0x0400B950 RID: 47440
		public int MaxCount;

		// Token: 0x0400B951 RID: 47441
		private readonly List<Item> _items;

		// Token: 0x0400B952 RID: 47442
		private readonly SortedList<int, Item> _deserializationList;
	}
}
