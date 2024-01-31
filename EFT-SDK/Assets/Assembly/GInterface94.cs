using System;
using EFT;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x020011CD RID: 4557
public interface GInterface94
{
	// Token: 0x17000F22 RID: 3874
	// (get) Token: 0x06006131 RID: 24881
	IPlayer iPlayer { get; }

	// Token: 0x17000F23 RID: 3875
	// (get) Token: 0x06006132 RID: 24882
	AIData AIData { get; }

	// Token: 0x17000F24 RID: 3876
	// (get) Token: 0x06006133 RID: 24883
	float AverageRotationSpeed { get; }

	// Token: 0x17000F25 RID: 3877
	// (get) Token: 0x06006134 RID: 24884
	float BotSoundCoef { get; }

	// Token: 0x17000F26 RID: 3878
	// (get) Token: 0x06006135 RID: 24885
	float SoundRadius { get; }

	// Token: 0x17000F27 RID: 3879
	// (get) Token: 0x06006136 RID: 24886
	Vector3 Velocity { get; }

	// Token: 0x06006137 RID: 24887
	bool HasBodyPartCollider(Collider col);

	// Token: 0x17000F28 RID: 3880
	// (get) Token: 0x06006138 RID: 24888
	bool IsAI { get; }

	// Token: 0x17000F29 RID: 3881
	// (get) Token: 0x06006139 RID: 24889
	ICharacterController CharacterController { get; }

	// Token: 0x17000F2A RID: 3882
	// (get) Token: 0x0600613A RID: 24890
	EPlayerState CurrentStataName { get; }

	// Token: 0x17000F2B RID: 3883
	// (get) Token: 0x0600613B RID: 24891
	float CharacterSpeed { get; }

	// Token: 0x17000F2C RID: 3884
	// (get) Token: 0x0600613C RID: 24892
	string Nickname { get; }

	// Token: 0x17000F2D RID: 3885
	// (get) Token: 0x0600613D RID: 24893
	WeaponSoundPlayer WeaponSoundPlayer { get; }

	// Token: 0x17000F2E RID: 3886
	// (get) Token: 0x0600613E RID: 24894
	HitReaction HitReaction { get; }

	// Token: 0x17000F2F RID: 3887
	// (get) Token: 0x0600613F RID: 24895
	string ItemInHandTemplateID { get; }

	// Token: 0x06006140 RID: 24896
	void ShotReactions(DamageInfo shot, EBodyPart bodyPart);

	// Token: 0x06006141 RID: 24897
	GClass1673 ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, GStruct389 shotId);
}
