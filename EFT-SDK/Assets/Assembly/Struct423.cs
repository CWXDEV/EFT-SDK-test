using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using UnityEngine;

// Token: 0x020018DF RID: 6367
[StructLayout(LayoutKind.Auto)]
public struct Struct423
{
	// Token: 0x0600891B RID: 35099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetBool()
	{
		throw null;
	}

	// Token: 0x0600891C RID: 35100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetFloat()
	{
		throw null;
	}

	// Token: 0x04008EFC RID: 36604
	public readonly EFT.NetworkPlayer.EMovementCommand Command;

	// Token: 0x04008EFD RID: 36605
	private bool bool_0;

	// Token: 0x04008EFE RID: 36606
	private float float_0;

	// Token: 0x04008EFF RID: 36607
	private Vector2 vector2_0;

	// Token: 0x04008F00 RID: 36608
	private bool[] bool_1;

	// Token: 0x020018E0 RID: 6368
	internal class Exception1 : Exception
	{
	}

	// Token: 0x020018E1 RID: 6369
	private enum EParams
	{
		// Token: 0x04008F02 RID: 36610
		Bool,
		// Token: 0x04008F03 RID: 36611
		Float,
		// Token: 0x04008F04 RID: 36612
		Vector2
	}
}
