using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.ObjectPool;

// Token: 0x020014F4 RID: 5364
public class GClass1649 : PooledObjectPolicy<GStruct161[]>
{
	// Token: 0x0600734F RID: 29519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct161[] Create()
	{
		throw null;
	}

	// Token: 0x06007350 RID: 29520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Return(GStruct161[] obj)
	{
		throw null;
	}

	// Token: 0x04007976 RID: 31094
	public const int CLIENT_INPUT_PACKETS_QUEUE_LENGTH = 5000;
}
