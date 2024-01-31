using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B68 RID: 2920
[RequireComponent(typeof(Camera))]
public class HdrModeSwitcher : MonoBehaviour
{
	// Token: 0x06003F59 RID: 16217 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreCull()
	{
		throw null;
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(CameraHDRMode hdrMode)
	{
		throw null;
	}

	// Token: 0x0400472C RID: 18220
	[SerializeField]
	private CameraHDRMode HdrMode;

	// Token: 0x0400472D RID: 18221
	private CameraHDRMode cameraHDRMode_0;
}
