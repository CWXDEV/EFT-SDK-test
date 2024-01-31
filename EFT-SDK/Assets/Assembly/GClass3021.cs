using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.UI;
using UnityEngine;

// Token: 0x020029D3 RID: 10707
public abstract class GClass3021<T> where T : struct, Enum
{
	// Token: 0x140002EA RID: 746
	// (add) Token: 0x0600D4F2 RID: 54514 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600D4F3 RID: 54515 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnRedrawRequired
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

	// Token: 0x170025B0 RID: 9648
	// (get) Token: 0x0600D4F4 RID: 54516 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual IEnumerable<T> SubInteractions
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025B1 RID: 9649
	// (get) Token: 0x0600D4F5 RID: 54517 RVA: 0x00002050 File Offset: 0x00000250
	public virtual IEnumerable<T> AllInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025B2 RID: 9650
	// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool ExaminationRequired
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025B3 RID: 9651
	// (get) Token: 0x0600D4F7 RID: 54519 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Dictionary<T, string> CustomNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025B4 RID: 9652
	// (get) Token: 0x0600D4F8 RID: 54520 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GClass3020> DynamicInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025B5 RID: 9653
	// (get) Token: 0x0600D4F9 RID: 54521 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool HasIcons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025B6 RID: 9654
	// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool HasInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600D4FB RID: 54523
	protected abstract void ExecuteInteractionInternal(T interaction);

	// Token: 0x0600D4FC RID: 54524
	public abstract bool IsActive(T button);

	// Token: 0x0600D4FD RID: 54525
	public abstract IResult IsInteractive(T button);

	// Token: 0x0600D4FE RID: 54526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0()
	{
		throw null;
	}

	// Token: 0x0600D4FF RID: 54527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(string id, string key, Action callback, Sprite icon = null)
	{
		throw null;
	}

	// Token: 0x0600D500 RID: 54528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(string key)
	{
		throw null;
	}

	// Token: 0x0600D501 RID: 54529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateSubInteractions(T parentInteraction, IBallisticsCalculator subInteractionsWrapper)
	{
		throw null;
	}

	// Token: 0x0600D502 RID: 54530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSubInteractions(T interaction)
	{
		throw null;
	}

	// Token: 0x0600D503 RID: 54531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallRedraw(string templateId)
	{
		throw null;
	}

	// Token: 0x0600D504 RID: 54532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInteractionAvailable(T interaction)
	{
		throw null;
	}

	// Token: 0x0600D505 RID: 54533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExecuteDynamicInteraction(string dynamicInteraction)
	{
		throw null;
	}

	// Token: 0x0600D506 RID: 54534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExecuteInteraction(T interaction)
	{
		throw null;
	}

	// Token: 0x0400D732 RID: 55090
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400D733 RID: 55091
	[CompilerGenerated]
	private readonly IEnumerable<T> ienumerable_0;

	// Token: 0x0400D734 RID: 55092
	protected readonly ItemUiContext itemUiContext_0;

	// Token: 0x0400D735 RID: 55093
	private readonly Dictionary<string, GClass3020> dictionary_0;

	// Token: 0x0400D736 RID: 55094
	private static readonly IEnumerable<T> ienumerable_1;
}
