using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000826 RID: 2086
public abstract class HalloweenEffect : MonoBehaviour
{
	// Token: 0x06002FC5 RID: 12229 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process()
	{
		throw null;
	}

	// Token: 0x06002FC6 RID: 12230
	protected abstract IEnumerator RunProcess();

	// Token: 0x06002FC7 RID: 12231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Abort()
	{
		throw null;
	}

	// Token: 0x04002F01 RID: 12033
	private IEnumerator ienumerator_0;
}
