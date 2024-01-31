using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000847 RID: 2119
[Serializable]
public class DeluxeFilmicCurve
{
	// Token: 0x06003080 RID: 12416 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetExposure()
	{
		throw null;
	}

	// Token: 0x06003081 RID: 12417 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ComputeK(float t, float c, float b, float s, float w)
	{
		throw null;
	}

	// Token: 0x06003082 RID: 12418 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Toe(float x, float t, float c, float b, float s, float w, float k)
	{
		throw null;
	}

	// Token: 0x06003083 RID: 12419 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Shoulder(float x, float t, float c, float b, float s, float w, float k)
	{
		throw null;
	}

	// Token: 0x06003084 RID: 12420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Graph(float x, float t, float c, float b, float s, float w, float k)
	{
		throw null;
	}

	// Token: 0x06003085 RID: 12421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreK()
	{
		throw null;
	}

	// Token: 0x06003086 RID: 12422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ComputeShaderCoefficients(float t, float c, float b, float s, float w, float k)
	{
		throw null;
	}

	// Token: 0x06003087 RID: 12423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCoefficients()
	{
		throw null;
	}

	// Token: 0x0400309B RID: 12443
	[SerializeField]
	public float m_BlackPoint;

	// Token: 0x0400309C RID: 12444
	[SerializeField]
	public float m_WhitePoint;

	// Token: 0x0400309D RID: 12445
	[SerializeField]
	public float m_CrossOverPoint;

	// Token: 0x0400309E RID: 12446
	[SerializeField]
	public float m_ToeStrength;

	// Token: 0x0400309F RID: 12447
	[SerializeField]
	public float m_ShoulderStrength;

	// Token: 0x040030A0 RID: 12448
	[SerializeField]
	public float m_Highlights;

	// Token: 0x040030A1 RID: 12449
	public float m_k;

	// Token: 0x040030A2 RID: 12450
	public Vector4 m_ToeCoef;

	// Token: 0x040030A3 RID: 12451
	public Vector4 m_ShoulderCoef;
}
