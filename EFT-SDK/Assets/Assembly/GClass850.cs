using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000A5D RID: 2653
public class GClass850 : GClass848<GClass854, GClass847>
{
	// Token: 0x170009BA RID: 2490
	// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00002050 File Offset: 0x00000250
	public Texture2D Texture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06003A7A RID: 14970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override GClass845<GClass854> CreateQuadrant(GClass845<GClass854> parent, Rect bounds)
	{
		throw null;
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetThreadParams(Camera camera, GClass1870 frustum, float maxScreenHScale, float maxScreenVScale)
	{
		throw null;
	}

	// Token: 0x06003A7C RID: 14972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTextureRequestedMipMapLevel()
	{
		throw null;
	}

	// Token: 0x06003A7D RID: 14973 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Insert(ref List<GClass854> infosList, Texture2D texture)
	{
		throw null;
	}

	// Token: 0x06003A7E RID: 14974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ValueTuple<float, float, float> method_2(GClass1870 frustum)
	{
		throw null;
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(object p)
	{
		throw null;
	}

	// Token: 0x04003DAA RID: 15786
	private static Thread thread_0;

	// Token: 0x04003DAB RID: 15787
	private static CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04003DAC RID: 15788
	private static CancellationToken cancellationToken_0;

	// Token: 0x04003DAD RID: 15789
	public static int ThreadSleepTime;

	// Token: 0x04003DAE RID: 15790
	public static int ThreadMinSleepTime;

	// Token: 0x04003DAF RID: 15791
	public static bool ThreadSkipJob;

	// Token: 0x04003DB0 RID: 15792
	public static int MipOffset;

	// Token: 0x04003DB1 RID: 15793
	public static int DropResultsAfterFramesCount;

	// Token: 0x04003DB2 RID: 15794
	private static HashSet<GClass850> hashSet_0;

	// Token: 0x04003DB3 RID: 15795
	private static object object_0;

	// Token: 0x04003DB4 RID: 15796
	private Texture2D texture2D_0;

	// Token: 0x04003DB5 RID: 15797
	private int int_0;

	// Token: 0x04003DB6 RID: 15798
	private int int_1;

	// Token: 0x04003DB7 RID: 15799
	private int int_2;

	// Token: 0x04003DB8 RID: 15800
	private string string_0;

	// Token: 0x04003DB9 RID: 15801
	private Dictionary<int, GClass850.Class538> dictionary_0;

	// Token: 0x04003DBA RID: 15802
	private object object_1;

	// Token: 0x04003DBB RID: 15803
	private static GClass850.Class540 class540_0;

	// Token: 0x02000A5E RID: 2654
	private class Class538
	{
		// Token: 0x04003DBC RID: 15804
		public int updatedDuringFrame;

		// Token: 0x04003DBD RID: 15805
		public int requestedMipMapLevel;

		// Token: 0x04003DBE RID: 15806
		public float pixelsHBuf;

		// Token: 0x04003DBF RID: 15807
		public float pixelsVBuf;

		// Token: 0x04003DC0 RID: 15808
		public float closestDist;
	}

	// Token: 0x02000A5F RID: 2655
	private class Class539
	{
		// Token: 0x04003DC1 RID: 15809
		public GClass850 tree;
	}

	// Token: 0x02000A60 RID: 2656
	private class Class540
	{
		// Token: 0x04003DC2 RID: 15810
		public GClass1870 frustum;

		// Token: 0x04003DC3 RID: 15811
		public float maxScreenHScale;

		// Token: 0x04003DC4 RID: 15812
		public float maxScreenVScale;

		// Token: 0x04003DC5 RID: 15813
		public int cameraInstanceID;

		// Token: 0x04003DC6 RID: 15814
		public int frameIndex;
	}
}
