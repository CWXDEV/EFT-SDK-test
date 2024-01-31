using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200106D RID: 4205
	[Serializable]
	public class BipedReferences
	{
		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060057C1 RID: 22465 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool isFilled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x00002050 File Offset: 0x00000250
		public bool isEmpty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsEmpty(bool includeRoot)
		{
			throw null;
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			throw null;
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.GStruct109 autoDetectParams)
		{
			throw null;
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.GStruct109 autoDetectParams)
		{
			throw null;
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.GStruct109 autoDetectParams)
		{
			throw null;
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(Transform bone, Transform leftUpperArm)
		{
			throw null;
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_1(Transform bone, ref BipedReferences references, BipedReferences.GStruct109 autoDetectParams)
		{
			throw null;
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_2(Transform bone, ref BipedReferences references, BipedReferences.GStruct109 autoDetectParams)
		{
			throw null;
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_3(GClass1262.BoneType boneType, GClass1262.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
			throw null;
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_4(ref Transform[] bones, Transform transform)
		{
			throw null;
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_5(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_6(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_7(BipedReferences references, ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_8(BipedReferences references, ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_9(BipedReferences references, ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_10(BipedReferences references, ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_11(BipedReferences references, ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_12(BipedReferences references, ref string warningMessage)
		{
			throw null;
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_13(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x04006372 RID: 25458
		public Transform root;

		// Token: 0x04006373 RID: 25459
		public Transform pelvis;

		// Token: 0x04006374 RID: 25460
		public Transform leftThigh;

		// Token: 0x04006375 RID: 25461
		public Transform leftCalf;

		// Token: 0x04006376 RID: 25462
		public Transform leftFoot;

		// Token: 0x04006377 RID: 25463
		public Transform rightThigh;

		// Token: 0x04006378 RID: 25464
		public Transform rightCalf;

		// Token: 0x04006379 RID: 25465
		public Transform rightFoot;

		// Token: 0x0400637A RID: 25466
		public Transform leftUpperArm;

		// Token: 0x0400637B RID: 25467
		public Transform leftForearm;

		// Token: 0x0400637C RID: 25468
		public Transform leftHand;

		// Token: 0x0400637D RID: 25469
		public Transform rightUpperArm;

		// Token: 0x0400637E RID: 25470
		public Transform rightForearm;

		// Token: 0x0400637F RID: 25471
		public Transform rightHand;

		// Token: 0x04006380 RID: 25472
		public Transform head;

		// Token: 0x04006381 RID: 25473
		public Transform[] spine;

		// Token: 0x04006382 RID: 25474
		public Transform[] eyes;

		// Token: 0x0200106E RID: 4206
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct109
		{
			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x060057D8 RID: 22488 RVA: 0x00002050 File Offset: 0x00000250
			public static BipedReferences.GStruct109 Default
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04006383 RID: 25475
			public bool legsParentInSpine;

			// Token: 0x04006384 RID: 25476
			public bool includeEyes;
		}
	}
}
