using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000860 RID: 2144
[RequireComponent(typeof(Camera))]
public class IconShadow : MonoBehaviour
{
	// Token: 0x17000860 RID: 2144
	// (get) Token: 0x060030BA RID: 12474 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000861 RID: 2145
	// (get) Token: 0x060030BB RID: 12475 RVA: 0x00002050 File Offset: 0x00000250
	private Material Material_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030BC RID: 12476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTexDimension(int width, int height)
	{
		throw null;
	}

	// Token: 0x060030BD RID: 12477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x04003196 RID: 12694
	[SerializeField]
	private Color _shadowColor;

	// Token: 0x04003197 RID: 12695
	[SerializeField]
	private Vector2 _shadowOffset;

	// Token: 0x04003198 RID: 12696
	private Material material_0;

	// Token: 0x04003199 RID: 12697
	private Material material_1;

	// Token: 0x0400319A RID: 12698
	private Vector4 vector4_0;

	// Token: 0x0400319B RID: 12699
	private Camera camera_0;

	// Token: 0x0400319C RID: 12700
	private static readonly int int_0;

	// Token: 0x0400319D RID: 12701
	private static readonly int int_1;

	// Token: 0x0400319E RID: 12702
	private static readonly int int_2;

	// Token: 0x0400319F RID: 12703
	private static readonly int int_3;
}
