using System;
using UnityEngine;

// Token: 0x02000B31 RID: 2865
[Serializable]
public class ValuesCoefs
{
	// Token: 0x04004511 RID: 17681
	[Range(0.01f, 10f)]
	public float MainTexColorCoef;

	// Token: 0x04004512 RID: 17682
	[Range(-10f, 10f)]
	public float MinimumTemperatureValue;

	// Token: 0x04004513 RID: 17683
	[Range(-1f, 1f)]
	public float RampShift;
}
