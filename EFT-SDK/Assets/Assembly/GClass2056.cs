using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.Trading;

// Token: 0x02001D59 RID: 7513
public abstract class GClass2056 : GClass2053
{
	// Token: 0x17001826 RID: 6182
	// (get) Token: 0x06009B2E RID: 39726
	protected abstract IReadOnlyList<string> ServiceAccept { get; }

	// Token: 0x17001827 RID: 6183
	// (get) Token: 0x06009B2F RID: 39727
	protected abstract IReadOnlyList<string> FailedToAccept { get; }

	// Token: 0x17001828 RID: 6184
	// (get) Token: 0x06009B30 RID: 39728
	protected abstract string PayoffLocale { get; }

	// Token: 0x140001D6 RID: 470
	// (add) Token: 0x06009B31 RID: 39729 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B32 RID: 39730 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct243, EServiceActionType, DialogDataStruct, IEnumerable<MongoID>, bool> OnExecute
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

	// Token: 0x17001829 RID: 6185
	// (get) Token: 0x06009B33 RID: 39731 RVA: 0x00002050 File Offset: 0x00000250
	protected override GStruct243 NextDialogData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700182B RID: 6187
	// (get) Token: 0x06009B34 RID: 39732 RVA: 0x00002050 File Offset: 0x00000250
	protected override GStruct246.EDialogLiteIconType IconType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009B35 RID: 39733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private DialogDataStruct method_2(GClass1791 serviceData, string subServiceId)
	{
		throw null;
	}

	// Token: 0x06009B36 RID: 39734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ExecuteInternal()
	{
		throw null;
	}

	// Token: 0x06009B37 RID: 39735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<GStruct243> method_3()
	{
		throw null;
	}

	// Token: 0x06009B38 RID: 39736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<EServiceActionType> method_4()
	{
		throw null;
	}

	// Token: 0x0400A283 RID: 41603
	[CompilerGenerated]
	private Action<GStruct243, EServiceActionType, DialogDataStruct, IEnumerable<MongoID>, bool> action_3;

	// Token: 0x0400A284 RID: 41604
	private GStruct243 gstruct243_0;

	// Token: 0x0400A285 RID: 41605
	private GClass1791 gclass1791_0;

	// Token: 0x0400A286 RID: 41606
	private readonly InventoryControllerClass gclass2757_0;

	// Token: 0x0400A287 RID: 41607
	private string string_0;

	// Token: 0x0400A288 RID: 41608
	private AbstractQuestControllerClass gclass3203_0;

	// Token: 0x0400A289 RID: 41609
	[CompilerGenerated]
	private readonly DialogDataStruct gstruct245_0;
}
