using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSG.CameraEffects
{
	// Token: 0x02000C3F RID: 3135
	[RequireComponent(typeof(Camera))]
	public class NightVision : MonoBehaviour, GInterface45
	{
		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x00002050 File Offset: 0x00000250
		private Material Material_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x00002050 File Offset: 0x00000250
		public bool On
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x00002050 File Offset: 0x00000250
		public bool InProcessSwitching
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMask(NightVisionComponent.EMask mask)
		{
			throw null;
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySettings()
		{
			throw null;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartSwitch(bool on)
		{
			throw null;
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FastForwardSwitch()
		{
			throw null;
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreCull()
		{
			throw null;
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPostRender()
		{
			throw null;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool on)
		{
			throw null;
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_0(AnimationCurve curve)
		{
			throw null;
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x04004DE5 RID: 19941
		public Shader Shader;

		// Token: 0x04004DE6 RID: 19942
		public float Intensity;

		// Token: 0x04004DE7 RID: 19943
		public Texture Noise;

		// Token: 0x04004DE8 RID: 19944
		public Texture Mask;

		// Token: 0x04004DE9 RID: 19945
		public float MaskSize;

		// Token: 0x04004DEA RID: 19946
		public float NoiseIntensity;

		// Token: 0x04004DEB RID: 19947
		public float NoiseScale;

		// Token: 0x04004DEC RID: 19948
		[ColorUsage(false)]
		public Color Color;

		// Token: 0x04004DED RID: 19949
		public TextureMask TextureMask;

		// Token: 0x04004DEE RID: 19950
		public MonoBehaviour[] SwitchComponentsOn;

		// Token: 0x04004DEF RID: 19951
		public MonoBehaviour[] SwitchComponentsOff;

		// Token: 0x04004DF0 RID: 19952
		public AnimationCurve BlackFlashGoingToOn;

		// Token: 0x04004DF1 RID: 19953
		public AnimationCurve BlackFlashGoingToOff;

		// Token: 0x04004DF2 RID: 19954
		public AudioClip SwitchOn;

		// Token: 0x04004DF3 RID: 19955
		public AudioClip SwitchOff;

		// Token: 0x04004DF4 RID: 19956
		public Texture ThermalMaskTexture;

		// Token: 0x04004DF5 RID: 19957
		public Texture AnvisMaskTexture;

		// Token: 0x04004DF6 RID: 19958
		public Texture BinocularMaskTexture;

		// Token: 0x04004DF7 RID: 19959
		public Texture GasMaskTexture;

		// Token: 0x04004DF8 RID: 19960
		public Texture OldMonocularMaskTexture;

		// Token: 0x04004DF9 RID: 19961
		public float ambientFactor;

		// Token: 0x04004DFA RID: 19962
		[SerializeField]
		private bool _on;

		// Token: 0x04004DFB RID: 19963
		private static readonly int int_0;

		// Token: 0x04004DFC RID: 19964
		private static readonly int int_1;

		// Token: 0x04004DFD RID: 19965
		private static readonly int int_2;

		// Token: 0x04004DFE RID: 19966
		private static readonly int int_3;

		// Token: 0x04004DFF RID: 19967
		private static readonly int int_4;

		// Token: 0x04004E00 RID: 19968
		private static readonly int int_5;

		// Token: 0x04004E01 RID: 19969
		private static readonly int int_6;

		// Token: 0x04004E02 RID: 19970
		private static readonly string string_0;

		// Token: 0x04004E03 RID: 19971
		private Material material_0;

		// Token: 0x04004E04 RID: 19972
		private Material material_1;

		// Token: 0x04004E05 RID: 19973
		private int int_7;

		// Token: 0x04004E06 RID: 19974
		private int int_8;

		// Token: 0x04004E07 RID: 19975
		private Class608 class608_0;

		// Token: 0x04004E08 RID: 19976
		[CanBeNull]
		private SSAA ssaa_0;

		// Token: 0x04004E09 RID: 19977
		private SSAAPropagator ssaapropagator_0;

		// Token: 0x04004E0A RID: 19978
		private bool? nullable_0;

		// Token: 0x04004E0B RID: 19979
		private bool bool_0;

		// Token: 0x04004E0C RID: 19980
		private CommandBuffer commandBuffer_0;

		// Token: 0x04004E0D RID: 19981
		private Camera camera_0;

		// Token: 0x04004E0E RID: 19982
		private bool bool_1;

		// Token: 0x04004E0F RID: 19983
		private Vector4 vector4_0;

		// Token: 0x04004E10 RID: 19984
		private Color color_0;

		// Token: 0x02000C40 RID: 3136
		[CompilerGenerated]
		private sealed class Class632
		{
			// Token: 0x0600444F RID: 17487 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Keyframe key)
			{
				throw null;
			}

			// Token: 0x04004E11 RID: 19985
			public float v;

			// Token: 0x04004E12 RID: 19986
			public Func<Keyframe, bool> func_0;
		}
	}
}
