using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.EnvironmentEffect
{
	// Token: 0x020026CC RID: 9932
	[RequireComponent(typeof(Collider))]
	[Obsolete]
	public class EnvironmentSwitcherTrigger : MonoBehaviour, IPhysicsTrigger, IPhysicsTriggerWithStay
	{
		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C4F2 RID: 50418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C4F3 RID: 50419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerStay(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C4F4 RID: 50420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600C4F7 RID: 50423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C4F8 RID: 50424 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0400C6B1 RID: 50865
		[Header("Синяя стрелка (ось Z) должна указывать наружу помещения")]
		public float MaxDaylight;

		// Token: 0x0400C6B2 RID: 50866
		public bool ChangeHarmonics;

		// Token: 0x0400C6B3 RID: 50867
		public float FadeTime;

		// Token: 0x0400C6B4 RID: 50868
		public Color IndorColor;

		// Token: 0x0400C6B5 RID: 50869
		[Space(15f)]
		public float SSAOIntensity;

		// Token: 0x0400C6B6 RID: 50870
		public int IndorShadowDistance;

		// Token: 0x0400C6B7 RID: 50871
		[CompilerGenerated]
		private readonly string string_0;
	}
}
