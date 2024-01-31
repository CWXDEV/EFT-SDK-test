using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Diz.Binding;
using Newtonsoft.Json;

namespace EFT.Quests
{
	// Token: 0x02002FCB RID: 12235
	public abstract class Condition : IUpdatable<Condition>
	{
		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600F19D RID: 61853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F19E RID: 61854 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty]
		public string id
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600F19F RID: 61855 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F1A0 RID: 61856 RVA: 0x00002050 File Offset: 0x00000250
		[DefaultValue(1)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float value
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

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600F1A1 RID: 61857 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F1A2 RID: 61858 RVA: 0x00002050 File Offset: 0x00000250
		[DefaultValue(ECompareMethod.MoreOrEqual)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ECompareMethod compareMethod
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x0600F1A3 RID: 61859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F1A4 RID: 61860 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int index
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600F1A5 RID: 61861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F1A6 RID: 61862 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("dynamicLocale")]
		public bool DynamicLocale
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600F1A7 RID: 61863 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool IsNecessary
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600F1A8 RID: 61864 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public virtual string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600F1A9 RID: 61865 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool IsHiddenValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F1AA RID: 61866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetIdentity()
		{
			throw null;
		}

		// Token: 0x0600F1AB RID: 61867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual List<object> IdentityFields()
		{
			throw null;
		}

		// Token: 0x0600F1AC RID: 61868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CalculateIdentity(object[] fields)
		{
			throw null;
		}

		// Token: 0x0600F1AD RID: 61869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CalculateIdentity(List<object> fields)
		{
			throw null;
		}

		// Token: 0x0600F1AE RID: 61870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CalculateIdentity(List<int> fieldsOfHashCodes)
		{
			throw null;
		}

		// Token: 0x0600F1AF RID: 61871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600F1B0 RID: 61872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Compare(Condition other)
		{
			throw null;
		}

		// Token: 0x0600F1B1 RID: 61873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFromAnotherItem(Condition other)
		{
			throw null;
		}

		// Token: 0x0400F7B0 RID: 63408
		[JsonProperty("visibilityConditions")]
		public Condition[] VisibilityConditions;

		// Token: 0x0400F7B2 RID: 63410
		public string parentId;

		// Token: 0x0400F7B4 RID: 63412
		private int _identity;

		// Token: 0x0400F7B5 RID: 63413
		public GClass3364<Condition> ChildConditions;

		// Token: 0x0400F7B6 RID: 63414
		[JsonProperty("oneSessionOnly")]
		public bool resetOnSessionEnd;

		// Token: 0x02002FCC RID: 12236
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3054
		{
			// Token: 0x0400F7B7 RID: 63415
			public static readonly Condition.Class3054 class3054_0;

			// Token: 0x0400F7B8 RID: 63416
			public static Func<object, int> func_0;

			// Token: 0x0400F7B9 RID: 63417
			public static Func<int, int, int> func_1;

			// Token: 0x0400F7BA RID: 63418
			public static Func<object, int> func_2;

			// Token: 0x0400F7BB RID: 63419
			public static Func<int, int, int> func_3;

			// Token: 0x0400F7BC RID: 63420
			public static Func<int, int, int> func_4;
		}
	}
}
