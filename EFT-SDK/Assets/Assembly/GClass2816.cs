using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002569 RID: 9577
public class GClass2816 : GClass2809
{
	// Token: 0x140002B4 RID: 692
	// (add) Token: 0x0600BF89 RID: 49033 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BF8A RID: 49034 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnSelected
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

	// Token: 0x1700222B RID: 8747
	// (get) Token: 0x0600BF8B RID: 49035 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSelected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BF8C RID: 49036 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActive(out string tooltip)
	{
		throw null;
	}

	// Token: 0x0600BF8D RID: 49037 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleSelection()
	{
		throw null;
	}

	// Token: 0x0600BF8E RID: 49038 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2816 CreateSelectableChild(Item item)
	{
		throw null;
	}

	// Token: 0x0600BF8F RID: 49039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GClass2816 CreateSelectableChild(Item item, ItemAddress targetAddress)
	{
		throw null;
	}

	// Token: 0x0600BF90 RID: 49040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass2809 CreateChild(Item item)
	{
		throw null;
	}

	// Token: 0x0600BF91 RID: 49041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Item item, bool selected)
	{
		throw null;
	}

	// Token: 0x0600BF92 RID: 49042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SwitchToParentsSource()
	{
		throw null;
	}

	// Token: 0x0600BF93 RID: 49043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C173 RID: 49523
	[CompilerGenerated]
	private Action<bool> action_6;

	// Token: 0x0400C174 RID: 49524
	private bool bool_0;

	// Token: 0x0400C175 RID: 49525
	private readonly GClass2816.GInterface335 ginterface335_0;

	// Token: 0x0400C176 RID: 49526
	public readonly ItemAddress TargetAddress;

	// Token: 0x0400C177 RID: 49527
	private GClass2816 gclass2816_0;

	// Token: 0x0200256A RID: 9578
	public interface GInterface335
	{
		// Token: 0x140002B5 RID: 693
		// (add) Token: 0x0600BF94 RID: 49044
		// (remove) Token: 0x0600BF95 RID: 49045
		event Action<Item, bool> OnItemSelected;

		// Token: 0x0600BF96 RID: 49046
		bool IsActive(GClass2816 context, out string tooltip);

		// Token: 0x0600BF97 RID: 49047
		bool IsSelected(Item item);

		// Token: 0x0600BF98 RID: 49048
		void ToggleSelection(GClass2816 context);
	}
}
