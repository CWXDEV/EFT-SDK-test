using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000E6A RID: 3690
public static class GClass1048
{
	// Token: 0x06004D0E RID: 19726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeGPUInstancer(GPUInstancerManager manager, bool forceNew = true)
	{
		throw null;
	}

	// Token: 0x06004D0F RID: 19727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCamera(GPUInstancerManager manager, Camera camera)
	{
		throw null;
	}

	// Token: 0x06004D10 RID: 19728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCamera(Camera camera)
	{
		throw null;
	}

	// Token: 0x06004D11 RID: 19729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<GPUInstancerManager> GetActiveManagers()
	{
		throw null;
	}

	// Token: 0x06004D12 RID: 19730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartListeningGPUIEvent(GPUInstancerEventType eventType, UnityAction callback)
	{
		throw null;
	}

	// Token: 0x06004D13 RID: 19731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopListeningGPUIEvent(GPUInstancerEventType eventType, UnityAction callback)
	{
		throw null;
	}

	// Token: 0x06004D14 RID: 19732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetGlobalPositionOffset(GPUInstancerManager manager, Vector3 offsetPosition)
	{
		throw null;
	}

	// Token: 0x06004D15 RID: 19733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstancesInsideBounds(GPUInstancerManager manager, Bounds bounds, float offset = 0f, List<GPUInstancerPrototype> prototypeFilter = null)
	{
		throw null;
	}

	// Token: 0x06004D16 RID: 19734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstancesInsideCollider(GPUInstancerManager manager, Collider collider, float offset = 0f, List<GPUInstancerPrototype> prototypeFilter = null)
	{
		throw null;
	}

	// Token: 0x06004D17 RID: 19735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ComputeBuffer GetTransformDataBuffer(GPUInstancerManager manager, GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D18 RID: 19736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLODBias(GPUInstancerManager manager, float newLODBias, List<GPUInstancerPrototype> prototypeFilter = null)
	{
		throw null;
	}

	// Token: 0x06004D19 RID: 19737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ChangeMaterial(GPUInstancerManager manager, GPUInstancerPrototype prototype, Material material, int lodLevel = 0, int rendererIndex = 0, int subMeshIndex = 0)
	{
		throw null;
	}

	// Token: 0x06004D1A RID: 19738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ChangeMesh(GPUInstancerManager manager, GPUInstancerPrototype prototype, Mesh mesh, int lodLevel = 0, int rendererIndex = 0, int subMeshIndex = 0)
	{
		throw null;
	}

	// Token: 0x06004D1B RID: 19739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetInstanceCount(GPUInstancerManager manager, GPUInstancerPrototype prototype, int instanceCount)
	{
		throw null;
	}

	// Token: 0x06004D1C RID: 19740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Matrix4x4[] GetInstanceDataArray(GPUInstancerManager manager, GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D1D RID: 19741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<GPUInstancerPrototype> GetPrototypeList(GPUInstancerManager manager)
	{
		throw null;
	}

	// Token: 0x06004D1E RID: 19742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterPrefabInstanceList(GPUInstancerPrefabManager manager, IEnumerable<GPUInstancerPrefab> prefabInstanceList)
	{
		throw null;
	}

	// Token: 0x06004D1F RID: 19743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterPrefabInstanceList(GPUInstancerPrefabManager manager, IEnumerable<GPUInstancerPrefab> prefabInstanceList)
	{
		throw null;
	}

	// Token: 0x06004D20 RID: 19744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearRegisteredPrefabInstances(GPUInstancerPrefabManager manager)
	{
		throw null;
	}

	// Token: 0x06004D21 RID: 19745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearRegisteredPrefabInstances(GPUInstancerPrefabManager manager, GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D22 RID: 19746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddPrefabInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance)
	{
		throw null;
	}

	// Token: 0x06004D23 RID: 19747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemovePrefabInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
	{
		throw null;
	}

	// Token: 0x06004D24 RID: 19748 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisableIntancingForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
	{
		throw null;
	}

	// Token: 0x06004D25 RID: 19749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EnableInstancingForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersDisabled = true)
	{
		throw null;
	}

	// Token: 0x06004D26 RID: 19750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateTransformDataForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance)
	{
		throw null;
	}

	// Token: 0x06004D27 RID: 19751 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DefinePrototypeVariationBuffer<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName)
	{
		throw null;
	}

	// Token: 0x06004D28 RID: 19752 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddVariation<T>(GPUInstancerPrefab prefabInstance, string bufferName, T value)
	{
		throw null;
	}

	// Token: 0x06004D29 RID: 19753 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateVariation<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, string bufferName, T value)
	{
		throw null;
	}

	// Token: 0x06004D2A RID: 19754 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DefineAndAddVariationFromArray<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray)
	{
		throw null;
	}

	// Token: 0x06004D2B RID: 19755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateVariationFromArray<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
	{
		throw null;
	}

	// Token: 0x06004D2C RID: 19756 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array)
	{
		throw null;
	}

	// Token: 0x06004D2D RID: 19757 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateVisibilityBufferWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
	{
		throw null;
	}

	// Token: 0x06004D2E RID: 19758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GPUInstancerPrefabPrototype DefineGameObjectAsPrefabPrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GameObject prototypeGameObject)
	{
		throw null;
	}

	// Token: 0x06004D2F RID: 19759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1061 InitializeGPUInstancer(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D30 RID: 19760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddInstancesToPrefabPrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prefabPrototype, IEnumerable<GameObject> instances)
	{
		throw null;
	}

	// Token: 0x06004D31 RID: 19761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemovePrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prefabPrototype)
	{
		throw null;
	}

	// Token: 0x06004D32 RID: 19762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupManagerWithTerrain(GPUInstancerTerrainManager manager, Terrain terrain)
	{
		throw null;
	}

	// Token: 0x06004D33 RID: 19763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateDetailInstances(GPUInstancerDetailManager manager, bool updateMeshes = false)
	{
		throw null;
	}

	// Token: 0x06004D34 RID: 19764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateTerrainNormalMapDetailInstance(GPUInstancerDetailManager manager)
	{
		throw null;
	}

	// Token: 0x06004D35 RID: 19765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<int[,]> GetDetailMapData(GPUInstancerDetailManager manager)
	{
		throw null;
	}

	// Token: 0x06004D36 RID: 19766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int[,] GetDetailLayer(GPUInstancerDetailManager manager, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06004D37 RID: 19767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDetailMapData(GPUInstancerDetailManager manager, List<int[,]> detailMapData)
	{
		throw null;
	}

	// Token: 0x02000E6B RID: 3691
	[CompilerGenerated]
	private sealed class Class736
	{
		// Token: 0x06004D38 RID: 19768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GPUInstancerManager m)
		{
			throw null;
		}

		// Token: 0x0400588D RID: 22669
		public Camera camera;
	}
}
