using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.EnvironmentEffect
{
	// Token: 0x020026C4 RID: 9924
	public class TriggerGroup : MonoBehaviour, EnvironmentManagerBase.GInterface21
	{
		// Token: 0x0600C4AF RID: 50351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reinit()
		{
			throw null;
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndoorTrigger Check(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Bounds bound)
		{
			throw null;
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(TriggerGroup t)
		{
			throw null;
		}

		// Token: 0x0400C65A RID: 50778
		[SerializeField]
		public Bounds Bounds;

		// Token: 0x0400C65B RID: 50779
		[SerializeField]
		public List<IndoorTrigger> _childrenTriggers;

		// Token: 0x0400C65C RID: 50780
		[SerializeField]
		public List<TriggerGroup> _childrenGroups;
	}
}
