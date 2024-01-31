using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000907 RID: 2311
[Serializable]
public class BetterSpring
{
	// Token: 0x0600344A RID: 13386 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Runtime update")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Cache()
	{
		throw null;
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600344C RID: 13388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyVelocity(Vector3 val)
	{
		throw null;
	}

	// Token: 0x0600344D RID: 13389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyVelocity(int comp, float val)
	{
		throw null;
	}

	// Token: 0x0600344E RID: 13390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyPosition(Vector3 position)
	{
		throw null;
	}

	// Token: 0x170008ED RID: 2285
	// (get) Token: 0x0600344F RID: 13391 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008EE RID: 2286
	// (get) Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003451 RID: 13393 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EquilibriumPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x040034C6 RID: 13510
	private Vector3 _pPos;

	// Token: 0x040034C7 RID: 13511
	private Vector3 _pVel;

	// Token: 0x040034C8 RID: 13512
	[SerializeField]
	private Vector3 _equilibriumPos;

	// Token: 0x040034C9 RID: 13513
	[SerializeField]
	public float _angularFrequency;

	// Token: 0x040034CA RID: 13514
	[SerializeField]
	public float _dampingRatio;

	// Token: 0x040034CB RID: 13515
	private const float Epsilon = 0.0001f;

	// Token: 0x040034CC RID: 13516
	private float _za;

	// Token: 0x040034CD RID: 13517
	private float _zb;

	// Token: 0x040034CE RID: 13518
	private float _z1;

	// Token: 0x040034CF RID: 13519
	private float _z2;

	// Token: 0x040034D0 RID: 13520
	private float _omegaZeta;

	// Token: 0x040034D1 RID: 13521
	private float _alpha;
}
