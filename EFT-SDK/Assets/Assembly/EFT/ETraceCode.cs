using System;

namespace EFT
{
	// Token: 0x020011AC RID: 4524
	public enum ETraceCode : byte
	{
		// Token: 0x04006A67 RID: 27239
		None,
		// Token: 0x04006A68 RID: 27240
		LoadProfileResourcesException,
		// Token: 0x04006A69 RID: 27241
		ClientDamageReceiveActionException,
		// Token: 0x04006A6A RID: 27242
		ClientProcessArmorPointsChangeException,
		// Token: 0x04006A6B RID: 27243
		ClientProcessPoisonResourceChangeException,
		// Token: 0x04006A6C RID: 27244
		ClientApplyHitDebuffException,
		// Token: 0x04006A6D RID: 27245
		ClientProcessRpcClientOperationStatusException,
		// Token: 0x04006A6E RID: 27246
		ClientProcessRpcAcceptHitDebugDataException,
		// Token: 0x04006A6F RID: 27247
		ClientProcessRpcQuestConditionValueChangedException,
		// Token: 0x04006A70 RID: 27248
		ClientProcessRpcAchievementConditionValueChangedException,
		// Token: 0x04006A71 RID: 27249
		ClientShowStatNotificationException,
		// Token: 0x04006A72 RID: 27250
		ClientProcessClientConfirmCallbackException,
		// Token: 0x04006A73 RID: 27251
		ClientProcessNetworkDeathException,
		// Token: 0x04006A74 RID: 27252
		ClientProcessWeaponOverheatException,
		// Token: 0x04006A75 RID: 27253
		ObserverProcessHandsChangePacketException,
		// Token: 0x04006A76 RID: 27254
		ObserverProcessPlayerPacketException,
		// Token: 0x04006A77 RID: 27255
		ObserverProcessInterpolationSpanException,
		// Token: 0x04006A78 RID: 27256
		ObserverInventoryCommandPacketException,
		// Token: 0x04006A79 RID: 27257
		ObserverSpeakerPlayDirectException,
		// Token: 0x04006A7A RID: 27258
		ObserverProcessSendInventoryHashException,
		// Token: 0x04006A7B RID: 27259
		ObserverProcessDeathInventorySyncException,
		// Token: 0x04006A7C RID: 27260
		ObserverProcessFrameException,
		// Token: 0x04006A7D RID: 27261
		ObserverRecordEnemyKillException,
		// Token: 0x04006A7E RID: 27262
		ObserverSetDogtagInfoException,
		// Token: 0x04006A7F RID: 27263
		ObserverProcessNetworkDeathException,
		// Token: 0x04006A80 RID: 27264
		ObserverCheckInvetorySyncException,
		// Token: 0x04006A81 RID: 27265
		ObserverOnDeserializeInitialStateJobException,
		// Token: 0x04006A82 RID: 27266
		ObserverDeserializeFromServerException,
		// Token: 0x04006A83 RID: 27267
		ObserverCldrEnabledException,
		// Token: 0x04006A84 RID: 27268
		ObserverRenderEnabledException,
		// Token: 0x04006A85 RID: 27269
		ObserverTemporaryCollidersEnabledException,
		// Token: 0x04006A86 RID: 27270
		ObserverTemporaryRenderersEnabledException,
		// Token: 0x04006A87 RID: 27271
		ObserverTemporaryCharacterControllerException,
		// Token: 0x04006A88 RID: 27272
		ObserverArmsAnimatorCommonEnabledException,
		// Token: 0x04006A89 RID: 27273
		ObserverBodyAnimatorCommonEnabledException,
		// Token: 0x04006A8A RID: 27274
		ObserverBodyShowException,
		// Token: 0x04006A8B RID: 27275
		ObserverSpawnDead,
		// Token: 0x04006A8C RID: 27276
		ObserverDestroyedWhileSpawning,
		// Token: 0x04006A8D RID: 27277
		ObserverRadioTransmitterStateException
	}
}
