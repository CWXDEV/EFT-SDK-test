using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BE7 RID: 3047
public class PhotoCamera : MonoBehaviour
{
	// Token: 0x140000D8 RID: 216
	// (add) Token: 0x06004262 RID: 16994 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06004263 RID: 16995 RVA: 0x00002050 File Offset: 0x00000250
	public event PhotoCamera.GDelegate26 OnTextureRenderFinished
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06004264 RID: 16996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06004265 RID: 16997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MakeTexture(GameObject gObject, Action<Texture> callback, int cameraOrthoSize, Vector2 renderTextureSize)
	{
		throw null;
	}

	// Token: 0x06004266 RID: 16998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreCull()
	{
		throw null;
	}

	// Token: 0x06004267 RID: 16999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Transform t)
	{
		throw null;
	}

	// Token: 0x06004268 RID: 17000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mesh method_1(int[] triangles, Mesh originalMesh)
	{
		throw null;
	}

	// Token: 0x06004269 RID: 17001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	// Token: 0x04004B7E RID: 19326
	private RenderTexture renderTexture_0;

	// Token: 0x04004B7F RID: 19327
	private Camera camera_0;

	// Token: 0x04004B80 RID: 19328
	private bool bool_0;

	// Token: 0x04004B81 RID: 19329
	private bool bool_1;

	// Token: 0x04004B82 RID: 19330
	private int int_0;

	// Token: 0x04004B83 RID: 19331
	private Vector3 vector3_0;

	// Token: 0x04004B84 RID: 19332
	[CompilerGenerated]
	private PhotoCamera.GDelegate26 gdelegate26_0;

	// Token: 0x04004B85 RID: 19333
	private Action<Texture> action_0;

	// Token: 0x04004B86 RID: 19334
	private GameObject gameObject_0;

	// Token: 0x04004B87 RID: 19335
	private Matrix4x4 matrix4x4_0;

	// Token: 0x04004B88 RID: 19336
	private Light light_0;

	// Token: 0x02000BE8 RID: 3048
	// (Invoke) Token: 0x0600426A RID: 17002
	public delegate void GDelegate26(PhotoCamera sender);
}
