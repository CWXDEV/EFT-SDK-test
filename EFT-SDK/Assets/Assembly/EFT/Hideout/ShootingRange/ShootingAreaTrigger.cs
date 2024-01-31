using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C0B RID: 7179
	public class ShootingAreaTrigger : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x0600969F RID: 38559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider collider)
		{
			throw null;
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider collider)
		{
			throw null;
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x060096A1 RID: 38561 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x060096A2 RID: 38562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060096A3 RID: 38563 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x04009D9A RID: 40346
		[SerializeField]
		private InteractiveShootingRange[] _targetControllers;

		// Token: 0x04009D9B RID: 40347
		[CompilerGenerated]
		private readonly string string_0;
	}
}
