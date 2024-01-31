using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010EC RID: 4332
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		// Token: 0x06005B75 RID: 23413 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Support Group")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Asset Store Thread")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_5(int k)
		{
			throw null;
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_7(Vector3 q, float r)
		{
			throw null;
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_8(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_9(Vector3 L)
		{
			throw null;
		}

		// Token: 0x040066EC RID: 26348
		[Range(0f, 180f)]
		public float twistLimit;

		// Token: 0x040066ED RID: 26349
		[Range(0f, 3f)]
		public int smoothIterations;

		// Token: 0x040066EE RID: 26350
		[HideInInspector]
		[SerializeField]
		public RotationLimitPolygonal.LimitPoint[] points;

		// Token: 0x040066EF RID: 26351
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		// Token: 0x040066F0 RID: 26352
		[SerializeField]
		[HideInInspector]
		public RotationLimitPolygonal.ReachCone[] reachCones;

		// Token: 0x020010ED RID: 4333
		[Serializable]
		public class ReachCone
		{
			// Token: 0x17000E4E RID: 3662
			// (get) Token: 0x06005B84 RID: 23428 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 o
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000E4F RID: 3663
			// (get) Token: 0x06005B85 RID: 23429 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 a
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000E50 RID: 3664
			// (get) Token: 0x06005B86 RID: 23430 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 b
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000E51 RID: 3665
			// (get) Token: 0x06005B87 RID: 23431 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 c
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000E52 RID: 3666
			// (get) Token: 0x06005B88 RID: 23432 RVA: 0x00002050 File Offset: 0x00000250
			public bool isValid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005B89 RID: 23433 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Calculate()
			{
				throw null;
			}

			// Token: 0x040066F1 RID: 26353
			public Vector3[] tetrahedron;

			// Token: 0x040066F2 RID: 26354
			public float volume;

			// Token: 0x040066F3 RID: 26355
			public Vector3 S;

			// Token: 0x040066F4 RID: 26356
			public Vector3 B;
		}

		// Token: 0x020010EE RID: 4334
		[Serializable]
		public class LimitPoint
		{
			// Token: 0x040066F5 RID: 26357
			public Vector3 point;

			// Token: 0x040066F6 RID: 26358
			public float tangentWeight;
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			throw new NotImplementedException();
		}
	}
}
