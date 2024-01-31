using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A29 RID: 2601
[ExecuteInEditMode]
public class FogEllipsoid : MonoBehaviour
{
	// Token: 0x06003932 RID: 14642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003933 RID: 14643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003935 RID: 14645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x04003B5A RID: 15194
	public FogEllipsoid.Blend m_Blend;

	// Token: 0x04003B5B RID: 15195
	public float m_Density;

	// Token: 0x04003B5C RID: 15196
	public float m_Radius;

	// Token: 0x04003B5D RID: 15197
	public float m_Stretch;

	// Token: 0x04003B5E RID: 15198
	[Range(0f, 1f)]
	public float m_Feather;

	// Token: 0x04003B5F RID: 15199
	[Range(0f, 1f)]
	public float m_NoiseAmount;

	// Token: 0x04003B60 RID: 15200
	public float m_NoiseSpeed;

	// Token: 0x04003B61 RID: 15201
	public float m_NoiseScale;

	// Token: 0x04003B62 RID: 15202
	private bool bool_0;

	// Token: 0x02000A2A RID: 2602
	public enum Blend
	{
		// Token: 0x04003B64 RID: 15204
		Additive,
		// Token: 0x04003B65 RID: 15205
		Multiplicative
	}
}
