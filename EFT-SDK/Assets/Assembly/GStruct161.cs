using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.NetworkPackets;
using UnityEngine;

// Token: 0x020014F5 RID: 5365
[StructLayout(LayoutKind.Auto)]
public struct GStruct161
{
	// Token: 0x1700122D RID: 4653
	// (get) Token: 0x06007351 RID: 29521 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasImportantData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeDiffUsing(GInterface79 writer, ref GStruct161 current, GStruct161 prevFrame)
	{
		throw null;
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeserializeDiffUsing(GInterface76 reader, ref GStruct161 current, GStruct161 prevFrame)
	{
		throw null;
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct164 movementInfoPacket)
	{
		throw null;
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddInventoryCommand(GStruct195 inventoryCommandPacket)
	{
		throw null;
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddInventoryCommand(GStruct195 inventoryCommandPacket, Vector3 origin, Vector3 direction)
	{
		throw null;
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct186 firearmPacket)
	{
		throw null;
	}

	// Token: 0x06007358 RID: 29528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct322 grenadePacket)
	{
		throw null;
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct328 knifePacket)
	{
		throw null;
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct317 emptyHandPacket)
	{
		throw null;
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct340 usableItemPacket)
	{
		throw null;
	}

	// Token: 0x0600735C RID: 29532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GStruct177 handsChangePacket)
	{
		throw null;
	}

	// Token: 0x1700122E RID: 4654
	// (get) Token: 0x0600735E RID: 29534 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasCommandsForHands
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600735F RID: 29535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearNonStaticData()
	{
		throw null;
	}

	// Token: 0x04007977 RID: 31095
	public const int INVENTORY_COMMANDS_BITS_COUNT = 8;

	// Token: 0x04007978 RID: 31096
	public const int MAX_NON_CRITICAL_PACKETS_IN_ROW = 5;

	// Token: 0x04007979 RID: 31097
	public const int MAX_FRAMES_BETWEEN_CRITICAL_PACKETS = 6;

	// Token: 0x0400797A RID: 31098
	public const int MAX_PACKETS_QUEUE = 127;

	// Token: 0x0400797B RID: 31099
	private const int int_0 = 3;

	// Token: 0x0400797C RID: 31100
	public static GStruct161 DEFAULT_CLIENT2_SERVER_PACKET;

	// Token: 0x0400797D RID: 31101
	private const int int_1 = 120;

	// Token: 0x0400797E RID: 31102
	public const float LOWEST_USUAL_DELTA_TIME = 0.008333334f;

	// Token: 0x0400797F RID: 31103
	private const float float_0 = 0.00048828125f;

	// Token: 0x04007980 RID: 31104
	private const float float_1 = 0.1f;

	// Token: 0x04007981 RID: 31105
	private static readonly GStruct99 gstruct99_0;

	// Token: 0x04007982 RID: 31106
	private static readonly GStruct99 gstruct99_1;

	// Token: 0x04007983 RID: 31107
	public bool HasCriticalData;

	// Token: 0x04007984 RID: 31108
	public ushort? RTT;

	// Token: 0x04007985 RID: 31109
	public bool IsExtraPrecisionMovement;

	// Token: 0x04007986 RID: 31110
	public float TempDeltaTime;

	// Token: 0x04007987 RID: 31111
	public float LastServerTime;

	// Token: 0x04007988 RID: 31112
	public float ClientTime;

	// Token: 0x04007989 RID: 31113
	public float DeltaTimeFromLastCriticalPacket;

	// Token: 0x0400798A RID: 31114
	public bool SyncSkills;

	// Token: 0x0400798B RID: 31115
	public GStruct164 MovementInfoPacket;

	// Token: 0x0400798C RID: 31116
	public GStruct177 HandsChangePacket;

	// Token: 0x0400798D RID: 31117
	public List<GStruct195> InventoryCommandPackets;

	// Token: 0x0400798E RID: 31118
	public GStruct139? LootRayInfo;

	// Token: 0x0400798F RID: 31119
	public EHandsTypePacket HandsTypePacket;

	// Token: 0x04007990 RID: 31120
	public GStruct186 FirearmPacket;

	// Token: 0x04007991 RID: 31121
	public GStruct322 GrenadePacket;

	// Token: 0x04007992 RID: 31122
	public GStruct328 KnifePacket;

	// Token: 0x04007993 RID: 31123
	public GStruct331 PhraseCommandPacket;

	// Token: 0x04007994 RID: 31124
	public GStruct317 EmptyHandPacket;

	// Token: 0x04007995 RID: 31125
	public GStruct340 UsableItemPacket;

	// Token: 0x04007996 RID: 31126
	public Player.EVoipState VoipState;

	// Token: 0x04007997 RID: 31127
	public bool IsTalked;

	// Token: 0x04007998 RID: 31128
	public bool? IsVoiceMuffled;

	// Token: 0x04007999 RID: 31129
	public bool? IsUnderRoof;

	// Token: 0x0400799A RID: 31130
	public GStruct214 ViewPacket;

	// Token: 0x0400799B RID: 31131
	public GStruct138? CancelApplyingItemPacket;

	// Token: 0x0400799C RID: 31132
	public GStruct136? StartSearchContentPacket;

	// Token: 0x0400799D RID: 31133
	public GStruct137? StopSearchContentPacket;

	// Token: 0x0400799E RID: 31134
	public GStruct140? CutsceneEndedPacket;

	// Token: 0x0400799F RID: 31135
	public GStruct180? HelmetLightPacket;

	// Token: 0x040079A0 RID: 31136
	public GStruct141? DevelopHealPacket;

	// Token: 0x040079A1 RID: 31137
	public GStruct142? DevelopTeleportPacket;

	// Token: 0x040079A2 RID: 31138
	public GStruct143? DevelopSetDamageCoeffPacket;

	// Token: 0x040079A3 RID: 31139
	public GStruct146? DevelopContainerHidePacket;

	// Token: 0x040079A4 RID: 31140
	public GStruct147? DevelopEnableServerHitDebuggingPacket;

	// Token: 0x040079A5 RID: 31141
	public GStruct154? DevelopKillMePacket;

	// Token: 0x040079A6 RID: 31142
	public GStruct148? DevelopKillAllAIs;

	// Token: 0x040079A7 RID: 31143
	public GStruct149? DevelopSpawnAI;

	// Token: 0x040079A8 RID: 31144
	public GStruct150? DevelopStartEvent;

	// Token: 0x040079A9 RID: 31145
	public GStruct152? DevelopSnapshotAllPlayers;

	// Token: 0x040079AA RID: 31146
	public GStruct153? DevelopAirdrop;

	// Token: 0x040079AB RID: 31147
	public GStruct151? DevelopUnlockAllDoors;

	// Token: 0x040079AC RID: 31148
	public GStruct155? DevelopResetDiscardLimits;

	// Token: 0x040079AD RID: 31149
	public GStruct157? DevelopResetBufferZoneUsageTime;

	// Token: 0x040079AE RID: 31150
	public GStruct156? DevelopSetBufferZoneAccess;

	// Token: 0x040079AF RID: 31151
	public GStruct158? DevelopSetEncodedRadioTransmitter;

	// Token: 0x040079B0 RID: 31152
	public GStruct159? DevelopSetActiveLighthouseTraderZoneDebug;

	// Token: 0x040079B1 RID: 31153
	public GStruct144? DevelopLighthouseKeeperServicesDebug;

	// Token: 0x040079B2 RID: 31154
	public GStruct145? DevelopBtrSupportServiceDebug;

	// Token: 0x040079B3 RID: 31155
	public GStruct160 PacketAuxiliaryData;

	// Token: 0x040079B4 RID: 31156
	public ulong FrameId;

	// Token: 0x040079B5 RID: 31157
	private const int int_2 = 15;
}
