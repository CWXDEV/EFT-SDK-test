using System;
using System.Collections;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x020008F3 RID: 2291
public class HandPoser : Poser
{
	// Token: 0x060033C5 RID: 13253 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Save as left")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Save as right")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x170008D2 RID: 2258
	// (get) Token: 0x060033C7 RID: 13255 RVA: 0x00002050 File Offset: 0x00000250
	private Transform[] Transform_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060033C8 RID: 13256 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitChildren()
	{
		throw null;
	}

	// Token: 0x060033C9 RID: 13257 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator Lerp2TargetRoutine(Quaternion[] qts, float t = 2f, float str = 0.5f)
	{
		throw null;
	}

	// Token: 0x060033CA RID: 13258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Lerp2Target(Quaternion[] qts, float t = 2f, float str = 0.5f)
	{
		throw null;
	}

	// Token: 0x060033CB RID: 13259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int NumParents(Transform child, Transform parent, int index = 0)
	{
		throw null;
	}

	// Token: 0x060033CC RID: 13260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void FixTransforms()
	{
		throw null;
	}

	// Token: 0x060033CD RID: 13261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060033CE RID: 13262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MapGrip(Transform t)
	{
		throw null;
	}

	// Token: 0x060033CF RID: 13263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MapIkPalm(GripPose t)
	{
		throw null;
	}

	// Token: 0x060033D0 RID: 13264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearMap()
	{
		throw null;
	}

	// Token: 0x060033D1 RID: 13265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGrip(GInterface23 grip)
	{
		throw null;
	}

	// Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(bool skip = false)
	{
		throw null;
	}

	// Token: 0x060033D3 RID: 13267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SimpleGrip(bool skip = false)
	{
		throw null;
	}

	// Token: 0x060033D4 RID: 13268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Quaternion method_2(int index)
	{
		throw null;
	}

	// Token: 0x060033D5 RID: 13269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AutoMapping()
	{
		throw null;
	}

	// Token: 0x060033D6 RID: 13270 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreDefaultState()
	{
		throw null;
	}

	// Token: 0x060033D7 RID: 13271 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveGripMapping()
	{
		throw null;
	}

	// Token: 0x0400346C RID: 13420
	private Transform[] transform_0;

	// Token: 0x0400346D RID: 13421
	private Transform[] transform_1;

	// Token: 0x0400346E RID: 13422
	private GInterface23 ginterface23_0;

	// Token: 0x0400346F RID: 13423
	private GInterface23 ginterface23_1;

	// Token: 0x04003470 RID: 13424
	private Transform[] transform_2;

	// Token: 0x04003471 RID: 13425
	public float GripWeight;

	// Token: 0x04003472 RID: 13426
	public float IKTresholdDistance;

	// Token: 0x04003473 RID: 13427
	public bool IgnoreIndexFinger;

	// Token: 0x020008F4 RID: 2292
	[CompilerGenerated]
	[Serializable]
	private sealed class Class478
	{
		// Token: 0x060033D8 RID: 13272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Quaternion method_0(Transform x)
		{
			throw null;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Quaternion method_1(Transform x)
		{
			throw null;
		}

		// Token: 0x04003474 RID: 13428
		public static readonly HandPoser.Class478 class478_0;

		// Token: 0x04003475 RID: 13429
		public static Func<Transform, Quaternion> func_0;

		// Token: 0x04003476 RID: 13430
		public static Func<Transform, Quaternion> func_1;
	}
}
