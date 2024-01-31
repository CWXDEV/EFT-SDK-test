using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Ballistics;
using EFT.InventoryLogic;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020000D7 RID: 215
public sealed class EFTHardSettings : ScriptableObject
{
	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
	public static EFTHardSettings Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task Load()
	{
		throw null;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Set(string key, string value)
	{
		throw null;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAimInState(EPlayerState currentStateName)
	{
		throw null;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BallisticPreset GetPresetFromCollider(BallisticCollider collider)
	{
		throw null;
	}

	// Token: 0x04000517 RID: 1303
	public const string PATH = "eftsettings";

	// Token: 0x04000518 RID: 1304
	private static EFTHardSettings _instance;

	// Token: 0x04000519 RID: 1305
	public AnimationCurve PoseInertiaDamp;

	// Token: 0x0400051A RID: 1306
	public AnimationCurve SpeedLimitAfterFall;

	// Token: 0x0400051B RID: 1307
	public AnimationCurve SpeedLimitDuration;

	// Token: 0x0400051C RID: 1308
	public AnimationCurve PoseInertiaOverFallDistance;

	// Token: 0x0400051D RID: 1309
	public AnimationCurve CrouchAccelerationWeightRange;

	// Token: 0x0400051E RID: 1310
	public AnimationCurve MovementAccelerationRange;

	// Token: 0x0400051F RID: 1311
	public float IdleStateMotionPreservation;

	// Token: 0x04000520 RID: 1312
	public float InertiaInputMaxSpeed;

	// Token: 0x04000521 RID: 1313
	public float DecelerationSpeed;

	// Token: 0x04000522 RID: 1314
	public AnimationCurve InertiaTiltCurve;

	// Token: 0x04000523 RID: 1315
	public float StartingSprintSpeed;

	// Token: 0x04000524 RID: 1316
	public AnimationCurve sprintSpeedInertiaCurve;

	// Token: 0x04000525 RID: 1317
	public AnimationCurve PlaneHeightChangeCurve;

	// Token: 0x04000526 RID: 1318
	public AnimationCurve PlaneVolumeCurve;

	// Token: 0x04000527 RID: 1319
	public AnimationCurve AdditionalTimeCurve;

	// Token: 0x04000528 RID: 1320
	[Header("Airdrop")]
	public float WindFactor;

	// Token: 0x04000529 RID: 1321
	public float WindTurningOffHeight;

	// Token: 0x0400052A RID: 1322
	public float ShakingCoef;

	// Token: 0x0400052B RID: 1323
	public float ShakingTime;

	// Token: 0x0400052C RID: 1324
	public Vector3 DebugWind;

	// Token: 0x0400052D RID: 1325
	[Header("Swing")]
	public float TiltAngleDeceleration;

	// Token: 0x0400052E RID: 1326
	public float SwingSpeed;

	// Token: 0x0400052F RID: 1327
	public float MinTiltAngle;

	// Token: 0x04000530 RID: 1328
	public float MaxTiltAngle;

	// Token: 0x04000531 RID: 1329
	public float MinSwingValue;

	// Token: 0x04000532 RID: 1330
	[Header("Torque")]
	public float MaxTorque;

	// Token: 0x04000533 RID: 1331
	public float TorqueDeceleration;

	// Token: 0x04000534 RID: 1332
	public float ToqueMinValue;

	// Token: 0x04000535 RID: 1333
	public float DeltaTimeModificator;

	// Token: 0x04000536 RID: 1334
	public AnimationCurve XPositionCurve;

	// Token: 0x04000537 RID: 1335
	public AnimationCurve YPositionCurve;

	// Token: 0x04000538 RID: 1336
	public AnimationCurve ZPositionCurve;

	// Token: 0x04000539 RID: 1337
	public AnimationCurve XRotationCurve;

	// Token: 0x0400053A RID: 1338
	public AnimationCurve YRotationCurve;

	// Token: 0x0400053B RID: 1339
	public AnimationCurve ZRotationCurve;

	// Token: 0x0400053C RID: 1340
	[NotNull]
	public AnimationCurve DoorCurve;

	// Token: 0x0400053D RID: 1341
	public EPlayerState[] UnsuitableStates;

	// Token: 0x0400053E RID: 1342
	public float TinnitusEffectSpeedMultiplier;

	// Token: 0x0400053F RID: 1343
	public AnimationCurve TinnitusSound;

	// Token: 0x04000540 RID: 1344
	public AnimationCurve TinnitusLowpas;

	// Token: 0x04000541 RID: 1345
	public AnimationCurve MainChannelLevel;

	// Token: 0x04000542 RID: 1346
	public AnimationCurve StairsSoundOcclusionCurve;

	// Token: 0x04000543 RID: 1347
	[Range(0f, 2f)]
	public float VerticalSoundFactor;

	// Token: 0x04000544 RID: 1348
	public float SoundOcclusionUpdateInterval;

	// Token: 0x04000545 RID: 1349
	public float SoundOcclusionWidening;

	// Token: 0x04000546 RID: 1350
	public float ListenerOcclusionWidening;

	// Token: 0x04000547 RID: 1351
	public float OcclusionHeight;

	// Token: 0x04000548 RID: 1352
	public bool DebugRays;

	// Token: 0x04000549 RID: 1353
	public bool DebugPropagationPath;

	// Token: 0x0400054A RID: 1354
	public bool SoundDebugConsole;

	// Token: 0x0400054B RID: 1355
	public Vector3[] BleedingCenters;

	// Token: 0x0400054C RID: 1356
	public float MAXIMUM_BODYPART_VELOCITY;

	// Token: 0x0400054D RID: 1357
	public float HIT_FORCE;

	// Token: 0x0400054E RID: 1358
	public float AIR_CONTROL_SAME_DIR;

	// Token: 0x0400054F RID: 1359
	public float AIR_CONTROL_BACK_DIR;

	// Token: 0x04000550 RID: 1360
	public float AIR_CONTROL_NONE_OR_ORT_DIR;

	// Token: 0x04000551 RID: 1361
	public float JumpTimeDescendingForStateEnter;

	// Token: 0x04000552 RID: 1362
	public float JumpTimeDescendingForStateExit;

	// Token: 0x04000553 RID: 1363
	public float ObservedJumpTimeDescendingForStateExit;

	// Token: 0x04000554 RID: 1364
	public float VaultingClimbOverTimeDescendingForStateEnter;

	// Token: 0x04000555 RID: 1365
	public float VaultingClimbUpTimeDescendingForStateEnter;

	// Token: 0x04000556 RID: 1366
	public float PICKUP_DELAY;

	// Token: 0x04000557 RID: 1367
	public AnimationCurve CURVA;

	// Token: 0x04000558 RID: 1368
	public float LOOT_RAYCAST_DISTANCE;

	// Token: 0x04000559 RID: 1369
	public float DOOR_RAYCAST_DISTANCE;

	// Token: 0x0400055A RID: 1370
	public float BEHIND_CAST;

	// Token: 0x0400055B RID: 1371
	public float PLAYER_RAYCAST_DISTANCE;

	// Token: 0x0400055C RID: 1372
	public float CULL_RECOIL;

	// Token: 0x0400055D RID: 1373
	public float CULL_GROUNDER;

	// Token: 0x0400055E RID: 1374
	public float CULL_GROUNDER_QUALITY;

	// Token: 0x0400055F RID: 1375
	[Header("Player.AudioController")]
	public AnimationCurve SoundRolloff;

	// Token: 0x04000560 RID: 1376
	public AnimationCurve SpreadCurve;

	// Token: 0x04000561 RID: 1377
	public float TURN_SOUND_DELAY;

	// Token: 0x04000562 RID: 1378
	public float TURN_ANGLE;

	// Token: 0x04000563 RID: 1379
	public float GEAR_SOUND_DELAY;

	// Token: 0x04000564 RID: 1380
	public AnimationCurve LOWER_LOWPASS;

	// Token: 0x04000565 RID: 1381
	public AnimationCurve UPPER_LOWPASS;

	// Token: 0x04000566 RID: 1382
	public LayerMask GunshotMask;

	// Token: 0x04000567 RID: 1383
	public LayerMask BaseMask;

	// Token: 0x04000568 RID: 1384
	public Vector2 VERTICAL_DOT_RANGE;

	// Token: 0x04000569 RID: 1385
	public Vector2 VERTICAL_DOT_RANGE_STAIRS;

	// Token: 0x0400056A RID: 1386
	public AnimationCurve VOLUME_BY_FLOOR_THICKNESS;

	// Token: 0x0400056B RID: 1387
	public bool SqrRootDecay;

	// Token: 0x0400056C RID: 1388
	public Vector2 ABOVE_OR_BELOW;

	// Token: 0x0400056D RID: 1389
	public Vector2 ABOVE_OR_BELOW_STAIRS;

	// Token: 0x0400056E RID: 1390
	[Header("Weapon")]
	public float STOP_AIMING_AT;

	// Token: 0x0400056F RID: 1391
	public bool OFFSET_FOLDED_WEAPON;

	// Token: 0x04000570 RID: 1392
	public double IDLING_MAX_TIME;

	// Token: 0x04000571 RID: 1393
	public Weapon.EMalfunctionState FORCE_MALFUNCTION;

	// Token: 0x04000572 RID: 1394
	public bool FORCE_MALFUNCTION_LOOPED;

	// Token: 0x04000573 RID: 1395
	public bool FORCE_MALFUNCTION_ONCE;

	// Token: 0x04000574 RID: 1396
	public bool NEXT_MALF_IS_UNKNOWN;

	// Token: 0x04000575 RID: 1397
	public float FORCE_NEXT_MALF_CHANCE;

	// Token: 0x04000576 RID: 1398
	public int FORCE_MALFUNCTION_IN_SHOT;

	// Token: 0x04000577 RID: 1399
	public LayerMask WEAPON_OCCLUSION_LAYERS;

	// Token: 0x04000578 RID: 1400
	public LayerMask WEAPON_OCCLUSION_SERVER_LAYERS;

	// Token: 0x04000579 RID: 1401
	public bool OVERHEAT_ALLOW_REDUCE_COI;

	// Token: 0x0400057A RID: 1402
	public bool OVERHEAT_ALLOW_BARREL_MOVE;

	// Token: 0x0400057B RID: 1403
	public float OVERHEAT_INCREASE_MULT;

	// Token: 0x0400057C RID: 1404
	public float DURABILITY_LOSS_MULT;

	// Token: 0x0400057D RID: 1405
	[Header("Shell Shot Extraction")]
	public Vector2 SHELLS_EXCTRACT_FORCE_X_RANGE;

	// Token: 0x0400057E RID: 1406
	public Vector2 SHELLS_EXCTRACT_FORCE_Y_RANGE;

	// Token: 0x0400057F RID: 1407
	public Vector2 SHELLS_EXCTRACT_FORCE_Z_RANGE;

	// Token: 0x04000580 RID: 1408
	public Vector2 SHELLS_EXCTRACT_ROTATION_RANGE_X;

	// Token: 0x04000581 RID: 1409
	public Vector2 SHELLS_EXCTRACT_ROTATION_RANGE_Y;

	// Token: 0x04000582 RID: 1410
	public Vector2 SHELLS_EXCTRACT_ROTATION_RANGE_Z;

	// Token: 0x04000583 RID: 1411
	public float SHELL_FORCE_MULTIPLIER;

	// Token: 0x04000584 RID: 1412
	[Header("Shell MISFIRE Extraction")]
	public Vector2 SHELLS_MISFIRE_FORCE_X_RANGE;

	// Token: 0x04000585 RID: 1413
	public Vector2 SHELLS_MISFIRE_FORCE_Y_RANGE;

	// Token: 0x04000586 RID: 1414
	public Vector2 SHELLS_MISFIRE_FORCE_Z_RANGE;

	// Token: 0x04000587 RID: 1415
	public Vector2 SHELLS_MISFIRE_ROTATION_RANGE_X;

	// Token: 0x04000588 RID: 1416
	public Vector2 SHELLS_MISFIRE_ROTATION_RANGE_Y;

	// Token: 0x04000589 RID: 1417
	public Vector2 SHELLS_MISFIRE_ROTATION_RANGE_Z;

	// Token: 0x0400058A RID: 1418
	[Header("Shell JAM Extraction")]
	public Vector2 SHELLS_JAM_FORCE_X_RANGE;

	// Token: 0x0400058B RID: 1419
	public Vector2 SHELLS_JAM_FORCE_Y_RANGE;

	// Token: 0x0400058C RID: 1420
	public Vector2 SHELLS_JAM_FORCE_Z_RANGE;

	// Token: 0x0400058D RID: 1421
	public Vector2 SHELLS_JAM_ROTATION_RANGE_X;

	// Token: 0x0400058E RID: 1422
	public Vector2 SHELLS_JAM_ROTATION_RANGE_Y;

	// Token: 0x0400058F RID: 1423
	public Vector2 SHELLS_JAM_ROTATION_RANGE_Z;

	// Token: 0x04000590 RID: 1424
	[Header("Grenade")]
	public float GrenadeForce;

	// Token: 0x04000591 RID: 1425
	public ForceMode GrenadeForceMode;

	// Token: 0x04000592 RID: 1426
	[Header("Visual Effects")]
	public bool PLAYER_HIT_DECALS_ENEBLED;

	// Token: 0x04000593 RID: 1427
	public bool HIT_EFFECTS_ENABLED;

	// Token: 0x04000594 RID: 1428
	public bool HEAT_EMITTER_ENABLED;

	// Token: 0x04000595 RID: 1429
	public bool SHOT_EFFECTS_ENABLED;

	// Token: 0x04000596 RID: 1430
	public bool DEFERRED_DECALS_ENABLED;

	// Token: 0x04000597 RID: 1431
	public bool STATIC_DEFERRED_DECALS_ENABLED;

	// Token: 0x04000598 RID: 1432
	[Header("Player")]
	public AnimationCurve ObservedPlayerStepsImitatorCurve;

	// Token: 0x04000599 RID: 1433
	public float SIDESTEP_TO_MOVE_DURATION;

	// Token: 0x0400059A RID: 1434
	public float HumanPyramidExtraDepenetration;

	// Token: 0x0400059B RID: 1435
	public float HumanPyramidSlopeLength;

	// Token: 0x0400059C RID: 1436
	public bool IS_CHARACTER_SPEED_OVERRIDDEN;

	// Token: 0x0400059D RID: 1437
	[Range(0f, 1f)]
	public float OVERRIDDEN_CHARACTER_SPEED;

	// Token: 0x0400059E RID: 1438
	public float PRONE_ALIGN_SPEED;

	// Token: 0x0400059F RID: 1439
	public AnimationCurve SWAY_STRENGTH_PER_KG;

	// Token: 0x040005A0 RID: 1440
	public AnimationCurve DISPLACEMENT_STRENGTH_PER_KG;

	// Token: 0x040005A1 RID: 1441
	public Vector2 MOUSE_LOOK_HORIZONTAL_LIMIT;

	// Token: 0x040005A2 RID: 1442
	public Vector2 MOUSE_LOOK_VERTICAL_LIMIT;

	// Token: 0x040005A3 RID: 1443
	public float MOUSE_LOOK_LIMIT_IN_AIMING_COEF;

	// Token: 0x040005A4 RID: 1444
	[SerializeField]
	private EPlayerState[] NO_AIM_STATES;

	// Token: 0x040005A5 RID: 1445
	public float DELTA_SPEED;

	// Token: 0x040005A6 RID: 1446
	public Vector2 SWAY_DAMPING_NORMAL_DAMAGED;

	// Token: 0x040005A7 RID: 1447
	public Vector2 SWAY_FREQ_NORMAL_DAMAGED;

	// Token: 0x040005A8 RID: 1448
	public float DELTA_LEVEL;

	// Token: 0x040005A9 RID: 1449
	public float DIRECTION_LERP_SPEED;

	// Token: 0x040005AA RID: 1450
	public float HANDS_TO_BODY_MAX_ANGLE;

	// Token: 0x040005AB RID: 1451
	public float POSE_CHANGING_SPEED;

	// Token: 0x040005AC RID: 1452
	public float TILT_CHANGING_SPEED;

	// Token: 0x040005AD RID: 1453
	public float CHARACTER_SPEED_CHANGING_SPEED;

	// Token: 0x040005AE RID: 1454
	public float TRANSFORM_ROTATION_LERP_SPEED;

	// Token: 0x040005AF RID: 1455
	public AnimationCurve DIRECTION_CURVE;

	// Token: 0x040005B0 RID: 1456
	public AnimationCurve LIFT_VELOCITY_BY_SPEED;

	// Token: 0x040005B1 RID: 1457
	public AnimationCurve JUMP_DELAY_BY_SPEED;

	// Token: 0x040005B2 RID: 1458
	public float AIR_MIN_SPEED;

	// Token: 0x040005B3 RID: 1459
	public float AIR_LERP;

	// Token: 0x040005B4 RID: 1460
	public LayerMask MOVEMENT_MASK;

	// Token: 0x040005B5 RID: 1461
	public bool MED_EFFECT_USING_PANEL;

	// Token: 0x040005B6 RID: 1462
	[Header("Roll State Parameters")]
	public bool UseRibcage;

	// Token: 0x040005B7 RID: 1463
	public Vector3 RollCheckShift;

	// Token: 0x040005B8 RID: 1464
	public Vector3 RollCheckSize;

	// Token: 0x040005B9 RID: 1465
	public Vector3 ProneTiltCheckShift;

	// Token: 0x040005BA RID: 1466
	public Vector3 ProneTiltCheckSize;

	// Token: 0x040005BB RID: 1467
	public float RollCheckGroundCastLength;

	// Token: 0x040005BC RID: 1468
	[Header("Ballistic")]
	public BallisticPreset[] ColliderPresets;

	// Token: 0x040005BD RID: 1469
	public float DECAL_SHIFT;

	// Token: 0x040005BE RID: 1470
	public float AIM_PROCEDURAL_INTENSITY;

	// Token: 0x040005BF RID: 1471
	public float PROCEDURAL_INTENSITY_AT_ZERO_LEVEL_POSE;

	// Token: 0x040005C0 RID: 1472
	[Header("BallisticEffects")]
	public float DRAW_BLOOD_ON_WALLS_MAX_DISTANCE;

	// Token: 0x040005C1 RID: 1473
	public float DRAW_BLEEDING_MAX_DISTANCE;

	// Token: 0x040005C2 RID: 1474
	public LayerMask ENVIRONMENT_HIT_MASK;

	// Token: 0x040005C3 RID: 1475
	public bool DRAW_DEFERRED_DECALS;

	// Token: 0x040005C4 RID: 1476
	[Header("Door")]
	public float DOOR_BREACH_THRESHOLD;

	// Token: 0x040005C5 RID: 1477
	[Header("Icons")]
	public StaticIcons StaticIcons;

	// Token: 0x040005C6 RID: 1478
	public Quaternion[] LEFT_HAND_QTS;

	// Token: 0x040005C7 RID: 1479
	public Quaternion[] RIGHT_HAND_QTS;

	// Token: 0x040005C8 RID: 1480
	[Header("Culling")]
	public float CULLING_PLAYER_SPHERE_RADIUS;

	// Token: 0x040005C9 RID: 1481
	public float CULLING_PLAYER_SPHERE_DEAD_BODY_RADIUS;

	// Token: 0x040005CA RID: 1482
	public Vector3 CULLING_PLAYER_SPHERE_SHIFT;

	// Token: 0x040005CB RID: 1483
	public float CULLING_PLAYER_DEAD_BODY_DISTANCE;

	// Token: 0x040005CC RID: 1484
	public float CULLING_PLAYER_DISTANCE;

	// Token: 0x040005CD RID: 1485
	public float CULLING_PLAYER_BALLISTICS_ANGLE;

	// Token: 0x040005CE RID: 1486
	public float PATRONS_MANIPULATIONS_VISIBLE_DISTANCE;

	// Token: 0x040005CF RID: 1487
	public float FLYING_SHELLS_VISIBLE_DISTANCE;

	// Token: 0x040005D0 RID: 1488
	[Header("-------- Simple character controller")]
	public float SIMPLE_CHARACTER_CONTROLLER_FIXED_DELTA_DISTANCE;

	// Token: 0x040005D1 RID: 1489
	public LayerMask TriggersCastLayerMask;

	// Token: 0x040005D2 RID: 1490
	public LayerMask TriggersCastLayerMaskForObservedPlayers;

	// Token: 0x040005D3 RID: 1491
	public LayerMask ServerTriggersCastLayerMask;

	// Token: 0x040005D4 RID: 1492
	public float HoboCastTimeBreakInterval;

	// Token: 0x040005D5 RID: 1493
	public float DelayToOpenContainer;

	// Token: 0x040005D6 RID: 1494
	public float GrenadeFullSyncDelay;

	// Token: 0x040005D7 RID: 1495
	public bool DisableDoorColliderOnInteraction;

	// Token: 0x040005D8 RID: 1496
	public float AnimatorCullDistance;

	// Token: 0x040005D9 RID: 1497
	public AnimationCurve StrafeInertionCurve;

	// Token: 0x040005DA RID: 1498
	public float StrafeInertionCoefficient;

	// Token: 0x040005DB RID: 1499
	[Header("Shells")]
	public EFTHardSettings.ShellsSettings Shells;

	// Token: 0x040005DC RID: 1500
	[Tooltip("This option will enable high quallity physics simulation if loot volume (size.x * size.y * size.z) is less than value\nNote: Continuous Collision Detection is only supported for Rigidbodies with Sphere-, Capsule- or BoxColliders")]
	public float LootVolumeForHighQuallityPhysicsClient;

	// Token: 0x040005DD RID: 1501
	public float LootVolumeForHighQuallityPhysicsServer;

	// Token: 0x040005DE RID: 1502
	public float ThrowLootMakeVisibleDelay;

	// Token: 0x040005DF RID: 1503
	[Header("Corpse")]
	public float CorpseEnergyToSleep;

	// Token: 0x040005E0 RID: 1504
	public float CorpseMaxDepenetrationVelocity;

	// Token: 0x040005E1 RID: 1505
	public float CorpseApplyHardSyncMinDistanceSqr;

	// Token: 0x040005E2 RID: 1506
	public float MaxSmoothPhysicsDeltaTime;

	// Token: 0x040005E3 RID: 1507
	private HashSet<EPlayerState> _noAimStatesHashSet;

	// Token: 0x040005E4 RID: 1508
	public bool DEBUG_CORPSE_PHYSICS;

	// Token: 0x020000D8 RID: 216
	[Serializable]
	public class ShellsSettings
	{
		// Token: 0x040005E5 RID: 1509
		public float radius;

		// Token: 0x040005E6 RID: 1510
		[Tooltip("Playback speed")]
		public float playMult;

		// Token: 0x040005E7 RID: 1511
		[Tooltip("Bigger value for better smoothness")]
		public int maxCastCount;

		// Token: 0x040005E8 RID: 1512
		public float deltaTimeStep;

		// Token: 0x040005E9 RID: 1513
		public float randomReboundSpread;

		// Token: 0x040005EA RID: 1514
		[Tooltip("intial speed")]
		public float velocityMult;

		// Token: 0x040005EB RID: 1515
		public float velocityRotation;

		// Token: 0x040005EC RID: 1516
		public float bounceSpeedMult;

		// Token: 0x040005ED RID: 1517
		public float enforceSurfaceNormals;

		// Token: 0x040005EE RID: 1518
		public Vector2 ReboundRotationX;

		// Token: 0x040005EF RID: 1519
		public Vector2 ReboundRotationY;

		// Token: 0x040005F0 RID: 1520
		public Vector2 ReboundRotationZ;

		// Token: 0x040005F1 RID: 1521
		public bool showDebug;
	}
}
