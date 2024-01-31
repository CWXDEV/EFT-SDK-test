using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.NetworkPackets;
using UnityEngine;

// Token: 0x0200162E RID: 5678
public sealed class GClass1762
{
	// Token: 0x06007B6F RID: 31599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06007B70 RID: 31600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007B71 RID: 31601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1762 Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x06007B72 RID: 31602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChangeSkillLevelPacket(byte skillId, float value, float effectiveness)
	{
		throw null;
	}

	// Token: 0x06007B73 RID: 31603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChangeMasteringLevelPacket(string groupName, float value)
	{
		throw null;
	}

	// Token: 0x06007B74 RID: 31604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStartSearchingActionPacket(string itemId)
	{
		throw null;
	}

	// Token: 0x06007B75 RID: 31605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStopSearchingActionPacket(string itemId)
	{
		throw null;
	}

	// Token: 0x06007B76 RID: 31606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddUpdateSearchedState(string itemId, SearchedState state)
	{
		throw null;
	}

	// Token: 0x06007B77 RID: 31607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSetSearchedPacket(string itemId, GStruct366 gridId, bool silent)
	{
		throw null;
	}

	// Token: 0x06007B78 RID: 31608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStopSearchingPacket(string itemId)
	{
		throw null;
	}

	// Token: 0x06007B79 RID: 31609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSyncPositionPacket(byte iteration, Vector3 position, SyncPositionReason reason)
	{
		throw null;
	}

	// Token: 0x06007B7A RID: 31610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSwitchRenderersPacket(bool value)
	{
		throw null;
	}

	// Token: 0x0400806A RID: 32874
	public GStruct203? StartSearchingActionPacket;

	// Token: 0x0400806B RID: 32875
	public GStruct204? StopSearchingActionPacket;

	// Token: 0x0400806C RID: 32876
	public GStruct205? UpdateAccessStatusPacket;

	// Token: 0x0400806D RID: 32877
	public GStruct206? SetSearchedPacket;

	// Token: 0x0400806E RID: 32878
	public GStruct335? StopSearchingPacket;

	// Token: 0x0400806F RID: 32879
	public GStruct336? SyncPositionPacket;

	// Token: 0x04008070 RID: 32880
	public GStruct209? SwitchRenderersPacket;

	// Token: 0x04008071 RID: 32881
	public GStruct207? ChangeSkillLevelPacket;

	// Token: 0x04008072 RID: 32882
	public GStruct208? ChangeMasteringLevelPacket;
}
