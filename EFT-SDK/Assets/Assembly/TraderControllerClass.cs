using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.LanguageExtensions;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using NLog;
using UnityEngine;

// Token: 0x020024CF RID: 9423
public class TraderControllerClass : IContainer, IItemOwner, GInterface319
{
	// Token: 0x140002A6 RID: 678
	// (add) Token: 0x0600BCB9 RID: 48313 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCBA RID: 48314 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> OnItemFound
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

	// Token: 0x140002A7 RID: 679
	// (add) Token: 0x0600BCBB RID: 48315 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCBC RID: 48316 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs2> AddItemEvent
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

	// Token: 0x170021A3 RID: 8611
	// (get) Token: 0x0600BCBD RID: 48317 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool InboundTransfer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021A4 RID: 8612
	// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool CanSearch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021A5 RID: 8613
	// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	public GClass2495[] MainStorage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021A6 RID: 8614
	// (get) Token: 0x0600BCC0 RID: 48320 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	public virtual LootItemClass Root
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BCC1 RID: 48321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(GEventArgs2 obj)
	{
		throw null;
	}

	// Token: 0x140002A8 RID: 680
	// (add) Token: 0x0600BCC2 RID: 48322 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCC3 RID: 48323 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs3> RemoveItemEvent
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

	// Token: 0x0600BCC4 RID: 48324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(GEventArgs3 obj)
	{
		throw null;
	}

	// Token: 0x140002A9 RID: 681
	// (add) Token: 0x0600BCC5 RID: 48325 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCC6 RID: 48326 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs6> ExamineEvent
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

	// Token: 0x0600BCC7 RID: 48327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(GEventArgs6 obj)
	{
		throw null;
	}

	// Token: 0x140002AA RID: 682
	// (add) Token: 0x0600BCC8 RID: 48328 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCC9 RID: 48329 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs6> PlayerExamineEvent
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

	// Token: 0x0600BCCA RID: 48330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3(GEventArgs6 obj)
	{
		throw null;
	}

	// Token: 0x140002AB RID: 683
	// (add) Token: 0x0600BCCB RID: 48331 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCCC RID: 48332 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Weapon> OnChamberCheck
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

	// Token: 0x0600BCCD RID: 48333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_4(Weapon obj)
	{
		throw null;
	}

	// Token: 0x140002AC RID: 684
	// (add) Token: 0x0600BCCE RID: 48334 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCCF RID: 48335 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs15> CreateMapMarkerEvent
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

	// Token: 0x0600BCD0 RID: 48336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5(GEventArgs15 obj)
	{
		throw null;
	}

	// Token: 0x140002AD RID: 685
	// (add) Token: 0x0600BCD1 RID: 48337 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCD2 RID: 48338 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs16> EditMapMarkerEvent
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

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_6(GEventArgs16 obj)
	{
		throw null;
	}

	// Token: 0x140002AE RID: 686
	// (add) Token: 0x0600BCD4 RID: 48340 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCD5 RID: 48341 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs17> DeleteMapMarkerEvent
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

	// Token: 0x0600BCD6 RID: 48342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_7(GEventArgs17 obj)
	{
		throw null;
	}

	// Token: 0x140002AF RID: 687
	// (add) Token: 0x0600BCD7 RID: 48343 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCD8 RID: 48344 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs22> RefreshItemEvent
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

	// Token: 0x0600BCD9 RID: 48345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_8(GEventArgs22 obj)
	{
		throw null;
	}

	// Token: 0x140002B0 RID: 688
	// (add) Token: 0x0600BCDA RID: 48346 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCDB RID: 48347 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs1> ActiveEventAdded
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

	// Token: 0x0600BCDC RID: 48348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_9(GEventArgs1 obj)
	{
		throw null;
	}

	// Token: 0x140002B1 RID: 689
	// (add) Token: 0x0600BCDD RID: 48349 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCDE RID: 48350 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GEventArgs1> ActiveEventsChanged
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

	// Token: 0x0600BCDF RID: 48351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_10(GEventArgs1 obj)
	{
		throw null;
	}

	// Token: 0x140002B2 RID: 690
	// (add) Token: 0x0600BCE0 RID: 48352 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BCE1 RID: 48353 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnLockedStatusChange
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

	// Token: 0x0600BCE2 RID: 48354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_11(bool obj)
	{
		throw null;
	}

