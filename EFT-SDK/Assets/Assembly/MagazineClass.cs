using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020023A6 RID: 9126
public class MagazineClass : GClass2662, IAmmoContainer
{
	// Token: 0x17002019 RID: 8217
	// (get) Token: 0x0600B840 RID: 47168 RVA: 0x00002050 File Offset: 0x00000250
	public virtual int MaxCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700201A RID: 8218
	// (get) Token: 0x0600B841 RID: 47169 RVA: 0x00002050 File Offset: 0x00000250
	public int magAnimationIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700201B RID: 8219
	// (get) Token: 0x0600B842 RID: 47170 RVA: 0x00002050 File Offset: 0x00000250
	public float LoadUnloadModifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700201C RID: 8220
	// (get) Token: 0x0600B843 RID: 47171 RVA: 0x00002050 File Offset: 0x00000250
	public float CheckTimeModifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700201D RID: 8221
	// (get) Token: 0x0600B844 RID: 47172 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass2568.GStruct367> VisibleAmmoRanges
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700201E RID: 8222
	// (get) Token: 0x0600B845 RID: 47173 RVA: 0x00002050 File Offset: 0x00000250
	public Weapon.EReloadMode ReloadMagType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700201F RID: 8223
	// (get) Token: 0x0600B846 RID: 47174 RVA: 0x00002050 File Offset: 0x00000250
	public float MalfunctionChance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002020 RID: 8224
	// (get) Token: 0x0600B847 RID: 47175 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMagazineWithBelt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002021 RID: 8225
	// (get) Token: 0x0600B848 RID: 47176 RVA: 0x00002050 File Offset: 0x00000250
	public int BeltMagazineRefreshCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002022 RID: 8226
	// (get) Token: 0x0600B849 RID: 47177 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMagazineForStationaryWeapon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002023 RID: 8227
	// (get) Token: 0x0600B84A RID: 47178 RVA: 0x00002050 File Offset: 0x00000250
	public int CheckOverride
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B84B RID: 47179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_29()
	{
		throw null;
	}

	// Token: 0x0600B84C RID: 47180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_30(float value)
	{
		throw null;
	}

	// Token: 0x0600B84D RID: 47181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAmmoCountByLevel(int ammoCount, int maxAmmoCount, int skill, string color, bool @checked, bool itemInHands, string valueFormat)
	{
		throw null;
	}

	// Token: 0x0600B84E RID: 47182 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override MagazineClass GetCurrentMagazine()
	{
		throw null;
	}

	// Token: 0x0600B84F RID: 47183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Compare(Item item)
	{
		throw null;
	}

	// Token: 0x17002024 RID: 8228
	// (get) Token: 0x0600B850 RID: 47184 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> ItemInteractionButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B851 RID: 47185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashSum()
	{
		throw null;
	}

	// Token: 0x17002025 RID: 8229
	// (get) Token: 0x0600B852 RID: 47186 RVA: 0x00002050 File Offset: 0x00000250
	public virtual int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B853 RID: 47187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Item FirstRealAmmo()
	{
		throw null;
	}

	// Token: 0x17002026 RID: 8230
	// (get) Token: 0x0600B854 RID: 47188 RVA: 0x00002050 File Offset: 0x00000250
	public StackSlot Cartridges
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002027 RID: 8231
	// (get) Token: 0x0600B855 RID: 47189 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<IContainer> Containers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B856 RID: 47190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item FindItem(string itemId)
	{
		throw null;
	}

	// Token: 0x0600B857 RID: 47191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IContainer GetContainer(string containerId)
	{
		throw null;
	}

	// Token: 0x0600B858 RID: 47192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BulletClass GetBulletAtPosition(int index)
	{
		throw null;
	}

	// Token: 0x0600B859 RID: 47193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAmmoCompatible(Slot[] chambers)
	{
		throw null;
	}

	// Token: 0x0600B85A RID: 47194 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct412 Apply([NotNull] TraderControllerClass itemController, [NotNull] Item item, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B85B RID: 47195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GStruct412 method_31([NotNull] TraderControllerClass itemController, [NotNull] Item item, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B85C RID: 47196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GStruct412 ApplyItem([NotNull] TraderControllerClass itemController, [NotNull] Item item, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B85D RID: 47197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GStruct412 ApplyWithoutRestrictions([NotNull] TraderControllerClass itemController, [NotNull] BulletClass ammo, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B85E RID: 47198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCompatibility(BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x0600B85F RID: 47199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxVisibleAmmo()
	{
		throw null;
	}

