using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;

// Token: 0x02001D68 RID: 7528
public abstract class GClass2053
{
	// Token: 0x140001D8 RID: 472
	// (add) Token: 0x06009B5E RID: 39774 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B5F RID: 39775 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct246.GStruct247> OnSaveState
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

	// Token: 0x140001D9 RID: 473
	// (add) Token: 0x06009B60 RID: 39776 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B61 RID: 39777 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct243, DialogDataStruct> OnChangeDialog
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

	// Token: 0x140001DA RID: 474
	// (add) Token: 0x06009B62 RID: 39778 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B63 RID: 39779 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnBlockDialog
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

	// Token: 0x17001841 RID: 6209
	// (get) Token: 0x06009B64 RID: 39780 RVA: 0x00002050 File Offset: 0x00000250
	public Sprite Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001842 RID: 6210
	// (get) Token: 0x06009B65 RID: 39781 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual ECommand ExecuteCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001843 RID: 6211
	// (get) Token: 0x06009B66 RID: 39782 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual GStruct246.GStruct247? SaveState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001844 RID: 6212
	// (get) Token: 0x06009B67 RID: 39783
	protected abstract GStruct243 NextDialogData { get; }

	// Token: 0x17001845 RID: 6213
	// (get) Token: 0x06009B68 RID: 39784
	protected abstract GStruct246.EDialogLiteIconType IconType { get; }

	// Token: 0x06009B69 RID: 39785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute()
	{
		throw null;
	}

	// Token: 0x06009B6A RID: 39786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ExecuteInternal()
	{
		throw null;
	}

	// Token: 0x06009B6B RID: 39787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GStruct246.GStruct247 data)
	{
		throw null;
	}

	// Token: 0x06009B6C RID: 39788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1()
	{
		throw null;
	}

	// Token: 0x06009B6D RID: 39789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputNode.ETranslateResult TranslateCommand(ECommand command)
	{
		throw null;
	}

	// Token: 0x0400A2C3 RID: 41667
	[CompilerGenerated]
	private Action<GStruct246.GStruct247> action_0;

	// Token: 0x0400A2C4 RID: 41668
	[CompilerGenerated]
	private Action<GStruct243, DialogDataStruct> action_1;

	// Token: 0x0400A2C5 RID: 41669
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400A2C6 RID: 41670
	public bool IsActiveAndInteractive;
}
