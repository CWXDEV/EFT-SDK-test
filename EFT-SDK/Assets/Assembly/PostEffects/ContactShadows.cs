using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace PostEffects
{
	// Token: 0x02000C57 RID: 3159
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public sealed class ContactShadows : MonoBehaviour
	{
		// Token: 0x060044D7 RID: 17623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreCull()
		{
			throw null;
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreRender()
		{
			throw null;
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Matrix4x4 smethod_0()
		{
			throw null;
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector2 method_2()
		{
			throw null;
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x04004ED4 RID: 20180
		[SerializeField]
		private Light _light;

		// Token: 0x04004ED5 RID: 20181
		[SerializeField]
		[Range(0f, 5f)]
		private float _rejectionDepth;

		// Token: 0x04004ED6 RID: 20182
		[SerializeField]
		[Range(0f, 32f)]
		private int _sampleCount;

		// Token: 0x04004ED7 RID: 20183
		[SerializeField]
		[Range(0f, 1f)]
		private float _temporalFilter;

		// Token: 0x04004ED8 RID: 20184
		[Range(0f, 1f)]
		[SerializeField]
		private float _contrast;

		// Token: 0x04004ED9 RID: 20185
		[SerializeField]
		private bool _downsample;

		// Token: 0x04004EDA RID: 20186
		[SerializeField]
		private NoiseTextureSet _noiseTextures;

		// Token: 0x04004EDB RID: 20187
		[HideInInspector]
		[SerializeField]
		private Shader _shader;

		// Token: 0x04004EDC RID: 20188
		private Material material_0;

		// Token: 0x04004EDD RID: 20189
		private RenderTexture renderTexture_0;

		// Token: 0x04004EDE RID: 20190
		private RenderTexture renderTexture_1;

		// Token: 0x04004EDF RID: 20191
		private CommandBuffer commandBuffer_0;

		// Token: 0x04004EE0 RID: 20192
		private CommandBuffer commandBuffer_1;

		// Token: 0x04004EE1 RID: 20193
		private Matrix4x4 matrix4x4_0;

		// Token: 0x04004EE2 RID: 20194
		private Camera camera_0;

		// Token: 0x04004EE3 RID: 20195
		private SSAA ssaa_0;

		// Token: 0x04004EE4 RID: 20196
		private int int_0;

		// Token: 0x04004EE5 RID: 20197
		private int int_1;

		// Token: 0x04004EE6 RID: 20198
		private int int_2;

		// Token: 0x04004EE7 RID: 20199
		private int int_3;

		// Token: 0x04004EE8 RID: 20200
		private static readonly int int_4;

		// Token: 0x04004EE9 RID: 20201
		private static readonly int int_5;

		// Token: 0x04004EEA RID: 20202
		private static readonly int int_6;

		// Token: 0x04004EEB RID: 20203
		private static readonly int int_7;

		// Token: 0x04004EEC RID: 20204
		private static readonly int int_8;

		// Token: 0x04004EED RID: 20205
		private static readonly int int_9;

		// Token: 0x04004EEE RID: 20206
		private static readonly int int_10;

		// Token: 0x04004EEF RID: 20207
		private static readonly int int_11;
	}
}
