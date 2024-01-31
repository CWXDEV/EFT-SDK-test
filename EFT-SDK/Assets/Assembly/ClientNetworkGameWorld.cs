using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200092B RID: 2347
internal class ClientNetworkGameWorld : ClientGameWorld
{
	// Token: 0x06003517 RID: 13591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override LootItem CreateLootWithRigidbody(GameObject lootObject, Item item, string objectName, GameWorld gameWorld, bool randomRotation, string[] validProfiles, out BoxCollider objectCollider, bool forceLayerSetup = false, bool syncable = true, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0f)
	{
		throw null;
	}

	// Token: 0x06003518 RID: 13592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLocalGame()
	{
		throw null;
	}

	// Token: 0x06003519 RID: 13593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}
}
