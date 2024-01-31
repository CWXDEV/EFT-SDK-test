using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000086 RID: 134
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Vintage")]
public class CC_Vintage : CC_LookupFilter
{
	// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04000281 RID: 641
	public CC_Vintage.Filter filter;

	// Token: 0x04000282 RID: 642
	protected CC_Vintage.Filter m_CurrentFilter;

	// Token: 0x02000087 RID: 135
	public enum Filter
	{
		// Token: 0x04000284 RID: 644
		None,
		// Token: 0x04000285 RID: 645
		K506,
		// Token: 0x04000286 RID: 646
		Zabid,
		// Token: 0x04000287 RID: 647
		Cognac,
		// Token: 0x04000288 RID: 648
		Edwards,
		// Token: 0x04000289 RID: 649
		Cheese,
		// Token: 0x0400028A RID: 650
		LateGoose,
		// Token: 0x0400028B RID: 651
		Bread,
		// Token: 0x0400028C RID: 652
		Montreal,
		// Token: 0x0400028D RID: 653
		Feather,
		// Token: 0x0400028E RID: 654
		Jason,
		// Token: 0x0400028F RID: 655
		Fahrenheit,
		// Token: 0x04000290 RID: 656
		Owl,
		// Token: 0x04000291 RID: 657
		Chillwave,
		// Token: 0x04000292 RID: 658
		Albert,
		// Token: 0x04000293 RID: 659
		Bayswater,
		// Token: 0x04000294 RID: 660
		Atlanta,
		// Token: 0x04000295 RID: 661
		Felicity,
		// Token: 0x04000296 RID: 662
		Stefano,
		// Token: 0x04000297 RID: 663
		Boost,
		// Token: 0x04000298 RID: 664
		Emilia,
		// Token: 0x04000299 RID: 665
		Doze,
		// Token: 0x0400029A RID: 666
		Clifden,
		// Token: 0x0400029B RID: 667
		Blender,
		// Token: 0x0400029C RID: 668
		Tokyo,
		// Token: 0x0400029D RID: 669
		Walk,
		// Token: 0x0400029E RID: 670
		Olive,
		// Token: 0x0400029F RID: 671
		Hotshot
	}
}
