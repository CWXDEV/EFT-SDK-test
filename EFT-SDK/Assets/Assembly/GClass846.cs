using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A57 RID: 2647
public class GClass846 : GClass845<StaticDeferredDecal>
{
	// Token: 0x06003A42 RID: 14914 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass846.GStruct57 method_4(StaticDeferredDecal decal)
	{
		throw null;
	}

	// Token: 0x06003A43 RID: 14915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override GClass845<StaticDeferredDecal> CreateQuadrant(GClass845<StaticDeferredDecal> parent, Rect bounds)
	{
		throw null;
	}

	// Token: 0x06003A44 RID: 14916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Bounds smethod_2()
	{
		throw null;
	}

	// Token: 0x06003A45 RID: 14917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GClass846 quadrant, Mesh mesh, GClass846.GDelegate25 preDrawCallback, ref List<StaticDeferredDecal> decalsList, ref List<GClass846.GStruct57> texturesList, ref Bounds boundsToSet)
	{
		throw null;
	}

	// Token: 0x06003A46 RID: 14918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(ref Bounds b)
	{
		throw null;
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueTuple<List<StaticDeferredDecal>, List<GClass846.GStruct57>, Bounds> ConstructSubtreeCommandBuffers(Mesh mesh, GClass846.GDelegate25 preDrawCallback)
	{
		throw null;
	}

	// Token: 0x06003A48 RID: 14920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetCommandBuffers(GClass1870 frustum, ref List<CommandBuffer> commandBuffers, int maxDepth)
	{
		throw null;
	}

	// Token: 0x06003A49 RID: 14921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecordCommandBuffer(GClass1870 frustum, CommandBuffer commandBuffer, int maxDepth, Mesh mesh)
	{
		throw null;
	}

	// Token: 0x06003A4A RID: 14922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_3(StaticDeferredDecal decal)
	{
		throw null;
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, List<StaticDeferredDecal>> smethod_4(List<StaticDeferredDecal> decals)
	{
		throw null;
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GenerateCommandBufferForQuadrant(GClass846 q, List<StaticDeferredDecal> decals, Mesh mesh, GClass846.GDelegate25 preDrawCallback)
	{
		throw null;
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GenerateOwnCommandBufferForQuadrant(GClass846 q, List<StaticDeferredDecal> decals, Mesh mesh, GClass846.GDelegate25 preDrawCallback)
	{
		throw null;
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RecordCommandBufferForQuadrant(GClass846 q, CommandBuffer cmdBuf, Mesh mesh)
	{
		throw null;
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ComputeDecalMinMaxPoints(StaticDeferredDecal decal, ref Vector3 minPoint, ref Vector3 maxPoint, Mesh mesh)
	{
		throw null;
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06003A51 RID: 14929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x06003A52 RID: 14930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04003D71 RID: 15729
	public CommandBuffer _subtreeCommandBuffer;

	// Token: 0x04003D72 RID: 15730
	public CommandBuffer _ownDecalsCommandBuffer;

	// Token: 0x04003D73 RID: 15731
	private SortedList<string, GClass852> sortedList_0;

	// Token: 0x04003D74 RID: 15732
	private SortedList<string, GClass852> sortedList_1;

	// Token: 0x04003D75 RID: 15733
	private Bounds bounds_0;

	// Token: 0x04003D76 RID: 15734
	private static readonly Bounds bounds_1;

	// Token: 0x02000A58 RID: 2648
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct57
	{
		// Token: 0x04003D77 RID: 15735
		public Texture2D Texture;

		// Token: 0x04003D78 RID: 15736
		public float MaxSize;

		// Token: 0x04003D79 RID: 15737
		public Vector3 Position;

		// Token: 0x04003D7A RID: 15738
		public Vector4 uvStartEnd;
	}

	// Token: 0x02000A59 RID: 2649
	// (Invoke) Token: 0x06003A53 RID: 14931
	public delegate void GDelegate25(CommandBuffer cbBuf);
}
