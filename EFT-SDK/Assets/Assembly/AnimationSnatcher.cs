using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020000D2 RID: 210
public class AnimationSnatcher : MonoBehaviour
{
	// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset(Transform from, Transform to, EPointOfView pointOfView)
	{
		throw null;
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitHands(Transform HandsContainerTransform, Transform bodyTransform)
	{
		throw null;
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateWeaponRoot(Transform HandsContainerTransform, Transform bodyTransform)
	{
		throw null;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform[] TransformToArray(Transform parent)
	{
		throw null;
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPointOfView(EPointOfView pointOfView)
	{
		throw null;
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeaponSnatchingPreferences(AnimationSnatcher.SnatcherPair.ECopyMode mode, bool respect)
	{
		throw null;
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeaponSnatchingWeights(float xz, float y, float r)
	{
		throw null;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPalmSnatchingWeight(float left, float right)
	{
		throw null;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0()
	{
		throw null;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_1()
	{
		throw null;
	}

	// Token: 0x040004F8 RID: 1272
	public List<AnimationSnatcher.HierarchySnatcherPair> MainPairs;

	// Token: 0x040004F9 RID: 1273
	public List<AnimationSnatcher.HierarchySnatcherPair> LeftHandPost;

	// Token: 0x040004FA RID: 1274
	public List<AnimationSnatcher.HierarchySnatcherPair> RightHandPost;

	// Token: 0x040004FB RID: 1275
	public const string PALM_LEFT_TRANSFORM = "Base HumanLPalm";

	// Token: 0x040004FC RID: 1276
	public const string PALM_RIGHT_TRANSFORM = "Base HumanRPalm";

	// Token: 0x040004FD RID: 1277
	public const string WEAPON_ROOT_TRANSFORM = "Weapon_root";

	// Token: 0x040004FE RID: 1278
	public const string RIBCAGE_TRANSFORM_NAME = "Base HumanRibcage";

	// Token: 0x040004FF RID: 1279
	public const string LEFT_ARM = "Base HumanLCollarbone";

	// Token: 0x04000500 RID: 1280
	public const string RIGHT_ARM = "Base HumanRCollarbone";

	// Token: 0x04000501 RID: 1281
	public Transform First;

	// Token: 0x04000502 RID: 1282
	public Transform Third;

	// Token: 0x04000503 RID: 1283
	public List<string> Ignore;

	// Token: 0x04000504 RID: 1284
	private EPointOfView epointOfView_0;

	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class SnatcherPair
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool IsDuplicating
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetWeight(float xz, float y, float r)
		{
			throw null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Process(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Transform source, Transform destination)
		{
			throw null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 SeparateLerp(Vector3 v1, Vector3 v2, float weightXZ, float weightY)
		{
			throw null;
		}

		// Token: 0x04000505 RID: 1285
		public Transform Source;

		// Token: 0x04000506 RID: 1286
		public Transform Destination;

		// Token: 0x04000507 RID: 1287
		public AnimationSnatcher.SnatcherPair.ECopyMode CopyMode;

		// Token: 0x04000508 RID: 1288
		public EPointOfView PointOfView;

		// Token: 0x04000509 RID: 1289
		public bool RespectPointOfView;

		// Token: 0x0400050A RID: 1290
		public float PositionXZWeight;

		// Token: 0x0400050B RID: 1291
		public float PositionYWeight;

		// Token: 0x0400050C RID: 1292
		public float RotationWeight;

		// Token: 0x020000D4 RID: 212
		public enum ECopyMode
		{
			// Token: 0x0400050E RID: 1294
			Local,
			// Token: 0x0400050F RID: 1295
			World
		}
	}

	// Token: 0x020000D5 RID: 213
	[Serializable]
	public class HierarchySnatcherPair : AnimationSnatcher.SnatcherPair
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsCopyHierarchy
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsDuplicating
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

		// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetWeight(float xz, float y, float r)
		{
			throw null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Process(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool enabled)
		{
			throw null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Transform> method_2(Transform source)
		{
			throw null;
		}

		// Token: 0x04000510 RID: 1296
		public string Name;

		// Token: 0x04000511 RID: 1297
		public bool ProcessOnlyChildren;

		// Token: 0x04000512 RID: 1298
		public bool foldOut;

		// Token: 0x04000513 RID: 1299
		public bool _isCopyHierarchy;

		// Token: 0x04000514 RID: 1300
		public string SearchPrefix;

		// Token: 0x04000515 RID: 1301
		private bool _isDuplicating;

		// Token: 0x04000516 RID: 1302
		public List<AnimationSnatcher.SnatcherPair> ChildrenPairs;
	}
}
