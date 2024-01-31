using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020011A6 RID: 4518
	public class CorpseRagdollTestApplication : AbstractApplication
	{
		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x00002050 File Offset: 0x00000250
		protected override EUpdateQueue PlayerUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass635 CreateLogConfigurator()
		{
			throw null;
		}

		// Token: 0x0600605B RID: 24667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnCorpse(int count = 1)
		{
			throw null;
		}

		// Token: 0x0600605C RID: 24668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DropAll()
		{
			throw null;
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetAVGSimulationDeltaTime()
		{
			throw null;
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x04006A28 RID: 27176
		[SerializeField]
		private GameObject _corpsePrefab;

		// Token: 0x04006A29 RID: 27177
		[SerializeField]
		private GameObject _weaponPrefab;

		// Token: 0x04006A2A RID: 27178
		private List<CorpseRagdollTest> list_0;

		// Token: 0x04006A2B RID: 27179
		[SerializeField]
		private Vector3 _velocity;

		// Token: 0x04006A2C RID: 27180
		[SerializeField]
		private float _maxDepenetrationVelocity;

		// Token: 0x04006A2D RID: 27181
		[SerializeField]
		private CollisionDetectionMode _collisionDetectionMode;

		// Token: 0x04006A2E RID: 27182
		[SerializeField]
		private bool _keepRigidbody;

		// Token: 0x04006A2F RID: 27183
		[SerializeField]
		private bool _putToSleep;

		// Token: 0x04006A30 RID: 27184
		[SerializeField]
		private bool _dropWeapon;

		// Token: 0x04006A31 RID: 27185
		[SerializeField]
		private bool _weaponFixedHinge;
	}
}
