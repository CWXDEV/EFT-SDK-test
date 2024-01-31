using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010C5 RID: 4293
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06005A2E RID: 23086 RVA: 0x00002050 File Offset: 0x00000250
		public FBIKChain leftArmChain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x00002050 File Offset: 0x00000250
		public FBIKChain rightArmChain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x00002050 File Offset: 0x00000250
		public FBIKChain leftLegChain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x00002050 File Offset: 0x00000250
		public FBIKChain rightLegChain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06005A32 RID: 23090 RVA: 0x00002050 File Offset: 0x00000250
		public IKMappingLimb leftArmMapping
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06005A33 RID: 23091 RVA: 0x00002050 File Offset: 0x00000250
		public IKMappingLimb rightArmMapping
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x00002050 File Offset: 0x00000250
		public IKMappingLimb leftLegMapping
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06005A35 RID: 23093 RVA: 0x00002050 File Offset: 0x00000250
		public IKMappingLimb rightLegMapping
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x00002050 File Offset: 0x00000250
		public IKMappingBone headMapping
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
			throw null;
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			throw null;
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			throw null;
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			throw null;
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			throw null;
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKMappingSpine GetSpineMapping()
		{
			throw null;
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKMappingBone GetHeadMapping()
		{
			throw null;
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			throw null;
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToReferences(BipedReferences references, Transform rootNode = null)
		{
			throw null;
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			throw null;
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
			throw null;
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06005A43 RID: 23107 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A44 RID: 23108 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 pullBodyOffset
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
			throw null;
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Transform smethod_0(BipedReferences references)
		{
			throw null;
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Transform smethod_1(BipedReferences references)
		{
			throw null;
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_2(Transform[] array, Transform transform)
		{
			throw null;
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReadPose()
		{
			throw null;
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2()
		{
			throw null;
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_3(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			throw null;
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ApplyBendConstraints()
		{
			throw null;
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WritePose()
		{
			throw null;
		}

		// Token: 0x040065E0 RID: 26080
		public Transform rootNode;

		// Token: 0x040065E1 RID: 26081
		[Range(0f, 1f)]
		public float spineStiffness;

		// Token: 0x040065E2 RID: 26082
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		// Token: 0x040065E3 RID: 26083
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		// Token: 0x040065E5 RID: 26085
		private Vector3 offset;
	}
}
