using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x02001FCB RID: 8139
public class GClass2362 : IDisposable
{
	// Token: 0x17001BC5 RID: 7109
	// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x00002050 File Offset: 0x00000250
	public EquipmentClass Equipment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BC6 RID: 7110
	// (get) Token: 0x0600A8FF RID: 43263 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600A900 RID: 43264 RVA: 0x00002050 File Offset: 0x00000250
	public BindableState<Item> ItemInHands
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

	// Token: 0x0600A901 RID: 43265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerBody playerBody, GClass2372 handsController, GClass2758 inventoryController, GStruct275 spawnMessage, ObservedPlayerView player)
	{
		throw null;
	}

	// Token: 0x0600A902 RID: 43266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GameObject parentModel)
	{
		throw null;
	}

	// Token: 0x0600A903 RID: 43267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x0600A904 RID: 43268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1(GClass2252 command)
	{
		throw null;
	}

	// Token: 0x0600A905 RID: 43269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass2223 command)
	{
		throw null;
	}

	// Token: 0x0600A906 RID: 43270 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(EquipmentSlot slotType, Slot slot)
	{
		throw null;
	}

	// Token: 0x0600A907 RID: 43271 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass2221 command)
	{
		throw null;
	}

	// Token: 0x0600A908 RID: 43272 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GClass2220 changeEquipCommandMessaged)
	{
		throw null;
	}

	// Token: 0x0600A909 RID: 43273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(EquipmentSlot slotType, Slot slot)
	{
		throw null;
	}

	// Token: 0x0600A90A RID: 43274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(PlayerBody.GClass1857 slotView)
	{
		throw null;
	}

	// Token: 0x0600A90B RID: 43275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(ValueTuple<Item, WeaponPrefab> prev, ValueTuple<Item, WeaponPrefab> next)
	{
		throw null;
	}

	// Token: 0x0600A90C RID: 43276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AFAC RID: 44972
	[CompilerGenerated]
	private BindableState<Item> gclass3370_0;

	// Token: 0x0400AFAD RID: 44973
	private PlayerBody playerBody_0;

	// Token: 0x0400AFAE RID: 44974
	private PlayerBones playerBones_0;

	// Token: 0x0400AFAF RID: 44975
	private GClass2758 gclass2758_0;

	// Token: 0x0400AFB0 RID: 44976
	private GClass2372 gclass2372_0;

	// Token: 0x0400AFB1 RID: 44977
	private ObservedPlayerView observedPlayerView_0;

	// Token: 0x0400AFB2 RID: 44978
	private bool bool_0;

	// Token: 0x0400AFB3 RID: 44979
	private Dictionary<string, TacticalComboVisualController> dictionary_0;

	// Token: 0x0400AFB4 RID: 44980
	private Dictionary<string, GStruct162> dictionary_1;

	// Token: 0x0400AFB5 RID: 44981
	private static readonly List<EquipmentSlot> list_0;

	// Token: 0x0400AFB6 RID: 44982
	private static readonly List<EquipmentSlot> list_1;

	// Token: 0x02001FCC RID: 8140
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1835
	{
		// Token: 0x0600A90D RID: 43277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(TacticalComboVisualController k)
		{
			throw null;
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TacticalComboVisualController method_1(TacticalComboVisualController v)
		{
			throw null;
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<IContainer> method_2(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0400AFB7 RID: 44983
		public static readonly GClass2362.Class1835 class1835_0;

		// Token: 0x0400AFB8 RID: 44984
		public static Func<TacticalComboVisualController, string> func_0;

		// Token: 0x0400AFB9 RID: 44985
		public static Func<TacticalComboVisualController, TacticalComboVisualController> func_1;

		// Token: 0x0400AFBA RID: 44986
		public static Func<ContainerCollection, IEnumerable<IContainer>> func_2;
	}

	// Token: 0x02001FCE RID: 8142
	[CompilerGenerated]
	private sealed class Class1836
	{
		// Token: 0x0600A912 RID: 43282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Item item, bool equipped)
		{
			throw null;
		}

		// Token: 0x0400AFC1 RID: 44993
		public GClass2362 gclass2362_0;

		// Token: 0x0400AFC2 RID: 44994
		public EquipmentSlot slotType;

		// Token: 0x0400AFC3 RID: 44995
		public Slot slot;
	}
}
