using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B19 RID: 6937
	[Serializable]
	public class QteData
	{
		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06009277 RID: 37495 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009278 RID: 37496 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Id")]
		public string Id
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600927A RID: 37498 RVA: 0x00002050 File Offset: 0x00000250
		[SerializeField]
		[JsonProperty("Type")]
		public QteData.EQteActivityType Type
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600927C RID: 37500 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Area")]
		public EAreaType AreaType
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x0600927D RID: 37501 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600927E RID: 37502 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("AreaLevel")]
		public int AreaLevel
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x0600927F RID: 37503 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009280 RID: 37504 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("QuickTimeEvents")]
		public QuickTimeEvent[] QuickTimeEvents
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06009281 RID: 37505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009282 RID: 37506 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Requirements")]
		public Requirement[] Requirements
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06009283 RID: 37507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009284 RID: 37508 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Results")]
		public Dictionary<QteData.EQteEffectType, QteResult> Results
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(QteData backendData)
		{
			throw null;
		}

		// Token: 0x02001B1A RID: 6938
		public enum EQteActivityType
		{
			// Token: 0x0400992E RID: 39214
			Gym
		}

		// Token: 0x02001B1B RID: 6939
		public enum EQteEffectType
		{
			// Token: 0x04009930 RID: 39216
			FinishEffect,
			// Token: 0x04009931 RID: 39217
			SingleSuccessEffect,
			// Token: 0x04009932 RID: 39218
			SingleFailEffect
		}
	}
}