	// Token: 0x170021A7 RID: 8615
	// (get) Token: 0x0600BCE3 RID: 48355 RVA: 0x00002050 File Offset: 0x00000250
	public MongoID CurrentId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021A8 RID: 8616
	// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x00002050 File Offset: 0x00000250
	public ushort GenNextOperationId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021A9 RID: 8617
	// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x00002050 File Offset: 0x00000250
	MongoID GInterface319.NextId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021AA RID: 8618
	// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual MongoID NextId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BCE7 RID: 48359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface319.RollBack()
	{
		throw null;
	}

	// Token: 0x0600BCE8 RID: 48360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RollBack()
	{
		throw null;
	}

	// Token: 0x170021AB RID: 8619
	// (get) Token: 0x0600BCE9 RID: 48361 RVA: 0x00002050 File Offset: 0x00000250
	public string ID
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021AC RID: 8620
	// (get) Token: 0x0600BCEA RID: 48362 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600BCEB RID: 48363 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x170021AD RID: 8621
	// (get) Token: 0x0600BCEC RID: 48364 RVA: 0x00002050 File Offset: 0x00000250
	public Item ParentItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021AE RID: 8622
	// (get) Token: 0x0600BCED RID: 48365 RVA: 0x00002050 File Offset: 0x00000250
	public Item RootItem
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021AF RID: 8623
	// (get) Token: 0x0600BCEE RID: 48366 RVA: 0x00002050 File Offset: 0x00000250
	public ContainerCollection QuestStashItem
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B0 RID: 8624
	// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x00002050 File Offset: 0x00000250
	public ContainerCollection QuestRaidItem
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B1 RID: 8625
	// (get) Token: 0x0600BCF0 RID: 48368 RVA: 0x00002050 File Offset: 0x00000250
	public EParentMergeType MergeContainerWithChildren
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B2 RID: 8626
	// (get) Token: 0x0600BCF1 RID: 48369 RVA: 0x00002050 File Offset: 0x00000250
	public string Name
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B3 RID: 8627
	// (get) Token: 0x0600BCF2 RID: 48370 RVA: 0x00002050 File Offset: 0x00000250
	public string ContainerName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B4 RID: 8628
	// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B5 RID: 8629
	// (get) Token: 0x0600BCF4 RID: 48372 RVA: 0x00002050 File Offset: 0x00000250
	public EOwnerType OwnerType
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B6 RID: 8630
	// (get) Token: 0x0600BCF5 RID: 48373 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600BCF6 RID: 48374 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool Locked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170021B7 RID: 8631
	// (get) Token: 0x0600BCF7 RID: 48375 RVA: 0x00002050 File Offset: 0x00000250
	private List<GEventArgs1> List_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B8 RID: 8632
	// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasActiveEvents
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021B9 RID: 8633
	// (get) Token: 0x0600BCF9 RID: 48377 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsChangingWeapon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021BA RID: 8634
	// (get) Token: 0x0600BCFA RID: 48378 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<Item> Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BCFB RID: 48379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_12()
	{
		throw null;
	}

	// Token: 0x0600BCFC RID: 48380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	int IContainer.GetHashSum()
	{
		throw null;
	}

	// Token: 0x0600BCFD RID: 48381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLockedStatus()
	{
		throw null;
	}

	// Token: 0x0600BCFE RID: 48382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterView(GInterface104 view)
	{
		throw null;
	}

	// Token: 0x0600BCFF RID: 48383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterView(GInterface104 view)
	{
		throw null;
	}

	// Token: 0x0600BD00 RID: 48384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<T> SelectEvents<T>(Item item = null) where T : GEventArgs1
	{
		throw null;
	}

	// Token: 0x0600BD01 RID: 48385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GEventArgs1> SelectEvents(Item item)
	{
		throw null;
	}

	// Token: 0x0600BD02 RID: 48386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveActiveEvent(GEventArgs1 activeEvent)
	{
		throw null;
	}

	// Token: 0x0600BD03 RID: 48387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(GEventArgs1 activeEvent)
	{
		throw null;
	}

	// Token: 0x0600BD04 RID: 48388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckItemAction(Item item, ItemAddress location)
	{
		throw null;
	}

	// Token: 0x0600BD05 RID: 48389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_14(Item item, ItemAddress location)
	{
		throw null;
	}

