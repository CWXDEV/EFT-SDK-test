using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002CA0 RID: 11424
	[ExecuteInEditMode]
	[RequireComponent(typeof(RawImage))]
	public sealed class CameraImage : MonoBehaviour
	{
		// Token: 0x0600E112 RID: 57618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E113 RID: 57619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600E114 RID: 57620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitCamera([CanBeNull] Camera cam)
		{
			throw null;
		}

		// Token: 0x0600E115 RID: 57621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E116 RID: 57622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRawImageColor(Color32 color)
		{
			throw null;
		}

		// Token: 0x0600E117 RID: 57623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CleanUp()
		{
			throw null;
		}

		// Token: 0x0600E118 RID: 57624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Camera cam)
		{
			throw null;
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Camera cam)
		{
			throw null;
		}

		// Token: 0x0600E11D RID: 57629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E11E RID: 57630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Camera cam)
		{
			throw null;
		}

		// Token: 0x0400E5C5 RID: 58821
		public Camera targetCamera;

		// Token: 0x0400E5C6 RID: 58822
		private RenderTexture renderTexture_0;

		// Token: 0x0400E5C7 RID: 58823
		public int TextureDepth;

		// Token: 0x0400E5C8 RID: 58824
		public RenderTextureFormat TextureFormat;

		// Token: 0x0400E5C9 RID: 58825
		public RenderTextureReadWrite RenderTextureReadWrite;

		// Token: 0x0400E5CA RID: 58826
		public int Antialiasing;

		// Token: 0x0400E5CB RID: 58827
		private int int_0;

		// Token: 0x0400E5CC RID: 58828
		private int int_1;

		// Token: 0x0400E5CD RID: 58829
		private RawImage rawImage_0;

		// Token: 0x0400E5CE RID: 58830
		private CameraImage.Struct945 struct945_0;

		// Token: 0x02002CA1 RID: 11425
		[StructLayout(LayoutKind.Auto)]
		public struct Struct945
		{
			// Token: 0x0600E11F RID: 57631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static CameraImage.Struct945 Store()
			{
				throw null;
			}

			// Token: 0x0600E120 RID: 57632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static void Reset()
			{
				throw null;
			}

			// Token: 0x0600E121 RID: 57633 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Restore()
			{
				throw null;
			}

			// Token: 0x0400E5CF RID: 58831
			public Color AmbientEquatorColor;

			// Token: 0x0400E5D0 RID: 58832
			public Color AmbientGroundColor;

			// Token: 0x0400E5D1 RID: 58833
			public float AmbientIntensity;

			// Token: 0x0400E5D2 RID: 58834
			public Color AmbientLight;

			// Token: 0x0400E5D3 RID: 58835
			public AmbientMode AmbientMode;

			// Token: 0x0400E5D4 RID: 58836
			public Color AmbientSkyColor;

			// Token: 0x0400E5D5 RID: 58837
			public bool Fog;
		}
	}
}
