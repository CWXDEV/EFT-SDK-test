using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;

// Token: 0x02002881 RID: 10369
public class GClass3008
{
	// Token: 0x0600CF15 RID: 53013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitSelected()
	{
		throw null;
	}

	// Token: 0x0600CF16 RID: 53014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DefaultSelected()
	{
		throw null;
	}

	// Token: 0x0600CF17 RID: 53015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectNextAction()
	{
		throw null;
	}

	// Token: 0x0600CF18 RID: 53016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectPreviousAction()
	{
		throw null;
	}

	// Token: 0x0600CF19 RID: 53017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectAction(GClass3007 action)
	{
		throw null;
	}

	// Token: 0x0400CFD8 RID: 53208
	public List<GClass3007> Actions;

	// Token: 0x0400CFD9 RID: 53209
	public GClass3007 SelectedAction;

	// Token: 0x0400CFDA RID: 53210
	public string Error;

	// Token: 0x0400CFDB RID: 53211
	[NonSerialized]
	public BindableEvent CurrentActionChanged;

	// Token: 0x02002882 RID: 10370
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2348
	{
		// Token: 0x0600CF1A RID: 53018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3007 x)
		{
			throw null;
		}

		// Token: 0x0600CF1B RID: 53019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass3007 x)
		{
			throw null;
		}

		// Token: 0x0600CF1C RID: 53020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GClass3007 x)
		{
			throw null;
		}

		// Token: 0x0400CFDC RID: 53212
		public static readonly GClass3008.Class2348 class2348_0;

		// Token: 0x0400CFDD RID: 53213
		public static Func<GClass3007, bool> func_0;

		// Token: 0x0400CFDE RID: 53214
		public static Func<GClass3007, bool> func_1;

		// Token: 0x0400CFDF RID: 53215
		public static Func<GClass3007, bool> func_2;
	}
}
