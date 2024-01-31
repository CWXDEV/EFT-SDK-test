using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E03 RID: 3587
	public sealed class PerfectCullingDoorPreProcess : PerfectCullingCrossSceneGroupPreProcess
	{
		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyCollection<GuidReference> DoorContent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] CollectBakeGroups()
		{
			throw null;
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BakeBatch[] CreateBakeBatches(PerfectCullingBakeGroup[] inputGroups)
		{
			throw null;
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BakeBatch[] GetBakeBatches()
		{
			throw null;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrebakeTransform(BakeBatch batch, ICollection<GameObject> tempObjects, out GClass1012.Mode writeMode)
		{
			throw null;
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WorldInteractiveObject smethod_0(PerfectCullingBakeGroup cullingGroup)
		{
			throw null;
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEndContentCollect()
		{
			throw null;
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PerfectCullingBakeGroup[] PrepareRuntimeContent()
		{
			throw null;
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector3 smethod_1(WorldInteractiveObject door)
		{
			throw null;
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Bounds smethod_2(Transform root)
		{
			throw null;
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MeshRenderer smethod_3(WorldInteractiveObject doorObj)
		{
			throw null;
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PerfectCullingBakeGroup[] method_1()
		{
			throw null;
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override SharedOccluder GenerateSharedOccluder()
		{
			throw null;
		}

		// Token: 0x04005635 RID: 22069
		[HideInInspector]
		[SerializeField]
		private GuidReference[] _doorContent;

		// Token: 0x02000E04 RID: 3588
		[CompilerGenerated]
		[Serializable]
		private sealed class Class710
		{
			// Token: 0x06004B21 RID: 19233 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(PerfectCullingCrossSceneContentDoors x, PerfectCullingCrossSceneContentDoors y)
			{
				throw null;
			}

			// Token: 0x04005636 RID: 22070
			public static readonly PerfectCullingDoorPreProcess.Class710 class710_0;

			// Token: 0x04005637 RID: 22071
			public static Comparison<PerfectCullingCrossSceneContentDoors> comparison_0;
		}
	}
}
