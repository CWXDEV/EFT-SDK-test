using System;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;
using Newtonsoft.Json;

// Token: 0x02001283 RID: 4739
public abstract class GClass1404
{
	// Token: 0x17000FB2 RID: 4018
	// (get) Token: 0x060062D6 RID: 25302 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062D7 RID: 25303 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("id")]
	public MongoID Id
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

	// Token: 0x17000FB3 RID: 4019
	// (get) Token: 0x060062D8 RID: 25304 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062D9 RID: 25305 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("value")]
	public double Value
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

	// Token: 0x17000FB4 RID: 4020
	// (get) Token: 0x060062DA RID: 25306
	[JsonProperty("type")]
	public abstract EBonusType BonusType { get; }

	// Token: 0x17000FB5 RID: 4021
	// (get) Token: 0x060062DB RID: 25307 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062DC RID: 25308 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("visible")]
	public bool IsVisible
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

	// Token: 0x17000FB6 RID: 4022
	// (get) Token: 0x060062DD RID: 25309 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062DE RID: 25310 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("passive")]
	public bool Passive
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

	// Token: 0x17000FB7 RID: 4023
	// (get) Token: 0x060062DF RID: 25311 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062E0 RID: 25312 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("production")]
	public bool Production
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

	// Token: 0x17000FB8 RID: 4024
	// (get) Token: 0x060062E1 RID: 25313 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062E2 RID: 25314 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("icon")]
	public string Icon
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

	// Token: 0x17000FB9 RID: 4025
	// (get) Token: 0x060062E3 RID: 25315 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public virtual string ValueFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000FBA RID: 4026
	// (get) Token: 0x060062E4 RID: 25316 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public virtual Enum TargetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000FBB RID: 4027
	// (get) Token: 0x060062E5 RID: 25317 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public virtual double ResultValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060062E6 RID: 25318
	public abstract double CalculateValue(double input);

	// Token: 0x17000FBC RID: 4028
	// (get) Token: 0x060062E7 RID: 25319 RVA: 0x00002050 File Offset: 0x00000250
	public virtual string LocalizationKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000FBD RID: 4029
	// (get) Token: 0x060062E8 RID: 25320 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool IsPositive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060062E9 RID: 25321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x060062EA RID: 25322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Add(GClass1404 bonus)
	{
		throw null;
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GClass1404 Clone()
	{
		throw null;
	}

	// Token: 0x04006FDB RID: 28635
	[CompilerGenerated]
	private MongoID mongoID_0;

	// Token: 0x04006FDC RID: 28636
	[CompilerGenerated]
	private double double_0;

	// Token: 0x04006FDD RID: 28637
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04006FDE RID: 28638
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x04006FDF RID: 28639
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04006FE0 RID: 28640
	[CompilerGenerated]
	private string string_0;
}
