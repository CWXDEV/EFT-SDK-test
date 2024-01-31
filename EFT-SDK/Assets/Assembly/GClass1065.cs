using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

// Token: 0x02000E9A RID: 3738
public static class GClass1065
{
	// Token: 0x06004DB7 RID: 19895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeGPUBuffers<T>(List<T> runtimeDataList) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DB8 RID: 19896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeGPUBuffer<T>(T runtimeData) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DB9 RID: 19897 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetAppendBuffers<T>(T runtimeData) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DBA RID: 19898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0<T>(T runtimeData) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DBB RID: 19899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1<T>(T runtimeData) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DBC RID: 19900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2<T>(T runtimeData) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DBD RID: 19901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateGPUBuffers<T>(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, ComputeShader visibilityComputeShader, int[] instanceVisibilityComputeKernelIDs, List<T> runtimeDataList, GPUInstancerTerrainSettings terrainSetting, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool showRenderedAmount, bool isInitial) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DBE RID: 19902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateGPUBuffer<T>(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, ComputeShader visibilityComputeShader, int[] instanceVisibilityComputeKernelIDs, T runtimeData, GPUInstancerTerrainSettings terrainSetting, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool showRenderedAmount, bool isInitial) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DBF RID: 19903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DispatchCSInstancedCameraCalculation<T>(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, T runtimeData, GPUInstancerTerrainSettings terrainSettings, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool isInitial) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC0 RID: 19904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DispatchCSInstancedVisibilityCalculation<T>(ComputeShader visibilityComputeShader, int instanceVisibilityComputeKernelId, T runtimeData, bool isShadow, int lodShift, int lodAppendIndex) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC1 RID: 19905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawPrePass<T>(CommandBuffer motionVectorsCb, List<T> runtimeDataList, Bounds instancingBounds, GPUInstancerCameraData cameraData, bool generateMotionVectors, int layerMask = -1) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC2 RID: 19906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GPUIDrawMeshInstancedIndirect<T>(List<T> runtimeDataList, Bounds instancingBounds, GPUInstancerCameraData cameraData, int layerMask = -1) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC3 RID: 19907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DispatchBufferToTexture<T>(List<T> runtimeDataList, ComputeShader bufferToTextureComputeShader, int bufferToTextureComputeKernelID) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC4 RID: 19908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsInLayer(int layerMask, int layer)
	{
		throw null;
	}

	// Token: 0x06004DC5 RID: 19909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReleaseInstanceBuffers<T>(List<T> runtimeDataList) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC6 RID: 19910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReleaseInstanceBuffers<T>(T runtimeData) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DC7 RID: 19911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReleaseSPBuffers(GClass1064<GClass1049> spData)
	{
		throw null;
	}

	// Token: 0x06004DC8 RID: 19912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReleaseSPCell(GClass1049 spCell)
	{
		throw null;
	}

	// Token: 0x06004DC9 RID: 19913 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearInstanceData<T>(List<T> runtimeDataList) where T : GClass1061
	{
		throw null;
	}

	// Token: 0x06004DCA RID: 19914 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDetailInstancePrototypes(GPUInstancerDetailManager detailManager, List<GPUInstancerPrototype> detailInstancePrototypes, DetailPrototype[] detailPrototypes, int quadCount, GPUInstancerTerrainSettings terrainSettings, bool forceNew, Terrain terrain)
	{
		throw null;
	}

	// Token: 0x06004DCB RID: 19915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddDetailInstancePrototypeFromTerrainPrototype(GPUInstancerDetailManager detailManager, List<GPUInstancerPrototype> detailInstancePrototypes, DetailPrototype terrainDetailPrototype, int detailIndex, int quadCount, GPUInstancerTerrainSettings terrainSettings, GameObject replacementPrefab = null, Terrain terrain = null)
	{
		throw null;
	}

	// Token: 0x06004DCC RID: 19916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImportFoliageLWRPShader()
	{
		throw null;
	}

	// Token: 0x06004DCD RID: 19917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImportFoliageLWRPShaderPopup()
	{
		throw null;
	}

	// Token: 0x06004DCE RID: 19918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnFoliageLWRPShaderImportCompleted(string foliageShaderPackageName)
	{
		throw null;
	}

	// Token: 0x06004DCF RID: 19919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddDetailInstanceRuntimeDataToList(Terrain terrain, List<GClass1061> runtimeDataList, List<GPUInstancerPrototype> detailPrototypes, GPUInstancerTerrainSettings terrainSettings, int detailLayer)
	{
		throw null;
	}