	// Token: 0x0600B860 RID: 47200 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_32()
	{
		throw null;
	}

	// Token: 0x0600B861 RID: 47201 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_33()
	{
		throw null;
	}

	// Token: 0x0600B862 RID: 47202 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_34()
	{
		throw null;
	}

	// Token: 0x0600B863 RID: 47203 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_35()
	{
		throw null;
	}

	// Token: 0x0600B864 RID: 47204 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_36()
	{
		throw null;
	}

	// Token: 0x0600B865 RID: 47205 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_37()
	{
		throw null;
	}

	// Token: 0x0600B866 RID: 47206 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_38()
	{
		throw null;
	}

	// Token: 0x0600B867 RID: 47207 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_39()
	{
		throw null;
	}

	// Token: 0x0600B868 RID: 47208 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_40()
	{
		throw null;
	}

	// Token: 0x0600B869 RID: 47209 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_41()
	{
		throw null;
	}

	// Token: 0x0600B86A RID: 47210 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<EItemInfoButton> method_42()
	{
		throw null;
	}

	// Token: 0x0400BB50 RID: 47952
	private static readonly string[] string_0;

	// Token: 0x0400BB51 RID: 47953
	public readonly TagComponent Tag;

	// Token: 0x0400BB52 RID: 47954
	private readonly string[] string_1;

	// Token: 0x0400BB53 RID: 47955
	private static List<EItemInfoButton> list_1;

	// Token: 0x0400BB54 RID: 47956
	public int ObservedMagazineCount;

	// Token: 0x0400BB55 RID: 47957
	[CompilerGenerated]
	private readonly StackSlot stackSlot_0;

	// Token: 0x020023A7 RID: 9127
	public sealed class GClass3323 : InventoryError
	{
		// Token: 0x0600B86B RID: 47211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BB56 RID: 47958
		public readonly MagazineClass Magazine;

		// Token: 0x0400BB57 RID: 47959
		public readonly BulletClass Ammo;
	}

	// Token: 0x020023A8 RID: 9128
	public sealed class GClass3324 : InventoryError
	{
		// Token: 0x0600B86D RID: 47213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BB58 RID: 47960
		public readonly StackSlot CartridgeSlot;

		// Token: 0x0400BB59 RID: 47961
		public readonly BulletClass Ammo;

		// Token: 0x020023A9 RID: 9129
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2025
		{
			// Token: 0x0600B86F RID: 47215 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<string> method_0(ItemFilter x)
			{
				throw null;
			}

			// Token: 0x0600B870 RID: 47216 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(string x)
			{
				throw null;
			}

			// Token: 0x0400BB5A RID: 47962
			public static readonly MagazineClass.GClass3324.Class2025 class2025_0;

			// Token: 0x0400BB5B RID: 47963
			public static Func<ItemFilter, IEnumerable<string>> func_0;

			// Token: 0x0400BB5C RID: 47964
			public static Func<string, string> func_1;
		}
	}

	// Token: 0x020023AA RID: 9130
	public sealed class GClass3325 : InventoryError
	{
		// Token: 0x0600B871 RID: 47217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetLocalizedDescription()
		{
			throw null;
		}

		// Token: 0x0400BB5D RID: 47965
		public readonly MagazineClass Magazine;

		// Token: 0x0400BB5E RID: 47966
		public readonly BulletClass Ammo;
	}

	// Token: 0x020023AB RID: 9131
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2026
	{
		// Token: 0x0600B873 RID: 47219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_0()
		{
			throw null;
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_1()
		{
			throw null;
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_2()
		{
			throw null;
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_3()
		{
			throw null;
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_4()
		{
			throw null;
		}

		// Token: 0x0400BB5F RID: 47967
		public static readonly MagazineClass.Class2026 class2026_0;

		// Token: 0x0400BB60 RID: 47968
		public static Func<EItemAttributeDisplayType> func_0;

		// Token: 0x0400BB61 RID: 47969
		public static Func<EItemAttributeDisplayType> func_1;

		// Token: 0x0400BB62 RID: 47970
		public static Func<EItemAttributeDisplayType> func_2;

		// Token: 0x0400BB63 RID: 47971
		public static Func<EItemAttributeDisplayType> func_3;

		// Token: 0x0400BB64 RID: 47972
		public static Func<EItemAttributeDisplayType> func_4;
	}
}
