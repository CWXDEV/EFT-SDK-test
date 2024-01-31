using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000060 RID: 96
[AddComponentMenu("")]
[RequireComponent(typeof(Camera))]
public sealed class AmplifyMotionPostProcess : MonoBehaviour
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
	public AmplifyMotionEffectBase Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x0400014C RID: 332
	private AmplifyMotionEffectBase amplifyMotionEffectBase_0;
}
