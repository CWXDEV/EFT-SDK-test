using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using UnityEngine;

namespace EFT.Animals
{
	// Token: 0x02002FC0 RID: 12224
	public class BirdsSpawner : MonoBehaviour
	{
		// Token: 0x0600F157 RID: 61783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F158 RID: 61784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Spawn()
		{
			throw null;
		}

		// Token: 0x0600F159 RID: 61785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Spawn(int count)
		{
			throw null;
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0(int count)
		{
			throw null;
		}

		// Token: 0x0400F77B RID: 63355
		[SerializeField]
		private BezierSpline[] _paths;

		// Token: 0x0400F77C RID: 63356
		[SerializeField]
		private GameObject[] _birdsPrefabs;

		// Token: 0x0400F77D RID: 63357
		[SerializeField]
		private int _count;

		// Token: 0x0400F77E RID: 63358
		[SerializeField]
		private float _spawnDelay;
	}
}
