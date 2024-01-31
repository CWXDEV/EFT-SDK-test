using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006FE RID: 1790
public class SmokeGrenadeSettings : GrenadeSettings
{
	// Token: 0x060029CD RID: 10701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x040027EB RID: 10219
	[SerializeField]
	public SphereCollider _emissionArea;

	// Token: 0x040027EC RID: 10220
	[SerializeField]
	public AnimationCurve _sizeOverTime;

	// Token: 0x040027ED RID: 10221
	[SerializeField]
	public float _initialRadius;

	// Token: 0x040027EE RID: 10222
	[SerializeField]
	public float _radiusMultiplier;

	// Token: 0x040027EF RID: 10223
	[SerializeField]
	public Vector3 _pivot;

	// Token: 0x040027F0 RID: 10224
	[SerializeField]
	public Vector3 _torque;

	// Token: 0x040027F1 RID: 10225
	[SerializeField]
	public float _torqueDelta;

	// Token: 0x040027F2 RID: 10226
	[SerializeField]
	public float _areaStartPosNorm;
}
