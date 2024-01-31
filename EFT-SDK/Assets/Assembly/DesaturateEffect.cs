using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000093 RID: 147
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Desaturate")]
public class DesaturateEffect
{
	// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040002DA RID: 730
	public Texture textureRamp;

	// Token: 0x040002DB RID: 731
	public float rampOffsetR;

	// Token: 0x040002DC RID: 732
	public float rampOffsetG;

	// Token: 0x040002DD RID: 733
	public float rampOffsetB;

	// Token: 0x040002DE RID: 734
	[FormerlySerializedAs("desaturateAmount")]
	public float WeatherDesaturate;

	// Token: 0x040002DF RID: 735
	public float HealthDesaturate;

	// Token: 0x040002E0 RID: 736
	public float MaskDesaturate;

	// Token: 0x040002E1 RID: 737
	public Vector2 MinMaxRadius;

	// Token: 0x040002E2 RID: 738
	[Range(0f, 1f)]
	public float Radius;

	// Token: 0x040002E3 RID: 739
	[Range(0f, 1f)]
	public float RadiusFalloff;

	// Token: 0x040002E4 RID: 740
	private static readonly int _rampTex;

	// Token: 0x040002E5 RID: 741
	private static readonly int _desatWeather;

	// Token: 0x040002E6 RID: 742
	private static readonly int _desatHealth;

	// Token: 0x040002E7 RID: 743
	private static readonly int _desatMask;

	// Token: 0x040002E8 RID: 744
	private static readonly int _rampOffset;

	// Token: 0x040002E9 RID: 745
	private static readonly int _radius;

	// Token: 0x040002EA RID: 746
	private static readonly int _radiusFalloff;
}
