using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000C7 RID: 199
[RequireComponent(typeof(MeshFilter))]
public class PaintingTarget : MonoBehaviour
{
	// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x040004CD RID: 1229
	public bool ApplyVertexColors;

	// Token: 0x040004CE RID: 1230
	public Mesh SharedMesh;

	// Token: 0x040004CF RID: 1231
	public Mesh TargetMesh;

	// Token: 0x040004D0 RID: 1232
	public List<Color> VerticesColors;

	// Token: 0x040004D1 RID: 1233
	public float GizmosScale;

	// Token: 0x040004D2 RID: 1234
	[HideInInspector]
	public Vector4 ChannelScale;

	// Token: 0x040004D3 RID: 1235
	[HideInInspector]
	public bool ShowVertices;

	// Token: 0x040004D4 RID: 1236
	private Color color_0;

	// Token: 0x040004D5 RID: 1237
	private List<int> list_0;
}
