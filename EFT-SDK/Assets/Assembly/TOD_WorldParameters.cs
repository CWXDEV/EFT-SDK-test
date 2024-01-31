using System;
using UnityEngine;

// Token: 0x020000AF RID: 175
[Serializable]
public class TOD_WorldParameters
{
	// Token: 0x040003BF RID: 959
	[Range(-90f, 90f)]
	[Tooltip("Latitude of the current location in degrees.")]
	public float Latitude;

	// Token: 0x040003C0 RID: 960
	[Tooltip("Longitude of the current location in degrees.")]
	[Range(-180f, 180f)]
	public float Longitude;

	// Token: 0x040003C1 RID: 961
	[Range(-14f, 14f)]
	[Tooltip("UTC/GMT time zone of the current location in hours.")]
	public float UTC;
}
