using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A8C RID: 2700
[ExecuteInEditMode]
public sealed class HighLightMesh : MonoBehaviour
{
	// Token: 0x06003B73 RID: 15219 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003B74 RID: 15220 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003B75 RID: 15221 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(int pass)
	{
		throw null;
	}

	// Token: 0x06003B76 RID: 15222 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003B77 RID: 15223 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04003FE9 RID: 16361
	[SerializeField]
	private Material Mat;

	// Token: 0x04003FEA RID: 16362
	public Color Color;

	// Token: 0x04003FEB RID: 16363
	public float LineWidth;

	// Token: 0x04003FEC RID: 16364
	public bool Always;

	// Token: 0x04003FED RID: 16365
	public Transform Target;

	// Token: 0x04003FEE RID: 16366
	private Transform transform_0;

	// Token: 0x04003FEF RID: 16367
	private float float_0;

	// Token: 0x04003FF0 RID: 16368
	private Color color_0;

	// Token: 0x04003FF1 RID: 16369
	private HighLightMesh.Class548[] class548_0;

	// Token: 0x04003FF2 RID: 16370
	private int int_0;

	// Token: 0x04003FF3 RID: 16371
	private int int_1;

	// Token: 0x04003FF4 RID: 16372
	private static readonly int int_2;

	// Token: 0x04003FF5 RID: 16373
	private static readonly int int_3;

	// Token: 0x04003FF6 RID: 16374
	private static readonly int int_4;

	// Token: 0x04003FF7 RID: 16375
	private static readonly int int_5;

	// Token: 0x04003FF8 RID: 16376
	private Camera camera_0;

	// Token: 0x04003FF9 RID: 16377
	private CommandBuffer commandBuffer_0;

	// Token: 0x04003FFA RID: 16378
	private RenderTexture renderTexture_0;

	// Token: 0x02000A8D RID: 2701
	private sealed class Class548
	{
		// Token: 0x06003B78 RID: 15224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(CommandBuffer cmd, Material mat, int pass)
		{
			throw null;
		}

		// Token: 0x04003FFB RID: 16379
		[CanBeNull]
		private readonly Mesh mesh_0;

		// Token: 0x04003FFC RID: 16380
		private readonly Transform transform_0;

		// Token: 0x04003FFD RID: 16381
		[CanBeNull]
		private readonly SkinnedMeshRenderer skinnedMeshRenderer_0;
	}
}
