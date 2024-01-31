using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BSG.CameraEffects;
using EFT.PostEffects;
using UnityEngine;

namespace EFT.CameraControl
{
	// Token: 0x0200270B RID: 9995
	[ExecuteAlways]
	public class OpticSight : MonoBehaviour
	{
		// Token: 0x0600C654 RID: 50772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LensFade(bool isHide = true)
		{
			throw null;
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Calc Distance")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalcDistance()
		{
			throw null;
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LookAt(Vector3 point, Vector3 worldUp)
		{
			throw null;
		}

		// Token: 0x0400C814 RID: 51220
		public static BindableState<OpticSight.GStruct381> OpticSightState;

		// Token: 0x0400C815 RID: 51221
		public Renderer LensRenderer;

		// Token: 0x0400C816 RID: 51222
		public Transform ScopeTransform;

		// Token: 0x0400C817 RID: 51223
		[SerializeField]
		public float DistanceToCamera;

		// Token: 0x0400C818 RID: 51224
		[SerializeField]
		public Camera TemplateCamera;

		// Token: 0x0400C819 RID: 51225
		[SerializeField]
		public OpticCullingMask OpticCullingMask;

		// Token: 0x0400C81A RID: 51226
		[SerializeField]
		public ChromaticAberration ChromaticAberration;

		// Token: 0x0400C81C RID: 51228
		[SerializeField]
		public ThermalVision ThermalVision;

		// Token: 0x0400C81D RID: 51229
		[SerializeField]
		public CC_FastVignette FastVignette;

		// Token: 0x0400C81E RID: 51230
		[SerializeField]
		public UltimateBloom UltimateBloom;

		// Token: 0x0400C820 RID: 51232
		[SerializeField]
		public NightVision NightVision;

		// Token: 0x0400C822 RID: 51234
		[SerializeField]
		public CameraLodBiasController CameraLodBiasController;

		// Token: 0x0400C823 RID: 51235
		[SerializeField]
		[Tooltip("ALARM! Consumes a lot of CPU!")]
		public bool IsThermalSightAvailableAt45Degrees;

		// Token: 0x0400C824 RID: 51236
		private readonly int int_0;

		// Token: 0x0200270C RID: 9996
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct381
		{
			// Token: 0x0400C825 RID: 51237
			public OpticSight OpticSight;

			// Token: 0x0400C826 RID: 51238
			public bool IsEnabled;
		}
	}
}
