using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BC5 RID: 3013
[RequireComponent(typeof(Collider))]
[ExecuteInEditMode]
public class RendererSelectorTest : MonoBehaviour
{
	// Token: 0x06004198 RID: 16792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x04004AA8 RID: 19112
	private Collider collider_0;

	// Token: 0x04004AA9 RID: 19113
	private Plane[] plane_0;

	// Token: 0x04004AAA RID: 19114
	[SerializeField]
	private bool _updateRendersEveryFrame;

	// Token: 0x04004AAB RID: 19115
	[SerializeField]
	private bool _updatePlanesEveryFrame;

	// Token: 0x04004AAC RID: 19116
	[SerializeField]
	private bool _updateSelectionEveryFrame;

	// Token: 0x04004AAD RID: 19117
	private ICollection<MeshRenderer> icollection_0;

	// Token: 0x04004AAE RID: 19118
	[SerializeField]
	private List<MeshRenderer> _selectedRenderers;
}
