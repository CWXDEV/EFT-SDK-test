using System;
using UnityEngine;

// Token: 0x02001E6C RID: 7788
public interface GInterface190
{
	// Token: 0x17001976 RID: 6518
	// (get) Token: 0x06009FB2 RID: 40882
	bool IsGrounded { get; }

	// Token: 0x17001977 RID: 6519
	// (get) Token: 0x06009FB3 RID: 40883
	bool IsSprintEnabled { get; }

	// Token: 0x17001978 RID: 6520
	// (get) Token: 0x06009FB4 RID: 40884
	Vector3 MovementDirection { get; }

	// Token: 0x17001979 RID: 6521
	// (get) Token: 0x06009FB5 RID: 40885
	Vector3 PlayerRealForward { get; }

	// Token: 0x1700197A RID: 6522
	// (get) Token: 0x06009FB6 RID: 40886
	Transform VaultingGridRoot { get; }

	// Token: 0x06009FB7 RID: 40887
	Vector3 VelocityProjectionOnRealForward();

	// Token: 0x06009FB8 RID: 40888
	void PlayerAnimatorSetObstacleLength(float length);

	// Token: 0x06009FB9 RID: 40889
	void PlayerAnimatorSetObstacleHeight(float height);

	// Token: 0x06009FBA RID: 40890
	float PlayerAnimatorGetObstacleLength();

	// Token: 0x06009FBB RID: 40891
	float PlayerAnimatorGetObstacleHeight();

	// Token: 0x06009FBC RID: 40892
	void PlayerAnimatorSetIsVaulting(bool isVaulting);

	// Token: 0x06009FBD RID: 40893
	bool PlayerAnimatorGetIsVaulting();

	// Token: 0x06009FBE RID: 40894
	void PlayerAnimatorSetDoVault(bool doVault);

	// Token: 0x06009FBF RID: 40895
	void PlayerAnimatorSetDoClimb(bool doClimb);

	// Token: 0x06009FC0 RID: 40896
	void PlayerAnimatorSetBehindObstacleRatio(float height);

	// Token: 0x06009FC1 RID: 40897
	void PlayerAnimatorSetAbsoluteForwardVelocity(float absoluteForwardVelocity);

	// Token: 0x06009FC2 RID: 40898
	bool IsAnimatorInTransitionState(int layer);

	// Token: 0x06009FC3 RID: 40899
	bool PlayerAnimatorIsJumpSetted();

	// Token: 0x06009FC4 RID: 40900
	void UpdateVaultingSpeedLimit();
}
