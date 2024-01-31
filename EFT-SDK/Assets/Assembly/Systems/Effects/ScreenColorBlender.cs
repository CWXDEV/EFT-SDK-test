using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Systems.Effects
{
	// Token: 0x02000C37 RID: 3127
	[RequireComponent(typeof(Camera))]
	public class ScreenColorBlender : MonoBehaviour
	{
		// Token: 0x0600441B RID: 17435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRenderImage(RenderTexture source, RenderTexture destanation)
		{
			throw null;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GenerateTextureAndReassignMaterial()
		{
			throw null;
		}

		// Token: 0x04004DAC RID: 19884
		[SerializeField]
		private Shader _shader;

		// Token: 0x04004DAD RID: 19885
		[SerializeField]
		private Color _color1;

		// Token: 0x04004DAE RID: 19886
		[SerializeField]
		private Color _color2;

		// Token: 0x04004DAF RID: 19887
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04004DB0 RID: 19888
		[Range(0f, 12f)]
		[SerializeField]
		private int _downsamplingValue;

		// Token: 0x04004DB1 RID: 19889
		[SerializeField]
		private bool _useExistingTexture;

		// Token: 0x04004DB2 RID: 19890
		[SerializeField]
		private Texture2D _blendTexture;

		// Token: 0x04004DB3 RID: 19891
		[Range(0f, 1f)]
		[SerializeField]
		private float _blendValue;

		// Token: 0x04004DB4 RID: 19892
		private Material material_0;

		// Token: 0x04004DB5 RID: 19893
		private Texture texture_0;

		// Token: 0x04004DB6 RID: 19894
		private static readonly int int_0;

		// Token: 0x04004DB7 RID: 19895
		private static readonly int int_1;
	}
}
