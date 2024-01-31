using System;
using System.Collections.Generic;
using EFT.CameraControl;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.PrefabSettings;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001191 RID: 4497
	public interface IPlayer
	{
		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06005F57 RID: 24407
		int Id { get; }

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06005F58 RID: 24408
		EPlayerSide Side { get; }

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06005F59 RID: 24409
		string GroupId { get; }

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06005F5A RID: 24410
		string TeamId { get; }

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06005F5B RID: 24411
		Vector3 LookDirection { get; }

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06005F5C RID: 24412
		Vector3 Position { get; }

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06005F5D RID: 24413
		BifacialTransform Transform { get; }

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06005F5E RID: 24414
		BifacialTransform WeaponRoot { get; }

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06005F5F RID: 24415
		IHealthController HealthController { get; }

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06005F60 RID: 24416
		Profile Profile { get; }

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06005F61 RID: 24417
		AIData AIData { get; }

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06005F62 RID: 24418
		PlayerLoyaltyData Loyalty { get; }

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06005F63 RID: 24419
		bool IsAI { get; }

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06005F64 RID: 24420
		Dictionary<BodyPartType, EnemyPart> MainParts { get; }

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06005F65 RID: 24421
		string ProfileId { get; }

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06005F66 RID: 24422
		string AccountId { get; }

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06005F67 RID: 24423
		PlayerBones PlayerBones { get; }

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06005F68 RID: 24424
		bool IsYourPlayer { get; }

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06005F69 RID: 24425
		PlayerBody PlayerBody { get; }

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06005F6A RID: 24426
		ICharacterController CharacterController { get; }

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06005F6B RID: 24427
		byte ChannelIndex { get; }

		// Token: 0x06005F6C RID: 24428
		void OnDeserializeFromServer(byte channelId, GInterface76 reader);

		// Token: 0x06005F6D RID: 24429
		RadioTransmitterRecodableComponent FindRadioTransmitter();

		// Token: 0x06005F6E RID: 24430
		GClass2712 FindCultistAmulet();

		// Token: 0x1400010C RID: 268
		// (add) Token: 0x06005F6F RID: 24431
		// (remove) Token: 0x06005F70 RID: 24432
		event Action<IPlayer> OnIPlayerDeadOrUnspawn;

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06005F71 RID: 24433
		// (set) Token: 0x06005F72 RID: 24434
		bool IsInBufferZone { get; set; }

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06005F73 RID: 24435
		// (set) Token: 0x06005F74 RID: 24436
		EPlayerBtrState BtrState { get; set; }

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06005F75 RID: 24437
		bool StateIsSuitableForHandInput { get; }

		// Token: 0x06005F76 RID: 24438
		void SetInteractInHands(bool isInteracting, int animationId = 1);

		// Token: 0x06005F77 RID: 24439
		void PlantItemLocalOnly(Item item, string zone);

		// Token: 0x06005F78 RID: 24440
		void UpdateInteractionCast();

		// Token: 0x06005F79 RID: 24441
		void HandleFlareSuccessEvent(Vector3 position, FlareEventType eventType);

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06005F7A RID: 24442
		Vector2 Rotation { get; }

		// Token: 0x06005F7B RID: 24443
		Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight);

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06005F7C RID: 24444
		Vector3 Velocity { get; }

		// Token: 0x06005F7D RID: 24445
		IAnimator GetArmsAnimatorCommon();

		// Token: 0x06005F7E RID: 24446
		void SetArmsAnimatorCommon(IAnimator animator);

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06005F7F RID: 24447
		Player.EUpdateMode ArmsUpdateMode { get; }

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06005F80 RID: 24448
		EUpdateQueue ArmsUpdateQueue { get; }

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06005F81 RID: 24449
		ECameraType VisibleToCameraType { get; }

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06005F82 RID: 24450
		bool IsVisibleToCamera { get; }
	}
}
