using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006AC RID: 1708
public class LevelPhysicsSettings : MonoBehaviour
{
	// Token: 0x060026AD RID: 9901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bounds GetGlobalBounds()
	{
		throw null;
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x040025DD RID: 9693
	private const int int_0 = 16;

	// Token: 0x040025DE RID: 9694
	[SerializeField]
	private Bounds _mbpBounds;

	// Token: 0x040025DF RID: 9695
	[Range(1f, 16f)]
	[SerializeField]
	private int _mbpSubdivisions;

	// Token: 0x040025E0 RID: 9696
	private static LevelPhysicsSettings levelPhysicsSettings_0;
}