	// Token: 0x0600BD06 RID: 48390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15(LootItemClass compoundItem, ItemAddress location)
	{
		throw null;
	}

	// Token: 0x0600BD07 RID: 48391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_16(Item item, ItemAddress location)
	{
		throw null;
	}

	// Token: 0x0600BD08 RID: 48392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool IsRootAddressIsStash(ItemAddress location)
	{
		throw null;
	}

	// Token: 0x0600BD09 RID: 48393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> LoadMagazine(BulletClass ammo, MagazineClass magazine, int loadCount)
	{
		throw null;
	}

	// Token: 0x0600BD0A RID: 48394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Task<IResult> LoadMagazine(BulletClass ammo, MagazineClass magazine, int loadCount, bool ignoreRestrictions)
	{
		throw null;
	}

	// Token: 0x0600BD0B RID: 48395 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<IResult> LoadMultiBarrelWeapon(Weapon weapon, BulletClass ammo, int ammoCount)
	{
		throw null;
	}

	// Token: 0x0600BD0C RID: 48396 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<IResult> LoadWeaponWithAmmo(Weapon weapon, BulletClass ammo, int ammoCount)
	{
		throw null;
	}

	// Token: 0x0600BD0D RID: 48397 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopProcesses()
	{
		throw null;
	}

	// Token: 0x0600BD0E RID: 48398 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckedChamber(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BD0F RID: 48399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckChamber(Weapon weapon, bool status)
	{
		throw null;
	}

	// Token: 0x0600BD10 RID: 48400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasAnyHandsAction()
	{
		throw null;
	}

	// Token: 0x0600BD11 RID: 48401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasUninterruptibleAction()
	{
		throw null;
	}

	// Token: 0x0600BD12 RID: 48402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(Item item, ItemAddress location, Item eventItem, ItemAddress eventLocation)
	{
		throw null;
	}

	// Token: 0x0600BD13 RID: 48403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2833 ConvertOperationResultToOperation(GInterface321 operationResult)
	{
		throw null;
	}

	// Token: 0x0600BD14 RID: 48404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunNetworkTransaction(GInterface321 operationResult, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD15 RID: 48405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<IResult> TryRunNetworkTransaction(GStruct412 operationResult, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD16 RID: 48406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(GInterface321 operationResult)
	{
		throw null;
	}

	// Token: 0x0600BD17 RID: 48407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Examined(Item item)
	{
		throw null;
	}

	// Token: 0x0600BD18 RID: 48408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanThrow(Item item)
	{
		throw null;
	}

	// Token: 0x0600BD19 RID: 48409 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsLimitedAtAddress(string templateId, ItemAddress address, out int limit)
	{
		throw null;
	}

	// Token: 0x0600BD1A RID: 48410 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsLimitedAtAddress(Item item, ItemAddress address, out int limit)
	{
		throw null;
	}

	// Token: 0x0600BD1B RID: 48411 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckOverLimit(IEnumerable<Item> items, ItemAddress to, bool useItemCountInEquipment, out GClass2770.GClass3339 error)
	{
		throw null;
	}

	// Token: 0x0600BD1C RID: 48412 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanMoveDogtag(Item item)
	{
		throw null;
	}

	// Token: 0x0600BD1D RID: 48413 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanMoveCompoundItem(Item item)
	{
		throw null;
	}

	// Token: 0x0600BD1E RID: 48414 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetItem(GClass2495 grid, int x, int y, [CanBeNull] out LocationInGrid location)
	{
		throw null;
	}

	// Token: 0x0600BD1F RID: 48415 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item FindItem(string itemId)
	{
		throw null;
	}

	// Token: 0x0600BD20 RID: 48416 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCompatibility(Item item)
	{
		throw null;
	}

	// Token: 0x0600BD21 RID: 48417 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAmmoLoadedCall(int count)
	{
		throw null;
	}

	// Token: 0x0600BD22 RID: 48418 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAmmoUnloadedCall(int count)
	{
		throw null;
	}

	// Token: 0x0600BD23 RID: 48419 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMagazineCheckCall()
	{
		throw null;
	}

