using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AAF RID: 2735
[ExecuteInEditMode]
public class DynamicFakeGI : MonoBehaviour
{
	// Token: 0x06003BEA RID: 15338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003BEB RID: 15339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04004143 RID: 16707
	[SerializeField]
	private float intensityMultiplier;

	// Token: 0x04004144 RID: 16708
	[SerializeField]
	private float lightSubtract;

	// Token: 0x04004145 RID: 16709
	[SerializeField]
	private Color hue;

	// Token: 0x04004146 RID: 16710
	[Range(0f, 1f)]
	public float minMaxWeatherInfluenceAmount;

	// Token: 0x04004147 RID: 16711
	private Light light_0;

	// Token: 0x04004148 RID: 16712
	private AreaLight areaLight_0;

	// Token: 0x04004149 RID: 16713
	private Color color_0;

	// Token: 0x0400414A RID: 16714
	private float float_0;

	// Token: 0x0400414B RID: 16715
	private float float_1;

	// Token: 0x0400414C RID: 16716
	private float float_2;

	// Token: 0x0400414D RID: 16717
	private float float_3;
}
