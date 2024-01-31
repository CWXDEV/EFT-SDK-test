using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AB0 RID: 6832
	public sealed class HideoutAreaTrigger : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06008FE9 RID: 36841 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(HideoutArea area)
		{
			throw null;
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06008FED RID: 36845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008FEE RID: 36846 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x04009724 RID: 38692
		[SerializeField]
		private List<HideoutInteractionTrigger> _levelTriggers;

		// Token: 0x04009725 RID: 38693
		private HideoutArea hideoutArea_0;

		// Token: 0x04009726 RID: 38694
		[CompilerGenerated]
		private readonly string string_0;
	}
}
