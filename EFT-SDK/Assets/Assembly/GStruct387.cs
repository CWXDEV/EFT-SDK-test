using System;
using System.Runtime.InteropServices;
using EFT.Ballistics;
using EFT.Interactive;
using UnityEngine;

// Token: 0x020027F1 RID: 10225
[StructLayout(LayoutKind.Auto)]
public struct GStruct387
{
	// Token: 0x0400CCFE RID: 52478
	public GameObject GameObject;

	// Token: 0x0400CCFF RID: 52479
	public Transform Transform;

	// Token: 0x0400CD00 RID: 52480
	public MeshFilter MeshFilter;

	// Token: 0x0400CD01 RID: 52481
	public MeshRenderer MeshRenderer;

	// Token: 0x0400CD02 RID: 52482
	public MeshCollider MeshCollider;

	// Token: 0x0400CD03 RID: 52483
	public BallisticCollider BallisticCollider;

	// Token: 0x0400CD04 RID: 52484
	public Transform ChildTransform;

	// Token: 0x0400CD05 RID: 52485
	public BoxCollider ChildBoxCollider;

	// Token: 0x0400CD06 RID: 52486
	public BrokenWindowPieceCollider ChildFragileCollider;
}
