using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000C02 RID: 3074
[CreateAssetMenu]
[Serializable]
public sealed class WinterMaterialFoliage : ScriptableObject, GInterface44
{
	// Token: 0x17000ACF RID: 2767
	// (get) Token: 0x060042B3 RID: 17075 RVA: 0x00002050 File Offset: 0x00000250
	private static LoggerClass WinterLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fix()
	{
		throw null;
	}

	// Token: 0x04004C3E RID: 19518
	private static readonly int _mainTexArray;

	// Token: 0x04004C3F RID: 19519
	private static readonly int _normalMapArray;

	// Token: 0x04004C40 RID: 19520
	private static readonly int _dryColor;

	// Token: 0x04004C41 RID: 19521
	private static readonly int _healthyColor;

	// Token: 0x04004C42 RID: 19522
	private static readonly int _windWaveTintColor;

	// Token: 0x04004C43 RID: 19523
	public Material Material;

	// Token: 0x04004C44 RID: 19524
	public Texture2DArray MainTexArray;

	// Token: 0x04004C45 RID: 19525
	public Texture2DArray NormalMapArray;

	// Token: 0x04004C46 RID: 19526
	public Color DryColor;

	// Token: 0x04004C47 RID: 19527
	public Color HealthyColor;

	// Token: 0x04004C48 RID: 19528
	public Color WindWaveTintColor;
}
