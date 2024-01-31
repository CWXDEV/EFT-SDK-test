using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

// Token: 0x02000660 RID: 1632
public class GripPose : MonoBehaviour, GInterface23
{
	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x0600256C RID: 9580 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCached
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x0600256D RID: 9581 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600256E RID: 9582 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x0600256F RID: 9583 RVA: 0x00002050 File Offset: 0x00000250
	public Quaternion Rotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x06002570 RID: 9584 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAlternative
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		throw null;
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CacheAndDestroy()
	{
		throw null;
	}

	// Token: 0x170006BA RID: 1722
	public Quaternion this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04002487 RID: 9351
	public EDoorState DoorState;

	// Token: 0x04002488 RID: 9352
	public GripPose.EHand Hand;

	// Token: 0x04002489 RID: 9353
	public GripPose.EGripType GripType;

	// Token: 0x0400248A RID: 9354
	public Transform[] FingerTransforms;

	// Token: 0x0400248B RID: 9355
	public Quaternion[] Fingers;

	// Token: 0x0400248C RID: 9356
	public bool DontCache;

	// Token: 0x0400248D RID: 9357
	[SerializeField]
	private bool _cached;

	// Token: 0x02000661 RID: 1633
	public enum EGripType
	{
		// Token: 0x0400248F RID: 9359
		Common,
		// Token: 0x04002490 RID: 9360
		Alternative,
		// Token: 0x04002491 RID: 9361
		UnderbarrelWeapon
	}

	// Token: 0x02000662 RID: 1634
	public enum EHand
	{
		// Token: 0x04002493 RID: 9363
		Left,
		// Token: 0x04002494 RID: 9364
		Right
	}

	// Token: 0x02000663 RID: 1635
	[CompilerGenerated]
	[Serializable]
	private sealed class Class312
	{
		// Token: 0x06002575 RID: 9589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Quaternion method_0(Transform x)
		{
			throw null;
		}

		// Token: 0x04002495 RID: 9365
		public static readonly GripPose.Class312 class312_0;

		// Token: 0x04002496 RID: 9366
		public static Func<Transform, Quaternion> func_0;
	}
}
