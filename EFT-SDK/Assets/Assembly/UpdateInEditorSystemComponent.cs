using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020007FA RID: 2042
[ExecuteInEditMode]
public abstract class UpdateInEditorSystemComponent<T> : BaseSystemComponent<T> where T : BaseSystemComponent<T>, GInterface27
{
	// Token: 0x06002F26 RID: 12070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06002F27 RID: 12071
	public abstract void ManualUpdate(float deltaTime);
}
