using System;
using UnityEngine;

// Token: 0x02000700 RID: 1792
public class ThrowableSettings : MonoBehaviour
{
	// Token: 0x040027F3 RID: 10227
	[SerializeField]
	public Vector3 Offset;

	// Token: 0x040027F4 RID: 10228
	[SerializeField]
	[Header("Threshold sqrMagnitude")]
	public float VelocityTreshold;
}
