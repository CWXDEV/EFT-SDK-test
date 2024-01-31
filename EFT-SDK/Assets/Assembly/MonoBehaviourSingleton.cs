using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005CD RID: 1485
public abstract class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviourSingleton<T>
{
	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x06002279 RID: 8825 RVA: 0x00002050 File Offset: 0x00000250
	public static T Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x0600227A RID: 8826 RVA: 0x00002050 File Offset: 0x00000250
	public static bool Instantiated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		throw null;
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDestroy()
	{
		throw null;
	}
}
