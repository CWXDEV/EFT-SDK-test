using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace GPUInstancer
{
	// Token: 0x02000EAB RID: 3755
	public class GPUInstancerHiZOcclusionGenerator : MonoBehaviour
	{
		// Token: 0x06004E6C RID: 20076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(Camera occlusionCamera = null)
		{
			throw null;
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0()
		{
			throw null;
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_1()
		{
			throw null;
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ScriptableRenderContext context, Camera camera)
		{
			throw null;
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Camera camera)
		{
			throw null;
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(int offset)
		{
			throw null;
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Camera camera)
		{
			throw null;
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x04005B29 RID: 23337
		public bool debuggerEnabled;

		// Token: 0x04005B2A RID: 23338
		public bool debuggerGUIOnTop;

		// Token: 0x04005B2B RID: 23339
		[Range(0f, 0.1f)]
		public float debuggerOverlay;

		// Token: 0x04005B2C RID: 23340
		[Range(0f, 16f)]
		public int debuggerMipLevel;

		// Token: 0x04005B2D RID: 23341
		[Header("For info only, don't change:")]
		public RenderTexture hiZDepthTexture;

		// Token: 0x04005B2E RID: 23342
		public Texture unityDepthTexture;

		// Token: 0x04005B2F RID: 23343
		public Vector2 hiZTextureSize;

		// Token: 0x04005B30 RID: 23344
		[HideInInspector]
		public bool isVREnabled;

		// Token: 0x04005B31 RID: 23345
		private Camera camera_0;

		// Token: 0x04005B32 RID: 23346
		private SSAA ssaa_0;

		// Token: 0x04005B33 RID: 23347
		private int int_0;

		// Token: 0x04005B34 RID: 23348
		private int int_1;

		// Token: 0x04005B35 RID: 23349
		private bool bool_0;

		// Token: 0x04005B36 RID: 23350
		private GPUIOcclusionCullingType gpuiocclusionCullingType_0;

		// Token: 0x04005B37 RID: 23351
		private Material material_0;

		// Token: 0x04005B38 RID: 23352
		private int int_2;

		// Token: 0x04005B39 RID: 23353
		private RenderTexture[] renderTexture_0;

		// Token: 0x04005B3A RID: 23354
		private RawImage rawImage_0;

		// Token: 0x04005B3B RID: 23355
		private GameObject gameObject_0;

		// Token: 0x04005B3C RID: 23356
		private bool bool_1;

		// Token: 0x04005B3D RID: 23357
		private float float_0;
	}
}
