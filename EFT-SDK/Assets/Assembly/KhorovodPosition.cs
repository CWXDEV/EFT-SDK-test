using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200053F RID: 1343
[Serializable]
public class KhorovodPosition
{
	// Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalcPosition(float radius, float time)
	{
		throw null;
	}

	// Token: 0x04001F3F RID: 7999
	[HideInInspector]
	public float angle;

	// Token: 0x04001F40 RID: 8000
	public BotOwner attachedOwner;

	// Token: 0x04001F41 RID: 8001
	public bool havePhrase;
}
