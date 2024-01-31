using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200110D RID: 4365
internal abstract class Class817
{
	// Token: 0x17000E5E RID: 3678
	// (get) Token: 0x06005BDF RID: 23519 RVA: 0x00002050 File Offset: 0x00000250
	public int PacketsInQueue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToQueue(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0()
	{
		throw null;
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendAndCheckQueue()
	{
		throw null;
	}

	// Token: 0x06005BE3 RID: 23523
	protected abstract bool vmethod_0();

	// Token: 0x06005BE4 RID: 23524
	public abstract bool ProcessPacket(Class825 packet);

	// Token: 0x0400677E RID: 26494
	protected readonly GClass1279 gclass1279_0;

	// Token: 0x0400677F RID: 26495
	protected readonly Queue<Class825> queue_0;

	// Token: 0x04006780 RID: 26496
	private int int_0;
}
