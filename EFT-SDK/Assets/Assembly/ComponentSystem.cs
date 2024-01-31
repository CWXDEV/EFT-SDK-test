using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020007ED RID: 2029
public abstract class ComponentSystem<T, TS> : MonoBehaviour, GInterface28<T> where T : GInterface27 where TS : ComponentSystem<T, TS>
{
	// Token: 0x1700082E RID: 2094
	// (get) Token: 0x06002EDF RID: 11999
	protected abstract bool HasUpdate { get; }

	// Token: 0x1700082F RID: 2095
	// (get) Token: 0x06002EE0 RID: 12000
	protected abstract bool HasLateUpdate { get; }

	// Token: 0x06002EE1 RID: 12001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Register(GameObject globalDotNotDestroy)
	{
		throw null;
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06002EE5 RID: 12005
	protected abstract void UpdateComponent(T component);

	// Token: 0x06002EE6 RID: 12006
	protected abstract void LateUpdateComponent(T component);

	// Token: 0x06002EE7 RID: 12007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Register(T component)
	{
		throw null;
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unregister(T component)
	{
		throw null;
	}

	// Token: 0x04002E2C RID: 11820
	protected List<T> Components;
}
