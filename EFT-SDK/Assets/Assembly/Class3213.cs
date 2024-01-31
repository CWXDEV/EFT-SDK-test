using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AmplifyMotion;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020031A9 RID: 12713
internal class Class3213 : MotionState
{
	// Token: 0x0600FA8C RID: 64140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(string message)
	{
		throw null;
	}

	// Token: 0x0600FA8D RID: 64141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mesh method_2()
	{
		throw null;
	}

	// Token: 0x0600FA8E RID: 64142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mesh method_3()
	{
		throw null;
	}

	// Token: 0x0600FA8F RID: 64143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void vmethod_0()
	{
		throw null;
	}

	// Token: 0x0600FA90 RID: 64144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600FA91 RID: 64145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void vmethod_3(CommandBuffer updateCB, bool starting)
	{
		throw null;
	}

	// Token: 0x0600FA92 RID: 64146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void vmethod_4(Camera camera, CommandBuffer renderCB, float scale, Quality quality)
	{
		throw null;
	}

	// Token: 0x0400FE99 RID: 65177
	public ParticleSystem m_particleSystem;

	// Token: 0x0400FE9A RID: 65178
	public ParticleSystemRenderer m_renderer;

	// Token: 0x0400FE9B RID: 65179
	private Mesh mesh_0;

	// Token: 0x0400FE9C RID: 65180
	private ParticleSystem.RotationOverLifetimeModule rotationOverLifetimeModule_0;

	// Token: 0x0400FE9D RID: 65181
	private ParticleSystem.RotationBySpeedModule rotationBySpeedModule_0;

	// Token: 0x0400FE9E RID: 65182
	private ParticleSystem.Particle[] particle_0;

	// Token: 0x0400FE9F RID: 65183
	private Dictionary<uint, Class3213.Class3216> dictionary_0;

	// Token: 0x0400FEA0 RID: 65184
	private List<uint> list_0;

	// Token: 0x0400FEA1 RID: 65185
	private Stack<Class3213.Class3216> stack_0;

	// Token: 0x0400FEA2 RID: 65186
	private int int_0;

	// Token: 0x0400FEA3 RID: 65187
	private MotionState.Struct1050[] struct1050_0;

	// Token: 0x0400FEA4 RID: 65188
	private bool bool_0;

	// Token: 0x0400FEA5 RID: 65189
	private bool bool_1;

	// Token: 0x0400FEA6 RID: 65190
	private static HashSet<AmplifyMotionObjectBase> hashSet_0;

	// Token: 0x020031AA RID: 12714
	protected class Class3216
	{
		// Token: 0x0400FEA7 RID: 65191
		public int refCount;

		// Token: 0x0400FEA8 RID: 65192
		public MotionState.Struct1051 prevLocalToWorld;

		// Token: 0x0400FEA9 RID: 65193
		public MotionState.Struct1051 currLocalToWorld;
	}
}