	// Token: 0x0600BD24 RID: 48420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OutProcess(TraderControllerClass executor, Item item, ItemAddress from, ItemAddress to, GInterface336 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD25 RID: 48421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InProcess(TraderControllerClass executor, Item item, ItemAddress to, bool succeed, GInterface336 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD26 RID: 48422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OutProcess(Item item, ItemAddress from, ItemAddress to, GInterface336 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD27 RID: 48423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IItemOwner.InProcess(Item item, ItemAddress to, bool succeed, GInterface336 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD28 RID: 48424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckTransferOwners(Item item, ItemAddress targetAddress, out Error error)
	{
		throw null;
	}

	// Token: 0x0600BD29 RID: 48425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Item item, ItemAddress to, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD2A RID: 48426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveAll(SearchableItemClass item, EquipmentClass equipment, IItemOwner equipmentOwner, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD2B RID: 48427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct415<bool> CanSwapToKnownPlaces(Item item, ItemAddress to, Item item1, ItemAddress to1)
	{
		throw null;
	}

	// Token: 0x0600BD2C RID: 48428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GStruct415<bool> TryThrowItem(Item item, Callback callback = null, bool silent = false)
	{
		throw null;
	}

	// Token: 0x0600BD2D RID: 48429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ThrowItem(Item item, [CanBeNull] IEnumerable<GStruct368> destroyedItems, Callback callback = null, bool downDirection = false)
	{
		throw null;
	}

	// Token: 0x0600BD2E RID: 48430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyItem(Item item, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD2F RID: 48431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RechamberWeapon(Weapon weapon, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD30 RID: 48432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GClass2871 ToggleItem(TogglableComponent togglable)
	{
		throw null;
	}

	// Token: 0x0600BD31 RID: 48433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExecuteShotOperation(FaceShieldComponent armor)
	{
		throw null;
	}

	// Token: 0x0600BD32 RID: 48434 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExecuteStationaryOperation(StationaryWeapon stationaryWeapon, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x0600BD33 RID: 48435 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RaiseCallback(IResult result, [CanBeNull] Callback callback, string operation = null)
	{
		throw null;
	}

	// Token: 0x0600BD34 RID: 48436 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Execute(GClass2865 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD35 RID: 48437 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ExecuteStop(GClass2865 operation)
	{
		throw null;
	}

	// Token: 0x0600BD36 RID: 48438 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BindableState<SearchedState> GetSearchState(SearchableItemClass item)
	{
		throw null;
	}

	// Token: 0x0600BD37 RID: 48439 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual bool vmethod_0(GClass2833 operation)
	{
		throw null;
	}

	// Token: 0x0600BD38 RID: 48440 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual void Execute(GClass2833 operation, [CanBeNull] Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD39 RID: 48441 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_17(GEventArgs1 args)
	{
		throw null;
	}

	// Token: 0x0600BD3A RID: 48442 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseAddEvent(GEventArgs2 args)
	{
		throw null;
	}

	// Token: 0x0600BD3B RID: 48443 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseExamineEvent(GEventArgs6 args)
	{
		throw null;
	}

	public void RaiseLoadMagazineEvent(GEventArgs7 args)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600BD3E RID: 48446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseUnloadMagazineEvent(GEventArgs8 args)
	{
		throw null;
	}

	// Token: 0x0600BD3F RID: 48447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseMergeEvent(GEventArgs20 args)
	{
		throw null;
	}

	// Token: 0x0600BD40 RID: 48448 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseInventoryCheckMagazine(MagazineClass item, float time, bool status)
	{
		throw null;
	}

	// Token: 0x0600BD41 RID: 48449 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseRemoveEvent(GEventArgs3 args)
	{
		throw null;
	}

	// Token: 0x0600BD42 RID: 48450 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs22 args)
	{
		throw null;
	}

	// Token: 0x0600BD43 RID: 48451 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(MagazineClass magazine)
	{
		throw null;
	}

	// Token: 0x0600BD44 RID: 48452 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs23 args)
	{
		throw null;
	}

	// Token: 0x0600BD45 RID: 48453 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvent(GEventArgs14 args)
	{
		throw null;
	}

	// Token: 0x0600BD46 RID: 48454 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RaiseBindItemEvent(GEventArgs12 args)
	{
		throw null;
	}

	// Token: 0x0600BD47 RID: 48455 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RaiseUnbindItemEvent(GEventArgs13 args)
	{
		throw null;
	}

