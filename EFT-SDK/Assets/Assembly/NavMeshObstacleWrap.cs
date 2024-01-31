using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000531 RID: 1329
[RequireComponent(typeof(NavMeshObstacle))]
public class NavMeshObstacleWrap : MonoBehaviour
{
	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x06002046 RID: 8262 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
	public bool Carving
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

	// Token: 0x04001EE8 RID: 7912
	public ENavMeshObstacleType Type;

	// Token: 0x04001EE9 RID: 7913
	public NavMeshObstacle NavMeshObstacle;
}
