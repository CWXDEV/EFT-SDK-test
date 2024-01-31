using System;
using System.Collections.Generic;
using Comfort.Common;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x0200244E RID: 9294
	public interface IItemOwner : IContainer
	{
		// Token: 0x14000298 RID: 664
		// (add) Token: 0x0600BAB7 RID: 47799
		// (remove) Token: 0x0600BAB8 RID: 47800
		event Action<GEventArgs2> AddItemEvent;

		// Token: 0x14000299 RID: 665
		// (add) Token: 0x0600BAB9 RID: 47801
		// (remove) Token: 0x0600BABA RID: 47802
		event Action<GEventArgs3> RemoveItemEvent;

		// Token: 0x1400029A RID: 666
		// (add) Token: 0x0600BABB RID: 47803
		// (remove) Token: 0x0600BABC RID: 47804
		event Action<GEventArgs6> PlayerExamineEvent;

		// Token: 0x1400029B RID: 667
		// (add) Token: 0x0600BABD RID: 47805
		// (remove) Token: 0x0600BABE RID: 47806
		event Action<GEventArgs15> CreateMapMarkerEvent;

		// Token: 0x1400029C RID: 668
		// (add) Token: 0x0600BABF RID: 47807
		// (remove) Token: 0x0600BAC0 RID: 47808
		event Action<GEventArgs16> EditMapMarkerEvent;

		// Token: 0x1400029D RID: 669
		// (add) Token: 0x0600BAC1 RID: 47809
		// (remove) Token: 0x0600BAC2 RID: 47810
		event Action<GEventArgs17> DeleteMapMarkerEvent;

		// Token: 0x1400029E RID: 670
		// (add) Token: 0x0600BAC3 RID: 47811
		// (remove) Token: 0x0600BAC4 RID: 47812
		event Action<GEventArgs22> RefreshItemEvent;

		// Token: 0x1400029F RID: 671
		// (add) Token: 0x0600BAC5 RID: 47813
		// (remove) Token: 0x0600BAC6 RID: 47814
		event Action<GEventArgs1> ActiveEventsChanged;

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600BAC7 RID: 47815
		Item RootItem { get; }

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600BAC8 RID: 47816
		[CanBeNull]
		ContainerCollection QuestRaidItem { get; }

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600BAC9 RID: 47817
		[CanBeNull]
		ContainerCollection QuestStashItem { get; }

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600BACA RID: 47818
		bool InboundTransfer { get; }

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600BACB RID: 47819
		// (set) Token: 0x0600BACC RID: 47820
		bool Locked { get; set; }

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600BACD RID: 47821
		string ContainerName { get; }

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600BACE RID: 47822
		EOwnerType OwnerType { get; }

		// Token: 0x0600BACF RID: 47823
		void InProcess(Item item, ItemAddress to, bool succeed, GInterface336 operation, Callback callback);

		// Token: 0x0600BAD0 RID: 47824
		void OutProcess(Item item, ItemAddress from, ItemAddress to, GInterface336 operation, Callback callback);

		// Token: 0x0600BAD1 RID: 47825
		void RaiseAddEvent(GEventArgs2 args);

		// Token: 0x0600BAD2 RID: 47826
		void RaiseRemoveEvent(GEventArgs3 args);

		// Token: 0x0600BAD3 RID: 47827
		void RaiseExamineEvent(GEventArgs6 args);

		// Token: 0x0600BAD4 RID: 47828
		void RaiseLoadMagazineEvent(GEventArgs7 args);

		// Token: 0x0600BAD5 RID: 47829
		void RaiseUnloadMagazineEvent(GEventArgs8 args);

		// Token: 0x0600BAD6 RID: 47830
		void RaiseInventoryCheckMagazine(MagazineClass item, float time, bool status);

		// Token: 0x0600BAD7 RID: 47831
		void RaiseEvent(GEventArgs22 args);

		// Token: 0x0600BAD8 RID: 47832
		void RaiseEvent(GEventArgs14 args);

		// Token: 0x0600BAD9 RID: 47833
		void RaiseBindItemEvent(GEventArgs12 args);

		// Token: 0x0600BADA RID: 47834
		void RaiseInsureItemsEvent(GEventArgs21 args);

		// Token: 0x0600BADB RID: 47835
		void RaiseUnbindItemEvent(GEventArgs13 args);

		// Token: 0x0600BADC RID: 47836
		void RaiseCreateMapMarkerEvent(GEventArgs15 args);

		// Token: 0x0600BADD RID: 47837
		void RaiseEditMapMarkerEvent(GEventArgs16 args);

		// Token: 0x0600BADE RID: 47838
		void RaiseDeleteMapMarkerEvent(GEventArgs17 args);

		// Token: 0x0600BADF RID: 47839
		void RaiseDiscoverEvent(GEventArgs18 args);

		// Token: 0x0600BAE0 RID: 47840
		void RaiseMergeEvent(GEventArgs20 args);

		// Token: 0x0600BAE1 RID: 47841
		void RegisterView(GInterface104 view);

		// Token: 0x0600BAE2 RID: 47842
		void UnregisterView(GInterface104 view);

		// Token: 0x0600BAE3 RID: 47843
		IEnumerable<T> SelectEvents<T>(Item item = null) where T : GEventArgs1;

		// Token: 0x0600BAE4 RID: 47844
		IEnumerable<GEventArgs1> SelectEvents(Item item);

		// Token: 0x0600BAE5 RID: 47845
		bool CheckItemAction(Item item, [CanBeNull] ItemAddress location);

		// Token: 0x0600BAE6 RID: 47846
		void RemoveActiveEvent(GEventArgs1 activeEvent);

		// Token: 0x0600BAE7 RID: 47847
		[CanBeNull]
		ItemAddress ToItemAddress(GClass1522 descriptor);

		// Token: 0x0600BAE8 RID: 47848
		GClass2763 ToSlotItemAddress(GClass1523 descriptor);

		// Token: 0x0600BAE9 RID: 47849
		GClass2765 ToGridItemAddress(GClass1525 descriptor);

		// Token: 0x0600BAEA RID: 47850
		GClass2764 ToStackSlotItemAddress(GClass1524 descriptor);
	}
}
