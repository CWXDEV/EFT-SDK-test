using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A13 RID: 2579
[RequireComponent(typeof(Terrain))]
public class TerrainNeighbors : MonoBehaviour
{
	// Token: 0x060038CA RID: 14538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x04003A82 RID: 14978
	public Terrain Left;

	// Token: 0x04003A83 RID: 14979
	public Terrain Right;

	// Token: 0x04003A84 RID: 14980
	public Terrain Top;

	// Token: 0x04003A85 RID: 14981
	public Terrain Bottom;
}
