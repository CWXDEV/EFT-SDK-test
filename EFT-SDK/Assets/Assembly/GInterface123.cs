using System;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x02001500 RID: 5376
public interface GInterface123
{
	// Token: 0x17001231 RID: 4657
	// (get) Token: 0x0600737A RID: 29562
	Item Item { get; }

	// Token: 0x17001232 RID: 4658
	// (get) Token: 0x0600737B RID: 29563
	bool Destroyed { get; }

	// Token: 0x17001233 RID: 4659
	// (get) Token: 0x0600737C RID: 29564
	bool IsAiming { get; }

	// Token: 0x17001234 RID: 4660
	// (get) Token: 0x0600737D RID: 29565
	float AimingSensitivity { get; }

	// Token: 0x17001235 RID: 4661
	// (get) Token: 0x0600737E RID: 29566
	TransformLinks HandsHierarchy { get; }

	// Token: 0x17001236 RID: 4662
	// (get) Token: 0x0600737F RID: 29567
	FirearmsAnimator FirearmsAnimator { get; }

	// Token: 0x06007380 RID: 29568
	bool CanExecute(GInterface336 operation);

	// Token: 0x06007381 RID: 29569
	void Execute(GInterface336 operation, Callback callback);

	// Token: 0x06007382 RID: 29570
	void Pickup(bool p);

	// Token: 0x06007383 RID: 29571
	bool SupportPickup();

	// Token: 0x06007384 RID: 29572
	void Interact(bool isInteracting, int actionIndex);

	// Token: 0x06007385 RID: 29573
	void Loot(bool b);

	// Token: 0x06007386 RID: 29574
	bool CanRemove();

	// Token: 0x06007387 RID: 29575
	bool IsHandsProcessing();

	// Token: 0x06007388 RID: 29576
	bool IsPlacingBeacon();

	// Token: 0x06007389 RID: 29577
	bool CanInteract();

	// Token: 0x0600738A RID: 29578
	bool IsInInteraction();

	// Token: 0x0600738B RID: 29579
	bool IsInInteractionStrictCheck();

	// Token: 0x0600738C RID: 29580
	float GetAnimatorFloatParam(int hash);

	// Token: 0x0600738D RID: 29581
	void ManualLateUpdate(float deltaTime);

	// Token: 0x0600738E RID: 29582
	void SetInventoryOpened(bool opened);

	// Token: 0x0600738F RID: 29583
	void OnPlayerDead();

	// Token: 0x06007390 RID: 29584
	void OnGameSessionEnd();

	// Token: 0x06007391 RID: 29585
	void Destroy();

	// Token: 0x06007392 RID: 29586
	void ShowGesture(EGesture gesture);

	// Token: 0x06007393 RID: 29587
	void BlindFire(int b);

	// Token: 0x06007394 RID: 29588
	bool InCanNotBeInterruptedOperation();
}
