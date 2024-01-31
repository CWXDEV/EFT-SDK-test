using System;
using System.Runtime.CompilerServices;
using EFT.Counters;
using Newtonsoft.Json;

namespace EFT.Quests
{
	// Token: 0x02003002 RID: 12290
	public sealed class ConditionStatistic : ConditionOneTarget
	{
		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600F207 RID: 61959 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public SessionCountersClass.GClass1784 Counter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600F208 RID: 61960 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public CounterTag CounterTag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400F827 RID: 63527
		private SessionCountersClass.GClass1784 _counter;

		// Token: 0x0400F828 RID: 63528
		private CounterTag? _counterTag;

		// Token: 0x0400F829 RID: 63529
		public bool byTag;
	}
}
