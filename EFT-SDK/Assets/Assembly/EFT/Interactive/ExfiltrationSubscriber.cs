using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200274D RID: 10061
	public class ExfiltrationSubscriber : MonoBehaviour
	{
		// Token: 0x0600C94C RID: 51532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Start()
		{
			throw null;
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus)
		{
			throw null;
		}

		// Token: 0x0600C94E RID: 51534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator Wait()
		{
			throw null;
		}

		// Token: 0x0600C94F RID: 51535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Play(bool force = false)
		{
			throw null;
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		// Token: 0x0400C972 RID: 51570
		public ExfiltrationPoint Subscribee;

		// Token: 0x0400C973 RID: 51571
		public float Delay;
	}
}
