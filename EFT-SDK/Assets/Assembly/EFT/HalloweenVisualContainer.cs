using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016C5 RID: 5829
	public class HalloweenVisualContainer : MonoBehaviour
	{
		// Token: 0x06007DD1 RID: 32209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(Vector3 ritualPosition = default(Vector3))
		{
			throw null;
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchLight(bool value)
		{
			throw null;
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchSight(bool value)
		{
			throw null;
		}

		// Token: 0x040084AB RID: 33963
		[SerializeField]
		private CultistSignEffect _sign;

		// Token: 0x040084AC RID: 33964
		[SerializeField]
		private LightPillarEffect _pillar;
	}
}
