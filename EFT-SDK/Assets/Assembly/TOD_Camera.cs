using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200009E RID: 158
[AddComponentMenu("Time of Day/Camera Main Script")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class TOD_Camera : MonoBehaviour
{
	// Token: 0x17000111 RID: 273
	// (get) Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
	public bool HDR
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnValidate()
	{
		throw null;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnEnable()
	{
		throw null;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Update()
	{
		throw null;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnPreCull()
	{
		throw null;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoDomeScaleToFarClip()
	{
		throw null;
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoDomePosToCamera()
	{
		throw null;
	}

	// Token: 0x04000345 RID: 837
	public TOD_Sky sky;

	// Token: 0x04000346 RID: 838
	public bool DomePosToCamera;

	// Token: 0x04000347 RID: 839
	public Vector3 DomePosOffset;

	// Token: 0x04000348 RID: 840
	public bool DomeScaleToFarClip;

	// Token: 0x04000349 RID: 841
	public float DomeScaleFactor;

	// Token: 0x0400034A RID: 842
	private Camera camera_0;

	// Token: 0x0400034B RID: 843
	private Transform transform_0;
}
