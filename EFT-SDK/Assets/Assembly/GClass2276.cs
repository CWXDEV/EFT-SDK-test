using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F68 RID: 8040
public class GClass2276 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B5F RID: 7007
	// (get) Token: 0x0600A668 RID: 42600 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A669 RID: 42601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A66A RID: 42602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A66B RID: 42603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A66C RID: 42604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A66D RID: 42605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400ADB4 RID: 44468
	public bool Fire;

	// Token: 0x0400ADB5 RID: 44469
	public bool AltFire;

	// Token: 0x0400ADB6 RID: 44470
	public bool QuickFire;

	// Token: 0x0400ADB7 RID: 44471
	public float MeleeAttackSpeed;

	// Token: 0x0400ADB8 RID: 44472
	public Action ActionOnFireBullet;

	// Token: 0x0400ADB9 RID: 44473
	public Action ActionOnFireEnd;
}
