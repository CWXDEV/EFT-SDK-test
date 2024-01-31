using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200007A RID: 122
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Levels")]
public class CC_Levels : CC_Base
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
	public int mode
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

	// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000219 RID: 537
	public bool isRGB;

	// Token: 0x0400021A RID: 538
	public float inputMinL;

	// Token: 0x0400021B RID: 539
	public float inputMaxL;

	// Token: 0x0400021C RID: 540
	public float inputGammaL;

	// Token: 0x0400021D RID: 541
	public float inputMinR;

	// Token: 0x0400021E RID: 542
	public float inputMaxR;

	// Token: 0x0400021F RID: 543
	public float inputGammaR;

	// Token: 0x04000220 RID: 544
	public float inputMinG;

	// Token: 0x04000221 RID: 545
	public float inputMaxG;

	// Token: 0x04000222 RID: 546
	public float inputGammaG;

	// Token: 0x04000223 RID: 547
	public float inputMinB;

	// Token: 0x04000224 RID: 548
	public float inputMaxB;

	// Token: 0x04000225 RID: 549
	public float inputGammaB;

	// Token: 0x04000226 RID: 550
	public float outputMinL;

	// Token: 0x04000227 RID: 551
	public float outputMaxL;

	// Token: 0x04000228 RID: 552
	public float outputMinR;

	// Token: 0x04000229 RID: 553
	public float outputMaxR;

	// Token: 0x0400022A RID: 554
	public float outputMinG;

	// Token: 0x0400022B RID: 555
	public float outputMaxG;

	// Token: 0x0400022C RID: 556
	public float outputMinB;

	// Token: 0x0400022D RID: 557
	public float outputMaxB;

	// Token: 0x0400022E RID: 558
	public int currentChannel;

	// Token: 0x0400022F RID: 559
	public bool logarithmic;

	// Token: 0x04000230 RID: 560
	private static readonly int int_0;

	// Token: 0x04000231 RID: 561
	private static readonly int int_1;

	// Token: 0x04000232 RID: 562
	private static readonly int int_2;

	// Token: 0x04000233 RID: 563
	private static readonly int int_3;

	// Token: 0x04000234 RID: 564
	private static readonly int int_4;
}
