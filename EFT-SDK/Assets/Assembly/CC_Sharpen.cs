using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000082 RID: 130
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Sharpen")]
public class CC_Sharpen : CC_Base
{
	// Token: 0x17000109 RID: 265
	// (get) Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
	public DesaturateEffect DesaturateEffectSettingsProvider
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
	public bool FailedToGetDesaturate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000254 RID: 596
	[Range(0f, 5f)]
	public float strength;

	// Token: 0x04000255 RID: 597
	[Range(0f, 1f)]
	public float clamp;

	// Token: 0x04000256 RID: 598
	public bool DoDesaturate;

	// Token: 0x04000257 RID: 599
	private static readonly int int_0;

	// Token: 0x04000258 RID: 600
	private static readonly int int_1;

	// Token: 0x04000259 RID: 601
	private static readonly int int_2;

	// Token: 0x0400025A RID: 602
	private static readonly int int_3;

	// Token: 0x0400025B RID: 603
	[CompilerGenerated]
	private DesaturateEffect desaturateEffect_0;

	// Token: 0x0400025C RID: 604
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400025D RID: 605
	public Texture textureRamp;

	// Token: 0x0400025E RID: 606
	public float rampOffsetR;

	// Token: 0x0400025F RID: 607
	public float rampOffsetG;

	// Token: 0x04000260 RID: 608
	public float rampOffsetB;

	// Token: 0x04000261 RID: 609
	public float WeatherDesaturate;

	// Token: 0x04000262 RID: 610
	public float HealthDesaturate;

	// Token: 0x04000263 RID: 611
	public float MaskDesaturate;

	// Token: 0x04000264 RID: 612
	public Vector2 MinMaxRadius;

	// Token: 0x04000265 RID: 613
	[Range(0f, 1f)]
	public float Radius;

	// Token: 0x04000266 RID: 614
	[Range(0f, 1f)]
	public float RadiusFalloff;

	// Token: 0x04000267 RID: 615
	private static readonly int int_4;

	// Token: 0x04000268 RID: 616
	private static readonly int int_5;

	// Token: 0x04000269 RID: 617
	private static readonly int int_6;

	// Token: 0x0400026A RID: 618
	private static readonly int int_7;

	// Token: 0x0400026B RID: 619
	private static readonly int int_8;

	// Token: 0x0400026C RID: 620
	private static readonly int int_9;

	// Token: 0x0400026D RID: 621
	private static readonly int int_10;

	// Token: 0x0400026E RID: 622
	private readonly string string_0;
}