	// Token: 0x0600BD48 RID: 48456 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseInsureItemsEvent(GEventArgs21 args)
	{
		throw null;
	}

	// Token: 0x0600BD49 RID: 48457 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSearched(Item item, GClass2765 gridItemAddress, bool silent = false)
	{
		throw null;
	}

	// Token: 0x0600BD4A RID: 48458 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckMagazineAmmoDepend(MagazineClass magazine, Action callback, bool useOperation, bool allowUncheck = false)
	{
		throw null;
	}

	// Token: 0x0600BD4B RID: 48459 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StrictCheckMagazine(MagazineClass magazine, bool status, int skill = 0, bool notify = false, bool useOperation = true)
	{
		throw null;
	}

	// Token: 0x0600BD4C RID: 48460 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseCreateMapMarkerEvent(GEventArgs15 args)
	{
		throw null;
	}

	// Token: 0x0600BD4D RID: 48461 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEditMapMarkerEvent(GEventArgs16 args)
	{
		throw null;
	}

	// Token: 0x0600BD4E RID: 48462 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseDeleteMapMarkerEvent(GEventArgs17 args)
	{
		throw null;
	}

	// Token: 0x0600BD4F RID: 48463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseDiscoverEvent(GEventArgs18 args)
	{
		throw null;
	}

	// Token: 0x0600BD50 RID: 48464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RunOperation(GClass2853 examineOperation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600BD51 RID: 48465 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallPlayerExamineEvent(GEventArgs6 args)
	{
		throw null;
	}

	// Token: 0x0600BD52 RID: 48466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<T> method_19<T>() where T : class, GInterface104
	{
		throw null;
	}

	// Token: 0x0600BD53 RID: 48467 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyDestroyResults(IEnumerable<GStruct368> destroyResults)
	{
		throw null;
	}

	// Token: 0x0600BD54 RID: 48468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 ExecutePossibleAction(GClass2809 itemContext, Item targetItem, bool partialTransferOnly, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BD55 RID: 48469 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 ExecutePossibleAction(GClass2809 itemContext, GClass2809 targetItemContext, ItemAddress to, bool partialTransferOnly, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BD56 RID: 48470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemAddress ToItemAddress(GClass1522 descriptor)
	{
		throw null;
	}

	// Token: 0x0600BD57 RID: 48471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IContainer method_20(GClass1527 container)
	{
		throw null;
	}

	// Token: 0x0600BD58 RID: 48472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2763 ToSlotItemAddress(GClass1523 descriptor)
	{
		throw null;
	}

	// Token: 0x0600BD59 RID: 48473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2765 ToGridItemAddress(GClass1525 descriptor)
	{
		throw null;
	}

	// Token: 0x0600BD5A RID: 48474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2764 ToStackSlotItemAddress(GClass1524 descriptor)
	{
		throw null;
	}

	// Token: 0x0600BD5B RID: 48475 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2762 method_21(GClass1526 descriptor)
	{
		throw null;
	}

	// Token: 0x0600BD5C RID: 48476 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct412 method_22(ref Error error, ref TraderControllerClass.Struct744 struct744_0)
	{
		throw null;
	}

	// Token: 0x0600BD5D RID: 48477 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct412 method_23(GInterface304 applicable, ref Error error, ref TraderControllerClass.Struct744 struct744_0)
	{
		throw null;
	}

	// Token: 0x0600BD5E RID: 48478 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct412 method_24(ref Error error, ref TraderControllerClass.Struct744 struct744_0)
	{
		throw null;
	}

	// Token: 0x0600BD5F RID: 48479 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct412 method_25(ref Error error, ref TraderControllerClass.Struct745 struct745_0)
	{
		throw null;
	}

	// Token: 0x0600BD60 RID: 48480 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct412 method_26(ref Error error, ref TraderControllerClass.Struct745 struct745_0)
	{
		throw null;
	}

	// Token: 0x0400BF8E RID: 49038
	public const int CANT_EXECUTE_ERROR_CODE = 1;

	// Token: 0x0400BF8F RID: 49039
	[CompilerGenerated]
	private Action<Item> action_0;

	// Token: 0x0400BF90 RID: 49040
	public readonly TraderControllerClass.GClass2761 Logger;

	// Token: 0x0400BF91 RID: 49041
	[CompilerGenerated]
	private Action<GEventArgs2> action_1;

