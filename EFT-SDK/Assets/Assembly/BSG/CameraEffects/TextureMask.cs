using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BSG.CameraEffects
{
	// Token: 0x02000C42 RID: 3138
	[AddComponentMenu("Image Effects/TextureMask")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class TextureMask : MonoBehaviour
	{
		// Token: 0x06004450 RID: 17488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Material method_0()
		{
			throw null;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			throw null;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySettings()
		{
			throw null;
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryToEnable(GInterface45 textureMaskHolder, bool on)
		{
			throw null;
		}

		// Token: 0x04004E13 RID: 19987
		private const string string_0 = "_STRETCH";

		// Token: 0x04004E14 RID: 19988
		public Shader Shader;

		// Token: 0x04004E15 RID: 19989
		public Color Color;

		// Token: 0x04004E16 RID: 19990
		public Texture Mask;

		// Token: 0x04004E17 RID: 19991
		public bool Stretch;

		// Token: 0x04004E18 RID: 19992
		public float Size;

		// Token: 0x04004E19 RID: 19993
		private readonly HashSet<GInterface45> hashSet_0;

		// Token: 0x04004E1A RID: 19994
		private Material material_0;

		// Token: 0x04004E1B RID: 19995
		private Camera camera_0;

		// Token: 0x04004E1C RID: 19996
		private SSAA ssaa_0;

		// Token: 0x04004E1D RID: 19997
		private SSAAPropagator ssaapropagator_0;

		// Token: 0x04004E1E RID: 19998
		private static readonly int int_0;

		// Token: 0x04004E1F RID: 19999
		private static readonly int int_1;

		// Token: 0x04004E20 RID: 20000
		private static readonly int int_2;

		// Token: 0x04004E21 RID: 20001
		private static readonly int int_3;

		// Token: 0x04004E22 RID: 20002
		private static readonly int int_4;
	}
}
