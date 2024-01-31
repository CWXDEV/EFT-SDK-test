using System;
using System.Runtime.CompilerServices;
using BSG.CameraEffects;
using EFT.PostEffects;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace EFT.CameraControl
{
	// Token: 0x020026FF RID: 9983
	[ExecuteAlways]
	public class OpticComponentUpdater : MonoBehaviour
	{
		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x0600C60E RID: 50702 RVA: 0x00002050 File Offset: 0x00000250
		public Camera MainCamera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C610 RID: 50704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPivot(Transform pivot)
		{
			throw null;
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyComponentFromOptic(OpticSight opticSight)
		{
			throw null;
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C613 RID: 50707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600C614 RID: 50708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400C7CB RID: 51147
		private Transform transform_0;

		// Token: 0x0400C7CC RID: 51148
		private Camera camera_0;

		// Token: 0x0400C7CD RID: 51149
		private global::ChromaticAberration chromaticAberration_0;

		// Token: 0x0400C7CF RID: 51151
		private ThermalVision thermalVision_0;

		// Token: 0x0400C7D0 RID: 51152
		private CC_FastVignette cc_FastVignette_0;

		// Token: 0x0400C7D1 RID: 51153
		private UltimateBloom ultimateBloom_0;

		// Token: 0x0400C7D3 RID: 51155
		private NightVision nightVision_0;

		// Token: 0x0400C7D5 RID: 51157
		private OpticCullingMask opticCullingMask_0;

		// Token: 0x0400C7D6 RID: 51158
		private CustomGlobalFog customGlobalFog_0;

		// Token: 0x0400C7D7 RID: 51159
		private TOD_Scattering tod_Scattering_0;

		// Token: 0x0400C7D8 RID: 51160
		private MBOIT_Scattering mboit_Scattering_0;

		// Token: 0x0400C7D9 RID: 51161
		private Undithering undithering_0;

		// Token: 0x0400C7DA RID: 51162
		private PostProcessLayer postProcessLayer_0;

		// Token: 0x0400C7DB RID: 51163
		private VolumetricLightRenderer volumetricLightRenderer_0;

		// Token: 0x0400C7DC RID: 51164
		private CustomGlobalFog customGlobalFog_1;

		// Token: 0x0400C7DD RID: 51165
		private TOD_Scattering tod_Scattering_1;

		// Token: 0x0400C7DE RID: 51166
		private MBOIT_Scattering mboit_Scattering_1;

		// Token: 0x0400C7DF RID: 51167
		private Undithering undithering_1;

		// Token: 0x0400C7E0 RID: 51168
		private PostProcessLayer postProcessLayer_1;

		// Token: 0x0400C7E1 RID: 51169
		private VolumetricLightRenderer volumetricLightRenderer_1;

		// Token: 0x0400C7E2 RID: 51170
		private CameraLodBiasController cameraLodBiasController_0;

		// Token: 0x0400C7E3 RID: 51171
		private int int_0;

		// Token: 0x0400C7E4 RID: 51172
		private float float_0;

		// Token: 0x0400C7E5 RID: 51173
		public float OpticScatterReductionStrength;
	}
}
