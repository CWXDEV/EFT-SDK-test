using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A6A RID: 2666
[ExecuteInEditMode]
public class LocalDustParticles : MonoBehaviour
{
	// Token: 0x06003AB2 RID: 15026 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06003AB3 RID: 15027 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x04003E0A RID: 15882
	public LocalDustParticlesParent PurticlesParent;

	// Token: 0x04003E0B RID: 15883
	public int Count;

	// Token: 0x04003E0C RID: 15884
	public Color ParticlesColor;

	// Token: 0x04003E0D RID: 15885
	public float AlphaRandomness;

	// Token: 0x04003E0E RID: 15886
	public float SizeRandomness;

	// Token: 0x04003E0F RID: 15887
	public float SideSpeed;

	// Token: 0x04003E10 RID: 15888
	private Matrix4x4 matrix4x4_0;

	// Token: 0x04003E11 RID: 15889
	private int int_0;

	// Token: 0x04003E12 RID: 15890
	private float float_0;

	// Token: 0x04003E13 RID: 15891
	private Color color_0;

	// Token: 0x04003E14 RID: 15892
	private float float_1;

	// Token: 0x04003E15 RID: 15893
	private float float_2;
}
