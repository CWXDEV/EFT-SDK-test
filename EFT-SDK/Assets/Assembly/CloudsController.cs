using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B89 RID: 2953
[ExecuteAlways]
public class CloudsController : MonoBehaviour
{
	// Token: 0x17000A62 RID: 2658
	// (set) Token: 0x06004020 RID: 16416 RVA: 0x00002050 File Offset: 0x00000250
	public float FogDensity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000A63 RID: 2659
	// (get) Token: 0x06004022 RID: 16418 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004021 RID: 16417 RVA: 0x00002050 File Offset: 0x00000250
	public float Density
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

	// Token: 0x06004023 RID: 16419 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh()
	{
		throw null;
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlayer(Transform player)
	{
		throw null;
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x040048C4 RID: 18628
	private static readonly int int_0;

	// Token: 0x040048C5 RID: 18629
	private static readonly int int_1;

	// Token: 0x040048C6 RID: 18630
	private static readonly int int_2;

	// Token: 0x040048C7 RID: 18631
	private static readonly int int_3;

	// Token: 0x040048C8 RID: 18632
	private static readonly int int_4;

	// Token: 0x040048C9 RID: 18633
	private static readonly int int_5;

	// Token: 0x040048CA RID: 18634
	private static readonly int int_6;

	// Token: 0x040048CB RID: 18635
	private static readonly int int_7;

	// Token: 0x040048CC RID: 18636
	private static readonly int int_8;

	// Token: 0x040048CD RID: 18637
	private static readonly int int_9;

	// Token: 0x040048CE RID: 18638
	private static readonly int int_10;

	// Token: 0x040048CF RID: 18639
	private static readonly int int_11;

	// Token: 0x040048D0 RID: 18640
	private static readonly int int_12;

	// Token: 0x040048D1 RID: 18641
	private static readonly int int_13;

	// Token: 0x040048D2 RID: 18642
	public static CloudsController Instance;

	// Token: 0x040048D3 RID: 18643
	public Mesh Icosphere;

	// Token: 0x040048D4 RID: 18644
	public Material CloudMaterial;

	// Token: 0x040048D5 RID: 18645
	public Material CloudShadowMaterial;

	// Token: 0x040048D6 RID: 18646
	public Material CloudLightMaterial;

	// Token: 0x040048D7 RID: 18647
	public Material CloudPointLightMaterial;

	// Token: 0x040048D8 RID: 18648
	public float FogDensityMultyplier;

	// Token: 0x040048D9 RID: 18649
	public float SunPositionUpdateDeltaSqrMangitude;

	// Token: 0x040048DA RID: 18650
	public CloudsController.CloudLayer[] CloudLayers;

	// Token: 0x040048DB RID: 18651
	public CloudsController.CloudShadows Shadows;

	// Token: 0x040048DC RID: 18652
	public CloudsController.CloudAutomatization Automatization;

	// Token: 0x040048DD RID: 18653
	public Vector2 CloudPosition;

	// Token: 0x040048DE RID: 18654
	private float float_0;

	// Token: 0x040048DF RID: 18655
	private Mesh mesh_0;

	// Token: 0x02000B8A RID: 2954
	[Serializable]
	public class CloudAutomatization
	{
		// Token: 0x06004029 RID: 16425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(CloudsController.CloudLayer[] cloudLayers)
		{
			throw null;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Color method_0(TOD_Sky todSky, float t)
		{
			throw null;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Color method_1(TOD_Sky todSky, float t)
		{
			throw null;
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(CloudsController.CloudLayer[] cloudLayers, Color cloudColor, Color sunMultyplyer, Color bottomReflections, Color cloudySun, float planetSize)
		{
			throw null;
		}

		// Token: 0x040048E0 RID: 18656
		[Header("midnight(left) sunrize/sunset(center) midday(right)")]
		public Gradient CloudColor;

		// Token: 0x040048E1 RID: 18657
		public Gradient SunMultyplyer;

		// Token: 0x040048E2 RID: 18658
		public Gradient BottomReflections;

		// Token: 0x040048E3 RID: 18659
		public Gradient CloudySun;

		// Token: 0x040048E4 RID: 18660
		[Range(0f, 1f)]
		public float CloudColorOvercast;

		// Token: 0x040048E5 RID: 18661
		[Range(0f, 1f)]
		public float SunMultyplyerOvercast;

		// Token: 0x040048E6 RID: 18662
		[Range(0f, 50f)]
		public float PlanetSizeOvercast;
	}

	// Token: 0x02000B8B RID: 2955
	[Serializable]
	public class CloudLayer
	{
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600402D RID: 16429 RVA: 0x00002050 File Offset: 0x00000250
		public float Density
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private get
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

		// Token: 0x17000A65 RID: 2661
		// (set) Token: 0x0600402F RID: 16431 RVA: 0x00002050 File Offset: 0x00000250
		public float FogDensity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetRealDensity()
		{
			throw null;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightSettings(Texture lightMap, Vector4 matTransform, Vector4 lightPosition)
		{
			throw null;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightIntensity(Color lightIntensity, Color pointLightIntensity)
		{
			throw null;
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(string name, Color color)
		{
			throw null;
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFloat(string name, float value)
		{
			throw null;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(bool full = true)
		{
			throw null;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 GetCloudPosition(Vector2 cloudPosition)
		{
			throw null;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(int index, int layer)
		{
			throw null;
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Vector2 cloudPosition, float density, int index)
		{
			throw null;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector2 cloudPosition, float density, int layer)
		{
			throw null;
		}

		// Token: 0x040048E7 RID: 18663
		public bool Enabled;

		// Token: 0x040048E8 RID: 18664
		[Range(0f, 1f)]
		public float RoughnessMin;

		// Token: 0x040048E9 RID: 18665
		[Range(0f, 1f)]
		public float NoiseMapRoughness;

		// Token: 0x040048EA RID: 18666
		[Range(-1f, 1f)]
		public float DensityShift;

		// Token: 0x040048EB RID: 18667
		[Space(16f)]
		public float Height;

		// Token: 0x040048EC RID: 18668
		public float Curviness;

		// Token: 0x040048ED RID: 18669
		public float Scale;

		// Token: 0x040048EE RID: 18670
		[Space(16f)]
		public float CloudPositionMultyply;

		// Token: 0x040048EF RID: 18671
		public Vector2 CloudPositionShift;

		// Token: 0x040048F0 RID: 18672
		[Range(0f, 1f)]
		[Space(16f)]
		public float ShadowStrength;

		// Token: 0x040048F1 RID: 18673
		[HideInInspector]
		public bool IsDrawLight;

		// Token: 0x040048F2 RID: 18674
		private Material _cloudMaterial;

		// Token: 0x040048F3 RID: 18675
		private Material _lightMaterial;

		// Token: 0x040048F4 RID: 18676
		private Material _pointLightMaterial;

		// Token: 0x040048F5 RID: 18677
		private MaterialPropertyBlock _cloudBlock;

		// Token: 0x040048F6 RID: 18678
		private MaterialPropertyBlock _lightBlock;

		// Token: 0x040048F7 RID: 18679
		private MaterialPropertyBlock _pointLightBlock;

		// Token: 0x040048F8 RID: 18680
		private MaterialPropertyBlock[] _materialBlocks;

		// Token: 0x040048F9 RID: 18681
		private Texture _lightMap;

		// Token: 0x040048FA RID: 18682
		private Vector4 _matTransform;

		// Token: 0x040048FB RID: 18683
		private Vector4 _lightPosition;

		// Token: 0x040048FC RID: 18684
		private Color _lightIntensity;

		// Token: 0x040048FD RID: 18685
		private Color _pointLightIntensity;
	}

	// Token: 0x02000B8C RID: 2956
	[Serializable]
	public class CloudShadows
	{
		// Token: 0x0600403C RID: 16444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(CloudsController.CloudLayer[] cloudLayers, Transform player, Transform light)
		{
			throw null;
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(CloudsController.CloudLayer[] cloudLayers, Vector2 cloudPosition)
		{
			throw null;
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy()
		{
			throw null;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0(CloudsController.CloudShadows.ECommandBufferVariant commandBufferVariant)
		{
			throw null;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(IReadOnlyList<CloudsController.CloudLayer> cloudLayers, Vector2 cloudPosition)
		{
			throw null;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(CommandBuffer commandBuffer, IReadOnlyList<CloudsController.CloudLayer> cloudLayers)
		{
			throw null;
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IEnumerable<CloudsController.CloudLayer> cloudLayers, float hide)
		{
			throw null;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(CommandBuffer commandBuffer)
		{
			throw null;
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Texture source, float blurInPixels, float intensity = 1f)
		{
			throw null;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(CommandBuffer commandBuffer, RenderTexture source, RenderTexture temp)
		{
			throw null;
		}

		// Token: 0x040048FE RID: 18686
		private int _lightdirection_ID;

		// Token: 0x040048FF RID: 18687
		private int _sunmatrix_ID;

		// Token: 0x04004900 RID: 18688
		private int _cloudroughnessmin_ID;

		// Token: 0x04004901 RID: 18689
		private int _cloudnoisemaproughness_ID;

		// Token: 0x04004902 RID: 18690
		private int _clouddensity_ID;

		// Token: 0x04004903 RID: 18691
		private int _cloudcurviness_ID;

		// Token: 0x04004904 RID: 18692
		private int _cloudscale_ID;

		// Token: 0x04004905 RID: 18693
		private int _cloudposition_ID;

		// Token: 0x04004906 RID: 18694
		private int _shadowscale_ID;

		// Token: 0x04004907 RID: 18695
		private int _shadowstrength_ID;

		// Token: 0x04004908 RID: 18696
		private int _addColorFieldID;

		// Token: 0x04004909 RID: 18697
		private int _multColorFieldID;

		// Token: 0x0400490A RID: 18698
		private int _intensityFieldID;

		// Token: 0x0400490B RID: 18699
		private int _blurOffsets0FieldID;

		// Token: 0x0400490C RID: 18700
		public Material CloudShadowMaterial;

		// Token: 0x0400490D RID: 18701
		public int TextureSize;

		// Token: 0x0400490E RID: 18702
		public float Blur;

		// Token: 0x0400490F RID: 18703
		public float ViewDistance;

		// Token: 0x04004910 RID: 18704
		public float ShadowScale;

		// Token: 0x04004911 RID: 18705
		private Material[] _cloudShadowMaterial;

		// Token: 0x04004912 RID: 18706
		private Material _cloudModifyMaterial;

		// Token: 0x04004913 RID: 18707
		private Material _cloudBlurMaterial0;

		// Token: 0x04004914 RID: 18708
		private Material _cloudBlurMaterial1;

		// Token: 0x04004915 RID: 18709
		private Material _cloudColorBlendMaterial;

		// Token: 0x04004916 RID: 18710
		private Transform _playerT;

		// Token: 0x04004917 RID: 18711
		private Vector3 _lastPlayerPosition;

		// Token: 0x04004918 RID: 18712
		private Transform _lightT;

		// Token: 0x04004919 RID: 18713
		private RenderTexture _renderTexture0;

		// Token: 0x0400491A RID: 18714
		private RenderTexture _renderTexture1;

		// Token: 0x0400491B RID: 18715
		private Light _light;

		// Token: 0x0400491C RID: 18716
		private CommandBuffer[] _commandBuffer;

		// Token: 0x0400491D RID: 18717
		private readonly CameraEvent _cameraEvent;

		// Token: 0x0400491E RID: 18718
		private CloudsController.CloudShadows.ECommandBufferVariant _prevCommandBufferVariant;

		// Token: 0x02000B8D RID: 2957
		[Flags]
		private enum ECommandBufferVariant : byte
		{
			// Token: 0x04004920 RID: 18720
			Blur = 1,
			// Token: 0x04004921 RID: 18721
			Modify = 2,
			// Token: 0x04004922 RID: 18722
			Draw = 4
		}
	}
}
