using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002750 RID: 10064
	public abstract class BorderZone : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x0600C95B RID: 51547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C95C RID: 51548 RVA: 0x00002050 File Offset: 0x00000250
		public int Id
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600C95D RID: 51549 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float Delay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600C95E RID: 51550 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140002D8 RID: 728
		// (add) Token: 0x0600C95F RID: 51551 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C960 RID: 51552 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GInterface94, BorderZone, float, bool> PlayerShotEvent
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

		// Token: 0x0600C961 RID: 51553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IEnumerator FireCoroutine(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAuthority()
		{
			throw null;
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ProcessIncomingPacket(GInterface94 player, bool willHit = true)
		{
			throw null;
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C966 RID: 51558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Player player)
		{
			throw null;
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Player player)
		{
			throw null;
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InvokePlayerShotEvent(GInterface94 player, float delay, bool willHit = true)
		{
			throw null;
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool IsInTriggerZone(Vector3 global)
		{
			throw null;
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600C96C RID: 51564 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer[] GetAllPlayersInArea
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x0600C96D RID: 51565 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C96E RID: 51566 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0400C97C RID: 51580
		protected const float DEEPENING_UPDATE_FREQUENCY = 1f;

		// Token: 0x0400C97D RID: 51581
		[SerializeField]
		private BoxCollider Collider;

		// Token: 0x0400C97E RID: 51582
		[SerializeField]
		protected Vector3 _extents;

		// Token: 0x0400C97F RID: 51583
		[SerializeField]
		protected Vector4 _triggerZoneSettings;

		// Token: 0x0400C980 RID: 51584
		private float float_0;

		// Token: 0x0400C981 RID: 51585
		protected List<IPlayer> TargetedPlayers;

		// Token: 0x0400C982 RID: 51586
		protected List<IPlayer> NotTargetedPlayers;

		// Token: 0x0400C983 RID: 51587
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400C984 RID: 51588
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x0400C985 RID: 51589
		[CompilerGenerated]
		private Action<GInterface94, BorderZone, float, bool> action_0;
	}
}
