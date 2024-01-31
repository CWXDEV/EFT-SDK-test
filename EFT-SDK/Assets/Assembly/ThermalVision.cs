using System;
using System.Runtime.CompilerServices;
using BSG.CameraEffects;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B2D RID: 2861
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class ThermalVision : MonoBehaviour, GInterface45
{
	// Token: 0x17000A05 RID: 2565
	// (get) Token: 0x06003DFA RID: 15866 RVA: 0x00002050 File Offset: 0x00000250
	public bool InProcessSwitching
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003DFB RID: 15867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003DFC RID: 15868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003DFD RID: 15869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003DFE RID: 15870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FastForwardSwitch()
	{
		throw null;
	}

	// Token: 0x06003DFF RID: 15871 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003E00 RID: 15872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreCull()
	{
		throw null;
	}

	// Token: 0x06003E01 RID: 15873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	// Token: 0x06003E02 RID: 15874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMask(NightVisionComponent.EMask mask)
	{
		throw null;
	}

	// Token: 0x06003E03 RID: 15875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool on)
	{
		throw null;
	}

	// Token: 0x06003E04 RID: 15876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Toggle()
	{
		throw null;
	}

	// Token: 0x06003E05 RID: 15877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartSwitch(bool on)
	{
		throw null;
	}

	// Token: 0x06003E06 RID: 15878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaterialProperties()
	{
		throw null;
	}

	// Token: 0x06003E07 RID: 15879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Texture method_2()
	{
		throw null;
	}

	// Token: 0x06003E08 RID: 15880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003E09 RID: 15881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_0(AnimationCurve curve)
	{
		throw null;
	}

	// Token: 0x06003E0A RID: 15882 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003E0B RID: 15883 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x040044D6 RID: 17622
	public bool On;

	// Token: 0x040044D7 RID: 17623
	public bool IsNoisy;

	// Token: 0x040044D8 RID: 17624
	public bool IsFpsStuck;

	// Token: 0x040044D9 RID: 17625
	public bool IsMotionBlurred;

	// Token: 0x040044DA RID: 17626
	public bool IsGlitch;

	// Token: 0x040044DB RID: 17627
	public bool IsPixelated;

	// Token: 0x040044DC RID: 17628
	public ThermalVisionUtilities ThermalVisionUtilities;

	// Token: 0x040044DD RID: 17629
	public StuckFPSUtilities StuckFpsUtilities;

	// Token: 0x040044DE RID: 17630
	public MotionBlurUtilities MotionBlurUtilities;

	// Token: 0x040044DF RID: 17631
	public GlitchUtilities GlitchUtilities;

	// Token: 0x040044E0 RID: 17632
	public PixelationUtilities PixelationUtilities;

	// Token: 0x040044E1 RID: 17633
	public TextureMask TextureMask;

	// Token: 0x040044E2 RID: 17634
	public MonoBehaviour[] SwitchComponentsOn;

	// Token: 0x040044E3 RID: 17635
	public MonoBehaviour[] SwitchComponentsOff;

	// Token: 0x040044E4 RID: 17636
	public float ChromaticAberrationThermalShift;

	// Token: 0x040044E5 RID: 17637
	public AnimationCurve BlackFlashGoingToOn;

	// Token: 0x040044E6 RID: 17638
	public AnimationCurve BlackFlashGoingToOff;

	// Token: 0x040044E7 RID: 17639
	public AudioClip SwitchOn;

	// Token: 0x040044E8 RID: 17640
	public AudioClip SwitchOff;

	// Token: 0x040044E9 RID: 17641
	[Header("Unsharp Mask")]
	public float UnsharpRadiusBlur;

	// Token: 0x040044EA RID: 17642
	public float UnsharpBias;

	// Token: 0x040044EB RID: 17643
	private Class608 class608_0;

	// Token: 0x040044EC RID: 17644
	private bool? nullable_0;

	// Token: 0x040044ED RID: 17645
	private bool bool_0;

	// Token: 0x040044EE RID: 17646
	private CommandBuffer commandBuffer_0;

	// Token: 0x040044EF RID: 17647
	private CommandBuffer commandBuffer_1;

	// Token: 0x040044F0 RID: 17648
	private Material material_0;

	// Token: 0x040044F1 RID: 17649
	private Camera camera_0;

	// Token: 0x040044F2 RID: 17650
	private GClass864 gclass864_0;

	// Token: 0x040044F3 RID: 17651
	private GClass862 gclass862_0;

	// Token: 0x040044F4 RID: 17652
	private GClass861 gclass861_0;

	// Token: 0x040044F5 RID: 17653
	private GClass863 gclass863_0;

	// Token: 0x040044F6 RID: 17654
	private VolumetricLightRenderer volumetricLightRenderer_0;

	// Token: 0x040044F7 RID: 17655
	private SSAA ssaa_0;

	// Token: 0x040044F8 RID: 17656
	private MBOIT_Scattering mboit_Scattering_0;

	// Token: 0x040044F9 RID: 17657
	private ChromaticAberration chromaticAberration_0;

	// Token: 0x040044FA RID: 17658
	private float float_0;

	// Token: 0x040044FB RID: 17659
	private float float_1;

	// Token: 0x040044FC RID: 17660
	private static readonly int int_0;

	// Token: 0x040044FD RID: 17661
	private static readonly int int_1;

	// Token: 0x040044FE RID: 17662
	private static readonly int int_2;

	// Token: 0x040044FF RID: 17663
	private static readonly int int_3;

	// Token: 0x04004500 RID: 17664
	private static readonly int int_4;

	// Token: 0x04004501 RID: 17665
	private static readonly int int_5;

	// Token: 0x04004502 RID: 17666
	private static readonly int int_6;

	// Token: 0x04004503 RID: 17667
	private static readonly int int_7;

	// Token: 0x04004504 RID: 17668
	private static readonly int int_8;

	// Token: 0x04004505 RID: 17669
	private static readonly int int_9;

	// Token: 0x04004506 RID: 17670
	private static readonly int int_10;
}
