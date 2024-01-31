using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Koenigz.PerfectCulling;
using Koenigz.PerfectCulling.EFT;
using UnityEngine;

// Token: 0x02000DD3 RID: 3539
public sealed class GClass1028 : IDisposable
{
	// Token: 0x17000BD5 RID: 3029
	// (get) Token: 0x06004A7A RID: 19066 RVA: 0x00002050 File Offset: 0x00000250
	public float BakeProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BD6 RID: 3030
	// (get) Token: 0x06004A7B RID: 19067 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInitialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BD7 RID: 3031
	// (get) Token: 0x06004A7C RID: 19068 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004A7D RID: 19069 RVA: 0x00002050 File Offset: 0x00000250
	public Thread BakeThread
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000BD8 RID: 3032
	// (get) Token: 0x06004A7E RID: 19070 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004A7F RID: 19071 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1012 ActiveSamplingTask
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000BD9 RID: 3033
	// (get) Token: 0x06004A80 RID: 19072 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004A81 RID: 19073 RVA: 0x00002050 File Offset: 0x00000250
	public int NumCellsRead
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06004A84 RID: 19076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateBakeSession()
	{
		throw null;
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBakeGroups(PerfectCullingCrossSceneGroup sourceGroup, PerfectCullingBakeGroup[] Groups, int idxStart, int idxEnd, HashSet<Renderer> AdditionalOccluders, int renderMode)
	{
		throw null;
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Thread BeginBake(GClass1012 samplingTask)
	{
		throw null;
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(object obj)
	{
		throw null;
	}

	// Token: 0x06004A88 RID: 19080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetBake()
	{
		throw null;
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDebugCameraTransform(Vector3 pos, Quaternion inputRotation)
	{
		throw null;
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugRender()
	{
		throw null;
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDebugCameraTransform(Vector3 eye, Vector3 at, Vector3 up)
	{
		throw null;
	}

	// Token: 0x06004A8D RID: 19085
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BkResetBake(IntPtr bakeSession);

	// Token: 0x06004A8E RID: 19086
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr BkCreateSession(GStruct75 parameters);

	// Token: 0x06004A8F RID: 19087
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern int BkDeleteSession(IntPtr bakeSession);

	// Token: 0x06004A90 RID: 19088
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern int BkLoadBakeScene(IntPtr bakeSession, GClass778.GStruct52[] nativeRenderers, int nativeRenderersCount, int renderMode);

	// Token: 0x06004A91 RID: 19089
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern int BkBeginSamplingSync(IntPtr bakeSession, Vector3[] samplingPositions, int samplingPositionCount, int[] colorHash, int colorHashCount);

	// Token: 0x06004A92 RID: 19090
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern int BkEndSamplingSync(IntPtr bakeSession);

	// Token: 0x06004A93 RID: 19091
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern float BkGetBakeProgress(IntPtr bakeSession);

	// Token: 0x06004A95 RID: 19093
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BkSetDebugCameraPosition(IntPtr bakeSession, float x, float y, float z);

	// Token: 0x06004A96 RID: 19094
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BkSetDebugCameraRotation(IntPtr bakeSession, float x, float y, float z, float w);

	// Token: 0x06004A97 RID: 19095
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BkDebugRender(IntPtr bakeSession);

	// Token: 0x06004A98 RID: 19096
	[DllImport("pc_renderer", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BkSetCameraTransform(IntPtr bakeSession, float eyeX, float eyeY, float eyeZ, float atX, float atY, float atZ, float upX, float upY, float upZ);

	// Token: 0x040055B6 RID: 21942
	private static readonly string string_0;

	// Token: 0x040055B7 RID: 21943
	private const int int_0 = 12;

	// Token: 0x040055B8 RID: 21944
	private const int int_1 = 4096;

	// Token: 0x040055B9 RID: 21945
	private IntPtr intptr_0;

	// Token: 0x040055BA RID: 21946
	private GStruct75 gstruct75_0;

	// Token: 0x040055BB RID: 21947
	private GClass1008 gclass1008_0;

	// Token: 0x040055BC RID: 21948
	private List<UnityEngine.Object> list_0;

	// Token: 0x040055BD RID: 21949
	private NamedPipeServerStream namedPipeServerStream_0;

	// Token: 0x040055BE RID: 21950
	private BinaryReader binaryReader_0;

	// Token: 0x040055BF RID: 21951
	private BinaryWriter binaryWriter_0;

	// Token: 0x040055C0 RID: 21952
	private static GClass1028 gclass1028_0;

	// Token: 0x040055C1 RID: 21953
	[CompilerGenerated]
	private Thread thread_0;

	// Token: 0x040055C2 RID: 21954
	[CompilerGenerated]
	private GClass1012 gclass1012_0;

	// Token: 0x040055C3 RID: 21955
	[CompilerGenerated]
	private int int_2;

	// Token: 0x02000DD4 RID: 3540
	public enum RenderMode
	{
		// Token: 0x040055C5 RID: 21957
		TerrainOccluder = 2,
		// Token: 0x040055C6 RID: 21958
		Wireframe = 1,
		// Token: 0x040055C7 RID: 21959
		Default = 0
	}
}
