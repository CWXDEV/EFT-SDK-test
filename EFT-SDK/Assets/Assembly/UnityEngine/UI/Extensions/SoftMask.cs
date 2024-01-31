using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200309C RID: 12444
	[ExecuteInEditMode]
	public class SoftMask : MonoBehaviour
	{
		// Token: 0x0600F413 RID: 62483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600F414 RID: 62484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Transform t)
		{
			throw null;
		}

		// Token: 0x0600F415 RID: 62485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F416 RID: 62486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600F417 RID: 62487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400FA39 RID: 64057
		private Material material_0;

		// Token: 0x0400FA3A RID: 64058
		private Canvas canvas_0;

		// Token: 0x0400FA3B RID: 64059
		public Shader ImageMaskShader;

		// Token: 0x0400FA3C RID: 64060
		[Tooltip("The area that is to be used as the container.")]
		public RectTransform MaskArea;

		// Token: 0x0400FA3D RID: 64061
		private RectTransform rectTransform_0;

		// Token: 0x0400FA3E RID: 64062
		[Tooltip("A Rect Transform that can be used to scale and move the mask - Does not apply to Text UI Components being masked")]
		public RectTransform maskScalingRect;

		// Token: 0x0400FA3F RID: 64063
		[Tooltip("Texture to be used to do the soft alpha")]
		public Texture AlphaMask;

		// Token: 0x0400FA40 RID: 64064
		[Tooltip("At what point to apply the alpha min range 0-1")]
		[Range(0f, 1f)]
		public float CutOff;

		// Token: 0x0400FA41 RID: 64065
		[Tooltip("Implement a hard blend based on the Cutoff")]
		public bool HardBlend;

		// Token: 0x0400FA42 RID: 64066
		[Tooltip("Flip the masks alpha value")]
		public bool FlipAlphaMask;

		// Token: 0x0400FA43 RID: 64067
		[Tooltip("If Mask Scaling Rect is given and this value is true, the area around the mask will not be clipped")]
		public bool DontClipMaskScalingRect;

		// Token: 0x0400FA44 RID: 64068
		[Tooltip("If set to true, this mask is applied to all child Graphic objects belonging to this object.")]
		public bool CascadeToALLChildren;

		// Token: 0x0400FA45 RID: 64069
		private Vector3[] vector3_0;

		// Token: 0x0400FA46 RID: 64070
		private Vector2 vector2_0;

		// Token: 0x0400FA47 RID: 64071
		private Vector2 vector2_1;

		// Token: 0x0400FA48 RID: 64072
		private Vector2 vector2_2;

		// Token: 0x0400FA49 RID: 64073
		private Vector2 vector2_3;

		// Token: 0x0400FA4A RID: 64074
		private Vector2 vector2_4;

		// Token: 0x0400FA4B RID: 64075
		private Vector2 vector2_5;

		// Token: 0x0400FA4C RID: 64076
		private bool bool_0;

		// Token: 0x0400FA4D RID: 64077
		private Rect rect_0;

		// Token: 0x0400FA4E RID: 64078
		private Rect rect_1;

		// Token: 0x0400FA4F RID: 64079
		private Vector2 vector2_6;

		// Token: 0x0400FA50 RID: 64080
		private static readonly int int_0;

		// Token: 0x0400FA51 RID: 64081
		private static readonly int int_1;

		// Token: 0x0400FA52 RID: 64082
		private static readonly int int_2;

		// Token: 0x0400FA53 RID: 64083
		private static readonly int int_3;

		// Token: 0x0400FA54 RID: 64084
		private static readonly int int_4;

		// Token: 0x0400FA55 RID: 64085
		private static readonly int int_5;

		// Token: 0x0400FA56 RID: 64086
		private static readonly int int_6;

		// Token: 0x0400FA57 RID: 64087
		private static readonly int int_7;
	}
}
