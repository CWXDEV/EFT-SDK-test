using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000672 RID: 1650
public class PhysicsTriggerHandler : MonoBehaviour, IPhysicsTrigger
{
	// Token: 0x170006DD RID: 1757
	// (get) Token: 0x060025CC RID: 9676 RVA: 0x00002050 File Offset: 0x00000250
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000070 RID: 112
	// (add) Token: 0x060025CD RID: 9677 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060025CE RID: 9678 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Collider> OnTriggerEnter
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

	// Token: 0x14000071 RID: 113
	// (add) Token: 0x060025CF RID: 9679 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060025D0 RID: 9680 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Collider> OnTriggerExit
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

	// Token: 0x060025D1 RID: 9681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPhysicsTrigger.OnTriggerEnter(Collider col)
	{
		throw null;
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPhysicsTrigger.OnTriggerExit(Collider col)
	{
		throw null;
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x170006DE RID: 1758
	// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00002050 File Offset: 0x00000250
	bool IPhysicsTrigger.enabled
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

	// Token: 0x040024DD RID: 9437
	[CompilerGenerated]
	private Action<Collider> action_0;

	// Token: 0x040024DE RID: 9438
	[CompilerGenerated]
	private Action<Collider> action_1;

	// Token: 0x040024DF RID: 9439
	public Collider trigger;
}
