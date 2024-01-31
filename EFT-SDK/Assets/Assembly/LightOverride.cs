using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A25 RID: 2597
public abstract class LightOverride : MonoBehaviour
{
	// Token: 0x17000986 RID: 2438
	// (get) Token: 0x0600390F RID: 14607 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003910 RID: 14608 RVA: 0x00002050 File Offset: 0x00000250
	public bool isOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000987 RID: 2439
	// (get) Token: 0x06003911 RID: 14609 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003912 RID: 14610 RVA: 0x00002050 File Offset: 0x00000250
	public Light light
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000988 RID: 2440
	// (get) Token: 0x06003913 RID: 14611 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003914 RID: 14612 RVA: 0x00002050 File Offset: 0x00000250
	public TubeLight tubeLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000989 RID: 2441
	// (get) Token: 0x06003915 RID: 14613 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003916 RID: 14614 RVA: 0x00002050 File Offset: 0x00000250
	public AreaLight areaLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700098A RID: 2442
	// (get) Token: 0x06003917 RID: 14615 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003918 RID: 14616 RVA: 0x00002050 File Offset: 0x00000250
	public LightOverride.Type type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600391A RID: 14618
	public abstract bool GetForceOn();

	// Token: 0x0600391B RID: 14619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x04003B13 RID: 15123
	[Header("Overrides")]
	public float m_IntensityMult;

	// Token: 0x04003B14 RID: 15124
	public float m_RangeMult;

	// Token: 0x04003B15 RID: 15125
	private LightOverride.Type type_0;

	// Token: 0x04003B16 RID: 15126
	private bool bool_0;

	// Token: 0x04003B17 RID: 15127
	private Light light_0;

	// Token: 0x04003B18 RID: 15128
	private TubeLight tubeLight_0;

	// Token: 0x04003B19 RID: 15129
	private AreaLight areaLight_0;

	// Token: 0x02000A26 RID: 2598
	public enum Type
	{
		// Token: 0x04003B1B RID: 15131
		None,
		// Token: 0x04003B1C RID: 15132
		Point,
		// Token: 0x04003B1D RID: 15133
		Tube,
		// Token: 0x04003B1E RID: 15134
		Area,
		// Token: 0x04003B1F RID: 15135
		Directional
	}
}
