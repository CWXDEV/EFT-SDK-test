using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027D7 RID: 10199
	public class BetterPropagationVolume : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600CC55 RID: 52309 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CC58 RID: 52312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CC59 RID: 52313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EVolumeRelationsMask GetRelation(BetterPropagationVolume volume)
		{
			throw null;
		}

		// Token: 0x0600CC5A RID: 52314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float Audibility(Vector3 globalPosition)
		{
			throw null;
		}

		// Token: 0x0600CC5B RID: 52315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ConnectionAudibility(BetterPropagationVolume volume)
		{
			throw null;
		}

		// Token: 0x0600CC5C RID: 52316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool UseManualAudibilitySettings(BetterPropagationVolume volume)
		{
			throw null;
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0(Vector3 localPosition)
		{
			throw null;
		}

		// Token: 0x0600CC5E RID: 52318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct386 GetRelationByPosition(Vector3 listenerPosition, Vector3 sourcePosition)
		{
			throw null;
		}

		// Token: 0x0600CC5F RID: 52319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct386 GetRelation([CanBeNull] Player player, [CanBeNull] IPlayer sourcePlayer, Vector3 lPosition, Vector3 sPosition)
		{
			throw null;
		}

		// Token: 0x0600CC60 RID: 52320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("ConvertEnums")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600CC62 RID: 52322 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CC63 RID: 52323 RVA: 0x00002050 File Offset: 0x00000250
		bool IPhysicsTrigger.enabled
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

		// Token: 0x0400CC71 RID: 52337
		public BoxCollider Collider;

		// Token: 0x0400CC72 RID: 52338
		public bool MutuallyExclusive;

		// Token: 0x0400CC73 RID: 52339
		public EVolumeRelations SelfRelation;

		// Token: 0x0400CC74 RID: 52340
		public bool IsIsolated;

		// Token: 0x0400CC75 RID: 52341
		[Range(0f, 1f)]
		public float SelfOcclusionIntensity;

		// Token: 0x0400CC76 RID: 52342
		[SerializeField]
		private bool _decayEnabled;

		// Token: 0x0400CC77 RID: 52343
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x0400CC78 RID: 52344
		[HideInInspector]
		public EVolumeRelationsMask SelfRelationMask;

		// Token: 0x0400CC79 RID: 52345
		public List<VolumeConnection> Connections;

		// Token: 0x0400CC7A RID: 52346
		public Vector4 PropagationDistance;
	}
}
