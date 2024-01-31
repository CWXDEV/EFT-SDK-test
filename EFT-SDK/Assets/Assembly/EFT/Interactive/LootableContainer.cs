using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.Interactive
{
	// Token: 0x02002777 RID: 10103
	public class LootableContainer : WorldInteractiveObject, GInterface26
	{
		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600CA7E RID: 51838 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA7F RID: 51839 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInitialized
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600CA80 RID: 51840 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2966[] Trees
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x00002050 File Offset: 0x00000250
		public override string TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Interact(InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Save OPEN position")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Save CLOSED position")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA86 RID: 51846 RVA: 0x00002050 File Offset: 0x00000250
		public new string Id
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

		// Token: 0x0600CA87 RID: 51847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootPointParameters AsLootPointParameters()
		{
			throw null;
		}

		// Token: 0x0600CA88 RID: 51848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(TraderControllerClass itemController)
		{
			throw null;
		}

		// Token: 0x0600CA89 RID: 51849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x0400CA8B RID: 51851
		[SerializeField]
		public TraderControllerClass ItemOwner;

		// Token: 0x0400CA8C RID: 51852
		public string Template;

		// Token: 0x0400CA8D RID: 51853
		public Vector3 ClosedPosition;

		// Token: 0x0400CA8E RID: 51854
		public Vector3 OpenPosition;

		// Token: 0x0400CA8F RID: 51855
		public string LootableContainersGroupId;

		// Token: 0x0400CA90 RID: 51856
		[HideInInspector]
		public bool IsAlwaysLootable;

		// Token: 0x0400CA91 RID: 51857
		[HideInInspector]
		public bool IsAlwaysSpawn;

		// Token: 0x0400CA92 RID: 51858
		[HideInInspector]
		[SerializeField]
		private bool _isConverted;

		// Token: 0x0400CA93 RID: 51859
		[FormerlySerializedAs("SpawnModifier")]
		public ELootableContainerSpawnType SpawnType;

		// Token: 0x0400CA94 RID: 51860
		[Range(0f, 100f)]
		public byte SpawnChance;

		// Token: 0x0400CA95 RID: 51861
		public List<GameObject> GameObjectsToDestroy;

		// Token: 0x0400CA96 RID: 51862
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400CA97 RID: 51863
		private GClass2966[] gclass2966_0;

		// Token: 0x0400CA98 RID: 51864
		public float ChanceModifier;

		// Token: 0x0400CA99 RID: 51865
		public List<LootableContainerParameters> FilterExtended;

		// Token: 0x02002778 RID: 10104
		[CompilerGenerated]
		private sealed class Class2279
		{
			// Token: 0x0600CA8A RID: 51850 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400CA9A RID: 51866
			public InteractionResult interactionResult;

			// Token: 0x0400CA9B RID: 51867
			public LootableContainer lootableContainer_0;
		}

		// Token: 0x02002779 RID: 10105
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2280
		{
			// Token: 0x0600CA8B RID: 51851 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Keyframe k)
			{
				throw null;
			}

			// Token: 0x0400CA9C RID: 51868
			public static readonly LootableContainer.Class2280 class2280_0;

			// Token: 0x0400CA9D RID: 51869
			public static Func<Keyframe, bool> func_0;
		}
	}
}
