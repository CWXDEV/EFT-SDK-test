using System;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000E77 RID: 3703
public static class GClass1053
{
	// Token: 0x06004D79 RID: 19833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupComputeSetDataPartial()
	{
		throw null;
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupComputeTextureUtils()
	{
		throw null;
	}

	// Token: 0x06004D7B RID: 19835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupComputeRuntimeModification()
	{
		throw null;
	}

	// Token: 0x06004D7C RID: 19836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDefaultPath()
	{
		throw null;
	}

	// Token: 0x04005918 RID: 22808
	public static GPUInstancerSettings gpuiSettings;

	// Token: 0x04005919 RID: 22809
	public static readonly Matrix4x4 zeroMatrix;

	// Token: 0x0400591A RID: 22810
	public static readonly int STRIDE_SIZE_MATRIX4X4;

	// Token: 0x0400591B RID: 22811
	public static readonly int STRIDE_SIZE_BOOL;

	// Token: 0x0400591C RID: 22812
	public static readonly int STRIDE_SIZE_INT;

	// Token: 0x0400591D RID: 22813
	public static readonly int STRIDE_SIZE_FLOAT;

	// Token: 0x0400591E RID: 22814
	public static readonly int STRIDE_SIZE_FLOAT4;

	// Token: 0x0400591F RID: 22815
	public const float FADE_DIST = 5f;

	// Token: 0x04005920 RID: 22816
	public static float COMPUTE_SHADER_THREAD_COUNT;

	// Token: 0x04005921 RID: 22817
	public static float COMPUTE_SHADER_THREAD_COUNT_2D;

	// Token: 0x04005922 RID: 22818
	public static int COMPUTE_MAX_LOD_BUFFER;

	// Token: 0x04005923 RID: 22819
	public static int TEXTURE_MAX_SIZE;

	// Token: 0x04005924 RID: 22820
	public static bool DETAIL_STORE_INSTANCE_DATA;

	// Token: 0x04005925 RID: 22821
	public static readonly string GUID_COMPUTE_PLATFORM_DEFINES;

	// Token: 0x04005926 RID: 22822
	public static readonly string GUID_CGINC_PLATFORM_DEPENDENT;

	// Token: 0x04005927 RID: 22823
	public static readonly string[] CAMERA_COMPUTE_KERNELS;

	// Token: 0x04005928 RID: 22824
	public static readonly string[] VISIBILITY_COMPUTE_KERNELS;

	// Token: 0x04005929 RID: 22825
	public static readonly string CAMERA_COMPUTE_RESOURCE_PATH;

	// Token: 0x0400592A RID: 22826
	public static readonly string CAMERA_VR_COMPUTE_RESOURCE_PATH;

	// Token: 0x0400592B RID: 22827
	public static readonly string VISIBILITY_COMPUTE_RESOURCE_PATH;

	// Token: 0x0400592C RID: 22828
	public static readonly string VISIBILITY_COMPUTE_RESOURCE_PATH_VULKAN;

	// Token: 0x0400592D RID: 22829
	public static readonly string BUFFER_TO_TEXTURE_COMPUTE_RESOURCE_PATH;

	// Token: 0x0400592E RID: 22830
	public static readonly string BUFFER_TO_TEXTURE_KERNEL;

	// Token: 0x0400592F RID: 22831
	public static readonly int BUFFER_COROUTINE_STEP_NUMBER;

	// Token: 0x04005930 RID: 22832
	public static int DETAIL_BUFFER_MERGE_FRAME_LIMIT;

	// Token: 0x04005931 RID: 22833
	public static readonly string COMPUTE_SET_DATA_PARTIAL_RESOURCE_PATH;

	// Token: 0x04005932 RID: 22834
	public static readonly string COMPUTE_SET_DATA_PARTIAL_KERNEL;

	// Token: 0x04005933 RID: 22835
	public static readonly string COMPUTE_SET_DATA_SINGLE_KERNEL;

	// Token: 0x04005934 RID: 22836
	public static ComputeShader computeBufferSetDataPartial;

	// Token: 0x04005935 RID: 22837
	public static int computeBufferSetDataPartialKernelId;

	// Token: 0x04005936 RID: 22838
	public static int computeBufferSetDataSingleKernelId;

	// Token: 0x04005937 RID: 22839
	public static readonly string COMPUTE_BILLBOARD_RESOURCE_PATH;

	// Token: 0x04005938 RID: 22840
	public static readonly string COMPUTE_BILLBOARD_DILATION_KERNEL;

	// Token: 0x04005939 RID: 22841
	public static readonly string COMPUTE_TEXTURE_UTILS_PATH;

	// Token: 0x0400593A RID: 22842
	public static readonly string COMPUTE_COPY_TEXTURE_KERNEL;

	// Token: 0x0400593B RID: 22843
	public static ComputeShader computeTextureUtils;

	// Token: 0x0400593C RID: 22844
	public static int computeTextureUtilsCopyTextureId;

	// Token: 0x0400593D RID: 22845
	public static readonly string GRASS_INSTANTIATION_KERNEL;

	// Token: 0x0400593E RID: 22846
	public static readonly string GRASS_INSTANTIATION_RESOURCE_PATH;

	// Token: 0x0400593F RID: 22847
	public static readonly string TREE_INSTANTIATION_KERNEL;

	// Token: 0x04005940 RID: 22848
	public static readonly string TREE_INSTANTIATION_RESOURCE_PATH;

	// Token: 0x04005941 RID: 22849
	public static readonly string COMPUTE_RUNTIME_MODIFICATION_RESOURCE_PATH;

	// Token: 0x04005942 RID: 22850
	public static readonly string COMPUTE_TRANSFORM_OFFSET_KERNEL;

	// Token: 0x04005943 RID: 22851
	public static readonly string COMPUTE_REMOVE_INSIDE_BOUNDS_KERNEL;

	// Token: 0x04005944 RID: 22852
	public static readonly string COMPUTE_REMOVE_INSIDE_BOX_KERNEL;

	// Token: 0x04005945 RID: 22853
	public static readonly string COMPUTE_REMOVE_INSIDE_SPHERE_KERNEL;

	// Token: 0x04005946 RID: 22854
	public static readonly string COMPUTE_REMOVE_INSIDE_CAPSULE_KERNEL;

	// Token: 0x04005947 RID: 22855
	public static ComputeShader computeRuntimeModification;

	// Token: 0x04005948 RID: 22856
	public static int computeBufferTransformOffsetId;

	// Token: 0x04005949 RID: 22857
	public static int computeRemoveInsideBoundsId;

	// Token: 0x0400594A RID: 22858
	public static int computeRemoveInsideBoxId;

	// Token: 0x0400594B RID: 22859
	public static int computeRemoveInsideSphereId;

	// Token: 0x0400594C RID: 22860
	public static int computeRemoveInsideCapsuleId;

	// Token: 0x0400594D RID: 22861
	public static readonly string SHADER_UNITY_STANDARD;

	// Token: 0x0400594E RID: 22862
	public static readonly string SHADER_UNITY_STANDARD_SPECULAR;

	// Token: 0x0400594F RID: 22863
	public static readonly string SHADER_UNITY_STANDARD_ROUGHNESS;

	// Token: 0x04005950 RID: 22864
	public static readonly string SHADER_UNITY_VERTEXLIT;

	// Token: 0x04005951 RID: 22865
	public static readonly string SHADER_UNITY_SPEED_TREE;

	// Token: 0x04005952 RID: 22866
	public static readonly string SHADER_UNITY_SPEED_TREE_8;

	// Token: 0x04005953 RID: 22867
	public static readonly string SHADER_UNITY_TREE_CREATOR_BARK;

	// Token: 0x04005954 RID: 22868
	public static readonly string SHADER_UNITY_TREE_CREATOR_BARK_OPTIMIZED;

	// Token: 0x04005955 RID: 22869
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES;

	// Token: 0x04005956 RID: 22870
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_OPTIMIZED;

	// Token: 0x04005957 RID: 22871
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_FAST;

	// Token: 0x04005958 RID: 22872
	public static readonly string SHADER_UNITY_TREE_CREATOR_LEAVES_FAST_OPTIMIZED;

	// Token: 0x04005959 RID: 22873
	public static readonly string SHADER_UNITY_TREE_SOFT_OCCLUSION_BARK;

	// Token: 0x0400595A RID: 22874
	public static readonly string SHADER_UNITY_TREE_SOFT_OCCLUSION_LEAVES;

	// Token: 0x0400595B RID: 22875
	public static readonly string SHADER_UNITY_INTERNAL_ERROR;

	// Token: 0x0400595C RID: 22876
	public static readonly string SHADER_GPUI_STANDARD;

	// Token: 0x0400595D RID: 22877
	public static readonly string SHADER_GPUI_STANDARD_SPECULAR;

	// Token: 0x0400595E RID: 22878
	public static readonly string SHADER_GPUI_STANDARD_ROUGHNESS;

	// Token: 0x0400595F RID: 22879
	public static readonly string SHADER_GPUI_VERTEXLIT;

	// Token: 0x04005960 RID: 22880
	public static readonly string SHADER_GPUI_FOLIAGE;

	// Token: 0x04005961 RID: 22881
	public static readonly string SHADER_GPUI_FOLIAGE_LWRP;

	// Token: 0x04005962 RID: 22882
	public static readonly string SHADER_GPUI_SHADOWS_ONLY;

	// Token: 0x04005963 RID: 22883
	public static readonly string SHADER_GPUI_HIZ_OCCLUSION_GENERATOR;

	// Token: 0x04005964 RID: 22884
	public static readonly string SHADER_GPUI_HIZ_OCCLUSION_DEBUGGER;

	// Token: 0x04005965 RID: 22885
	public static readonly string SHADER_GPUI_SPEED_TREE;

	// Token: 0x04005966 RID: 22886
	public static readonly string SHADER_GPUI_SPEED_TREE_8;

	// Token: 0x04005967 RID: 22887
	public static readonly string SHADER_GPUI_TREE_PROXY;

	// Token: 0x04005968 RID: 22888
	public static readonly string SHADER_GPUI_TREE_CREATOR_BARK;

	// Token: 0x04005969 RID: 22889
	public static readonly string SHADER_GPUI_TREE_CREATOR_BARK_OPTIMIZED;

	// Token: 0x0400596A RID: 22890
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES;

	// Token: 0x0400596B RID: 22891
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_OPTIMIZED;

	// Token: 0x0400596C RID: 22892
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_FAST;

	// Token: 0x0400596D RID: 22893
	public static readonly string SHADER_GPUI_TREE_CREATOR_LEAVES_FAST_OPTIMIZED;

	// Token: 0x0400596E RID: 22894
	public static readonly string SHADER_GPUI_TREE_SOFT_OCCLUSION_BARK;

	// Token: 0x0400596F RID: 22895
	public static readonly string SHADER_GPUI_TREE_SOFT_OCCLUSION_LEAVES;

	// Token: 0x04005970 RID: 22896
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_TREE;

	// Token: 0x04005971 RID: 22897
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_TREECREATOR;

	// Token: 0x04005972 RID: 22898
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_SOFTOCCLUSION;

	// Token: 0x04005973 RID: 22899
	public static readonly string SHADER_GPUI_BILLBOARD_2D_RENDERER_STANDARD;

	// Token: 0x04005974 RID: 22900
	public static readonly string SHADER_GPUI_BILLBOARD_ALBEDO_BAKER;

	// Token: 0x04005975 RID: 22901
	public static readonly string SHADER_GPUI_BILLBOARD_NORMAL_BAKER;

	// Token: 0x04005976 RID: 22902
	public static readonly string DEFAULT_PATH_GUID;

	// Token: 0x04005977 RID: 22903
	public static readonly string RESOURCES_PATH;

	// Token: 0x04005978 RID: 22904
	public static readonly string SETTINGS_PATH;

	// Token: 0x04005979 RID: 22905
	public static readonly string SHADERS_PATH;

	// Token: 0x0400597A RID: 22906
	public static readonly string EDITOR_TEXTURES_PATH;

	// Token: 0x0400597B RID: 22907
	public static readonly string NOISE_TEXTURES_PATH;

	// Token: 0x0400597C RID: 22908
	public static readonly string GPUI_SETTINGS_DEFAULT_NAME;

	// Token: 0x0400597D RID: 22909
	public static readonly string SHADER_BINDINGS_DEFAULT_NAME;

	// Token: 0x0400597E RID: 22910
	public static readonly string BILLBOARD_ATLAS_BINDINGS_DEFAULT_NAME;

	// Token: 0x0400597F RID: 22911
	public static readonly string SHADER_VARIANT_COLLECTION_DEFAULT_NAME;

	// Token: 0x04005980 RID: 22912
	public static readonly string PROTOTYPES_TERRAIN_PATH;

	// Token: 0x04005981 RID: 22913
	public static readonly string PROTOTYPES_PREFAB_PATH;

	// Token: 0x04005982 RID: 22914
	public static readonly string PROTOTYPES_BILLBOARD_TEXTURES_PATH;

	// Token: 0x04005983 RID: 22915
	public static readonly string PROTOTYPES_SHADERS_PATH;

	// Token: 0x04005984 RID: 22916
	public static readonly string PROTOTYPES_SERIALIZED_PATH;

	// Token: 0x04005985 RID: 22917
	private static string string_0;

	// Token: 0x04005986 RID: 22918
	public static readonly string DEFAULT_HEALTHY_DRY_NOISE;

	// Token: 0x04005987 RID: 22919
	public static readonly string DEFAULT_WIND_WAVE_NOISE;

	// Token: 0x04005988 RID: 22920
	public static readonly string ERRORTEXT_cameraNotFound;

	// Token: 0x04005989 RID: 22921
	public static readonly int DEBUG_INFO_SIZE;

	// Token: 0x02000E78 RID: 3704
	public static class GClass1054
	{
		// Token: 0x0400598A RID: 22922
		public static readonly int TRANSFORMATION_MATRIX_TEXTURE;
	}

	// Token: 0x02000E79 RID: 3705
	public static class GClass1055
	{
		// Token: 0x0400598B RID: 22923
		public static readonly int TRANSFORMATION_MATRIX_BUFFER;

		// Token: 0x0400598C RID: 22924
		public static readonly int INSTANCE_LOD_BUFFER;

		// Token: 0x0400598D RID: 22925
		public static readonly int[] TRANSFORMATION_MATRIX_APPEND_BUFFERS;

		// Token: 0x0400598E RID: 22926
		public static readonly int INSTANCE_DATA_BUFFER;

		// Token: 0x0400598F RID: 22927
		public static readonly int RENDERER_TRANSFORM_OFFSET;

		// Token: 0x04005990 RID: 22928
		public static readonly int BUFFER_PARAMETER_MVP_MATRIX;

		// Token: 0x04005991 RID: 22929
		public static readonly int BUFFER_PARAMETER_MVP_MATRIX2;

		// Token: 0x04005992 RID: 22930
		public static readonly int BUFFER_PARAMETER_BOUNDS_CENTER;

		// Token: 0x04005993 RID: 22931
		public static readonly int BUFFER_PARAMETER_BOUNDS_EXTENTS;

		// Token: 0x04005994 RID: 22932
		public static readonly int BUFFER_PARAMETER_FRUSTUM_CULL_SWITCH;

		// Token: 0x04005995 RID: 22933
		public static readonly int BUFFER_PARAMETER_HIERARCHICAL_Z_TEXTURE_SIZE;

		// Token: 0x04005996 RID: 22934
		public static readonly int BUFFER_PARAMETER_FRUSTUM_OFFSET;

		// Token: 0x04005997 RID: 22935
		public static readonly int BUFFER_PARAMETER_MIN_VIEW_DISTANCE;

		// Token: 0x04005998 RID: 22936
		public static readonly int BUFFER_PARAMETER_MAX_VIEW_DISTANCE;

		// Token: 0x04005999 RID: 22937
		public static readonly int BUFFER_PARAMETER_CAMERA_POSITION;

		// Token: 0x0400599A RID: 22938
		public static readonly int BUFFER_PARAMETER_BUFFER_SIZE;

		// Token: 0x0400599B RID: 22939
		public static readonly int BUFFER_PARAMETER_OCCLUSION_OFFSET;

		// Token: 0x0400599C RID: 22940
		public static readonly int BUFFER_PARAMETER_OCCLUSION_ACCURACY;

		// Token: 0x0400599D RID: 22941
		public static readonly int BUFFER_PARAMETER_SHADOW_DISTANCE;

		// Token: 0x0400599E RID: 22942
		public static readonly int BUFFER_PARAMETER_LOD_SIZES;

		// Token: 0x0400599F RID: 22943
		public static readonly int BUFFER_PARAMETER_LOD_SHIFT;

		// Token: 0x040059A0 RID: 22944
		public static readonly int BUFFER_PARAMETER_LOD_APPEND_INDEX;

		// Token: 0x040059A1 RID: 22945
		public static readonly int BUFFER_PARAMETER_LOD_COUNT;

		// Token: 0x040059A2 RID: 22946
		public static readonly int BUFFER_PARAMETER_LOD_LEVEL;

		// Token: 0x040059A3 RID: 22947
		public static readonly int BUFFER_PARAMETER_HALF_ANGLE;

		// Token: 0x040059A4 RID: 22948
		public static readonly int BUFFER_PARAMETER_ANIMATE_CROSS_FADE;

		// Token: 0x040059A5 RID: 22949
		public static readonly int BUFFER_PARAMETER_DELTA_TIME;

		// Token: 0x040059A6 RID: 22950
		public static readonly int BUFFER_PARAMETER_FADE_LEVEL_MULTIPLIER;

		// Token: 0x040059A7 RID: 22951
		public static readonly int BUFFER_PARAMETER_OCCLUSION_CULL_SWITCH;

		// Token: 0x040059A8 RID: 22952
		public static readonly int BUFFER_PARAMETER_HIERARCHICAL_Z_TEXTURE_MAP;

		// Token: 0x040059A9 RID: 22953
		public static readonly int BUFFER_PARAMETER_MIN_CULLING_DISTANCE;

		// Token: 0x040059AA RID: 22954
		public static readonly int BUFFER_PARAMETER_SHADOW_LOD_MAP;

		// Token: 0x040059AB RID: 22955
		public static readonly int BUFFER_PARAMETER_CULL_SHADOW;
	}

	// Token: 0x02000E7A RID: 3706
	public static class GClass1056
	{
		// Token: 0x040059AC RID: 22956
		public static readonly int BUFFER_PARAMETER_MANAGED_BUFFER_DATA;

		// Token: 0x040059AD RID: 22957
		public static readonly int BUFFER_PARAMETER_COMPUTE_BUFFER_START_INDEX;

		// Token: 0x040059AE RID: 22958
		public static readonly int BUFFER_PARAMETER_COUNT;

		// Token: 0x040059AF RID: 22959
		public static readonly int BUFFER_PARAMETER_DATA_TO_SET;
	}

	// Token: 0x02000E7B RID: 3707
	public static class GClass1057
	{
		// Token: 0x040059B0 RID: 22960
		public static readonly int SOURCE_TEXTURE;

		// Token: 0x040059B1 RID: 22961
		public static readonly int DESTINATION_TEXTURE;

		// Token: 0x040059B2 RID: 22962
		public static readonly int OFFSET_X;

		// Token: 0x040059B3 RID: 22963
		public static readonly int SOURCE_SIZE_X;

		// Token: 0x040059B4 RID: 22964
		public static readonly int SOURCE_SIZE_Y;

		// Token: 0x040059B5 RID: 22965
		public static readonly int DESTINATION_SIZE_X;

		// Token: 0x040059B6 RID: 22966
		public static readonly int DESTINATION_SIZE_Y;

		// Token: 0x040059B7 RID: 22967
		public static readonly int REVERSE_Z;
	}

	// Token: 0x02000E7C RID: 3708
	public static class GClass1058
	{
		// Token: 0x040059B8 RID: 22968
		public static readonly int DETAIL_MAP_DATA_BUFFER;

		// Token: 0x040059B9 RID: 22969
		public static readonly int HEIGHT_MAP_DATA_BUFFER;

		// Token: 0x040059BA RID: 22970
		public static readonly int COUNTER_BUFFER;

		// Token: 0x040059BB RID: 22971
		public static readonly int COUNT_FACTOR;

		// Token: 0x040059BC RID: 22972
		public static readonly int TERRAIN_DETAIL_RESOLUTION_DATA;

		// Token: 0x040059BD RID: 22973
		public static readonly int TERRAIN_HEIGHT_RESOLUTION_DATA;

		// Token: 0x040059BE RID: 22974
		public static readonly int GRASS_START_POSITION_DATA;

		// Token: 0x040059BF RID: 22975
		public static readonly int TERRAIN_SIZE_DATA;

		// Token: 0x040059C0 RID: 22976
		public static readonly int DETAIL_SCALE_DATA;

		// Token: 0x040059C1 RID: 22977
		public static readonly int DETAIL_AND_HEIGHT_MAP_SIZE_DATA;

		// Token: 0x040059C2 RID: 22978
		public static readonly int HEALTHY_DRY_NOISE_TEXTURE;

		// Token: 0x040059C3 RID: 22979
		public static readonly int NOISE_SPREAD;

		// Token: 0x040059C4 RID: 22980
		public static readonly int DETAIL_UNIQUE_VALUE;

		// Token: 0x040059C5 RID: 22981
		public static readonly int DETAIL_DENSITY;

		// Token: 0x040059C6 RID: 22982
		public static readonly int DETAIL_TERRAIN_NORMAL;
	}

	// Token: 0x02000E7D RID: 3709
	public static class GClass1059
	{
		// Token: 0x040059C7 RID: 22983
		public static readonly int TREE_DATA;

		// Token: 0x040059C8 RID: 22984
		public static readonly int TREE_SCALES;

		// Token: 0x040059C9 RID: 22985
		public static readonly int TERRAIN_POSITION;

		// Token: 0x040059CA RID: 22986
		public static readonly int IS_APPLY_ROTATION;

		// Token: 0x040059CB RID: 22987
		public static readonly int IS_APPLY_TERRAIN_HEIGHT;

		// Token: 0x040059CC RID: 22988
		public static readonly int PROTOTYPE_INDEX;
	}

	// Token: 0x02000E7E RID: 3710
	public static class GClass1060
	{
		// Token: 0x040059CD RID: 22989
		public static readonly int BUFFER_PARAMETER_POSITION_OFFSET;

		// Token: 0x040059CE RID: 22990
		public static readonly int BUFFER_PARAMETER_MODIFIER_TRANSFORM;

		// Token: 0x040059CF RID: 22991
		public static readonly int BUFFER_PARAMETER_MODIFIER_RADIUS;

		// Token: 0x040059D0 RID: 22992
		public static readonly int BUFFER_PARAMETER_MODIFIER_HEIGHT;

		// Token: 0x040059D1 RID: 22993
		public static readonly int BUFFER_PARAMETER_MODIFIER_AXIS;
	}
}
