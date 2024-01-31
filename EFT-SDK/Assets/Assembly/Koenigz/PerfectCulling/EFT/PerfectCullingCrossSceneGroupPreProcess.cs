using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E01 RID: 3585
	[RequireComponent(typeof(PerfectCullingCrossSceneGroup))]
	[DisallowMultipleComponent]
	public abstract class PerfectCullingCrossSceneGroupPreProcess : MonoBehaviour
	{
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingCrossSceneGroup Group
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetBakeResolution()
		{
			throw null;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual PerfectCullingCrossSceneGroupPreProcess.RenderMode GetGroupRenderMode()
		{
			throw null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual PerfectCullingBakeGroup[] CollectBakeGroups()
		{
			throw null;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual BakeBatch[] CreateBakeBatches(PerfectCullingBakeGroup[] inputGroups)
		{
			throw null;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual PerfectCullingBakeGroup[] PrebakeTransform(BakeBatch batch, ICollection<GameObject> tempObjects, out GClass1012.Mode writeMode)
		{
			throw null;
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetBakeHash()
		{
			throw null;
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual BakeBatch[] GetBakeBatches()
		{
			throw null;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnBeginContentCollect()
		{
			throw null;
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEndContentCollect()
		{
			throw null;
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual PerfectCullingBakeGroup[] PrepareRuntimeContent()
		{
			throw null;
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RemapBatchResult(BakeBatch sourceBatch, GClass1012 task)
		{
			throw null;
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual SharedOccluder GenerateSharedOccluder()
		{
			throw null;
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual LODGroup[] GetLODGroups()
		{
			throw null;
		}

		// Token: 0x02000E02 RID: 3586
		public enum RenderMode
		{
			// Token: 0x04005633 RID: 22067
			TriangleFill,
			// Token: 0x04005634 RID: 22068
			Wireframe
		}
	}
}
