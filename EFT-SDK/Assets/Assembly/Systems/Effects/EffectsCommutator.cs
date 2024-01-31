using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Ballistics;
using UnityEngine;

namespace Systems.Effects
{
	// Token: 0x02000C33 RID: 3123
	public class EffectsCommutator : MonoBehaviour
	{
		// Token: 0x06004408 RID: 17416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerMeshesHit(List<GStruct53> renderers, Vector3 point, Vector3 direction)
		{
			throw null;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayHitEffect(GClass2988 info, GClass1673 playerHitInfo)
		{
			throw null;
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsHitPointAlreadyProcessed(Vector3 hitPoint)
		{
			throw null;
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CheckEnvironmentHitAfterBodyHit(GClass2988 fragment)
		{
			throw null;
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayKnifeHitEffect(DamageInfo info)
		{
			throw null;
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayKnifeHitEffect(BallisticCollider collider, Vector3 hitPoint, Vector3 hitNormal, KnifeClass knife)
		{
			throw null;
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBleedingForPlayer(IPlayer player)
		{
			throw null;
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopBleedingForPlayer(IPlayer player)
		{
			throw null;
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePlayersBleedings()
		{
			throw null;
		}

		// Token: 0x04004D8F RID: 19855
		[SerializeField]
		private Vector2 _minMaxBleedingSpawnDelta;

		// Token: 0x04004D90 RID: 19856
		private Effects.Effect[] effect_0;

		// Token: 0x04004D91 RID: 19857
		private List<Vector3> list_0;

		// Token: 0x04004D92 RID: 19858
		private readonly List<KeyValuePair<IPlayer, float>> list_1;

		// Token: 0x04004D93 RID: 19859
		private const int int_0 = 3;

		// Token: 0x04004D94 RID: 19860
		private const int int_1 = 4;
	}
}
