using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000667 RID: 1639
[ExecuteInEditMode]
public class DoorHandle : MonoBehaviour
{
	// Token: 0x06002583 RID: 9603 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Open Position")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenPos()
	{
		throw null;
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Default Position")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DefPos()
	{
		throw null;
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Open()
	{
		throw null;
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator OpenCoroutine()
	{
		throw null;
	}

	// Token: 0x040024A0 RID: 9376
	private const int int_0 = 14;

	// Token: 0x040024A1 RID: 9377
	public Quaternion OpenRotation;

	// Token: 0x040024A2 RID: 9378
	public Quaternion DefaultRotation;

	// Token: 0x040024A3 RID: 9379
	public AnimationCurve OpenAnimation;

	// Token: 0x040024A4 RID: 9380
	public AnimationCurve LockedAnimation;

	// Token: 0x040024A5 RID: 9381
	public bool pos;

	// Token: 0x040024A6 RID: 9382
	public Vector3 OpenPosition;

	// Token: 0x040024A7 RID: 9383
	public Vector3 DefaultPosition;

	// Token: 0x040024A8 RID: 9384
	public AudioClip[] DownSound;

	// Token: 0x040024A9 RID: 9385
	public AudioClip[] UpSound;

	// Token: 0x040024AA RID: 9386
	private float float_0;
}
