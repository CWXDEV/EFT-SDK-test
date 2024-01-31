using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000BE0 RID: 3040
public class GClass884
{
	// Token: 0x0600424F RID: 16975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Camera camera, CommandBuffer cmdBuf)
	{
		throw null;
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommandBuffer OnRenderObject()
	{
		throw null;
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnRenderObject(out CommandBuffer buffer)
	{
		throw null;
	}

	// Token: 0x06004252 RID: 16978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateOnRenderObject(out CommandBuffer buffer)
	{
		throw null;
	}

	// Token: 0x06004253 RID: 16979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateOnPreCullRender(out CommandBuffer buffer)
	{
		throw null;
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SSAA GetSSAAComponent()
	{
		throw null;
	}

	// Token: 0x06004255 RID: 16981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CommandBuffer smethod_0(Camera camera, CameraEvent cameraEvent, string name)
	{
		throw null;
	}

	// Token: 0x06004256 RID: 16982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CommandBuffer FindOrCreate(Camera camera, CameraEvent cameraEvent, string name)
	{
		throw null;
	}

	// Token: 0x06004257 RID: 16983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyBuffers()
	{
		throw null;
	}

	// Token: 0x04004B6B RID: 19307
	public readonly Dictionary<Camera, CommandBuffer> Cameras;

	// Token: 0x04004B6C RID: 19308
	public readonly Dictionary<Camera, SSAA> SSAAs;

	// Token: 0x04004B6D RID: 19309
	public readonly string BufferName;

	// Token: 0x04004B6E RID: 19310
	public readonly CameraEvent CameraEvent;
}