	// Token: 0x06004DD0 RID: 19920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateDetailInstanceRuntimeDataList(Terrain terrain, List<GClass1061> runtimeDataList, GPUInstancerTerrainSettings terrainSettings, bool updateMeshes = false, int detailLayer = 0)
	{
		throw null;
	}

	// Token: 0x06004DD1 RID: 19921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateTerrainNormalMapDetailInstance(Terrain terrain, List<GClass1061> runtimeDataList)
	{
		throw null;
	}

	// Token: 0x06004DD2 RID: 19922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetDistanceRelativeHeight(GPUInstancerDetailPrototype detailPrototype)
	{
		throw null;
	}

	// Token: 0x06004DD3 RID: 19923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPrefabInstancePrototypes(GameObject gameObject, List<GPUInstancerPrototype> prototypeList, List<GameObject> prefabList, bool forceNew)
	{
		throw null;
	}

	// Token: 0x06004DD4 RID: 19924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GPUInstancerPrefabPrototype GeneratePrefabPrototype(GameObject go, bool forceNew)
	{
		throw null;
	}

	// Token: 0x06004DD5 RID: 19925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetTreeInstancePrototypes(GameObject gameObject, List<GPUInstancerPrototype> treeIntancePrototypes, TreePrototype[] treePrototypes, GPUInstancerTerrainSettings terrainSettings, bool forceNew)
	{
		throw null;
	}

	// Token: 0x06004DD6 RID: 19926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddTreeInstancePrototypeFromTerrainPrototype(GameObject gameObject, List<GPUInstancerPrototype> treeInstancePrototypes, TreePrototype terrainTreePrototype, int treeIndex, GPUInstancerTerrainSettings terrainSettings)
	{
		throw null;
	}

	// Token: 0x06004DD7 RID: 19927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddTreeInstanceRuntimeDataToList(List<GClass1061> runtimeDataList, List<GPUInstancerPrototype> treePrototypes, GPUInstancerTerrainSettings terrainSettings)
	{
		throw null;
	}

	// Token: 0x06004DD8 RID: 19928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DetermineTreePrototypeType(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004DD9 RID: 19929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImportSpeedTree8Shader()
	{
		throw null;
	}

	// Token: 0x06004DDA RID: 19930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImportSpeedTree8ShaderPopup()
	{
		throw null;
	}

	// Token: 0x06004DDB RID: 19931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh CreateCrossQuadsMeshForDetailGrass(float width, float height, string name, int quality)
	{
		throw null;
	}

	// Token: 0x06004DDC RID: 19932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh GenerateQuadMesh(float width, float height, Rect? uvRect = null, bool centerPivotAtBottom = false, float pivotOffsetX = 0f, float pivotOffsetY = 0f)
	{
		throw null;
	}

	// Token: 0x06004DDD RID: 19933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<int[]> GetDetailMapsFromTerrain(Terrain terrain, List<GPUInstancerPrototype> detailPrototypeList)
	{
		throw null;
	}

	// Token: 0x06004DDE RID: 19934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bounds GenerateBoundsFromTerrainPositionAndSize(Vector3 position, Vector3 size)
	{
		throw null;
	}

	// Token: 0x06004DDF RID: 19935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float SampleTerrainHeight(float px, float py, float leftBottomH, float leftTopH, float rightBottomH, float rightTopH)
	{
		throw null;
	}

	// Token: 0x06004DE0 RID: 19936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 ComputeTerrainNormal(float leftBottomH, float leftTopH, float rightBottomH, float scale)
	{
		throw null;
	}

	// Token: 0x06004DE1 RID: 19937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GCD(int[] numbers)
	{
		throw null;
	}

	// Token: 0x06004DE2 RID: 19938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GCD(int a, int b)
	{
		throw null;
	}

	// Token: 0x06004DE3 RID: 19939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<int> GetDivisors(int n)
	{
		throw null;
	}

	// Token: 0x06004DE4 RID: 19940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AssignBillboardBinding(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004DE5 RID: 19941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GeneratePrototypeBillboard(GPUInstancerPrototype prototype, bool forceRegenerate = false)
	{
		throw null;
	}

	// Token: 0x06004DE6 RID: 19942 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D DilateBillboardTexture(Texture2D billboardTexture, int frameCount, bool isNormal)
	{
		throw null;
	}

