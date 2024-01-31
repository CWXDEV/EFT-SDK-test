using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D2E RID: 3374
	[Serializable]
	public sealed class AudioTriggerArea : MonoBehaviour, IPhysicsTrigger, IPhysicsTriggerWithStay
	{
		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x060047D0 RID: 18384 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047D1 RID: 18385 RVA: 0x00002050 File Offset: 0x00000250
		public event EventHandler<GEventArgs0> OnTriggerArea
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider coll)
		{
			throw null;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerStay(Collider coll)
		{
			throw null;
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider coll)
		{
			throw null;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(IPlayer player)
		{
			throw null;
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(IPlayer player)
		{
			throw null;
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BoxCollider GetCollider()
		{
			throw null;
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x040052B6 RID: 21174
		[SerializeField]
		private BoxCollider areaCollider;

		// Token: 0x040052B7 RID: 21175
		private Dictionary<int, int> _playersTriggerCounter;

		// Token: 0x040052B8 RID: 21176
		private Dictionary<Collider, IPlayer> _playersColliders;
	}
}
