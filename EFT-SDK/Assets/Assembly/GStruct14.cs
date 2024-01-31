using System;
using System.Runtime.InteropServices;
using EFT;
using UnityEngine;

// Token: 0x020001FE RID: 510
[StructLayout(LayoutKind.Auto)]
public struct GStruct14
{
	// Token: 0x04000A2E RID: 2606
	public bool Inited;

	// Token: 0x04000A2F RID: 2607
	public string Name;

	// Token: 0x04000A30 RID: 2608
	public EBotState Status;

	// Token: 0x04000A31 RID: 2609
	public int MainTactic;

	// Token: 0x04000A32 RID: 2610
	public string StrategyName;

	// Token: 0x04000A33 RID: 2611
	public int Ammo;

	// Token: 0x04000A34 RID: 2612
	public string LookDirType;

	// Token: 0x04000A35 RID: 2613
	public string Target;

	// Token: 0x04000A36 RID: 2614
	public float SeenInfo;

	// Token: 0x04000A37 RID: 2615
	public float SeenTime;

	// Token: 0x04000A38 RID: 2616
	public float VisibleDist;

	// Token: 0x04000A39 RID: 2617
	public float GrassDist;

	// Token: 0x04000A3A RID: 2618
	public int HourServer;

	// Token: 0x04000A3B RID: 2619
	public bool InCover;

	// Token: 0x04000A3C RID: 2620
	public byte GreenType;

	// Token: 0x04000A3D RID: 2621
	public int CoverIndex;

	// Token: 0x04000A3E RID: 2622
	public bool UnderFire;

	// Token: 0x04000A3F RID: 2623
	public bool TriangleLoad;

	// Token: 0x04000A40 RID: 2624
	public bool IsInSpawnWeapon;

	// Token: 0x04000A41 RID: 2625
	public bool Reloading;

	// Token: 0x04000A42 RID: 2626
	public bool HaveAxeEnemy;

	// Token: 0x04000A43 RID: 2627
	public bool IsProblem;

	// Token: 0x04000A44 RID: 2628
	public int Request;

	// Token: 0x04000A45 RID: 2629
	public bool Shooting;

	// Token: 0x04000A46 RID: 2630
	public bool HaveGrenade;

	// Token: 0x04000A47 RID: 2631
	public bool IsFlashed;

	// Token: 0x04000A48 RID: 2632
	public bool IsParametesChanged;

	// Token: 0x04000A49 RID: 2633
	public bool IsGoalEnemyVisible;

	// Token: 0x04000A4A RID: 2634
	public bool CanLookThoughtGrass;

	// Token: 0x04000A4B RID: 2635
	public bool CanShoot;

	// Token: 0x04000A4C RID: 2636
	public bool InBuildingTarget;

	// Token: 0x04000A4D RID: 2637
	public bool InBuildingMe;

	// Token: 0x04000A4E RID: 2638
	public EEnemyPartVisibleType IsEnemyVisibleOnlyBySense;

	// Token: 0x04000A4F RID: 2639
	public float GainSightCoef;

	// Token: 0x04000A50 RID: 2640
	public float AccuratySpeed;

	// Token: 0x04000A51 RID: 2641
	public float ScatteringPerMeter;

	// Token: 0x04000A52 RID: 2642
	public float GainSightCoefCur;

	// Token: 0x04000A53 RID: 2643
	public float ScatteringPerMeterCur;

	// Token: 0x04000A54 RID: 2644
	public bool ShallRunIfNoAmmo;

	// Token: 0x04000A55 RID: 2645
	public string LayerName;

	// Token: 0x04000A56 RID: 2646
	public int NodeRepeats;

	// Token: 0x04000A57 RID: 2647
	public string NodeName;

	// Token: 0x04000A58 RID: 2648
	public string PrevNodeName;

	// Token: 0x04000A59 RID: 2649
	public string Reason;

	// Token: 0x04000A5A RID: 2650
	public string PrevNodeExitReason;

	// Token: 0x04000A5B RID: 2651
	public string CustomData;

	// Token: 0x04000A5C RID: 2652
	public int BotRole;

	// Token: 0x04000A5D RID: 2653
	public int BotDifficulty;

	// Token: 0x04000A5E RID: 2654
	public bool HasBossToFollow;

	// Token: 0x04000A5F RID: 2655
	public BotStandByType StandBy;

	// Token: 0x04000A60 RID: 2656
	public float SeenCoef;

	// Token: 0x04000A61 RID: 2657
	public bool UseMeds;

	// Token: 0x04000A62 RID: 2658
	public bool Damaged;

	// Token: 0x04000A63 RID: 2659
	public bool HaveMeds;

	// Token: 0x04000A64 RID: 2660
	public bool HaveStimulator;

	// Token: 0x04000A65 RID: 2661
	public bool UseStimulator;

	// Token: 0x04000A66 RID: 2662
	public bool HaveSurgical;

	// Token: 0x04000A67 RID: 2663
	public bool UseSurgical;

	// Token: 0x04000A68 RID: 2664
	public int HitsOnMe;

	// Token: 0x04000A69 RID: 2665
	public int ShootsOnMe;

	// Token: 0x04000A6A RID: 2666
	public int Id;

	// Token: 0x04000A6B RID: 2667
	public bool PatrolPointStatus;

	// Token: 0x04000A6C RID: 2668
	public bool PatrolWayStatus;

	// Token: 0x04000A6D RID: 2669
	public string FightType;

	// Token: 0x04000A6E RID: 2670
	public bool CanShootByState;

	// Token: 0x04000A6F RID: 2671
	public EPlayerState PlayerState;

	// Token: 0x04000A70 RID: 2672
	public Vector3 TargetPoint;
}
