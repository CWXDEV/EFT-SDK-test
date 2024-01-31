using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02001F8B RID: 8075
[StructLayout(LayoutKind.Auto)]
public struct GStruct275
{
	// Token: 0x0600A73B RID: 42811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A73C RID: 42812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A73D RID: 42813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A73E RID: 42814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeCustomization(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A73F RID: 42815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeserializeCustomization(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A740 RID: 42816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeArmorsInfo(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A741 RID: 42817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeserializeArmorsInfo(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0400AE5F RID: 44639
	public float RemoteTime;

	// Token: 0x0400AE60 RID: 44640
	public Vector3 BodyPosition;

	// Token: 0x0400AE61 RID: 44641
	public Dictionary<EBodyModelPart, string> Customization;

	// Token: 0x0400AE62 RID: 44642
	public EPlayerSide Side;

	// Token: 0x0400AE63 RID: 44643
	public WildSpawnType WildSpawnType;

	// Token: 0x0400AE64 RID: 44644
	public string GroupID;

	// Token: 0x0400AE65 RID: 44645
	public string TeamID;

	// Token: 0x0400AE66 RID: 44646
	public bool IsAI;

	// Token: 0x0400AE67 RID: 44647
	public string ProfileID;

	// Token: 0x0400AE68 RID: 44648
	public string Voice;

	// Token: 0x0400AE69 RID: 44649
	public Player.EVoipState VoIPState;

	// Token: 0x0400AE6A RID: 44650
	public string NickName;

	// Token: 0x0400AE6B RID: 44651
	public string AccountId;

	// Token: 0x0400AE6C RID: 44652
	public EArmorPlateCollider ArmorPlateColliderMask;

	// Token: 0x0400AE6D RID: 44653
	public Inventory Inventory;

	// Token: 0x0400AE6E RID: 44654
	public GClass2241 HandsController;

	// Token: 0x0400AE6F RID: 44655
	public List<GClass2307> ArmorsInfo;

	// Token: 0x0400AE70 RID: 44656
	public GStruct273 ArenaObservedPlayerSpawnMessage;
}
