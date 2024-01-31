using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using FastAnimatorSystem;
using UnityEngine;

// Token: 0x0200073B RID: 1851
public class PlayerBones : MonoBehaviour
{
	// Token: 0x06002B7A RID: 11130 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RotateHead(float blendValue, Vector3 offset, bool leftStance, float leftStanceCurveValue, bool isAiming)
	{
		throw null;
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetArmorPlateCollidersState(EArmorPlateCollider activeCollidersMask)
	{
		throw null;
	}

	// Token: 0x06002B7C RID: 11132 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateBifacialTransformsCollection()
	{
		throw null;
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableBoneImitation(bool useImitation)
	{
		throw null;
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AdjustPistolHolster(Transform holsterTransform, bool isRightLeg)
	{
		throw null;
	}

	// Token: 0x06002B80 RID: 11136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateImportantBones(TransformLinks tLinks)
	{
		throw null;
	}

	// Token: 0x06002B81 RID: 11137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLauncherRightHand()
	{
		throw null;
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetShoulders(float str, float strRight)
	{
		throw null;
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Kinematics(Transform target, float weight)
	{
		throw null;
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShiftWeaponRoot(float t, EPointOfView pv, float thirdPersonAuthority, bool armsupdated = false, float positionCacheValue = 0f, float leftStanceCurveValue = 0f, bool inSprint = false, bool inLeftStanceAnimValue = false, bool inLeftStanceCacheValue = false, bool isAiming = false)
	{
		throw null;
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteTransition(ref PlayerBones.GStruct35 trans)
	{
		throw null;
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Transit(AnimationCurve c, PlayerBones.ETransitionType type)
	{
		throw null;
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IKTransit(PlayerBones.ETransitionType eTransitionType, float speed = 4f)
	{
		throw null;
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BifacialTransform FindFireport()
	{
		throw null;
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BifacialTransform[] FindMultiBarrelsFireports(bool isMultiBarrel)
	{
		throw null;
	}

	// Token: 0x04002974 RID: 10612
	public Player Player;

	// Token: 0x04002975 RID: 10613
	public PlayableAnimator PlayableAnimator;

	// Token: 0x04002976 RID: 10614
	public Transform Weapon_Root_Third;

	// Token: 0x04002977 RID: 10615
	public Transform Weapon_Root_Anim;

	// Token: 0x04002978 RID: 10616
	public Transform Neck;

	// Token: 0x04002979 RID: 10617
	public Transform Weapon_reference_point;

	// Token: 0x0400297A RID: 10618
	public Vector3 R_Neck;

	// Token: 0x0400297B RID: 10619
	public Vector3 R_Head;

	// Token: 0x0400297C RID: 10620
	public Vector3 R_Neck_LeftStance;

	// Token: 0x0400297D RID: 10621
	public Vector3 R_Head_LeftStance;

	// Token: 0x0400297E RID: 10622
	public Transform[] Shoulders;

	// Token: 0x0400297F RID: 10623
	public Transform[] Shoulders_Anim;

	// Token: 0x04002980 RID: 10624
	public Transform[] Upperarms;

	// Token: 0x04002981 RID: 10625
	public Transform[] Forearms;

	// Token: 0x04002982 RID: 10626
	public Transform LeftPalm;

	// Token: 0x04002983 RID: 10627
	public Transform RightPalm;

	// Token: 0x04002984 RID: 10628
	public Transform LootRaycastOrigin;

	// Token: 0x04002985 RID: 10629
	public Transform RootJoint;

	// Token: 0x04002986 RID: 10630
	public Transform VaultingGridRoot;

	// Token: 0x04002987 RID: 10631
	public Transform HolsterPrimary;

	// Token: 0x04002988 RID: 10632
	public Transform HolsterPrimaryAlternative;

	// Token: 0x04002989 RID: 10633
	public Transform HolsterSecondary;

	// Token: 0x0400298A RID: 10634
	public Transform HolsterSecondaryAlternative;

	// Token: 0x0400298B RID: 10635
	public Transform ScabbardTagillaMelee;

	// Token: 0x0400298C RID: 10636
	public Transform HolsterPistol;

	// Token: 0x0400298D RID: 10637
	public Transform LeftLegHolsterPistol;

	// Token: 0x0400298E RID: 10638
	public Transform[] BendGoals;

	// Token: 0x0400298F RID: 10639
	public Transform KickingFoot;

	// Token: 0x04002990 RID: 10640
	public Transform[] FovSpecialTransforms;

	// Token: 0x04002991 RID: 10641
	public BifacialTransform WeaponRoot;

	// Token: 0x04002992 RID: 10642
	public BifacialTransform Ribcage;

	// Token: 0x04002993 RID: 10643
	public BifacialTransform Head;

	// Token: 0x04002994 RID: 10644
	public BifacialTransform LeftShoulder;

	// Token: 0x04002995 RID: 10645
	public BifacialTransform RightShoulder;

	// Token: 0x04002996 RID: 10646
	public BifacialTransform LeftThigh2;

	// Token: 0x04002997 RID: 10647
	public BifacialTransform RightThigh2;

	// Token: 0x04002998 RID: 10648
	public BifacialTransform BodyTransform;

	// Token: 0x04002999 RID: 10649
	public BifacialTransform AnimatedTransform;

	// Token: 0x0400299A RID: 10650
	public BifacialTransform Pelvis;

	// Token: 0x0400299B RID: 10651
	public BifacialTransform LeftThigh1;

	// Token: 0x0400299C RID: 10652
	public BifacialTransform RightThigh1;

	// Token: 0x0400299D RID: 10653
	public BifacialTransform Spine3;

	// Token: 0x0400299E RID: 10654
	public Vector3 Offset;

	// Token: 0x0400299F RID: 10655
	public Quaternion DeltaRotation;

	// Token: 0x040029A0 RID: 10656
	public BodyPartCollider LeftHandCollider;

	// Token: 0x040029A1 RID: 10657
	[HideInInspector]
	public BifacialTransform Fireport;

	// Token: 0x040029A2 RID: 10658
	public BifacialTransform LeftMultiBarrelFireport;

	// Token: 0x040029A3 RID: 10659
	public BifacialTransform RightMultiBarrelFireport;

	// Token: 0x040029A4 RID: 10660
	public BifacialTransform[] MultiBarrelsFireports;

	// Token: 0x040029A5 RID: 10661
	public readonly Dictionary<PlayerBoneType, BifacialTransform> BifacialTransforms;

	// Token: 0x040029A6 RID: 10662
	public readonly Dictionary<EBodyPartColliderType, BodyPartCollider> BodyPartCollidersDictionary;

	// Token: 0x040029A7 RID: 10663
	public readonly Dictionary<EArmorPlateCollider, ArmorPlateCollider> ArmorPlateCollidersDict;

	// Token: 0x040029A8 RID: 10664
	public BodyPartCollider[] BodyPartColliders;

	// Token: 0x040029A9 RID: 10665
	public ArmorPlateCollider[] ArmorPlateColliders;

	// Token: 0x040029AA RID: 10666
	public readonly HashSet<Collider> BodyPartCollidersHashSet;

	// Token: 0x040029AB RID: 10667
	private AnimationCurve _transitionCurve;

	// Token: 0x040029AC RID: 10668
	private float _transitionTime;

	// Token: 0x040029AD RID: 10669
	private float _transitionLn;

	// Token: 0x040029AE RID: 10670
	private PlayerBones.ETransitionType _transitionType;

	// Token: 0x040029AF RID: 10671
	public AnimationCurve HeadRotationCurve;

	// Token: 0x040029B0 RID: 10672
	public Transform Spine1;

	// Token: 0x040029B1 RID: 10673
	private PlayerBones.GStruct35 _transition;

	// Token: 0x040029B2 RID: 10674
	public float HeadChain;

	// Token: 0x040029B3 RID: 10675
	public float NeckChain;

	// Token: 0x040029B4 RID: 10676
	private float _offsetForRootAimInLeftStance;

	// Token: 0x040029B5 RID: 10677
	private readonly Vector3 _offsterDirrectionForLeftStanceInAim;

	// Token: 0x040029B6 RID: 10678
	public float leftStanceRotationAndPositionChangeSpeed;

	// Token: 0x040029B7 RID: 10679
	public float leftStanceReturnBackSpeed;

	// Token: 0x040029B8 RID: 10680
	private Quaternion _lastWeaponRotationInLeftStance;

	// Token: 0x040029B9 RID: 10681
	private Vector3 targetLSPosition;

	// Token: 0x040029BA RID: 10682
	private bool _gotFullLeftStanceLastFrame;

	// Token: 0x040029BB RID: 10683
	private bool _wasMovingInLsAim;

	// Token: 0x040029BC RID: 10684
	private Vector3 _targetLSInAimPosition;

	// Token: 0x0200073C RID: 1852
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct35
	{
		// Token: 0x040029BD RID: 10685
		public PlayerBones.ETransitionType type;

		// Token: 0x040029BE RID: 10686
		public AnimationCurve c;

		// Token: 0x040029BF RID: 10687
		public bool executed;
	}

	// Token: 0x0200073D RID: 1853
	public enum ETransitionType
	{
		// Token: 0x040029C1 RID: 10689
		In,
		// Token: 0x040029C2 RID: 10690
		Out,
		// Token: 0x040029C3 RID: 10691
		None
	}
}
