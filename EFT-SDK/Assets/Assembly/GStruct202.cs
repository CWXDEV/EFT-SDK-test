using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.Ballistics;
using JetBrains.Annotations;

// Token: 0x0200161D RID: 5661
[StructLayout(LayoutKind.Auto)]
public struct GStruct202
{
	// Token: 0x06007B33 RID: 31539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06007B34 RID: 31540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasData()
	{
		throw null;
	}

	// Token: 0x06007B35 RID: 31541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlushSkills()
	{
		throw null;
	}

	// Token: 0x06007B36 RID: 31542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChangeSkillExperiencePacket(byte skillId, float value, float effectiveness)
	{
		throw null;
	}

	// Token: 0x06007B37 RID: 31543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChangeMasteringExperiencePacket(string groupName, float value)
	{
		throw null;
	}

	// Token: 0x06007B38 RID: 31544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTraderInfoPacket(string traderId, double standing)
	{
		throw null;
	}

	// Token: 0x06007B39 RID: 31545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStringNotificationPacket(string message)
	{
		throw null;
	}

	// Token: 0x06007B3A RID: 31546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddClientRadioTransmitterPacket(bool isEncoded, RadioTransmitterStatus status, bool isAgressor)
	{
		throw null;
	}

	// Token: 0x06007B3B RID: 31547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLighthouseTraderZoneDebugToolPacket(bool isActive)
	{
		throw null;
	}

	// Token: 0x06007B3C RID: 31548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAcceptHitDebugDataPacket(NetworkPlayer.ClientShot[] clientShots)
	{
		throw null;
	}

	// Token: 0x06007B3D RID: 31549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddQuestConditionValueChangedPacket(GStruct221 conditionalData)
	{
		throw null;
	}

	// Token: 0x06007B3E RID: 31550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAchievementConditionValueChangedPacket(GStruct221 conditionalData)
	{
		throw null;
	}

	// Token: 0x06007B3F RID: 31551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddShowStatNotificationPacket(uint localizationKey1, uint localizationKey2, int value)
	{
		throw null;
	}

	// Token: 0x06007B40 RID: 31552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPlayerDiedPacket(string aggressor, EPlayerSide aggressorSide, EBodyPartColliderType colliderType, string weaponName, EMemberCategory memberCategory, string aggressorMainCharacterName)
	{
		throw null;
	}

	// Token: 0x06007B41 RID: 31553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddClientConfirmCallbackPacket(uint callbackId, [CanBeNull] string error, int inventoryHashSum, byte badBeforeExecuting)
	{
		throw null;
	}

	// Token: 0x06007B42 RID: 31554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddWeaponOverheatPacket(string weaponId, float lastShotTime, float lastOverheat, bool slideReached)
	{
		throw null;
	}

	// Token: 0x06007B43 RID: 31555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSyncHealthPacket(GStruct345 packet)
	{
		throw null;
	}

	// Token: 0x06007B44 RID: 31556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PurgeSyncHealthPackets()
	{
		throw null;
	}

	// Token: 0x06007B45 RID: 31557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddHitInfo(GStruct325 hitInfo)
	{
		throw null;
	}

	// Token: 0x06007B46 RID: 31558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDetailedHitInfo(EDamageType damageType, int d, int absorbed, int staminaLoss, EBodyPart part, MaterialType special)
	{
		throw null;
	}

	// Token: 0x06007B47 RID: 31559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDetailedHitInfo(GStruct316 d)
	{
		throw null;
	}

	// Token: 0x06007B48 RID: 31560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateArmor(GStruct312 a)
	{
		throw null;
	}

	// Token: 0x06007B49 RID: 31561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSideEffectResource(GStruct334 update)
	{
		throw null;
	}

	// Token: 0x06007B4A RID: 31562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOperationStatus(GStruct326 operationStatus)
	{
		throw null;
	}

	// Token: 0x06007B4B RID: 31563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGlobalOperation(int playerId, byte[] serializedDescriptor)
	{
		throw null;
	}

	// Token: 0x06007B4C RID: 31564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface79 writer, ref GStruct202 selfPlayerInfo)
	{
		throw null;
	}

	// Token: 0x06007B4D RID: 31565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize(GInterface76 reader, ref GStruct202 selfPlayerInfo)
	{
		throw null;
	}

	// Token: 0x0400802A RID: 32810
	public const int PROCESSED_CRITICAL_PACKETS_COMMON_MAX_COUNT = 7;

	// Token: 0x0400802B RID: 32811
	private const int int_0 = 2047;

	// Token: 0x0400802C RID: 32812
	public ushort? RTT;

	// Token: 0x0400802D RID: 32813
	public int ServerFixedUpdate;

	// Token: 0x0400802E RID: 32814
	public int ServerTime;

	// Token: 0x0400802F RID: 32815
	public float ServerWorldTime;

	// Token: 0x04008030 RID: 32816
	public List<GStruct325> HitInfos;

	// Token: 0x04008031 RID: 32817
	public List<GStruct316> DetailedHitInfo;

	// Token: 0x04008032 RID: 32818
	public List<GStruct312> ArmorUpdates;

	// Token: 0x04008033 RID: 32819
	public List<GStruct334> PoisonUpdates;

	// Token: 0x04008034 RID: 32820
	public List<GStruct326> OperationStatuses;

	// Token: 0x04008035 RID: 32821
	public List<ValueTuple<int, byte[]>> GlobalOperations;

	// Token: 0x04008036 RID: 32822
	public GClass1762 CommonPacket;

	// Token: 0x04008037 RID: 32823
	public GStruct345? SyncHealthPacket;

	// Token: 0x04008038 RID: 32824
	public GStruct216? AcceptHitDebugDataPacket;

	// Token: 0x04008039 RID: 32825
	public GStruct217? QuestConditionValueChangedPacket;

	// Token: 0x0400803A RID: 32826
	public GStruct220? AchievementConditionValueChangedPacket;

	// Token: 0x0400803B RID: 32827
	public GStruct223? ShowStatNotificationPacket;

	// Token: 0x0400803C RID: 32828
	public GStruct224? PlayerDiedPacket;

	// Token: 0x0400803D RID: 32829
	public GStruct225? ClientConfirmCallbackPacket;

	// Token: 0x0400803E RID: 32830
	public GStruct226? WeaponOverheatPacket;

	// Token: 0x0400803F RID: 32831
	public GStruct207? ChangeSkillExperiencePacket;

	// Token: 0x04008040 RID: 32832
	public GStruct208? ChangeMasteringExperiencePacket;

	// Token: 0x04008041 RID: 32833
	public GStruct210? TradersInfoPacket;

	// Token: 0x04008042 RID: 32834
	public GStruct211? StringNotificationPacket;

	// Token: 0x04008043 RID: 32835
	public GStruct212? RadioTransmitterPacket;

	// Token: 0x04008044 RID: 32836
	public GStruct131? LighthouseTraderZoneDataPacket;

	// Token: 0x04008045 RID: 32837
	public GStruct213? LighthouseTraderZoneDebugToolPacket;

	// Token: 0x04008046 RID: 32838
	public PlayerInteractPacket? InteractWithBtrPacket;

	// Token: 0x04008047 RID: 32839
	public bool TalkDetected;

	// Token: 0x04008048 RID: 32840
	public int CriticalPacketsProcessed;

	// Token: 0x04008049 RID: 32841
	private bool bool_0;
}
