using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x020022F4 RID: 8948
	public class Slot : IContainer
	{
		// Token: 0x14000291 RID: 657
		// (add) Token: 0x0600B557 RID: 46423 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600B558 RID: 46424 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Item, bool> OnAddOrRemoveItem
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

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600B559 RID: 46425 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B55A RID: 46426 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		public virtual Item ContainedItem
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x0600B55B RID: 46427 RVA: 0x00002050 File Offset: 0x00000250
		[NotNull]
		public virtual Item ParentItem
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<Item> ReactiveContainedItem
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600B55D RID: 46429 RVA: 0x00002050 File Offset: 0x00000250
		public string ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600B55E RID: 46430 RVA: 0x00002050 File Offset: 0x00000250
		public string FullId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x00002050 File Offset: 0x00000250
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string LocalizedName()
		{
			throw null;
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600B561 RID: 46433 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSpecial
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<Item> Items
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Item FindItem(string itemId)
		{
			throw null;
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x0600B564 RID: 46436 RVA: 0x00002050 File Offset: 0x00000250
		public EParentMergeType MergeContainerWithChildren
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x0600B565 RID: 46437 RVA: 0x00002050 File Offset: 0x00000250
		public EBodyPartColliderType[] ArmorColliders
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x00002050 File Offset: 0x00000250
		public EArmorPlateCollider ArmorPlateColliderMask
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x0600B567 RID: 46439 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B568 RID: 46440 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600B569 RID: 46441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B56A RID: 46442 RVA: 0x00002050 File Offset: 0x00000250
		public bool Locked
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

		// Token: 0x0600B56B RID: 46443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<EBodyPartColliderType> method_0()
		{
			throw null;
		}

		// Token: 0x0600B56C RID: 46444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private EArmorPlateCollider method_1()
		{
			throw null;
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyContainedItem()
		{
			throw null;
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Examined(Item item)
		{
			throw null;
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<Slot> method_2(Item item)
		{
			throw null;
		}

		// Token: 0x0600B570 RID: 46448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct415<bool> method_3(Item item)
		{
			throw null;
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool CanAcceptRaid(out InventoryError error)
		{
			throw null;
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckCompatibility(Item item)
		{
			throw null;
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct415<bool> method_4(Item item, bool ignoreRestrictions = false, bool ignoreMalfunction = false)
		{
			throw null;
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeContainedItemDirectly(Item item)
		{
			throw null;
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Item item)
		{
			throw null;
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<int> Add(Item item, bool simulate, bool ignoreMalfunction = false)
		{
			throw null;
		}

		// Token: 0x0600B577 RID: 46455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<int> AddWithoutRestrictions(Item item)
		{
			throw null;
		}

		// Token: 0x0600B578 RID: 46456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<bool> RemoveItem(bool simulate = false)
		{
			throw null;
		}

		// Token: 0x0600B579 RID: 46457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanReplace(Item item)
		{
			throw null;
		}

		// Token: 0x0600B57A RID: 46458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2763 FindLocationForItem(Item item, out Error error)
		{
			throw null;
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashSum()
		{
			throw null;
		}

		// Token: 0x0400B8F3 RID: 47347
		public const string SPECIAL_SLOT_PREFIX = "SpecialSlot";

		// Token: 0x0400B8F4 RID: 47348
		public const string BUILD_SLOT = "BuildSlot";

		// Token: 0x0400B8F6 RID: 47350
		public readonly string Id;

		// Token: 0x0400B8F7 RID: 47351
		public readonly bool Required;

		// Token: 0x0400B8F8 RID: 47352
		private readonly BindableState<Item> _reactiveContainedItem;

		// Token: 0x0400B8F9 RID: 47353
		public Dictionary<string, Slot> ConflictingSlots;

		// Token: 0x0400B8FA RID: 47354
		public readonly List<Slot> BlockerSlots;

		// Token: 0x0400B8FB RID: 47355
		private string _cachedSlotName;

		// Token: 0x0400B8FC RID: 47356
		public bool Deleted;

		// Token: 0x0400B8FD RID: 47357
		private bool? _isSpecial;

		// Token: 0x020022F5 RID: 8949
		[StructLayout(LayoutKind.Auto)]
		public struct Struct737
		{
			// Token: 0x0400B905 RID: 47365
			public readonly Item Item;

			// Token: 0x0400B906 RID: 47366
			public readonly string ConflictingTemplateId;
		}

		// Token: 0x020022F6 RID: 8950
		public class GClass3305 : InventoryError
		{
			// Token: 0x0600B57D RID: 46461 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B57E RID: 46462 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}
		}

		// Token: 0x020022F7 RID: 8951
		public class GClass3306 : InventoryError
		{
			// Token: 0x0600B57F RID: 46463 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B580 RID: 46464 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B907 RID: 47367
			public readonly Slot Slot;
		}

		// Token: 0x020022F8 RID: 8952
		public class GClass3307 : InventoryError
		{
			// Token: 0x0600B581 RID: 46465 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B582 RID: 46466 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B908 RID: 47368
			public readonly Item Item;

			// Token: 0x0400B909 RID: 47369
			public readonly Slot Slot;

			// Token: 0x020022F9 RID: 8953
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1982
			{
				// Token: 0x0600B583 RID: 46467 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_0(Slot x)
				{
					throw null;
				}

				// Token: 0x0600B584 RID: 46468 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_1(Slot x)
				{
					throw null;
				}

				// Token: 0x0400B90A RID: 47370
				public static readonly Slot.GClass3307.Class1982 class1982_0;

				// Token: 0x0400B90B RID: 47371
				public static Func<Slot, string> func_0;

				// Token: 0x0400B90C RID: 47372
				public static Func<Slot, string> func_1;
			}
		}

		// Token: 0x020022FA RID: 8954
		public class GClass3308 : InventoryError
		{
			// Token: 0x0600B585 RID: 46469 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B586 RID: 46470 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B90D RID: 47373
			public readonly Item Item;

			// Token: 0x0400B90E RID: 47374
			public readonly Slot Slot;

			// Token: 0x0400B90F RID: 47375
			public readonly Slot ConflictingSlot;
		}

		// Token: 0x020022FB RID: 8955
		public class GClass3309 : InventoryError
		{
			// Token: 0x0600B587 RID: 46471 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0400B910 RID: 47376
			public readonly Item Item;

			// Token: 0x0400B911 RID: 47377
			public readonly Slot Slot;

			// Token: 0x0400B912 RID: 47378
			public readonly int MaxAllowedCount;
		}

		// Token: 0x020022FC RID: 8956
		public class GClass3310 : InventoryError
		{
			// Token: 0x0600B588 RID: 46472 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B589 RID: 46473 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B913 RID: 47379
			public readonly Item Item;

			// Token: 0x0400B914 RID: 47380
			public readonly Slot Slot;
		}

		// Token: 0x020022FD RID: 8957
		public class GClass3311 : InventoryError
		{
			// Token: 0x0600B58A RID: 46474 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B58B RID: 46475 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B915 RID: 47381
			public readonly Item Item;

			// Token: 0x0400B916 RID: 47382
			public readonly Slot Slot;
		}

		// Token: 0x020022FE RID: 8958
		public class GClass3312 : InventoryError
		{
			// Token: 0x0600B58C RID: 46476 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B58D RID: 46477 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B917 RID: 47383
			public readonly Item Item;

			// Token: 0x0400B918 RID: 47384
			public readonly IContainer Container;

			// Token: 0x0400B919 RID: 47385
			public IEnumerable<Slot> MissingParts;

			// Token: 0x020022FF RID: 8959
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1983
			{
				// Token: 0x0600B58E RID: 46478 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_0(Slot x)
				{
					throw null;
				}

				// Token: 0x0600B58F RID: 46479 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_1(Slot x)
				{
					throw null;
				}

				// Token: 0x0400B91A RID: 47386
				public static readonly Slot.GClass3312.Class1983 class1983_0;

				// Token: 0x0400B91B RID: 47387
				public static Func<Slot, string> func_0;

				// Token: 0x0400B91C RID: 47388
				public static Func<Slot, string> func_1;
			}
		}

		// Token: 0x02002300 RID: 8960
		public class GClass3313 : InventoryError
		{
			// Token: 0x0600B590 RID: 46480 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B591 RID: 46481 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B91D RID: 47389
			public readonly Item Item;

			// Token: 0x0400B91E RID: 47390
			public readonly Slot Slot;
		}

		// Token: 0x02002301 RID: 8961
		public class GClass3314 : InventoryError
		{
			// Token: 0x0600B592 RID: 46482 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B593 RID: 46483 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B91F RID: 47391
			public readonly Item Item;

			// Token: 0x0400B920 RID: 47392
			public readonly Slot Slot;

			// Token: 0x02002302 RID: 8962
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1984
			{
				// Token: 0x0600B594 RID: 46484 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal IEnumerable<string> method_0(ItemFilter x)
				{
					throw null;
				}

				// Token: 0x0600B595 RID: 46485 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_1(string x)
				{
					throw null;
				}

				// Token: 0x0600B596 RID: 46486 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2(ItemFilter x)
				{
					throw null;
				}

				// Token: 0x0600B597 RID: 46487 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal IEnumerable<string> method_3(ItemFilter x)
				{
					throw null;
				}

				// Token: 0x0600B598 RID: 46488 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_4(string x)
				{
					throw null;
				}

				// Token: 0x0400B921 RID: 47393
				public static readonly Slot.GClass3314.Class1984 class1984_0;

				// Token: 0x0400B922 RID: 47394
				public static Func<ItemFilter, IEnumerable<string>> func_0;

				// Token: 0x0400B923 RID: 47395
				public static Func<string, string> func_1;

				// Token: 0x0400B924 RID: 47396
				public static Func<ItemFilter, bool> func_2;

				// Token: 0x0400B925 RID: 47397
				public static Func<ItemFilter, IEnumerable<string>> func_3;

				// Token: 0x0400B926 RID: 47398
				public static Func<string, string> func_4;
			}
		}

		// Token: 0x02002303 RID: 8963
		public class GClass3315 : InventoryError
		{
			// Token: 0x0600B599 RID: 46489 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B59A RID: 46490 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B927 RID: 47399
			public readonly Item Item;

			// Token: 0x0400B928 RID: 47400
			public readonly Item RootItem;

			// Token: 0x0400B929 RID: 47401
			public readonly Item ConflictingItem;
		}

		// Token: 0x02002304 RID: 8964
		public class GClass3316 : InventoryError
		{
			// Token: 0x0600B59B RID: 46491 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B59C RID: 46492 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B92A RID: 47402
			public readonly Item Item;

			// Token: 0x0400B92B RID: 47403
			public readonly Item RootItem;
		}

		// Token: 0x02002305 RID: 8965
		public class GClass3317 : InventoryError
		{
			// Token: 0x0600B59D RID: 46493 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0400B92C RID: 47404
			public readonly Item Item;

			// Token: 0x0400B92D RID: 47405
			public readonly Slot Slot;
		}

		// Token: 0x02002309 RID: 8969
		[CompilerGenerated]
		private sealed class Class1988
		{
			// Token: 0x0600B5AD RID: 46509 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Slot.Struct737 method_0(string y)
			{
				throw null;
			}

			// Token: 0x0400B942 RID: 47426
			public Item x;
		}

		// Token: 0x0200230A RID: 8970
		[CompilerGenerated]
		private sealed class Class1989
		{
			// Token: 0x0600B5AE RID: 46510 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Slot.Struct737 method_0(string y)
			{
				throw null;
			}

			// Token: 0x0400B943 RID: 47427
			public Item x;
		}

		// Token: 0x0200230B RID: 8971
		[CompilerGenerated]
		private sealed class Class1990
		{
			// Token: 0x0600B5AF RID: 46511 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Slot.Struct737 x)
			{
				throw null;
			}

			// Token: 0x0400B944 RID: 47428
			public Item existingItem;
		}

		// Token: 0x0200230C RID: 8972
		[CompilerGenerated]
		private sealed class Class1991
		{
			// Token: 0x0600B5B0 RID: 46512 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Slot.Struct737 x)
			{
				throw null;
			}

			// Token: 0x0400B945 RID: 47429
			public Item newItem;
		}

		// Token: 0x0200230D RID: 8973
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1992
		{
			// Token: 0x0600B5B1 RID: 46513 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Slot.Struct737> method_0(Item x)
			{
				throw null;
			}

			// Token: 0x0600B5B2 RID: 46514 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Slot.Struct737> method_1(Item x)
			{
				throw null;
			}

			// Token: 0x0400B946 RID: 47430
			public static readonly Slot.Class1992 class1992_0;

			// Token: 0x0400B947 RID: 47431
			public static Func<Item, IEnumerable<Slot.Struct737>> func_0;

			// Token: 0x0400B948 RID: 47432
			public static Func<Item, IEnumerable<Slot.Struct737>> func_1;
		}
	}
}
