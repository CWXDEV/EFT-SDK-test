using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010AB RID: 4267
	public class FBBIKHeadEffector : MonoBehaviour
	{
		// Token: 0x06005951 RID: 22865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(int iteration)
		{
			throw null;
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
			throw null;
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
			throw null;
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x040064D9 RID: 25817
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		// Token: 0x040064DA RID: 25818
		public float positionWeight;

		// Token: 0x040064DB RID: 25819
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		// Token: 0x040064DC RID: 25820
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		// Token: 0x040064DD RID: 25821
		public float rotationWeight;

		// Token: 0x040064DE RID: 25822
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		// Token: 0x040064DF RID: 25823
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		// Token: 0x040064E0 RID: 25824
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		// Token: 0x040064E1 RID: 25825
		[Tooltip("The bones to use for bending.")]
		public FBBIKHeadEffector.BendBone[] bendBones;

		// Token: 0x040064E2 RID: 25826
		public float CCDWeight;

		// Token: 0x040064E3 RID: 25827
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		// Token: 0x040064E4 RID: 25828
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		// Token: 0x040064E5 RID: 25829
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		// Token: 0x040064E6 RID: 25830
		public float postStretchWeight;

		// Token: 0x040064E7 RID: 25831
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		// Token: 0x040064E8 RID: 25832
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		// Token: 0x040064E9 RID: 25833
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		// Token: 0x040064EA RID: 25834
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		// Token: 0x040064EB RID: 25835
		public Vector3 chestDirection;

		// Token: 0x040064EC RID: 25836
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		// Token: 0x040064ED RID: 25837
		public Transform[] chestBones;

		// Token: 0x040064EE RID: 25838
		public IKSolver.GDelegate39 OnPostHeadEffectorFK;

		// Token: 0x040064EF RID: 25839
		private Vector3 vector3_0;

		// Token: 0x040064F0 RID: 25840
		private Vector3 vector3_1;

		// Token: 0x040064F1 RID: 25841
		private Vector3 vector3_2;

		// Token: 0x040064F2 RID: 25842
		private Vector3 vector3_3;

		// Token: 0x040064F3 RID: 25843
		private Vector3 vector3_4;

		// Token: 0x040064F4 RID: 25844
		private Vector3 vector3_5;

		// Token: 0x040064F5 RID: 25845
		private Vector3 vector3_6;

		// Token: 0x040064F6 RID: 25846
		private float float_0;

		// Token: 0x040064F7 RID: 25847
		private float float_1;

		// Token: 0x040064F8 RID: 25848
		private float float_2;

		// Token: 0x040064F9 RID: 25849
		private Quaternion quaternion_0;

		// Token: 0x040064FA RID: 25850
		private Quaternion quaternion_1;

		// Token: 0x040064FB RID: 25851
		private Quaternion[] quaternion_2;

		// Token: 0x040064FC RID: 25852
		private Vector3 vector3_7;

		// Token: 0x040064FD RID: 25853
		private Quaternion quaternion_3;

		// Token: 0x040064FE RID: 25854
		private Vector3[] vector3_8;

		// Token: 0x040064FF RID: 25855
		private Quaternion[] quaternion_4;

		// Token: 0x04006500 RID: 25856
		private Vector3[] vector3_9;

		// Token: 0x04006501 RID: 25857
		private Quaternion[] quaternion_5;

		// Token: 0x04006502 RID: 25858
		private int int_0;

		// Token: 0x04006503 RID: 25859
		private int int_1;

		// Token: 0x04006504 RID: 25860
		private int int_2;

		// Token: 0x04006505 RID: 25861
		private int int_3;

		// Token: 0x020010AC RID: 4268
		[Serializable]
		public class BendBone
		{
			// Token: 0x0600595E RID: 22878 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreDefaultLocalState()
			{
				throw null;
			}

			// Token: 0x0600595F RID: 22879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixTransforms()
			{
				throw null;
			}

			// Token: 0x04006506 RID: 25862
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			// Token: 0x04006507 RID: 25863
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			// Token: 0x04006508 RID: 25864
			private Quaternion defaultLocalRotation;
		}
	}
}
