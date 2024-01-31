using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E88 RID: 3720
	[Serializable]
	public class GPUInstancerSettings : ScriptableObject
	{
		// Token: 0x06004D8B RID: 19851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetDefaultDetailDistance(bool isOptic)
		{
			throw null;
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetDefaultFrustumOffset(bool isOptic)
		{
			throw null;
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetDefaultDetailCellSize(bool isOptic)
		{
			throw null;
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetDefaultDetailDensity(Terrain terrain, bool isOptic)
		{
			throw null;
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddExtension(GPUInstancerSettingsExtension extension)
		{
			throw null;
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GPUInstancerSettings GetDefaultGPUInstancerSettings()
		{
			throw null;
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefultBindings()
		{
			throw null;
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefaultGPUInstancerShaderBindings()
		{
			throw null;
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GPUInstancerShaderBindings GetDefaultGPUInstancerShaderBindings()
		{
			throw null;
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefaultGPUInstancerBillboardAtlasBindings()
		{
			throw null;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GPUInstancerBillboardAtlasBindings GetDefaultGPUInstancerBillboardAtlasBindings()
		{
			throw null;
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefaultShaderVariantCollection()
		{
			throw null;
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ShaderVariantCollection GetDefaultShaderVariantCollection()
		{
			throw null;
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefaultShaderVariants()
		{
			throw null;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddShaderVariantToCollection(string shaderName, string extensionCode = null)
		{
			throw null;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddShaderVariantToCollection(Material material, string extensionCode = null)
		{
			throw null;
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GPUIMatrixHandlingType GetMatrixHandlingType(GPUIPlatform platform)
		{
			throw null;
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GPUIComputeThreadCount GetComputeThreadCount(GPUIPlatform platform)
		{
			throw null;
		}

		// Token: 0x04005A37 RID: 23095
		public float versionNo;

		// Token: 0x04005A38 RID: 23096
		public GPUInstancerShaderBindings shaderBindings;

		// Token: 0x04005A39 RID: 23097
		public GPUInstancerBillboardAtlasBindings billboardAtlasBindings;

		// Token: 0x04005A3A RID: 23098
		public ShaderVariantCollection shaderVariantCollection;

		// Token: 0x04005A3B RID: 23099
		public bool packagesLoaded;

		// Token: 0x04005A3C RID: 23100
		public bool isHDRP;

		// Token: 0x04005A3D RID: 23101
		public bool isLWRP;

		// Token: 0x04005A3E RID: 23102
		public bool isShaderGraphPresent;

		// Token: 0x04005A3F RID: 23103
		public int instancingBoundsSize;

		// Token: 0x04005A40 RID: 23104
		public float MAX_DETAIL_DISTANCE;

		// Token: 0x04005A41 RID: 23105
		public float MAX_TREE_DISTANCE;

		// Token: 0x04005A42 RID: 23106
		public float MAX_PREFAB_DISTANCE;

		// Token: 0x04005A43 RID: 23107
		public int MAX_PREFAB_EXTRA_BUFFER_SIZE;

		// Token: 0x04005A44 RID: 23108
		public Vector2Int DEFAULT_DETAIL_DISTANCE;

		// Token: 0x04005A45 RID: 23109
		public Vector2Int DEFAULT_DETAIL_CELL_SIZE;

		// Token: 0x04005A46 RID: 23110
		public Vector2 DEFAULT_DETAIL_DENSITY_FACTOR;

		// Token: 0x04005A47 RID: 23111
		public Vector2 DEFAULT_FRUSTUM_OFFSET;

		// Token: 0x04005A48 RID: 23112
		public bool DEFAULT_USE_DENSITY_MASK;

		// Token: 0x04005A49 RID: 23113
		public float DEFAULT_GRASS_SHADOW_DISTANCE;

		// Token: 0x04005A4A RID: 23114
		public bool useCustomPreviewBackgroundColor;

		// Token: 0x04005A4B RID: 23115
		public Color previewBackgroundColor;

		// Token: 0x04005A4C RID: 23116
		public bool disableAutoGenerateBillboards;

		// Token: 0x04005A4D RID: 23117
		public bool disableShaderVariantCollection;

		// Token: 0x04005A4E RID: 23118
		public bool disableInstanceCountWarning;

		// Token: 0x04005A4F RID: 23119
		public bool disableAutoShaderConversion;

		// Token: 0x04005A50 RID: 23120
		public bool disableAutoVariantHandling;

		// Token: 0x04005A51 RID: 23121
		public bool testBothEyesForVROcclusion;

		// Token: 0x04005A52 RID: 23122
		public int vrRenderingMode;

		// Token: 0x04005A53 RID: 23123
		public List<GPUInstancerSettingsExtension> extensionSettings;

		// Token: 0x04005A54 RID: 23124
		public List<GPUInstancerSettings.GPUIRenderingSettings> renderingSettingPresets;

		// Token: 0x04005A55 RID: 23125
		public bool hasCustomRenderingSettings;

		// Token: 0x04005A56 RID: 23126
		public GPUInstancerSettings.GPUIRenderingSettings customRenderingSettings;

		// Token: 0x04005A57 RID: 23127
		public GPUIOcclusionCullingType occlusionCullingType;

		// Token: 0x02000E89 RID: 3721
		[Serializable]
		public class GPUIRenderingSettings
		{
			// Token: 0x04005A58 RID: 23128
			public GPUIPlatform platform;

			// Token: 0x04005A59 RID: 23129
			public GPUIMatrixHandlingType matrixHandlingType;

			// Token: 0x04005A5A RID: 23130
			public GPUIComputeThreadCount computeThreadCount;
		}

		// Token: 0x02000E8A RID: 3722
		[CompilerGenerated]
		[Serializable]
		private sealed class Class738
		{
			// Token: 0x06004D9D RID: 19869 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GPUInstancerSettingsExtension ex)
			{
				throw null;
			}

			// Token: 0x04005A5B RID: 23131
			public static readonly GPUInstancerSettings.Class738 class738_0;

			// Token: 0x04005A5C RID: 23132
			public static Predicate<GPUInstancerSettingsExtension> predicate_0;
		}
	}
}
