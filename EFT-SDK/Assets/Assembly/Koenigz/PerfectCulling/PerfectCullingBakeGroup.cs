using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Koenigz.PerfectCulling.EFT;
using UnityEngine;
using UnityEngine.Rendering;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000D90 RID: 3472
	[Serializable]
	public class PerfectCullingBakeGroup
	{
		// Token: 0x06004969 RID: 18793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LODGroup TryGetLODGroupFromRenderersHierarchyUpwards()
		{
			throw null;
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetCenter()
		{
			throw null;
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsRenderer(Renderer rend)
		{
			throw null;
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteRuntimeProxies()
		{
			throw null;
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateRuntimeProxies()
		{
			throw null;
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LODGroup method_1()
		{
			throw null;
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ValidateRuntime()
		{
			throw null;
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerator<Vector3> EnumerateCenters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Bounds method_2()
		{
			throw null;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<bool, Bounds> GetGroupBounds()
		{
			throw null;
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingBakeGroup.RuntimeGroupContent[] RuntimeGroupData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004976 RID: 18806 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsEnabled
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

		// Token: 0x06004977 RID: 18807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RuntimeSetForceRenderingOff(bool forceRenderingOff)
		{
			throw null;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int Init()
		{
			throw null;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushRuntimeRenderer(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PopRuntimeRenderer(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PerfectCullingBakeGroup.RuntimeGroupContent groupContent)
		{
			throw null;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PerfectCullingBakeGroup.RuntimeGroupContent method_4()
		{
			throw null;
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Toggle(bool rendererEnabled)
		{
			throw null;
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForeachRenderer(Action<Renderer> actionForRenderer)
		{
			throw null;
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x00002050 File Offset: 0x00000250
		public float Volume
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040054A6 RID: 21670
		public PerfectCullingBakeGroup.GroupType groupType;

		// Token: 0x040054A7 RID: 21671
		public Renderer[] renderers;

		// Token: 0x040054A8 RID: 21672
		public ScreenDistanceSwitcher screenDistanceSwitcher;

		// Token: 0x040054A9 RID: 21673
		public int serializedGroupId;

		// Token: 0x040054AA RID: 21674
		public float lightBakeSize;

		// Token: 0x040054AB RID: 21675
		public Vector3 lightBakePosition;

		// Token: 0x040054AC RID: 21676
		public Vector3 lightDir;

		// Token: 0x040054AD RID: 21677
		public float lightAngle;

		// Token: 0x040054AE RID: 21678
		public LightType lightType;

		// Token: 0x040054AF RID: 21679
		public CullingObject[] cullingLightObjects;

		// Token: 0x040054B0 RID: 21680
		public AnalyticSource[] analyticSources;

		// Token: 0x040054B1 RID: 21681
		[NonSerialized]
		public int vertexCount;

		// Token: 0x040054B2 RID: 21682
		[NonSerialized]
		public ushort runtimeGroupIndex;

		// Token: 0x040054B3 RID: 21683
		[NonSerialized]
		public int updateCounter;

		// Token: 0x040054B4 RID: 21684
		[NonSerialized]
		public Renderer[] runtimeProxies;

		// Token: 0x040054B5 RID: 21685
		[NonSerialized]
		public LODGroup runtimeLodGroup;

		// Token: 0x040054B6 RID: 21686
		[NonSerialized]
		private int int_0;

		// Token: 0x040054B7 RID: 21687
		[NonSerialized]
		private PerfectCullingBakeGroup.RuntimeGroupContent[] runtimeGroupContent_0;

		// Token: 0x040054B8 RID: 21688
		[NonSerialized]
		public bool isGroupEnabled;

		// Token: 0x040054B9 RID: 21689
		public const float PERSISTENT_SHADOW_OBJ_SIZE = 2.5f;

		// Token: 0x040054BA RID: 21690
		public static int numPersistentShadowLods;

		// Token: 0x040054BB RID: 21691
		[NonSerialized]
		public Light[] runtimeLights;

		// Token: 0x02000D91 RID: 3473
		public readonly struct RuntimeGroupContent
		{
			// Token: 0x040054BC RID: 21692
			public readonly Renderer Renderer;

			// Token: 0x040054BD RID: 21693
			public readonly ShadowCastingMode ShadowCastingMode;

			// Token: 0x040054BE RID: 21694
			public readonly GameObject RendererObj;

			// Token: 0x040054BF RID: 21695
			public readonly string RendererObjName;
		}

		// Token: 0x02000D92 RID: 3474
		public enum GroupType
		{
			// Token: 0x040054C1 RID: 21697
			Other,
			// Token: 0x040054C2 RID: 21698
			LOD,
			// Token: 0x040054C3 RID: 21699
			User,
			// Token: 0x040054C4 RID: 21700
			Light,
			// Token: 0x040054C5 RID: 21701
			CullingLightObject,
			// Token: 0x040054C6 RID: 21702
			Door,
			// Token: 0x040054C7 RID: 21703
			Portal,
			// Token: 0x040054C8 RID: 21704
			CullingCell,
			// Token: 0x040054C9 RID: 21705
			BakedLod
		}

		// Token: 0x02000D93 RID: 3475
		[CompilerGenerated]
		private sealed class Class687
		{
			// Token: 0x06004980 RID: 18816 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Renderer x)
			{
				throw null;
			}

			// Token: 0x040054CA RID: 21706
			public Renderer rend;
		}
	}
}
