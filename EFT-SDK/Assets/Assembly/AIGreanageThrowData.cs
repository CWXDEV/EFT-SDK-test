using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200049D RID: 1181
public class AIGreanageThrowData
{
	// Token: 0x06001CB3 RID: 7347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUpToDate()
	{
		throw null;
	}

	// Token: 0x0400184B RID: 6219
	public bool CanThrow;

	// Token: 0x0400184C RID: 6220
	public float Ang;

	// Token: 0x0400184D RID: 6221
	public float Force;

	// Token: 0x0400184E RID: 6222
	public Vector3 Direction;

	// Token: 0x0400184F RID: 6223
	public Vector3 Target;

	// Token: 0x04001850 RID: 6224
	public Vector3 Position;

	// Token: 0x04001851 RID: 6225
	public bool ThrowComplete;

	// Token: 0x04001852 RID: 6226
	public GameObject HitsObject;

	// Token: 0x04001853 RID: 6227
	public ThrowWeapType? GrenadeType;

	// Token: 0x04001854 RID: 6228
	private readonly bool _alwaysGood;

	// Token: 0x04001855 RID: 6229
	private readonly float CreatedTime;
}
