using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EB4 RID: 3764
	public class GPUInstancerPrefabManager : GPUInstancerManager
	{
		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool isCulled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			throw null;
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClearInstancingData()
		{
			throw null;
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GeneratePrototypesForWinter()
		{
			throw null;
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void GeneratePrototypes(bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
			throw null;
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
			throw null;
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int additionalBufferSize = 0)
		{
			throw null;
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GClass1061 InitializeRuntimeDataForPrefabPrototype(GPUInstancerPrefabPrototype p, int additionalBufferSize = 0)
		{
			throw null;
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetRenderersEnabled(GPUInstancerPrefab prefabInstance, bool enabled)
		{
			throw null;
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableIntancingForInstance(GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
		{
			throw null;
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableInstancingForInstance(GPUInstancerPrefab prefabInstance, bool setRenderersDisabled = true)
		{
			throw null;
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTransformDataForInstance(GPUInstancerPrefab prefabInstance)
		{
			throw null;
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPrefabInstance(GPUInstancerPrefab prefabInstance, bool automaticallyIncreaseBufferSize = false)
		{
			throw null;
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorBuffers(List<Color> dryColor, List<Color> healthyColor)
		{
			throw null;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPrefabInstances(IEnumerable<GPUInstancerPrefab> prefabInstances, bool isThreading = false)
		{
			throw null;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPrefabInstances(GPUInstancerPrefabPrototype prototype, IEnumerable<GPUInstancerPrefab> prefabInstances, bool isThreading = false)
		{
			throw null;
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInstanceDataArray(GClass1061 runtimeData, List<GPUInstancerPrefab> prefabList, bool isThreading = false)
		{
			throw null;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePrefabInstance(GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
		{
			throw null;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePrefabInstances(IEnumerable<GPUInstancerPrefab> prefabInstances, bool isThreading = false)
		{
			throw null;
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePrefabInstances(GPUInstancerPrefabPrototype prototype, IEnumerable<GPUInstancerPrefab> prefabInstances, bool isThreading = false)
		{
			throw null;
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterPrefabsInScene()
		{
			throw null;
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterPrefabInstanceList(IEnumerable<GPUInstancerPrefab> prefabInstanceList)
		{
			throw null;
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterPrefabInstanceList(IEnumerable<GPUInstancerPrefab> prefabInstanceList)
		{
			throw null;
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearRegisteredPrefabInstances()
		{
			throw null;
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearRegisteredPrefabInstances(GPUInstancerPrototype p)
		{
			throw null;
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1066<T> DefinePrototypeVariationBuffer<T>(GPUInstancerPrefabPrototype prototype, string bufferName)
		{
			throw null;
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateVariationData<T>(GPUInstancerPrefab prefabInstance, string bufferName, T value)
		{
			throw null;
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1066<T> DefineAndAddVariationFromArray<T>(GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray)
		{
			throw null;
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1066<T> UpdateVariationsFromArray<T>(GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
		{
			throw null;
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GPUInstancerPrefabPrototype DefineGameObjectAsPrefabPrototypeAtRuntime(GameObject prototypeGameObject)
		{
			throw null;
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddInstancesToPrefabPrototypeAtRuntime(GPUInstancerPrefabPrototype prefabPrototype, IEnumerable<GameObject> instances)
		{
			throw null;
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePrototypeAtRuntime(GPUInstancerPrefabPrototype prefabPrototype)
		{
			throw null;
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRegisteredPrefab(GPUInstancerPrefab prefabInstance)
		{
			throw null;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRuntimeRegisteredPrefab(GPUInstancerPrefab prefabInstance)
		{
			throw null;
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddModificationCollider(GPUInstancerModificationCollider modificationCollider)
		{
			throw null;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetEnabledPrefabCount()
		{
			throw null;
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<GPUInstancerPrototype, List<GPUInstancerPrefab>> GetRegisteredPrefabsRuntimeData()
		{
			throw null;
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x04005B62 RID: 23394
		[SerializeField]
		public List<RegisteredPrefabsData> registeredPrefabs;

		// Token: 0x04005B63 RID: 23395
		[SerializeField]
		public List<GameObject> prefabList;

		// Token: 0x04005B64 RID: 23396
		public bool enableMROnManagerDisable;

		// Token: 0x04005B65 RID: 23397
		public bool enableMROnRemoveInstance;

		// Token: 0x04005B66 RID: 23398
		protected List<GPUInstancerModificationCollider> _modificationColliders;

		// Token: 0x04005B67 RID: 23399
		protected Dictionary<GPUInstancerPrototype, List<GPUInstancerPrefab>> _registeredPrefabsRuntimeData;

		// Token: 0x04005B68 RID: 23400
		protected List<GInterface66> _variationDataList;

		// Token: 0x04005B69 RID: 23401
		protected volatile bool _addRemoveInProgress;

		// Token: 0x04005B6A RID: 23402
		public bool IsActive;

		// Token: 0x04005B6B RID: 23403
		private static readonly string string_0;

		// Token: 0x04005B6C RID: 23404
		private static readonly string string_1;

		// Token: 0x04005B6D RID: 23405
		private ComputeBuffer computeBuffer_0;

		// Token: 0x04005B6E RID: 23406
		private ComputeBuffer computeBuffer_1;

		// Token: 0x02000EB5 RID: 3765
		[CompilerGenerated]
		private sealed class Class754
		{
			// Token: 0x06004EC2 RID: 20162 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06004EC3 RID: 20163 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04005B6F RID: 23407
			public GClass1061 runtimeData;
		}

		// Token: 0x02000EB6 RID: 3766
		[CompilerGenerated]
		private sealed class Class755
		{
			// Token: 0x06004EC4 RID: 20164 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04005B70 RID: 23408
			public GClass1061 runtimeData;

			// Token: 0x04005B71 RID: 23409
			public int instanceCount;

			// Token: 0x04005B72 RID: 23410
			public int bufferSize;
		}

		// Token: 0x02000EB7 RID: 3767
		[CompilerGenerated]
		[Serializable]
		private sealed class Class756
		{
			// Token: 0x06004EC5 RID: 20165 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GPUInstancerPrefab pi)
			{
				throw null;
			}

			// Token: 0x04005B73 RID: 23411
			public static readonly GPUInstancerPrefabManager.Class756 class756_0;

			// Token: 0x04005B74 RID: 23412
			public static Predicate<GPUInstancerPrefab> predicate_0;
		}

		// Token: 0x02000EB8 RID: 3768
		[CompilerGenerated]
		private sealed class Class757<T>
		{
			// Token: 0x06004EC6 RID: 20166 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface66 v)
			{
				throw null;
			}

			// Token: 0x04005B75 RID: 23413
			public GPUInstancerPrefabPrototype prototype;

			// Token: 0x04005B76 RID: 23414
			public string bufferName;
		}

		// Token: 0x02000EB9 RID: 3769
		[CompilerGenerated]
		private sealed class Class758<T>
		{
			// Token: 0x06004EC7 RID: 20167 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface66 v)
			{
				throw null;
			}

			// Token: 0x04005B77 RID: 23415
			public GPUInstancerPrefab prefabInstance;

			// Token: 0x04005B78 RID: 23416
			public string bufferName;
		}

		// Token: 0x02000EBA RID: 3770
		[CompilerGenerated]
		private sealed class Class759<T>
		{
			// Token: 0x06004EC8 RID: 20168 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface66 v)
			{
				throw null;
			}

			// Token: 0x04005B79 RID: 23417
			public GPUInstancerPrefabPrototype prototype;

			// Token: 0x04005B7A RID: 23418
			public string bufferName;
		}

		// Token: 0x02000EBB RID: 3771
		[CompilerGenerated]
		private sealed class Class760
		{
			// Token: 0x06004EC9 RID: 20169 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RegisteredPrefabsData d)
			{
				throw null;
			}

			// Token: 0x04005B7B RID: 23419
			public GPUInstancerPrefabPrototype prefabPrototype;
		}

		// Token: 0x02000EBC RID: 3772
		[CompilerGenerated]
		private sealed class Class761
		{
			// Token: 0x06004ECA RID: 20170 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RegisteredPrefabsData d)
			{
				throw null;
			}

			// Token: 0x04005B7C RID: 23420
			public GPUInstancerPrefabPrototype prefabPrototype;
		}

		// Token: 0x02000EBD RID: 3773
		[CompilerGenerated]
		private sealed class Class762
		{
			// Token: 0x06004ECB RID: 20171 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RegisteredPrefabsData rpd)
			{
				throw null;
			}

			// Token: 0x04005B7D RID: 23421
			public GPUInstancerPrefab prefabInstance;
		}
	}
}
