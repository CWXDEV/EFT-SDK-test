using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animals
{
	// Token: 0x02002FBD RID: 12221
	public class BirdBoidsSpawner : MonoBehaviour
	{
		// Token: 0x0600F14B RID: 61771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F14C RID: 61772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Spawn()
		{
			throw null;
		}

		// Token: 0x0600F14D RID: 61773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Spawn(int count)
		{
			throw null;
		}

		// Token: 0x0600F14E RID: 61774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0(int count)
		{
			throw null;
		}

		// Token: 0x0400F75C RID: 63324
		[Header("Spawn")]
		[SerializeField]
		private GameObject[] _birdsPrefabs;

		// Token: 0x0400F75D RID: 63325
		[SerializeField]
		private int _count;

		// Token: 0x0400F75E RID: 63326
		[SerializeField]
		private float _spawnDelay;

		// Token: 0x0400F75F RID: 63327
		[SerializeField]
		private float _spawnRadius;

		// Token: 0x0400F760 RID: 63328
		[Header("Behaviour")]
		[Header("Boids:")]
		public float BaseSpeed;

		// Token: 0x0400F761 RID: 63329
		public float CohesionRadius;

		// Token: 0x0400F762 RID: 63330
		public float SeparationMaxSqrDistance;

		// Token: 0x0400F763 RID: 63331
		public int MinBoidsForCohesion;

		// Token: 0x0400F764 RID: 63332
		public int MaxBoidsForCohesion;

		// Token: 0x0400F765 RID: 63333
		[Header("Update")]
		public float CalculationVelocityInterval;

		// Token: 0x0400F766 RID: 63334
		public float UpdateDirectionInterval;

		// Token: 0x0400F767 RID: 63335
		[Header("Mults")]
		public float VelocityMult;

		// Token: 0x0400F768 RID: 63336
		public float SeparationMult;

		// Token: 0x0400F769 RID: 63337
		public float CohesionMult;

		// Token: 0x0400F76A RID: 63338
		public float AlignmentMult;

		// Token: 0x0400F76B RID: 63339
		[Header("Swarm Center")]
		public float SwarmSqrRadius;

		// Token: 0x0400F76C RID: 63340
		[HideInInspector]
		public Transform TransformCache;
	}
}
