using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.SpatialSystem;
using UnityEngine;

// Token: 0x02000D2D RID: 3373
public abstract class GClass970 : GInterface54
{
	// Token: 0x17000B63 RID: 2915
	// (get) Token: 0x060047B9 RID: 18361 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060047BA RID: 18362 RVA: 0x00002050 File Offset: 0x00000250
	public float OcclusionEffect
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000B64 RID: 2916
	// (get) Token: 0x060047BB RID: 18363 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060047BC RID: 18364 RVA: 0x00002050 File Offset: 0x00000250
	public float ObstructionEffect
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000B65 RID: 2917
	// (get) Token: 0x060047BD RID: 18365 RVA: 0x00002050 File Offset: 0x00000250
	public float PropagationEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060047BE RID: 18366
	public abstract void UpdateOcclusion(GClass984 sourceContainer, Transform listenerTransform, bool updateImmediately = false);

	// Token: 0x060047BF RID: 18367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ApplyOcclusionToSource(BetterSource source, bool updateImmediately = false)
	{
		throw null;
	}

	// Token: 0x060047C0 RID: 18368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float method_0()
	{
		throw null;
	}

	// Token: 0x060047C1 RID: 18369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ESoundOcclusionType method_1(SpatialAudioSettings settings)
	{
		throw null;
	}

	// Token: 0x060047C2 RID: 18370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float method_2(Vector3 sourcePos, Vector3 listenerPos, bool isolated = false, EOcclusionTest test = EOcclusionTest.Regular)
	{
		throw null;
	}

	// Token: 0x060047C3 RID: 18371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_3(SpatialAudioRoom sourceRoom)
	{
		throw null;
	}

	// Token: 0x060047C4 RID: 18372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(SpatialAudioRoom secondIsolatedRoom)
	{
		throw null;
	}

	// Token: 0x060047C5 RID: 18373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(SpatialAudioRoom firstRoom, SpatialAudioRoom secondRoom)
	{
		throw null;
	}

	// Token: 0x060047C6 RID: 18374 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5(Vector3 sourcePos, SpatialAudioSettings settings)
	{
		throw null;
	}

	// Token: 0x060047C7 RID: 18375 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_1(SpatialAudioSettings settings)
	{
		throw null;
	}

	// Token: 0x060047C8 RID: 18376 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float method_6(AnimationCurve curve)
	{
		throw null;
	}

	// Token: 0x060047C9 RID: 18377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float method_7(Vector3 listenerPos, BetterSource source)
	{
		throw null;
	}

	// Token: 0x060047CA RID: 18378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static float smethod_2(Vector3 soundPos, Vector3 listenerPos, Vector3 listenerForward, float threshold)
	{
		throw null;
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static float smethod_3(AnimationCurve volumeCurve, float value)
	{
		throw null;
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_8(GClass984 container)
	{
		throw null;
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
		throw null;
	}

	// Token: 0x060047CE RID: 18382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(BetterSource source, GClass980 parameters)
	{
		throw null;
	}

	// Token: 0x040052A7 RID: 21159
	private const int int_0 = 4;

	// Token: 0x040052A8 RID: 21160
	[CompilerGenerated]
	private float float_0;

	// Token: 0x040052A9 RID: 21161
	[CompilerGenerated]
	private float float_1;

	// Token: 0x040052AA RID: 21162
	protected float float_2;

	// Token: 0x040052AB RID: 21163
	protected readonly Dictionary<BetterSource, GClass980> dictionary_0;

	// Token: 0x040052AC RID: 21164
	protected float float_3;

	// Token: 0x040052AD RID: 21165
	protected float float_4;

	// Token: 0x040052AE RID: 21166
	protected float float_5;

	// Token: 0x040052AF RID: 21167
	protected float float_6;

	// Token: 0x040052B0 RID: 21168
	protected float float_7;

	// Token: 0x040052B1 RID: 21169
	protected float float_8;

	// Token: 0x040052B2 RID: 21170
	protected float float_9;

	// Token: 0x040052B3 RID: 21171
	protected float float_10;

	// Token: 0x040052B4 RID: 21172
	protected float float_11;

	// Token: 0x040052B5 RID: 21173
	protected readonly LoggerClass gclass611_0;
}