	// Token: 0x06004DE7 RID: 19943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddBillboardToRuntimeData(GClass1061 runtimeData)
	{
		throw null;
	}

	// Token: 0x06004DE8 RID: 19944 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material GetBillboardMaterial(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004DE9 RID: 19945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBillboardShaderName(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004DEA RID: 19946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBillboardGeneratedByDefault(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004DEB RID: 19947 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBillboardQuad(GPUInstancerPrototype prototype, Vector3 quadPos)
	{
		throw null;
	}

	// Token: 0x06004DEC RID: 19948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveAssetsOfType(UnityEngine.Object baseAsset, Type type)
	{
		throw null;
	}

	// Token: 0x06004DED RID: 19949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveUnusedAssets<T>(UnityEngine.Object baseAsset, List<T> prototypeList, Type prototypeType) where T : GPUInstancerPrototype
	{
		throw null;
	}

	// Token: 0x06004DEE RID: 19950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddObjectToAsset(UnityEngine.Object baseAsset, UnityEngine.Object objectToAdd)
	{
		throw null;
	}

	// Token: 0x06004DEF RID: 19951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPrototypeListFromAssets<T>(UnityEngine.Object baseAsset, List<T> prototypeList, Type prototypeType) where T : GPUInstancerPrototype
	{
		throw null;
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetAssetGUID(UnityEngine.Object assetObject)
	{
		throw null;
	}

	// Token: 0x06004DF1 RID: 19953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateSpatialPartitioningValuesFromTerrain(GClass1064<GClass1049> spData, Terrain terrain, float maxDetailDistance, float preferedCellSize = 0f)
	{
		throw null;
	}

	// Token: 0x06004DF2 RID: 19954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GenerateInstancedShadersForGameObject(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004DF3 RID: 19955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsShaderInstanced(Shader shader)
	{
		throw null;
	}

	// Token: 0x06004DF4 RID: 19956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Shader CreateInstancedShader(Shader originalShader, bool useOriginal = false)
	{
		throw null;
	}

	// Token: 0x06004DF5 RID: 19957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T[] MirrorAndFlatten<T>(this T[,] array2D)
	{
		throw null;
	}

	// Token: 0x06004DF6 RID: 19958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T[] MirrorAndFlatten<T>(this T[,] array2D, int xBase, int yBase, int width, int height)
	{
		throw null;
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float Range(this System.Random prng, float min, float max)
	{
		throw null;
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Matrix4x4ToFloatArray(this Matrix4x4 matrix4x4, float[] floatArray)
	{
		throw null;
	}

	// Token: 0x06004DF9 RID: 19961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Matrix4x4 Matrix4x4FromString(string matrixStr)
	{
		throw null;
	}

	// Token: 0x06004DFA RID: 19962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Matrix4x4ToString(Matrix4x4 matrix4x4)
	{
		throw null;
	}

	// Token: 0x06004DFB RID: 19963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetMatrix4x4ToTransform(this Transform transform, Matrix4x4 matrix)
	{
		throw null;
	}

	// Token: 0x06004DFC RID: 19964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float[] Matrix4x4ToFloatArray(this Matrix4x4 matrix4x4)
	{
		throw null;
	}

	// Token: 0x06004DFD RID: 19965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDataSingle(this ComputeBuffer computeBuffer, Matrix4x4[] data, int managedBufferStartIndex, int computeBufferStartIndex)
	{
		throw null;
	}

	// Token: 0x06004DFE RID: 19966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDataPartial(this ComputeBuffer computeBuffer, Matrix4x4[] data, int managedBufferStartIndex, int computeBufferStartIndex, int count, ComputeBuffer managedBuffer = null, Matrix4x4[] managedData = null)
	{
		throw null;
	}

	// Token: 0x06004DFF RID: 19967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CopyComputeBuffer(this ComputeBuffer computeBuffer, int computeBufferStartIndex, int count, ComputeBuffer managedBuffer)
	{
		throw null;
	}

	// Token: 0x06004E00 RID: 19968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ComputeBuffer MergeComputeBuffers(this ComputeBuffer computeBuffer, ComputeBuffer bufferToMerge, bool releaseMergedBuffers)
	{
		throw null;
	}

	// Token: 0x06004E01 RID: 19969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetGlobalPositionOffset(GPUInstancerManager manager, Vector3 offsetPosition)
	{
		throw null;
	}

	// Token: 0x06004E02 RID: 19970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstancesInsideBounds(ComputeBuffer instanceDataBuffer, Vector3 center, Vector3 extents, float offset)
	{
		throw null;
	}

	// Token: 0x06004E03 RID: 19971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstancesInsideBoxCollider(ComputeBuffer instanceDataBuffer, BoxCollider boxCollider, float offset)
	{
		throw null;
	}

	// Token: 0x06004E04 RID: 19972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstancesInsideSphereCollider(ComputeBuffer instanceDataBuffer, SphereCollider sphereCollider, float offset)
	{
		throw null;
	}

	// Token: 0x06004E05 RID: 19973 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveInstancesInsideCapsuleCollider(ComputeBuffer instanceDataBuffer, CapsuleCollider capsuleCollider, float offset)
	{
		throw null;
	}

	// Token: 0x06004E06 RID: 19974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array)
	{
		throw null;
	}

	// Token: 0x06004E07 RID: 19975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateVisibilityBufferWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
	{
		throw null;
	}

	// Token: 0x06004E08 RID: 19976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CopyTextureWithComputeShader(Texture source, Texture destination, int offsetX, int sourceMip = 0, int destinationMip = 0, bool reverseZ = true)
	{
		throw null;
	}

	// Token: 0x06004E09 RID: 19977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReduceTextureWithComputeShader(Texture source, Texture destination, int offsetX)
	{
		throw null;
	}

	// Token: 0x06004E0A RID: 19978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartListening(GPUInstancerEventType eventType, UnityAction listener)
	{
		throw null;
	}

	// Token: 0x06004E0B RID: 19979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopListening(GPUInstancerEventType eventType, UnityAction listener)
	{
		throw null;
	}

	// Token: 0x06004E0C RID: 19980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TriggerEvent(GPUInstancerEventType eventType)
	{
		throw null;
	}

	// Token: 0x06004E0D RID: 19981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VersionControlCheckout(UnityEngine.Object assetObject)
	{
		throw null;
	}

	// Token: 0x06004E0E RID: 19982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VersionControlCheckout(string path)
	{
		throw null;
	}

	// Token: 0x06004E0F RID: 19983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPlatformDependentVariables()
	{
		throw null;
	}

	// Token: 0x06004E10 RID: 19984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GPUIPlatform DeterminePlatform()
	{
		throw null;
	}

	// Token: 0x06004E11 RID: 19985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdatePlatformDependentFiles()
	{
		throw null;
	}

	// Token: 0x04005A9F RID: 23199
	private static readonly int int_0;

	// Token: 0x04005AA0 RID: 23200
	private static readonly int int_1;

	// Token: 0x04005AA1 RID: 23201
	private static readonly int int_2;

	// Token: 0x04005AA2 RID: 23202
	private static readonly int int_3;

	// Token: 0x04005AA3 RID: 23203
	private static readonly int int_4;

	// Token: 0x04005AA4 RID: 23204
	private static readonly int int_5;

	// Token: 0x04005AA5 RID: 23205
	private static readonly int int_6;

	// Token: 0x04005AA6 RID: 23206
	private static readonly int int_7;

	// Token: 0x04005AA7 RID: 23207
	private static readonly int int_8;

	// Token: 0x04005AA8 RID: 23208
	private static readonly int int_9;

	// Token: 0x04005AA9 RID: 23209
	private static readonly int int_10;

	// Token: 0x04005AAA RID: 23210
	private static readonly int int_11;

	// Token: 0x04005AAB RID: 23211
	private static readonly int int_12;

	// Token: 0x04005AAC RID: 23212
	private static readonly int int_13;

	// Token: 0x04005AAD RID: 23213
	private static readonly int int_14;

	// Token: 0x04005AAE RID: 23214
	private static readonly int int_15;

	// Token: 0x04005AAF RID: 23215
	private static readonly int int_16;

	// Token: 0x04005AB0 RID: 23216
	private static readonly int int_17;

	// Token: 0x04005AB1 RID: 23217
	private static readonly int int_18;

	// Token: 0x04005AB2 RID: 23218
	private static readonly int int_19;

	// Token: 0x04005AB3 RID: 23219
	private static readonly int int_20;

	// Token: 0x04005AB4 RID: 23220
	private static readonly int int_21;

	// Token: 0x04005AB5 RID: 23221
	private static readonly int int_22;

	// Token: 0x04005AB6 RID: 23222
	private static readonly int int_23;

	// Token: 0x04005AB7 RID: 23223
	private static readonly int int_24;

	// Token: 0x04005AB8 RID: 23224
	private static readonly int int_25;

	// Token: 0x04005AB9 RID: 23225
	private static readonly int int_26;

	// Token: 0x04005ABA RID: 23226
	private static readonly int int_27;

	// Token: 0x04005ABB RID: 23227
	private static readonly int int_28;

	// Token: 0x04005ABC RID: 23228
	private static readonly int int_29;

	// Token: 0x04005ABD RID: 23229
	private static readonly int int_30;

	// Token: 0x04005ABE RID: 23230
	private static readonly int int_31;

	// Token: 0x04005ABF RID: 23231
	private static readonly int int_32;

	// Token: 0x04005AC0 RID: 23232
	private static readonly int int_33;

	// Token: 0x04005AC1 RID: 23233
	private static readonly int int_34;

	// Token: 0x04005AC2 RID: 23234
	private static readonly int int_35;

	// Token: 0x04005AC3 RID: 23235
	private static readonly int int_36;

	// Token: 0x04005AC4 RID: 23236
	private static readonly int int_37;

	// Token: 0x04005AC5 RID: 23237
	private static readonly int int_38;

	// Token: 0x04005AC6 RID: 23238
	private static readonly int int_39;

	// Token: 0x04005AC7 RID: 23239
	private static readonly int int_40;

	// Token: 0x04005AC8 RID: 23240
	private static readonly int int_41;

	// Token: 0x04005AC9 RID: 23241
	private static readonly int int_42;

	// Token: 0x04005ACA RID: 23242
	private static readonly int int_43;

	// Token: 0x04005ACB RID: 23243
	private static readonly int int_44;

	// Token: 0x04005ACC RID: 23244
	private static readonly int int_45;

	// Token: 0x04005ACD RID: 23245
	private static readonly int int_46;

	// Token: 0x04005ACE RID: 23246
	public static Texture2D dummyHiZTex;

	// Token: 0x04005ACF RID: 23247
	public static GPUIMatrixHandlingType matrixHandlingType;

	// Token: 0x04005AD0 RID: 23248
	private static Dictionary<GPUInstancerEventType, UnityEvent> dictionary_0;

	// Token: 0x02000E9B RID: 3739
	[CompilerGenerated]
	[Serializable]
	private sealed class Class741
	{
		// Token: 0x06004E12 RID: 19986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(MeshRenderer r)
		{
			throw null;
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(MeshRenderer r)
		{
			throw null;
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(MeshRenderer mr)
		{
			throw null;
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(Material m)
		{
			throw null;
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(Renderer r)
		{
			throw null;
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_5(Renderer r)
		{
			throw null;
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_6(MeshRenderer r)
		{
			throw null;
		}

		// Token: 0x04005AD1 RID: 23249
		public static readonly GClass1065.Class741 class741_0;

		// Token: 0x04005AD2 RID: 23250
		public static Func<MeshRenderer, bool> func_0;

		// Token: 0x04005AD3 RID: 23251
		public static Func<MeshRenderer, bool> func_1;

		// Token: 0x04005AD4 RID: 23252
		public static Func<Material, bool> func_2;

		// Token: 0x04005AD5 RID: 23253
		public static Func<MeshRenderer, bool> func_3;

		// Token: 0x04005AD6 RID: 23254
		public static Func<Renderer, bool> func_4;

		// Token: 0x04005AD7 RID: 23255
		public static Func<Renderer, bool> func_5;

		// Token: 0x04005AD8 RID: 23256
		public static Func<MeshRenderer, bool> func_6;
	}

	// Token: 0x02000E9C RID: 3740
	[CompilerGenerated]
	private sealed class Class742
	{
		// Token: 0x06004E19 RID: 19993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GPUInstancerPrototype p)
		{
			throw null;
		}

		// Token: 0x04005AD9 RID: 23257
		public GameObject go;
	}

	// Token: 0x02000E9D RID: 3741
	[CompilerGenerated]
	private sealed class Class743
	{
		// Token: 0x06004E1A RID: 19994 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(int a)
		{
			throw null;
		}

		// Token: 0x04005ADA RID: 23258
		public int n;
	}

	// Token: 0x02000E9E RID: 3742
	[CompilerGenerated]
	private sealed class Class744
	{
		// Token: 0x06004E1B RID: 19995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(int d)
		{
			throw null;
		}

		// Token: 0x04005ADB RID: 23259
		public GClass1064<GClass1049> spData;
	}
}
