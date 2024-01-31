using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006A4 RID: 1700
public class BouncingObjectLauncher : MonoBehaviour
{
	// Token: 0x06002693 RID: 9875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Launch()
	{
		throw null;
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Transform from)
	{
		throw null;
	}

	// Token: 0x040025B8 RID: 9656
	[SerializeField]
	private LayerMask _castMask;

	// Token: 0x040025B9 RID: 9657
	[SerializeField]
	private int _maxCastCount;

	// Token: 0x040025BA RID: 9658
	[SerializeField]
	private float _deltaTimeStep;

	// Token: 0x040025BB RID: 9659
	[SerializeField]
	private float _jumpSpeed;

	// Token: 0x040025BC RID: 9660
	[SerializeField]
	private float _playMult;

	// Token: 0x040025BD RID: 9661
	[SerializeField]
	private float _randomReboundSpread;

	// Token: 0x040025BE RID: 9662
	[SerializeField]
	private float _bounceSpeedMult;

	// Token: 0x040025BF RID: 9663
	[SerializeField]
	private float _radius;

	// Token: 0x040025C0 RID: 9664
	private GameObject gameObject_0;
}
