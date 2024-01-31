using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Settings.Graphics;
using EFT.SpeedTree;
using Prism.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x0200092E RID: 2350
[AddComponentMenu("Scripts/Game/Components/LevelSettings")]
public class LevelSettings : MonoBehaviour, CameraClass.GInterface350
{
	// Token: 0x1700090F RID: 2319
	// (get) Token: 0x0600351B RID: 13595 RVA: 0x00002050 File Offset: 0x00000250
	Camera CameraClass.GInterface350.CameraPrefab
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000910 RID: 2320
	// (get) Token: 0x0600351C RID: 13596 RVA: 0x00002050 File Offset: 0x00000250
	PrismPreset CameraClass.GInterface350.PrismPresetPrefab
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000911 RID: 2321
	// (get) Token: 0x0600351D RID: 13597 RVA: 0x00002050 File Offset: 0x00000250
	PostProcessProfile CameraClass.GInterface350.PostProcessProfilePrefab
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000912 RID: 2322
	// (get) Token: 0x0600351E RID: 13598 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600351F RID: 13599 RVA: 0x00002050 File Offset: 0x00000250
	public AmbientType AmbientType
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000913 RID: 2323
	// (get) Token: 0x06003520 RID: 13600 RVA: 0x00002050 File Offset: 0x00000250
	protected bool isTaaHighEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000915 RID: 2325
	// (get) Token: 0x06003521 RID: 13601 RVA: 0x00002050 File Offset: 0x00000250
	public float NorthDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003522 RID: 13602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003523 RID: 13603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPostLoadingScene()
	{
		throw null;
	}

	// Token: 0x06003524 RID: 13604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003525 RID: 13605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplySettings()
	{
		throw null;
	}

	// Token: 0x06003526 RID: 13606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetSceneParameters()
	{
		throw null;
	}

	// Token: 0x06003527 RID: 13607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Camera cam)
	{
		throw null;
	}

	// Token: 0x06003528 RID: 13608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003529 RID: 13609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600352A RID: 13610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600352B RID: 13611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTreeWindSettings()
	{
		throw null;
	}

	// Token: 0x0600352C RID: 13612 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(EAntialiasingMode x)
	{
		throw null;
	}

	// Token: 0x040035F2 RID: 13810
	public Camera CameraPrefab;

	// Token: 0x040035F3 RID: 13811
	public PrismPreset PrismPresetPrefab;

	// Token: 0x040035F4 RID: 13812
	public PostProcessProfile PostProcessProfilePrefab;

	// Token: 0x040035F5 RID: 13813
	public Material skybox;

	// Token: 0x040035F6 RID: 13814
	public Bounds RainBounds;

	// Token: 0x040035F7 RID: 13815
	[Header("Ambient")]
	public AmbientMode AmbientMode;

	// Token: 0x040035F8 RID: 13816
	public Color SkyColor;

	// Token: 0x040035F9 RID: 13817
	public Color EquatorColor;

	// Token: 0x040035FA RID: 13818
	public Color GroundColor;

	// Token: 0x040035FB RID: 13819
	public float AmbientIntensity;

	// Token: 0x040035FC RID: 13820
	[Header("NightVisionAmbient")]
	public Color NightVisionSkyColor;

	// Token: 0x040035FD RID: 13821
	public Color NightVisionEquatorColor;

	// Token: 0x040035FE RID: 13822
	public Color NightVisionGroundColor;

	// Token: 0x040035FF RID: 13823
	public float NightVisionAmbientIntensity;

	// Token: 0x04003600 RID: 13824
	[SerializeField]
	[Space]
	private Color _minSmokeAmbientColor;

	// Token: 0x04003601 RID: 13825
	public float SSRFactor;

	// Token: 0x04003602 RID: 13826
	[Header("Fog")]
	public bool fog;

	// Token: 0x04003603 RID: 13827
	public Color fogColor;

	// Token: 0x04003604 RID: 13828
	public float fogDensity;

	// Token: 0x04003605 RID: 13829
	public float fogEndDistance;

	// Token: 0x04003606 RID: 13830
	public FogMode fogMode;

	// Token: 0x04003607 RID: 13831
	public float fogStartDistance;

	// Token: 0x04003608 RID: 13832
	[Header("Sun")]
	public Color SunColor;

	// Token: 0x04003609 RID: 13833
	public float SunScratchesIntensity;

	// Token: 0x0400360A RID: 13834
	public float SunShaftsIntensity;

	// Token: 0x0400360B RID: 13835
	public float SunShaftsDensity;

	// Token: 0x0400360C RID: 13836
	public bool SunLensFlares;

	// Token: 0x0400360D RID: 13837
	public bool SunBackGroung;

	// Token: 0x0400360E RID: 13838
	public float LyingWater;

	// Token: 0x0400360F RID: 13839
	[Range(0f, 1f)]
	public float DirectionLightShadowForUnshadowedShaders;

	// Token: 0x04003610 RID: 13840
	[Range(0f, 1f)]
	[Header("Scattering")]
	public float HeightFalloff;

	// Token: 0x04003611 RID: 13841
	public float ZeroLevel;

	// Token: 0x04003612 RID: 13842
	private static readonly int int_0;

	// Token: 0x04003613 RID: 13843
	private static readonly int int_1;

	// Token: 0x04003614 RID: 13844
	private static readonly int int_2;

	// Token: 0x04003615 RID: 13845
	private static readonly int int_3;

	// Token: 0x04003616 RID: 13846
	private static readonly int int_4;

	// Token: 0x04003617 RID: 13847
	private static readonly int int_5;

	// Token: 0x04003618 RID: 13848
	[Range(0f, 360f)]
	[SerializeField]
	[Header("Compass")]
	private float _northDirection;

	// Token: 0x04003619 RID: 13849
	[SerializeField]
	public Vector4 MaxMapTextureMemory;

	// Token: 0x0400361A RID: 13850
	[CompilerGenerated]
	private AmbientType ambientType_0;

	// Token: 0x0400361B RID: 13851
	private Action action_0;

	// Token: 0x0400361C RID: 13852
	private IEnumerable<TreeWind> ienumerable_0;

	// Token: 0x0400361D RID: 13853
	private Color color_0;

	// Token: 0x0400361E RID: 13854
	private float float_0;

	// Token: 0x0400361F RID: 13855
	private bool bool_0;

	// Token: 0x04003620 RID: 13856
	private Color color_1;

	// Token: 0x04003621 RID: 13857
	private float float_1;

	// Token: 0x04003622 RID: 13858
	private float float_2;

	// Token: 0x04003623 RID: 13859
	private FogMode fogMode_0;

	// Token: 0x04003624 RID: 13860
	private float float_3;

	// Token: 0x04003625 RID: 13861
	private float float_4;

	// Token: 0x04003626 RID: 13862
	private Material material_0;
}
