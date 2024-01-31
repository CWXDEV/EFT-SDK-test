using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020030AD RID: 12461
public sealed class GClass3258
{
	// Token: 0x17002A08 RID: 10760
	// (get) Token: 0x0600F49B RID: 62619 RVA: 0x00002050 File Offset: 0x00000250
	public int MainThreadId
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F49C RID: 62620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTask(Func<Action> task)
	{
		throw null;
	}

	// Token: 0x0600F49D RID: 62621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateThread()
	{
		throw null;
	}

	// Token: 0x0600F49E RID: 62622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunInMainTread(Action action)
	{
		throw null;
	}

	// Token: 0x0600F49F RID: 62623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckForFinishedTasks()
	{
		throw null;
	}

	// Token: 0x0600F4A0 RID: 62624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Kill()
	{
		throw null;
	}

	// Token: 0x0600F4A1 RID: 62625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Func<Action> task)
	{
		throw null;
	}

	// Token: 0x0600F4A2 RID: 62626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0400FAA8 RID: 64168
	private volatile bool bool_0;

	// Token: 0x0400FAA9 RID: 64169
	private Thread thread_0;

	// Token: 0x0400FAAA RID: 64170
	private Thread thread_1;

	// Token: 0x0400FAAB RID: 64171
	private readonly EventWaitHandle eventWaitHandle_0;

	// Token: 0x0400FAAC RID: 64172
	private readonly Queue<Func<Action>> queue_0;

	// Token: 0x0400FAAD RID: 64173
	private readonly Queue<Action> queue_1;

	// Token: 0x0400FAAE RID: 64174
	[CompilerGenerated]
	private readonly int int_0;
}
