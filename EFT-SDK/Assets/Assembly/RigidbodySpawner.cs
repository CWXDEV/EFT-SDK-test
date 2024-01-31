using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005CC RID: 1484
[DisallowMultipleComponent]
public class RigidbodySpawner : MonoBehaviour
{
	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
	public Rigidbody Rigidbody
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000051 RID: 81
	// (add) Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<RigidbodySpawner, Rigidbody> SpawnEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000052 RID: 82
	// (add) Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002276 RID: 8822 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<RigidbodySpawner> RemoveEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rigidbody Create()
	{
		throw null;
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove()
	{
		throw null;
	}

	// Token: 0x040021C5 RID: 8645
	public float mass;

	// Token: 0x040021C6 RID: 8646
	public float drag;

	// Token: 0x040021C7 RID: 8647
	public float angularDrag;

	// Token: 0x040021C8 RID: 8648
	public bool useGravity;

	// Token: 0x040021C9 RID: 8649
	public bool isKinematic;

	// Token: 0x040021CA RID: 8650
	public RigidbodyInterpolation interpolation;

	// Token: 0x040021CB RID: 8651
	public CollisionDetectionMode collisionDetectionMode;

	// Token: 0x040021CC RID: 8652
	public RigidbodyConstraints constraints;

	// Token: 0x040021CD RID: 8653
	private Rigidbody rigidbody_0;

	// Token: 0x040021CE RID: 8654
	[CompilerGenerated]
	private Action<RigidbodySpawner, Rigidbody> action_0;

	// Token: 0x040021CF RID: 8655
	[CompilerGenerated]
	private Action<RigidbodySpawner> action_1;
}
