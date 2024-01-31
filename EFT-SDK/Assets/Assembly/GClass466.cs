using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200040F RID: 1039
public abstract class GClass466
{
	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
	public float ReachDist
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

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06001930 RID: 6448
	public abstract GInterface6 TargetPoint { get; }

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06001931 RID: 6449 RVA: 0x00002050 File Offset: 0x00000250
	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
	public int CurIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
	public string DebugInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetReturnPoint()
	{
		throw null;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPoint(int index)
	{
		throw null;
	}

	// Token: 0x06001936 RID: 6454
	public abstract void DrawSelectedGizmosWay(float upCoef);

	// Token: 0x06001937 RID: 6455
	public abstract void DrawDebugWay(float upCoef);

	// Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CurrentCorner()
	{
		throw null;
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 LastCorner()
	{
		throw null;
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLast()
	{
		throw null;
	}

	// Token: 0x0600193B RID: 6459
	public abstract void Complete();

	// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncCornerIndex()
	{
		throw null;
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckIsFinished(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x0600193E RID: 6462
	public abstract bool IsSame(Vector3 target, Vector3 ownerPosition);

	// Token: 0x0600193F RID: 6463
	public abstract bool IsSame(IAICorePointLink target, Vector3 ownerPosition);

	// Token: 0x040015A5 RID: 5541
	protected int int_0;

	// Token: 0x040015A6 RID: 5542
	protected readonly Vector3[] vector3_0;

	// Token: 0x040015A7 RID: 5543
	private readonly Vector3 vector3_1;

	// Token: 0x040015A8 RID: 5544
	[CompilerGenerated]
	private float float_0;
}
