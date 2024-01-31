using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000077 RID: 119
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Hue, Saturation, Value")]
public class CC_HueSaturationValue : CC_Base
{
	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
	public float hue
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

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
	public float saturation
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

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
	public float value
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

	// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
	[ImageEffectTransformsToLDR]
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040001EF RID: 495
	[Range(-180f, 180f)]
	public float masterHue;

	// Token: 0x040001F0 RID: 496
	[Range(-100f, 100f)]
	public float masterSaturation;

	// Token: 0x040001F1 RID: 497
	[Range(-100f, 100f)]
	public float masterValue;

	// Token: 0x040001F2 RID: 498
	[Range(-180f, 180f)]
	public float redsHue;

	// Token: 0x040001F3 RID: 499
	[Range(-100f, 100f)]
	public float redsSaturation;

	// Token: 0x040001F4 RID: 500
	[Range(-100f, 100f)]
	public float redsValue;

	// Token: 0x040001F5 RID: 501
	[Range(-180f, 180f)]
	public float yellowsHue;

	// Token: 0x040001F6 RID: 502
	[Range(-100f, 100f)]
	public float yellowsSaturation;

	// Token: 0x040001F7 RID: 503
	[Range(-100f, 100f)]
	public float yellowsValue;

	// Token: 0x040001F8 RID: 504
	[Range(-180f, 180f)]
	public float greensHue;

	// Token: 0x040001F9 RID: 505
	[Range(-100f, 100f)]
	public float greensSaturation;

	// Token: 0x040001FA RID: 506
	[Range(-100f, 100f)]
	public float greensValue;

	// Token: 0x040001FB RID: 507
	[Range(-180f, 180f)]
	public float cyansHue;

	// Token: 0x040001FC RID: 508
	[Range(-100f, 100f)]
	public float cyansSaturation;

	// Token: 0x040001FD RID: 509
	[Range(-100f, 100f)]
	public float cyansValue;

	// Token: 0x040001FE RID: 510
	[Range(-180f, 180f)]
	public float bluesHue;

	// Token: 0x040001FF RID: 511
	[Range(-100f, 100f)]
	public float bluesSaturation;

	// Token: 0x04000200 RID: 512
	[Range(-100f, 100f)]
	public float bluesValue;

	// Token: 0x04000201 RID: 513
	[Range(-180f, 180f)]
	public float magentasHue;

	// Token: 0x04000202 RID: 514
	[Range(-100f, 100f)]
	public float magentasSaturation;

	// Token: 0x04000203 RID: 515
	[Range(-100f, 100f)]
	public float magentasValue;

	// Token: 0x04000204 RID: 516
	public bool advanced;

	// Token: 0x04000205 RID: 517
	public int currentChannel;

	// Token: 0x04000206 RID: 518
	private static readonly int int_0;

	// Token: 0x04000207 RID: 519
	private static readonly int int_1;

	// Token: 0x04000208 RID: 520
	private static readonly int int_2;

	// Token: 0x04000209 RID: 521
	private static readonly int int_3;

	// Token: 0x0400020A RID: 522
	private static readonly int int_4;

	// Token: 0x0400020B RID: 523
	private static readonly int int_5;

	// Token: 0x0400020C RID: 524
	private static readonly int int_6;
}
