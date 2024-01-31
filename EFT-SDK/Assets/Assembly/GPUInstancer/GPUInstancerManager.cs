using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using EFT.Settings.Graphics;
using UnityEngine;
using UnityEngine.Rendering;

namespace GPUInstancer
{
	// Token: 0x02000E6D RID: 3693
	public abstract class GPUInstancerManager : MonoBehaviour
	{
		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool isCulled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x00002050 File Offset: 0x00000250
		protected Camera Camera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06004D3D RID: 19773 RVA: 0x00002050 File Offset: 0x00000250
		protected SSAA CameraSSAA
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06004D3E RID: 19774 RVA: 0x00002050 File Offset: 0x00000250
		public RenderTargetIdentifier[] MRT
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06004D3F RID: 19775 RVA: 0x00002050 File Offset: 0x00000250
		protected static bool isTaaEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x00002050 File Offset: 0x00000250
		protected static int OpticResolution
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Awake()
		{
			throw null;
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void OnResolutionChangeStatic(GStruct235 displaySettings)
		{
			throw null;
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(EftResolution resolution)
		{
			throw null;
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1()
		{
			throw null;
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			throw null;
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Reset()
		{
			throw null;
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClearInstancingData()
		{
			throw null;
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GeneratePrototypes(bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
			throw null;
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitializeSpatialPartitioning()
		{
			throw null;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateSpatialPartitioningCells(GPUInstancerCameraData renderingCameraData)
		{
			throw null;
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
			throw null;
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RemoveInstancesInsideBounds(Bounds bounds, float offset, List<GPUInstancerPrototype> prototypeFilter = null)
		{
			throw null;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RemoveInstancesInsideCollider(Collider collider, float offset, List<GPUInstancerPrototype> prototypeFilter = null)
		{
			throw null;
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetGlobalPositionOffset(Vector3 offsetPosition)
		{
			throw null;
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCompletedThreads()
		{
			throw null;
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeCameraData()
		{
			throw null;
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupOcclusionCulling()
		{
			throw null;
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBuffers()
		{
			throw null;
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCamera(Camera camera)
		{
			throw null;
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ComputeBuffer GetTransformDataBuffer(GPUInstancerPrototype prototype)
		{
			throw null;
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLODBias(float newLODBias, List<GPUInstancerPrototype> prototypeFilter)
		{
			throw null;
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTreeMPB()
		{
			throw null;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddTreeProxy(GPUInstancerPrototype treePrototype, GClass1061 runtimeData)
		{
			throw null;
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InstantiateTreeProxyObject(GameObject treePrefab, GameObject proxyObjectParent, Material[] proxyMaterials, Mesh proxyMesh, bool setBounds)
		{
			throw null;
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateSceneWind()
		{
			throw null;
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogThreadException()
		{
			throw null;
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1061 GetRuntimeData(GPUInstancerPrototype prototype, bool logError = false)
		{
			throw null;
		}

		// Token: 0x04005895 RID: 22677
		public bool IsOptic;

		// Token: 0x04005896 RID: 22678
		public List<GPUInstancerPrototype> prototypeList;

		// Token: 0x04005897 RID: 22679
		public GPUInstancerCameraData cameraData;

		// Token: 0x04005898 RID: 22680
		public bool useFloatingOriginHandler;

		// Token: 0x04005899 RID: 22681
		public Transform floatingOriginTransform;

		// Token: 0x0400589A RID: 22682
		public GPUInstancerFloatingOriginHandler floatingOriginHandler;

		// Token: 0x0400589B RID: 22683
		public GPUInstancerTerrainSettings terrainSettings;

		// Token: 0x0400589C RID: 22684
		public List<GClass1061> runtimeDataList;

		// Token: 0x0400589D RID: 22685
		public Bounds instancingBounds;

		// Token: 0x0400589E RID: 22686
		public bool isFrustumCulling;

		// Token: 0x0400589F RID: 22687
		public bool isOcclusionCulling;

		// Token: 0x040058A0 RID: 22688
		public float minCullingDistance;

		// Token: 0x040058A1 RID: 22689
		protected GClass1064<GClass1049> spData;

		// Token: 0x040058A2 RID: 22690
		public static List<GPUInstancerManager> activeManagerList;

		// Token: 0x040058A3 RID: 22691
		public static bool showRenderedAmount;

		// Token: 0x040058A4 RID: 22692
		protected static ComputeShader _cameraComputeShader;

		// Token: 0x040058A5 RID: 22693
		protected static int[] _cameraComputeKernelIDs;

		// Token: 0x040058A6 RID: 22694
		protected static ComputeShader _visibilityComputeShader;

		// Token: 0x040058A7 RID: 22695
		protected static int[] _instanceVisibilityComputeKernelIDs;

		// Token: 0x040058A8 RID: 22696
		protected static ComputeShader _bufferToTextureComputeShader;

		// Token: 0x040058A9 RID: 22697
		protected static int _bufferToTextureComputeKernelID;

		// Token: 0x040058AA RID: 22698
		public int maxThreads;

		// Token: 0x040058AB RID: 22699
		public readonly List<Thread> activeThreads;

		// Token: 0x040058AC RID: 22700
		public readonly Queue<GPUInstancerManager.GClass1052> threadStartQueue;

		// Token: 0x040058AD RID: 22701
		public readonly Queue<Action> threadQueue;

		// Token: 0x040058AE RID: 22702
		public static int lastTreePositionUpdate;

		// Token: 0x040058AF RID: 22703
		public static GameObject treeProxyParent;

		// Token: 0x040058B0 RID: 22704
		public static Dictionary<GameObject, Transform> treeProxyList;

		// Token: 0x040058B1 RID: 22705
		public static int lastDrawCallFrame;

		// Token: 0x040058B2 RID: 22706
		public static float lastDrawCallTime;

		// Token: 0x040058B3 RID: 22707
		public static float timeSinceLastDrawCall;

		// Token: 0x040058B4 RID: 22708
		protected static Vector4 _windVector;

		// Token: 0x040058B5 RID: 22709
		protected bool isInitial;

		// Token: 0x040058B6 RID: 22710
		public bool isInitialized;

		// Token: 0x040058B7 RID: 22711
		public Dictionary<GPUInstancerPrototype, GClass1061> runtimeDataDictionary;

		// Token: 0x040058B8 RID: 22712
		public LayerMask layerMask;

		// Token: 0x040058B9 RID: 22713
		protected static CommandBuffer motionVectorsCb;

		// Token: 0x040058BA RID: 22714
		protected static CommandBuffer motionVectorsAfterCb;

		// Token: 0x040058BB RID: 22715
		protected static RenderTexture motionVectorsRt;

		// Token: 0x040058BC RID: 22716
		protected static RenderTexture motionVectorsRtDepth;

		// Token: 0x040058BD RID: 22717
		protected static CommandBuffer motionVectorsCbOptic;

		// Token: 0x040058BE RID: 22718
		protected static CommandBuffer motionVectorsAfterCbOptic;

		// Token: 0x040058BF RID: 22719
		protected static RenderTexture motionVectorsRtOptic;

		// Token: 0x040058C0 RID: 22720
		protected static RenderTexture motionVectorsRtDepthOptic;

		// Token: 0x040058C1 RID: 22721
		protected static RenderTargetIdentifier[] mrt;

		// Token: 0x040058C2 RID: 22722
		protected static RenderTargetIdentifier[] mrtOptic;

		// Token: 0x040058C3 RID: 22723
		protected static bool isMotionVectorDataClear;

		// Token: 0x040058C4 RID: 22724
		protected static bool isMotionVectorDataClearOptic;

		// Token: 0x040058C5 RID: 22725
		protected static bool isMotionVectorsInit;

		// Token: 0x040058C6 RID: 22726
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x040058C7 RID: 22727
		public Exception threadException;

		// Token: 0x040058C8 RID: 22728
		private static readonly int int_0;

		// Token: 0x040058C9 RID: 22729
		private static readonly int int_1;

		// Token: 0x02000E6E RID: 3694
		public class GClass1052
		{
			// Token: 0x040058CA RID: 22730
			public Thread thread;

			// Token: 0x040058CB RID: 22731
			public object parameter;
		}

		// Token: 0x02000E6F RID: 3695
		[CompilerGenerated]
		[Serializable]
		private sealed class Class737
		{
			// Token: 0x06004D61 RID: 19809 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GPUInstancerPrototype p)
			{
				throw null;
			}

			// Token: 0x040058CC RID: 22732
			public static readonly GPUInstancerManager.Class737 class737_0;

			// Token: 0x040058CD RID: 22733
			public static Predicate<GPUInstancerPrototype> predicate_0;
		}
	}
}
