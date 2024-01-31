using System;
using UnityEngine;

// Token: 0x020006A9 RID: 1705
public class ExternalTerrainCollider : MonoBehaviour
{
	// Token: 0x040025DA RID: 9690
	public Terrain Terrain;

	// Token: 0x040025DB RID: 9691
	[Range(2f, 2048f)]
	public int GridX;

	// Token: 0x040025DC RID: 9692
	[Range(2f, 2048f)]
	public int GridY;
}
