using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x0200151C RID: 5404
[StructLayout(LayoutKind.Auto)]
public struct GStruct164
{
	// Token: 0x17001248 RID: 4680
	// (get) Token: 0x060073EF RID: 29679 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass1174 USUAL_POSITION_QUANTIZER
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001249 RID: 4681
	// (get) Token: 0x060073F0 RID: 29680 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass1174 PRECISE_POSITION_QUANTIZER
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700124A RID: 4682
	// (get) Token: 0x060073F1 RID: 29681 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasImportantData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060073F2 RID: 29682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCommandRelatedData()
	{
		throw null;
	}

	// Token: 0x060073F3 RID: 29683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x060073F4 RID: 29684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeDiffUsing(GInterface79 writer, ref GStruct164 current, GStruct164 prevFrame, bool isExtraPrecisionMovement = false)
	{
		throw null;
	}

	// Token: 0x060073F5 RID: 29685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(GInterface79 writer, Vector2 currentRotation, Vector2 prevFrameRotation)
	{
		throw null;
	}

	// Token: 0x060073F6 RID: 29686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 smethod_1(GInterface76 reader, Vector2 prevFrameRotation)
	{
		throw null;
	}

	// Token: 0x060073F7 RID: 29687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector3 smethod_2(GInterface79 writer, Vector3 currentPosition, Vector3 prevFramePosition, bool isExtraPrecisionMovement, bool forceSyncPosition)
	{
		throw null;
	}

	// Token: 0x060073F8 RID: 29688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector3 smethod_3(GInterface76 reader, Vector3 prevPosition, bool isExtraPrecisionMovement)
	{
		throw null;
	}

	// Token: 0x060073F9 RID: 29689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeserializeDiffUsing(GInterface76 reader, ref GStruct164 movementInfoPacket, GStruct164 prevFrame, bool isExtraPrecisionMovement = false)
	{
		throw null;
	}

	// Token: 0x04007A0E RID: 31246
	private const int int_0 = 31;

	// Token: 0x04007A0F RID: 31247
	private const int int_1 = 70;

	// Token: 0x04007A10 RID: 31248
	private const int int_2 = 8;

	// Token: 0x04007A11 RID: 31249
	private const float float_0 = 6f;

	// Token: 0x04007A12 RID: 31250
	public const float USUAL_POSITION_X_RESOLUTION = 0.001953125f;

	// Token: 0x04007A13 RID: 31251
	public const float USUAL_POSITION_Y_RESOLUTION = 0.0009765625f;

	// Token: 0x04007A14 RID: 31252
	public const float USUAL_POSITION_Z_RESOLUTION = 0.001953125f;

	// Token: 0x04007A15 RID: 31253
	public const float PRECISE_POSITION_RESOLUTION_MULTIPLIER = 0.1f;

	// Token: 0x04007A16 RID: 31254
	public const float MOVEMENT_DIRECTION_RESOLUTION = 0.015625f;

	// Token: 0x04007A17 RID: 31255
	private static readonly GClass1174 gclass1174_0;

	// Token: 0x04007A18 RID: 31256
	private static readonly GClass1174 gclass1174_1;

	// Token: 0x04007A19 RID: 31257
	private static readonly GClass1174 gclass1174_2;

	// Token: 0x04007A1A RID: 31258
	private const float float_1 = 9.536743E-07f;

	// Token: 0x04007A1B RID: 31259
	private const int int_3 = 8;

	// Token: 0x04007A1C RID: 31260
	private static readonly GClass1171 gclass1171_0;

	// Token: 0x04007A1D RID: 31261
	private static readonly GStruct101 gstruct101_0;

	// Token: 0x04007A1E RID: 31262
	private static readonly GStruct101 gstruct101_1;

	// Token: 0x04007A1F RID: 31263
	private static readonly GStruct101 gstruct101_2;

	// Token: 0x04007A20 RID: 31264
	public static GClass1171 MOVEMENT_DIRECTION_QUANTIZER;

	// Token: 0x04007A21 RID: 31265
	public bool SyncPositionApplied;

	// Token: 0x04007A22 RID: 31266
	public EPlayerState EPlayerState;

	// Token: 0x04007A23 RID: 31267
	public int AnimatorStateIndex;

	// Token: 0x04007A24 RID: 31268
	public int DiscreteDirection;

	// Token: 0x04007A25 RID: 31269
	public float PoseLevel;

	// Token: 0x04007A26 RID: 31270
	public float CharacterMovementSpeed;

	// Token: 0x04007A27 RID: 31271
	public float Tilt;

	// Token: 0x04007A28 RID: 31272
	public int Step;

	// Token: 0x04007A29 RID: 31273
	public int BlindFire;

	// Token: 0x04007A2A RID: 31274
	public bool SoftSurface;

	// Token: 0x04007A2B RID: 31275
	public bool LeftStance;

	// Token: 0x04007A2C RID: 31276
	public GClass678.GStruct34 Stamina;

	// Token: 0x04007A2D RID: 31277
	public GStruct166 InteractWithDoorPacket;

	// Token: 0x04007A2E RID: 31278
	public PlayerInteractPacket InteractWithBtrPacket;

	// Token: 0x04007A2F RID: 31279
	public GStruct172 LootInteractionPacket;

	// Token: 0x04007A30 RID: 31280
	public GStruct168 StationaryWeaponPacket;

	// Token: 0x04007A31 RID: 31281
	public GStruct169 PlantItemPacket;

	// Token: 0x04007A32 RID: 31282
	public Vector3 HeadRotation;

	// Token: 0x04007A33 RID: 31283
	public bool IsGrounded;

	// Token: 0x04007A34 RID: 31284
	public Vector3 SurfaceNormal;

	// Token: 0x04007A35 RID: 31285
	public Vector3 PlayerSurfaceUpAlignNormal;

	// Token: 0x04007A36 RID: 31286
	public bool AutoVaultingSettingEnable;

	// Token: 0x04007A37 RID: 31287
	public bool FullPositionSync;
}
