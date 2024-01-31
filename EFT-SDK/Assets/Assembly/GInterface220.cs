using System;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02001F8E RID: 8078
public interface GInterface220
{
	// Token: 0x17001B77 RID: 7031
	// (get) Token: 0x0600A749 RID: 42825
	ICharacterController CharacterController { get; }

	// Token: 0x0600A74A RID: 42826
	void OnStateEnter(BaseMovementState nextState);

	// Token: 0x0600A74B RID: 42827
	void OnStateExit(BaseMovementState state);

	// Token: 0x0600A74C RID: 42828
	void OnStateMove(BaseMovementState state);

	// Token: 0x17001B78 RID: 7032
	// (get) Token: 0x0600A74D RID: 42829
	Quaternion TargetBodyRotation { get; }

	// Token: 0x17001B79 RID: 7033
	// (get) Token: 0x0600A74E RID: 42830
	Vector3 BodyPosition { get; }

	// Token: 0x17001B7A RID: 7034
	// (get) Token: 0x0600A74F RID: 42831
	Quaternion BodyRotation { get; }

	// Token: 0x17001B7B RID: 7035
	// (get) Token: 0x0600A750 RID: 42832
	bool IsGrounded { get; }

	// Token: 0x0600A751 RID: 42833
	void SetRotation(Quaternion value);

	// Token: 0x0600A752 RID: 42834
	void EnableApproached(bool value);

	// Token: 0x0600A753 RID: 42835
	void EnableKick(bool value);

	// Token: 0x0600A754 RID: 42836
	void EnableKickSucceed(bool value);

	// Token: 0x17001B7C RID: 7036
	// (get) Token: 0x0600A755 RID: 42837
	WorldInteractiveObject InteractionDoor { get; }

	// Token: 0x17001B7D RID: 7037
	// (get) Token: 0x0600A756 RID: 42838
	bool InteractionDoorResult { get; }

	// Token: 0x17001B7E RID: 7038
	// (get) Token: 0x0600A757 RID: 42839
	Item InteractionDoorKey { get; }

	// Token: 0x17001B7F RID: 7039
	// (get) Token: 0x0600A758 RID: 42840
	PlayerAnimator PlayerAnimator { get; }

	// Token: 0x17001B80 RID: 7040
	// (get) Token: 0x0600A759 RID: 42841
	FirearmsAnimator FirearmsAnimator { get; }

	// Token: 0x0600A75A RID: 42842
	void CreateKeyInHand(Item key);

	// Token: 0x0600A75B RID: 42843
	void DestroyKeyInHand();

	// Token: 0x0600A75C RID: 42844
	void SetIKInteract(GripPose grip);

	// Token: 0x0600A75D RID: 42845
	float UpdateIKInteract();

	// Token: 0x0600A75E RID: 42846
	void ClearIKInteract();

	// Token: 0x0600A75F RID: 42847
	void UpdateStationaryWeaponPosition();

	// Token: 0x0600A760 RID: 42848
	void ExitFromStationary();

	// Token: 0x0600A761 RID: 42849
	void ObservedSetLeftStanceState(bool value);

	// Token: 0x0600A762 RID: 42850
	void ObservedSetAnimatorLeftStanceToCacheValue();

	// Token: 0x0600A763 RID: 42851
	void ObservedDisableLeftStanceAnim();
}
