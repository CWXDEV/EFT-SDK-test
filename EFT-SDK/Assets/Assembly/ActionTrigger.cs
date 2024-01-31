using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000C4 RID: 196
public class ActionTrigger : MonoBehaviour
{
	// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Use()
	{
		throw null;
	}

	// Token: 0x040004C6 RID: 1222
	public bool State;

	// Token: 0x040004C7 RID: 1223
	public Animator Target;

	// Token: 0x040004C8 RID: 1224
	public string StateFalseAnim;

	// Token: 0x040004C9 RID: 1225
	public string StateTrueAnim;

	// Token: 0x040004CA RID: 1226
	public int Layer;
}
