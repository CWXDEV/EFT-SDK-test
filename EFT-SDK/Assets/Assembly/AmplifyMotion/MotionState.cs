using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace AmplifyMotion
{
	// Token: 0x020031A5 RID: 12709
	[Serializable]
	internal abstract class MotionState
	{
		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0600FA78 RID: 64120 RVA: 0x00002050 File Offset: 0x00000250
		public AmplifyMotionCamera Owner
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0600FA79 RID: 64121 RVA: 0x00002050 File Offset: 0x00000250
		public bool Initialized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600FA7A RID: 64122 RVA: 0x00002050 File Offset: 0x00000250
		public bool Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600FA7B RID: 64123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_0()
		{
			throw null;
		}

		// Token: 0x0600FA7C RID: 64124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_1()
		{
			throw null;
		}

		// Token: 0x0600FA7D RID: 64125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_2()
		{
			throw null;
		}

		// Token: 0x0600FA7E RID: 64126
		internal abstract void vmethod_3(CommandBuffer updateCB, bool starting);

		// Token: 0x0600FA7F RID: 64127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_4(Camera camera, CommandBuffer renderCB, float scale, Quality quality)
		{
			throw null;
		}

		// Token: 0x0600FA80 RID: 64128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_5()
		{
			throw null;
		}

		// Token: 0x0600FA81 RID: 64129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected MotionState.Struct1050[] method_0(Material[] mats)
		{
			throw null;
		}

		// Token: 0x0600FA82 RID: 64130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static bool smethod_0(MotionState.Struct1051 a, MotionState.Struct1051 b)
		{
			throw null;
		}

		// Token: 0x0600FA83 RID: 64131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void smethod_1(ref Vector3 result, ref MotionState.Struct1051 mat, Vector4 vec)
		{
			throw null;
		}

		// Token: 0x0600FA84 RID: 64132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void smethod_2(ref Vector3 result, ref MotionState.Struct1051 mat, Vector4 vec)
		{
			throw null;
		}

		// Token: 0x0600FA85 RID: 64133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void smethod_3(ref Vector3 result, ref MotionState.Struct1051 mat, Vector4 vec)
		{
			throw null;
		}

		// Token: 0x0400FE75 RID: 65141
		public const int AsyncUpdateTimeout = 100;

		// Token: 0x0400FE76 RID: 65142
		protected bool m_error;

		// Token: 0x0400FE77 RID: 65143
		protected bool m_initialized;

		// Token: 0x0400FE78 RID: 65144
		protected Transform m_transform;

		// Token: 0x0400FE79 RID: 65145
		protected AmplifyMotionCamera m_owner;

		// Token: 0x0400FE7A RID: 65146
		protected AmplifyMotionObjectBase m_obj;

		// Token: 0x0400FE7B RID: 65147
		private static HashSet<Material> m_materialWarnings;

		// Token: 0x020031A6 RID: 12710
		[StructLayout(LayoutKind.Auto)]
		public struct Struct1050
		{
			// Token: 0x0400FE7C RID: 65148
			public Material material;

			// Token: 0x0400FE7D RID: 65149
			public MaterialPropertyBlock propertyBlock;

			// Token: 0x0400FE7E RID: 65150
			public bool coverage;

			// Token: 0x0400FE7F RID: 65151
			public bool cutoff;
		}

		// Token: 0x020031A7 RID: 12711
		[StructLayout(LayoutKind.Auto)]
		public struct Struct1051
		{
			// Token: 0x0600FA86 RID: 64134 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector4 GetRow(int i)
			{
				throw null;
			}

			// Token: 0x0400FE80 RID: 65152
			public float m00;

			// Token: 0x0400FE81 RID: 65153
			public float m01;

			// Token: 0x0400FE82 RID: 65154
			public float m02;

			// Token: 0x0400FE83 RID: 65155
			public float m03;

			// Token: 0x0400FE84 RID: 65156
			public float m10;

			// Token: 0x0400FE85 RID: 65157
			public float m11;

			// Token: 0x0400FE86 RID: 65158
			public float m12;

			// Token: 0x0400FE87 RID: 65159
			public float m13;

			// Token: 0x0400FE88 RID: 65160
			public float m20;

			// Token: 0x0400FE89 RID: 65161
			public float m21;

			// Token: 0x0400FE8A RID: 65162
			public float m22;

			// Token: 0x0400FE8B RID: 65163
			public float m23;
		}
	}
}
