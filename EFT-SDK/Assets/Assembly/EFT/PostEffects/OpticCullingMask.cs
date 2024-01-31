using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EFT.PostEffects
{
	// Token: 0x02001984 RID: 6532
	[RequireComponent(typeof(Camera))]
	[DisallowMultipleComponent]
	public class OpticCullingMask : MonoBehaviour
	{
		// Token: 0x06008BE2 RID: 35810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateParameters()
		{
			throw null;
		}

		// Token: 0x0400917B RID: 37243
		[SerializeField]
		private Shader _cullingMaskShader;

		// Token: 0x0400917C RID: 37244
		[SerializeField]
		[Range(0f, 2f)]
		public float _maskScale;

		// Token: 0x0400917D RID: 37245
		private static Mesh mesh_0;

		// Token: 0x0400917E RID: 37246
		private static readonly Matrix4x4 matrix4x4_0;

		// Token: 0x0400917F RID: 37247
		private Camera camera_0;

		// Token: 0x04009180 RID: 37248
		private Material material_0;

		// Token: 0x04009181 RID: 37249
		private CameraEvent cameraEvent_0;

		// Token: 0x04009182 RID: 37250
		private CommandBuffer commandBuffer_0;

		// Token: 0x04009183 RID: 37251
		private int int_0;
	}
}
