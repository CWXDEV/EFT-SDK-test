using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002758 RID: 10072
	[RequireComponent(typeof(Collider))]
	public abstract class DamageTrigger : MonoBehaviour, IPhysicsTrigger, IPhysicsTriggerWithStay
	{
		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x0600C9A9 RID: 51625 RVA: 0x00002050 File Offset: 0x00000250
		public virtual string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x0600C9AA RID: 51626
		protected abstract bool IsStatic { get; }

		// Token: 0x0600C9AB RID: 51627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerStay(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C9B1 RID: 51633
		protected abstract void ProceedDamage(GInterface94 player, BodyPartCollider bodyPart);

		// Token: 0x0600C9B2 RID: 51634
		protected abstract void AddPenalty(GInterface94 player);

		// Token: 0x0600C9B3 RID: 51635
		protected abstract void RemovePenalty(GInterface94 player);

		// Token: 0x0600C9B4 RID: 51636
		protected abstract void PlaySound();

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600C9B5 RID: 51637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C9B6 RID: 51638 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0400C9BA RID: 51642
		private Collider collider_0;

		// Token: 0x0400C9BB RID: 51643
		private Bounds bounds_0;

		// Token: 0x0400C9BC RID: 51644
		private Collider[] collider_1;

		// Token: 0x0400C9BD RID: 51645
		private Dictionary<Player, int> dictionary_0;

		// Token: 0x0400C9BE RID: 51646
		[CompilerGenerated]
		private readonly string string_0;
	}
}
