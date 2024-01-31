using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.HealthSystem;

// Token: 0x02002CD4 RID: 11476
public abstract class GClass3096 : IDisposable, GInterface371, GInterface372
{
	// Token: 0x1400031D RID: 797
	// (add) Token: 0x0600E1AC RID: 57772 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E1AD RID: 57773 RVA: 0x00002050 File Offset: 0x00000250
	private event Action Event_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1700274D RID: 10061
	// (get) Token: 0x0600E1AE RID: 57774 RVA: 0x00002050 File Offset: 0x00000250
	protected static BackendConfigSettingsClass.GClass1357.GClass1359 GClass1359_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700274E RID: 10062
	// (get) Token: 0x0600E1AF RID: 57775 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E1B0 RID: 57776 RVA: 0x00002050 File Offset: 0x00000250
	public EHealthFactorType FactorType { get; }

	public string TreatmentName
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

	// Token: 0x1700274F RID: 10063
	// (get) Token: 0x0600E1B1 RID: 57777 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E1B2 RID: 57778 RVA: 0x00002050 File Offset: 0x00000250
	public float ValueToHeal
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

	// Token: 0x17002750 RID: 10064
	// (get) Token: 0x0600E1B3 RID: 57779 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E1B4 RID: 57780 RVA: 0x00002050 File Offset: 0x00000250
	public float TreatmentCost
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

	// Token: 0x17002752 RID: 10066
	// (get) Token: 0x0600E1B5 RID: 57781
	protected abstract float HealPrice { get; }

	// Token: 0x17002753 RID: 10067
	// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x00002050 File Offset: 0x00000250
	public bool Active
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600E1B7 RID: 57783
	protected abstract float GetValueToHeal();

	// Token: 0x0600E1B8 RID: 57784
	public abstract void Dispose();

	// Token: 0x0600E1B9 RID: 57785
	protected abstract void Init();

	// Token: 0x0600E1BA RID: 57786
	public abstract void Store(TreatmentDataClass treatmentData, out float cost);

	// Token: 0x0600E1BB RID: 57787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTreatment()
	{
		throw null;
	}

	// Token: 0x0600E1BC RID: 57788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action Subscribe(Action handler)
	{
		throw null;
	}

	// Token: 0x0600E1BD RID: 57789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unsubscribe(Action handler)
	{
		throw null;
	}

	// Token: 0x0600E1BE RID: 57790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface372 Clone(Profile profile, HealthControllerClass healthController, Profile.TraderInfo traderInfo)
	{
		throw null;
	}

	// Token: 0x0600E1BF RID: 57791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600E1C0 RID: 57792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0()
	{
		throw null;
	}

	// Token: 0x0600E1C1 RID: 57793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Profile profile, HealthControllerClass healthController, Profile.TraderInfo traderInfo)
	{
		throw null;
	}

	// Token: 0x0400E695 RID: 59029
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400E696 RID: 59030
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400E697 RID: 59031
	[CompilerGenerated]
	private float float_0;

	// Token: 0x0400E698 RID: 59032
	[CompilerGenerated]
	private float float_1;

	// Token: 0x0400E699 RID: 59033
	protected HealthControllerClass gclass2415_0;

	// Token: 0x0400E69A RID: 59034
	private Profile profile_0;

	// Token: 0x0400E69B RID: 59035
	private Profile.TraderInfo traderInfo_0;

	// Token: 0x02002CD5 RID: 11477
	[CompilerGenerated]
	private sealed class Class2744
	{
		// Token: 0x0600E1C2 RID: 57794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400E69C RID: 59036
		public GClass3096 gclass3096_0;

		// Token: 0x0400E69D RID: 59037
		public Action handler;
	}
}
