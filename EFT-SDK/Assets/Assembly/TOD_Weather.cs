using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000C3 RID: 195
public class TOD_Weather : MonoBehaviour
{
	// Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Start()
	{
		throw null;
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Update()
	{
		throw null;
	}

	// Token: 0x040004BB RID: 1211
	[Tooltip("Time to fade from one weather type to the other.")]
	public float FadeTime;

	// Token: 0x040004BC RID: 1212
	[Tooltip("Currently selected cloud type.")]
	public TOD_CloudType Clouds;

	// Token: 0x040004BD RID: 1213
	[Tooltip("Currently selected weather type.")]
	public TOD_WeatherType Weather;

	// Token: 0x040004BE RID: 1214
	private float float_0;

	// Token: 0x040004BF RID: 1215
	private float float_1;

	// Token: 0x040004C0 RID: 1216
	private float float_2;

	// Token: 0x040004C1 RID: 1217
	private float float_3;

	// Token: 0x040004C2 RID: 1218
	private float float_4;

	// Token: 0x040004C3 RID: 1219
	private float float_5;

	// Token: 0x040004C4 RID: 1220
	private float float_6;

	// Token: 0x040004C5 RID: 1221
	private TOD_Sky tod_Sky_0;
}
