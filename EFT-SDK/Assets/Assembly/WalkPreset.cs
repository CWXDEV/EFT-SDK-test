using System;
using System.Runtime.CompilerServices;
using EFT.Animations;
using UnityEngine;

// Token: 0x02000918 RID: 2328
[Serializable]
public class WalkPreset : ScriptableObject
{
	// Token: 0x170008F5 RID: 2293
	public AnimVal this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04003553 RID: 13651
	public AnimVal[] Curves;
}
