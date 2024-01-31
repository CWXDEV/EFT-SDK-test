using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027E1 RID: 10209
	public class ObservedCorpse : Corpse
	{
		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600CC78 RID: 52344 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDone
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool CheckCorpseIsStill(bool sleeping, float timePass)
		{
			throw null;
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearWeaponInHands()
		{
			throw null;
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpecificSettings(Transform rightPalm)
		{
			throw null;
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyNetPacket(GStruct125 packet)
		{
			throw null;
		}

		// Token: 0x0600CC7D RID: 52349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceStill()
		{
			throw null;
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_19(Vector3 position, float corpseSyncThreshold)
		{
			throw null;
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_20(Vector3 desiredPosition, float corpseSyncThreshold, GStruct104[] packetTransformSyncs)
		{
			throw null;
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_21(GStruct104[] packetTransformSyncs)
		{
			throw null;
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ApplyTransformSync(GStruct104[] packetTransformSyncs)
		{
			throw null;
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceApplyTransformSync(GStruct104[] packetTransformSyncs)
		{
			throw null;
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600CC83 RID: 52355 RVA: 0x00002050 File Offset: 0x00000250
		public override float PhysicsQuality
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x00002050 File Offset: 0x00000250
		protected override CollisionDetectionMode CollisionDetectionMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22()
		{
			throw null;
		}

		// Token: 0x0400CCA2 RID: 52386
		private Transform transform_0;

		// Token: 0x0400CCA3 RID: 52387
		private EDamageType edamageType_0;

		// Token: 0x0400CCA4 RID: 52388
		private bool bool_4;

		// Token: 0x0400CCA5 RID: 52389
		private bool bool_5;

		// Token: 0x0400CCA6 RID: 52390
		private bool bool_6;

		// Token: 0x0400CCA7 RID: 52391
		private IEnumerator ienumerator_1;

		// Token: 0x0400CCA8 RID: 52392
		private bool bool_7;
	}
}
