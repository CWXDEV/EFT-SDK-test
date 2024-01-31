using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x020023A4 RID: 9124
public class GClass2568 : GClass2565
{
	// Token: 0x17002017 RID: 8215
	// (get) Token: 0x0600B83A RID: 47162 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600B83B RID: 47163 RVA: 0x00002050 File Offset: 0x00000250
	public static float MaxMalfunctionChance
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

	// Token: 0x17002018 RID: 8216
	// (get) Token: 0x0600B83C RID: 47164 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass2568.GStruct367> VisibleAmmoRanges
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B83D RID: 47165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnInit()
	{
		throw null;
	}

	// Token: 0x0600B83E RID: 47166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<GClass2568.GStruct367> smethod_0(string visibleAmmoRangesString, List<GClass2568.GStruct367> defaultVisibleRanges)
	{
		throw null;
	}

	// Token: 0x0400BB41 RID: 47937
	[CompilerGenerated]
	private static float float_0;

	// Token: 0x0400BB42 RID: 47938
	public int magAnimationIndex;

	// Token: 0x0400BB43 RID: 47939
	public StackSlot[] Cartridges;

	// Token: 0x0400BB44 RID: 47940
	public float LoadUnloadModifier;

	// Token: 0x0400BB45 RID: 47941
	public float CheckTimeModifier;

	// Token: 0x0400BB46 RID: 47942
	public int CheckOverride;

	// Token: 0x0400BB47 RID: 47943
	public Weapon.EReloadMode ReloadMagType;

	// Token: 0x0400BB48 RID: 47944
	public string VisibleAmmoRangesString;

	// Token: 0x0400BB49 RID: 47945
	public float MalfunctionChance;

	// Token: 0x0400BB4A RID: 47946
	public bool MagazineWithBelt;

	// Token: 0x0400BB4B RID: 47947
	public int BeltMagazineRefreshCount;

	// Token: 0x0400BB4C RID: 47948
	public bool IsMagazineForStationaryWeapon;

	// Token: 0x0400BB4D RID: 47949
	private List<GClass2568.GStruct367> list_0;

	// Token: 0x020023A5 RID: 9125
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct367
	{
		// Token: 0x0600B83F RID: 47167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(int stackableItemStackObjectsCount)
		{
			throw null;
		}

		// Token: 0x0400BB4E RID: 47950
		public int Start;

		// Token: 0x0400BB4F RID: 47951
		public int End;
	}
}
