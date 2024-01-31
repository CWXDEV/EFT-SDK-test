using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200095E RID: 2398
public class PreviewMaterialSetter : MonoBehaviour
{
	// Token: 0x06003637 RID: 13879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003638 RID: 13880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAvailable(bool isAvailable)
	{
		throw null;
	}

	// Token: 0x0600363A RID: 13882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material[] method_1(MeshRenderer renderer)
	{
		throw null;
	}

	// Token: 0x0600363C RID: 13884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600363D RID: 13885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(MeshRenderer renderer, Material[] savedMaterials)
	{
		throw null;
	}

	// Token: 0x04003733 RID: 14131
	[SerializeField]
	private Color _availableColor;

	// Token: 0x04003734 RID: 14132
	[SerializeField]
	private Color _availableReflectionColor;

	// Token: 0x04003735 RID: 14133
	[SerializeField]
	private Color _unvailableColor;

	// Token: 0x04003736 RID: 14134
	[SerializeField]
	private Color _unvailableReflectionColor;

	// Token: 0x04003737 RID: 14135
	private Dictionary<MeshRenderer, Material[]> dictionary_0;

	// Token: 0x04003738 RID: 14136
	private Material material_0;

	// Token: 0x04003739 RID: 14137
	private static readonly int int_0;

	// Token: 0x0400373A RID: 14138
	private static readonly int int_1;
}
