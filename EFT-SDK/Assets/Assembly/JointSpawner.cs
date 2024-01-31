using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005CB RID: 1483
[DisallowMultipleComponent]
public abstract class JointSpawner : MonoBehaviour
{
	// Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Joint Create()
	{
		throw null;
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove()
	{
		throw null;
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Joint CreateComponent()
	{
		throw null;
	}

	// Token: 0x040021BD RID: 8637
	public RigidbodySpawner connectedBody;

	// Token: 0x040021BE RID: 8638
	public Vector3 anchor;

	// Token: 0x040021BF RID: 8639
	public Vector3 axis;

	// Token: 0x040021C0 RID: 8640
	public bool autoConfigureConnectedAnchor;

	// Token: 0x040021C1 RID: 8641
	public Vector3 connectedAnchor;

	// Token: 0x040021C2 RID: 8642
	public bool enableCollision;

	// Token: 0x040021C3 RID: 8643
	public bool enablePreprocessing;

	// Token: 0x040021C4 RID: 8644
	protected Joint _joint;
}
