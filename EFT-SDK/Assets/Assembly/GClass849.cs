using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A53 RID: 2643
public class GClass849 : GClass848<StaticDeferredDecal, GClass846>
{
	// Token: 0x06003A22 RID: 14882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06003A23 RID: 14883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override GClass845<StaticDeferredDecal> CreateQuadrant(GClass845<StaticDeferredDecal> parent, Rect bounds)
	{
		throw null;
	}

	// Token: 0x06003A24 RID: 14884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Insert(StaticDeferredDecal decal, Mesh mesh)
	{
		throw null;
	}

	// Token: 0x06003A25 RID: 14885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<Texture2D, GClass850> ConstructCommandBuffersAndTexturesTrees(Mesh mesh, GClass846.GDelegate25 preDrawCallback)
	{
		throw null;
	}

	// Token: 0x06003A26 RID: 14886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommandBuffer GetRootCommandBuffer()
	{
		throw null;
	}

	// Token: 0x06003A27 RID: 14887 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetCommandBuffers(GClass1870 frustum, ref List<CommandBuffer> commandBuffers, int maxDepth)
	{
		throw null;
	}

	// Token: 0x06003A28 RID: 14888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecordCommandBuffer(GClass1870 frustum, CommandBuffer commandBuffer, int maxDepth, GClass846.GDelegate25 preDrawCallback, Mesh mesh)
	{
		throw null;
	}

	// Token: 0x06003A29 RID: 14889 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetThreadParams(GClass1870 frustum, int maxDepth)
	{
		throw null;
	}

	// Token: 0x06003A2A RID: 14890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetThreadResults(ref List<CommandBuffer> commandBuffers)
	{
		throw null;
	}

	// Token: 0x06003A2B RID: 14891 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(object p)
	{
		throw null;
	}

	// Token: 0x04003D54 RID: 15700
	private Thread thread_0;

	// Token: 0x04003D55 RID: 15701
	private static CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04003D56 RID: 15702
	private static CancellationToken cancellationToken_0;

	// Token: 0x04003D57 RID: 15703
	public static int ThreadSleepTime;

	// Token: 0x04003D58 RID: 15704
	public static bool ThreadSkipJob;

	// Token: 0x04003D59 RID: 15705
	private object object_0;

	// Token: 0x04003D5A RID: 15706
	private object object_1;

	// Token: 0x04003D5B RID: 15707
	private static GClass849.Class536 class536_0;

	// Token: 0x02000A54 RID: 2644
	private class Class535
	{
		// Token: 0x04003D5C RID: 15708
		public GClass849 tree;
	}

	// Token: 0x02000A55 RID: 2645
	private class Class536
	{
		// Token: 0x04003D5D RID: 15709
		public GClass1870 frustum;

		// Token: 0x04003D5E RID: 15710
		public int maxDepth;

		// Token: 0x04003D5F RID: 15711
		public List<CommandBuffer> threadResults;
	}
}