	// Token: 0x0400BF92 RID: 49042
	private string[] string_0;

	// Token: 0x0400BF93 RID: 49043
	[CompilerGenerated]
	private Action<GEventArgs3> action_2;

	// Token: 0x0400BF94 RID: 49044
	[CompilerGenerated]
	private Action<GEventArgs6> action_3;

	// Token: 0x0400BF95 RID: 49045
	[CompilerGenerated]
	private Action<GEventArgs6> action_4;

	// Token: 0x0400BF96 RID: 49046
	[CompilerGenerated]
	private Action<Weapon> action_5;

	// Token: 0x0400BF97 RID: 49047
	[CompilerGenerated]
	private Action<GEventArgs15> action_6;

	// Token: 0x0400BF98 RID: 49048
	[CompilerGenerated]
	private Action<GEventArgs16> action_7;

	// Token: 0x0400BF99 RID: 49049
	[CompilerGenerated]
	private Action<GEventArgs17> action_8;

	// Token: 0x0400BF9A RID: 49050
	[CompilerGenerated]
	private Action<GEventArgs22> action_9;

	// Token: 0x0400BF9B RID: 49051
	[CompilerGenerated]
	private Action<GEventArgs1> action_10;

	// Token: 0x0400BF9C RID: 49052
	[CompilerGenerated]
	private Action<GEventArgs1> action_11;

	// Token: 0x0400BF9D RID: 49053
	[CompilerGenerated]
	private Action<bool> action_12;

	// Token: 0x0400BF9E RID: 49054
	protected readonly HashSet<GInterface104> hashSet_0;

	// Token: 0x0400BF9F RID: 49055
	private readonly List<GInterface104> list_0;

	// Token: 0x0400BFA0 RID: 49056
	protected ushort ushort_0;

	// Token: 0x0400BFA1 RID: 49057
	protected MongoID mongoID_0;

	// Token: 0x0400BFA2 RID: 49058
	private bool bool_0;

	// Token: 0x0400BFA3 RID: 49059
	[CompilerGenerated]
	private readonly string string_1;

	// Token: 0x0400BFA4 RID: 49060
	[CompilerGenerated]
	private ItemFilter[] itemFilter_0;

	// Token: 0x0400BFA5 RID: 49061
	[CompilerGenerated]
	private readonly Item item_0;

	// Token: 0x0400BFA6 RID: 49062
	[CompilerGenerated]
	private readonly ContainerCollection containerCollection_0;

	// Token: 0x0400BFA7 RID: 49063
	[CompilerGenerated]
	private readonly ContainerCollection containerCollection_1;

	// Token: 0x0400BFA8 RID: 49064
	[CompilerGenerated]
	private readonly string string_2;

	// Token: 0x0400BFA9 RID: 49065
	[CompilerGenerated]
	private readonly bool bool_1;

	// Token: 0x0400BFAA RID: 49066
	[CompilerGenerated]
	private readonly EOwnerType eownerType_0;

	// Token: 0x0400BFAB RID: 49067
	[CompilerGenerated]
	private readonly List<GEventArgs1> list_1;

