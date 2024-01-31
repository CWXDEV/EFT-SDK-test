using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020007EB RID: 2027
public abstract class BaseSystemComponent<T> : MonoBehaviour, GInterface27 where T : BaseSystemComponent<T>, GInterface27
{
	// Token: 0x06002EDB RID: 11995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnable()
	{
		throw null;
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}
}
