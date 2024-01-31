using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000F4A RID: 3914
public abstract class GClass1125<T, U> : GInterface70 where T : StateMachineBehaviour where U : GClass1121, new()
{
	// Token: 0x06005211 RID: 21009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual U InternalCreate(T behaviour, GClass1105 state)
	{
		throw null;
	}

	// Token: 0x06005212 RID: 21010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	GClass1121 GInterface70.Create(StateMachineBehaviour behaviour, GClass1105 state)
	{
		throw null;
	}
}
