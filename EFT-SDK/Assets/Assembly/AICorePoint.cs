using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000214 RID: 532
public class AICorePoint : MonoBehaviour, IPositionPoint, IAICorePointLink, GInterface4
{
	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
	public int ConnectionGroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
	public AICorePoint CorePointInGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddWay(int id, GInterface4 wayTo)
	{
		throw null;
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearConnections()
	{
		throw null;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIds(int id, int connectId)
	{
		throw null;
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToName(string addName)
	{
		throw null;
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GizmosDrawWays(float h)
	{
		throw null;
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(List<AICorePoint> corePoints)
	{
		throw null;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x04000AD0 RID: 2768
	[SerializeField]
	private int _id;

	// Token: 0x04000AD1 RID: 2769
	[SerializeField]
	private int _connectionGroupId;

	// Token: 0x04000AD2 RID: 2770
	[SerializeField]
	private List<int> _connectionsAtNetId;

	// Token: 0x04000AD3 RID: 2771
	[SerializeField]
	public List<AICorePoint> ConnectionsAtNet;

	// Token: 0x04000AD4 RID: 2772
	[NonSerialized]
	private bool bool_0;

	// Token: 0x02000215 RID: 533
	[CompilerGenerated]
	private sealed class Class117
	{
		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AICorePoint x)
		{
			throw null;
		}

		// Token: 0x04000AD5 RID: 2773
		public int i;
	}
}
