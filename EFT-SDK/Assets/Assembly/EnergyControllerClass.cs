using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001AA0 RID: 6816
public sealed class EnergyControllerClass : GInterface147, GInterface168
{
	// Token: 0x1400019E RID: 414
	// (add) Token: 0x06008F96 RID: 36758 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06008F97 RID: 36759 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnEnergyGenerationChanged
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

	// Token: 0x170015BF RID: 5567
	// (get) Token: 0x06008F98 RID: 36760 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008F99 RID: 36761 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEnergyGenerationOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06008F9A RID: 36762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGenerator(GInterface160 generator, bool switchedOn)
	{
		throw null;
	}

	// Token: 0x06008F9B RID: 36763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GInterface160 generator, bool isWorking)
	{
		throw null;
	}

	// Token: 0x06008F9C RID: 36764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start(float profileDecayTime)
	{
		throw null;
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06008F9E RID: 36766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSwitchedStatus(bool isOn)
	{
		throw null;
	}

	// Token: 0x06008F9F RID: 36767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool hasFuel, bool switchedOn)
	{
		throw null;
	}

	// Token: 0x06008FA0 RID: 36768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040096C0 RID: 38592
	private readonly List<GInterface160> list_0;

	// Token: 0x040096C1 RID: 38593
	[CompilerGenerated]
	private Action<bool> action_0;

	// Token: 0x040096C2 RID: 38594
	private bool bool_0;

	// Token: 0x040096C3 RID: 38595
	private bool bool_1;

	// Token: 0x040096C4 RID: 38596
	private bool bool_2;

	// Token: 0x02001AA1 RID: 6817
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1598
	{
		// Token: 0x06008FA1 RID: 36769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GInterface160 registeredGenerator)
		{
			throw null;
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GInterface160 registeredGenerator)
		{
			throw null;
		}

		// Token: 0x040096C5 RID: 38597
		public static readonly EnergyControllerClass.Class1598 class1598_0;

		// Token: 0x040096C6 RID: 38598
		public static Func<GInterface160, bool> func_0;

		// Token: 0x040096C7 RID: 38599
		public static Func<GInterface160, bool> func_1;
	}
}
