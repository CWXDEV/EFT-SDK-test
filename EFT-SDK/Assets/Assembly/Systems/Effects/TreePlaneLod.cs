using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Systems.Effects
{
	// Token: 0x02000C38 RID: 3128
	public class TreePlaneLod : MonoBehaviour
	{
		// Token: 0x0600441F RID: 17439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CalcBounds(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void UpdateMesh()
		{
			throw null;
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameVisible()
		{
			throw null;
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBecameInvisible()
		{
			throw null;
		}

		// Token: 0x04004DB8 RID: 19896
		private static LinkedList<TreePlaneLod> linkedList_0;

		// Token: 0x04004DB9 RID: 19897
		private static TreePlaneLod[] treePlaneLod_0;

		// Token: 0x04004DBA RID: 19898
		private static Vector3[] vector3_0;

		// Token: 0x04004DBB RID: 19899
		private static Vector3[] vector3_1;

		// Token: 0x04004DBC RID: 19900
		private static Vector4[] vector4_0;

		// Token: 0x04004DBD RID: 19901
		private static Vector2[] vector2_0;

		// Token: 0x04004DBE RID: 19902
		private static Vector2[] vector2_1;

		// Token: 0x04004DBF RID: 19903
		private static int[] int_0;

		// Token: 0x04004DC0 RID: 19904
		private static Mesh mesh_0;

		// Token: 0x04004DC1 RID: 19905
		private static Vector3 vector3_2;

		// Token: 0x04004DC2 RID: 19906
		private static Vector3 vector3_3;

		// Token: 0x04004DC3 RID: 19907
		private static bool bool_0;

		// Token: 0x04004DC4 RID: 19908
		public float Height;

		// Token: 0x04004DC5 RID: 19909
		public float Width;

		// Token: 0x04004DC6 RID: 19910
		public Material Mat;

		// Token: 0x04004DC7 RID: 19911
		private int int_1;
	}
}
