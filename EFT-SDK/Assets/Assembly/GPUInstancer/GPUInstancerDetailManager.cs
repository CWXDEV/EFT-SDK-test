using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EA0 RID: 3744
	public class GPUInstancerDetailManager : GPUInstancerTerrainManager
	{
		// Token: 0x06004E1F RID: 19999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_1()
		{
			throw null;
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClearInstancingData()
		{
			throw null;
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void GeneratePrototypes(bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
			throw null;
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateSpatialPartitioningCells(GPUInstancerCameraData renderingCameraData)
		{
			throw null;
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
			throw null;
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RemoveInstancesInsideBounds(Bounds bounds, float offset, List<GPUInstancerPrototype> prototypeFilter = null)
		{
			throw null;
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RemoveInstancesInsideCollider(Collider collider, float offset, List<GPUInstancerPrototype> prototypeFilter = null)
		{
			throw null;
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetGlobalPositionOffset(Vector3 offsetPosition)
		{
			throw null;
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_3(int value, int max, int failValue)
		{
			throw null;
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Matrix4x4[] GetInstanceDataForDetailPrototype(GPUInstancerDetailPrototype detailPrototype, int[] detailMap, float[] heightMapData, int detailMapSize, int heightMapSize, int detailResolution, int heightResolution, Vector3 startPosition, Vector3 terrainSize, int instanceCount)
		{
			throw null;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Matrix4x4[] method_2(GPUInstancerDetailPrototype detailPrototype, int[] detailMap, float[] heightMapData, int heightMapSize, int heightResolution, Vector3 startPosition, Vector3 terrainSize, int instanceCount, ComputeShader grassInstantiationComputeShader, GPUInstancerTerrainSettings terrainSettings)
		{
			throw null;
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ComputeBuffer method_3(GPUInstancerDetailPrototype detailPrototype, int heightMapSize, int heightResolution, Vector3 startPosition, Vector3 terrainSize, int instanceCount, ComputeShader grassInstantiationComputeShader, GPUInstancerTerrainSettings terrainSettings, ComputeBuffer heightMapBuffer, ComputeBuffer detailMapBuffer)
		{
			throw null;
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ComputeShader grassComputeShader, int grassInstantiationComputeKernelId, ComputeBuffer visibilityBuffer, ComputeBuffer detailMapBuffer, ComputeBuffer heightMapBuffer, Vector4 detailAndHeightMapSize, Vector3 startPosition, Vector3 terrainSize, float detailResolution, int heightResolution, Vector4 detailScale, Texture healthyDryNoiseTexture, float noiseSpread, int instanceID, float detailDensity, float detailTerrainNormal)
		{
			throw null;
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IEnumerator routine)
		{
			throw null;
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeSpatialPartitioning()
		{
			throw null;
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_6()
		{
			throw null;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_7()
		{
			throw null;
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FillCellsDetailDataCallBack()
		{
			throw null;
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_10(GClass1064<GClass1049> spData, List<GPUInstancerPrototype> prototypeList, int heightMapSize, int heightmapResolution, Vector3 terrainSize, GPUInstancerTerrainSettings terrainSettings, Action callback)
		{
			throw null;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int[,] method_11(int layer, float density, int resizeCount)
		{
			throw null;
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int[,] method_12(int[,] map, float density)
		{
			throw null;
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator FillCellsDetailData(Terrain terrain)
		{
			throw null;
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FillCellsDetailDataThread(object parameter)
		{
			throw null;
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator FillCellsDetailDataCoroutine(Vector4 coord)
		{
			throw null;
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDetailMapData(List<int[,]> detailMapData)
		{
			throw null;
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int[,] GetDetailLayer(int layer)
		{
			throw null;
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int[,]> GetDetailMapData()
		{
			throw null;
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int[,] method_13(int[] array)
		{
			throw null;
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int[] method_14(int[,] array)
		{
			throw null;
		}

		// Token: 0x04005ADE RID: 23262
		public int detailLayer;

		// Token: 0x04005ADF RID: 23263
		public bool runInThreads;

		// Token: 0x04005AE0 RID: 23264
		public bool doRefresh;

		// Token: 0x04005AE1 RID: 23265
		private static ComputeShader computeShader_0;

		// Token: 0x04005AE2 RID: 23266
		private ComputeBuffer computeBuffer_0;

		// Token: 0x04005AE3 RID: 23267
		private bool bool_0;

		// Token: 0x04005AE4 RID: 23268
		private ComputeBuffer computeBuffer_1;

		// Token: 0x04005AE5 RID: 23269
		private int[] int_2;

		// Token: 0x04005AE6 RID: 23270
		public float[,] threadHeightMapData;

		// Token: 0x04005AE7 RID: 23271
		public List<int[,]> threadDetailMapData;

		// Token: 0x04005AE8 RID: 23272
		public int threadHeightResolution;

		// Token: 0x04005AE9 RID: 23273
		private float float_0;
	}
}
