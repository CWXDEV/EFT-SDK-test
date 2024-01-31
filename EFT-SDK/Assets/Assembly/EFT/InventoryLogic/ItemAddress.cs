using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x020024E1 RID: 9441
	public abstract class ItemAddress
	{
		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x0600BD80 RID: 48512
		public abstract Item Item { get; }

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x0600BD81 RID: 48513
		public abstract string ContainerName { get; }

		// Token: 0x0600BD82 RID: 48514
		public abstract GStruct415<int> GetMaxAddCount(Item item, string visitorId);

		// Token: 0x0600BD83 RID: 48515
		public abstract GStruct415<int> Add(Item item, string[] visitorIds, bool simulate = false);

		// Token: 0x0600BD84 RID: 48516
		public abstract GStruct415<int> AddWithoutRestrictions(Item item, string[] visitorIds);

		// Token: 0x0600BD85 RID: 48517
		public abstract GStruct415<GStruct369> Remove(Item item, string visitorId, bool simulate = false);

		// Token: 0x0600BD86 RID: 48518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsSpecialSlotAddress()
		{
			throw null;
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RaiseAddEvent(Item item, CommandStatus status, string profileId, bool silent = false)
		{
			throw null;
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RaiseMergeEvent(Item item, CommandStatus status, string profileId, bool silent = false)
		{
			throw null;
		}

		// Token: 0x0600BD89 RID: 48521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RaiseDiscoverEvent(Item item)
		{
			throw null;
		}

		// Token: 0x0600BD8A RID: 48522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RaiseRemoveEvent(Item item, CommandStatus status)
		{
			throw null;
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals([CanBeNull] object obj)
		{
			throw null;
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetHashSum()
		{
			throw null;
		}

		// Token: 0x0400BFE1 RID: 49121
		public readonly IContainer Container;
	}
}