	// Token: 0x020024D0 RID: 9424
	public sealed class GClass2761
	{
		// Token: 0x0600BD61 RID: 48481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogError(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogWarn(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("SERVER")]
		[Conditional("CONSOLE")]
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogInfo(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("SERVER")]
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogDebug(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogTrace(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x0400BFAC RID: 49068
		private readonly TraderControllerClass.GClass2761.Class350 class350_0;

		// Token: 0x020024D1 RID: 9425
		private sealed class Class350 : LoggerClass
		{
			// Token: 0x0600BD66 RID: 48486 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Log(LogLevel logLevel, string format, params object[] args)
			{
				throw null;
			}

			// Token: 0x0600BD67 RID: 48487 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void LogFormat(LogType logType, string format, params object[] args)
			{
				throw null;
			}

			// Token: 0x0400BFAD RID: 49069
			private readonly string string_0;
		}
	}

	// Token: 0x020024D2 RID: 9426
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2103
	{
		// Token: 0x0600BD68 RID: 48488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GEventArgs1 x)
		{
			throw null;
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GEventArgs1 x)
		{
			throw null;
		}

		// Token: 0x0600BD6A RID: 48490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GEventArgs1 x)
		{
			throw null;
		}

		// Token: 0x0600BD6B RID: 48491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(IResult _)
		{
			throw null;
		}

		// Token: 0x0400BFAE RID: 49070
		public static readonly TraderControllerClass.Class2103 class2103_0;

		// Token: 0x0400BFAF RID: 49071
		public static Func<GEventArgs1, bool> func_0;

		// Token: 0x0400BFB0 RID: 49072
		public static Func<GEventArgs1, bool> func_1;

		// Token: 0x0400BFB1 RID: 49073
		public static Func<GEventArgs1, bool> func_2;

		// Token: 0x0400BFB2 RID: 49074
		public static Callback callback_0;
	}

	// Token: 0x020024D4 RID: 9428
	[CompilerGenerated]
	private sealed class Class2105<T> where T : GEventArgs1
	{
		// Token: 0x0600BD71 RID: 48497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T activeEvent)
		{
			throw null;
		}

		// Token: 0x0400BFB7 RID: 49079
		public Item item;
	}

	// Token: 0x020024D5 RID: 9429
	[CompilerGenerated]
	private sealed class Class2106
	{
		// Token: 0x0600BD72 RID: 48498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GEventArgs1 activeEvent)
		{
			throw null;
		}

		// Token: 0x0400BFB8 RID: 49080
		public Item item;
	}

	// Token: 0x020024D6 RID: 9430
	[CompilerGenerated]
	private sealed class Class2107
	{
		// Token: 0x0600BD73 RID: 48499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item i)
		{
			throw null;
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item i)
		{
			throw null;
		}

		// Token: 0x0400BFB9 RID: 49081
		public GEventArgs19 inOutHandsProcess;
	}

	// Token: 0x020024D9 RID: 9433
	[CompilerGenerated]
	private sealed class Class2108
	{
		// Token: 0x0600BD79 RID: 48505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400BFC9 RID: 49097
		public TaskCompletionSource<IResult> callbackTask;

		// Token: 0x0400BFCA RID: 49098
		public Callback callback;
	}

	// Token: 0x020024DA RID: 9434
	[CompilerGenerated]
	private sealed class Class2109
	{
		// Token: 0x0600BD7A RID: 48506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400BFCB RID: 49099
		public TraderControllerClass gclass2754_0;

		// Token: 0x0400BFCC RID: 49100
		public GClass2833 operation;

		// Token: 0x0400BFCD RID: 49101
		public Callback callback;
	}

	// Token: 0x020024DB RID: 9435
	[CompilerGenerated]
	private sealed class Class2110
	{
		// Token: 0x0600BD7B RID: 48507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400BFCE RID: 49102
		public TraderControllerClass gclass2754_0;

		// Token: 0x0400BFCF RID: 49103
		public MagazineClass parentMagazine;
	}

	// Token: 0x020024DC RID: 9436
	[CompilerGenerated]
	private sealed class Class2111
	{
		// Token: 0x0600BD7C RID: 48508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400BFD0 RID: 49104
		public TraderControllerClass gclass2754_0;

		// Token: 0x0400BFD1 RID: 49105
		public MagazineClass magazine;
	}

	// Token: 0x020024DD RID: 9437
	[CompilerGenerated]
	private sealed class Class2112
	{
		// Token: 0x0600BD7D RID: 48509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400BFD2 RID: 49106
		public TraderControllerClass gclass2754_0;

		// Token: 0x0400BFD3 RID: 49107
		public MagazineClass magazine;
	}

	// Token: 0x020024DF RID: 9439
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct744
	{
		// Token: 0x0400BFD9 RID: 49113
		public Item item;

		// Token: 0x0400BFDA RID: 49114
		public Item targetItem;

		// Token: 0x0400BFDB RID: 49115
		public TraderControllerClass gclass2754_0;

		// Token: 0x0400BFDC RID: 49116
		public bool simulate;
	}

	// Token: 0x020024E0 RID: 9440
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct745
	{
		// Token: 0x0400BFDD RID: 49117
		public Item item;

		// Token: 0x0400BFDE RID: 49118
		public ItemAddress to;

		// Token: 0x0400BFDF RID: 49119
		public TraderControllerClass gclass2754_0;

		// Token: 0x0400BFE0 RID: 49120
		public bool simulate;
	}
}
