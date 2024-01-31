using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A1F RID: 2591
[RequireComponent(typeof(Camera))]
public class AreaLightManager : MonoBehaviour
{
	// Token: 0x06003905 RID: 14597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x04003B0A RID: 15114
	[SerializeField]
	private Shader ClearStencilShader;

	// Token: 0x04003B0B RID: 15115
	private const int int_0 = 192;

	// Token: 0x04003B0C RID: 15116
	private Material material_0;

	// Token: 0x04003B0D RID: 15117
	private CommandBuffer commandBuffer_0;

	// Token: 0x04003B0E RID: 15118
	private Camera camera_0;

	// Token: 0x04003B0F RID: 15119
	private Mesh mesh_0;
}
