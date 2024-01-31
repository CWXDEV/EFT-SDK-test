using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B7F RID: 2943
[Obsolete]
public class WeaponWetDropsController : WeaponCubeMapper
{
	// Token: 0x06003FD9 RID: 16345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Texture2D rainDistort, Texture2D rainMask)
	{
		throw null;
	}

	// Token: 0x06003FDA RID: 16346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InternalInit()
	{
		throw null;
	}

	// Token: 0x0400484E RID: 18510
	[SerializeField]
	private Shader _shaderToReplace;

	// Token: 0x0400484F RID: 18511
	[SerializeField]
	private float _refraction;

	// Token: 0x04004850 RID: 18512
	[SerializeField]
	private Texture2D _refractionMap;

	// Token: 0x04004851 RID: 18513
	[SerializeField]
	private Texture2D _mask;

	// Token: 0x04004852 RID: 18514
	private static readonly int _refr;

	// Token: 0x04004853 RID: 18515
	private static readonly int _lerp;

	// Token: 0x04004854 RID: 18516
	private static readonly int _dropsMap;

	// Token: 0x04004855 RID: 18517
	private static readonly int _noise;
}
