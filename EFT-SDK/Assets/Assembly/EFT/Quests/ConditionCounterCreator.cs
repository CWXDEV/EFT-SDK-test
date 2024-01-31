using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace EFT.Quests
{
	// Token: 0x02002FD8 RID: 12248
	public sealed class ConditionCounterCreator : Condition
	{
		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F1C9 RID: 61897 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public GClass3365 Conditions
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

		// Token: 0x0600F1CA RID: 61898 RVA: 0x00002050 File Offset: 0x00000250
		[OnDeserialized]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void OnDeserializedMethod(StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override List<object> IdentityFields()
		{
			throw null;
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600F1CC RID: 61900 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F1CD RID: 61901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string LocalizeDescription()
		{
			throw null;
		}

		// Token: 0x0600F1CE RID: 61902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400F7CC RID: 63436
		[JsonProperty("counter")]
		private ConditionCounterCreator.ConditionCounterTemplate _templateConditions;

		// Token: 0x0400F7CE RID: 63438
		public RawQuestClass.EQuestType type;

		// Token: 0x0400F7CF RID: 63439
		public bool doNotResetIfCounterCompleted;

		// Token: 0x0400F7D0 RID: 63440
		private static readonly Dictionary<Type, string> _localizationTypes;

		// Token: 0x02002FD9 RID: 12249
		private sealed class ConditionCounterTemplate
		{
			// Token: 0x0400F7D1 RID: 63441
			[JsonProperty("conditions")]
			public GClass3365 Conditions;
		}
	}
}
