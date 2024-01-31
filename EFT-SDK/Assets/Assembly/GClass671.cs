using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.AssetsManager;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020006F4 RID: 1780
public class GClass671 : IDisposable
{
	// Token: 0x060029B7 RID: 10679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBone(IContainer container, Transform bone)
	{
		throw null;
	}

	// Token: 0x060029B8 RID: 10680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChildBones(Transform childRoot)
	{
		throw null;
	}

	// Token: 0x060029B9 RID: 10681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBone(IContainer container)
	{
		throw null;
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBones(IEnumerable<IContainer> containers)
	{
		throw null;
	}

	// Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetBoneForSlot(IContainer container)
	{
		throw null;
	}

	// Token: 0x060029BC RID: 10684 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass671.GClass672 GetViewForSlot(IContainer container)
	{
		throw null;
	}

	// Token: 0x060029BD RID: 10685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<GClass671.GClass672> GetBonesWhereSlot<TContainer>(Func<TContainer, bool> whereFunc) where TContainer : IContainer
	{
		throw null;
	}

	// Token: 0x060029BE RID: 10686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogEverything()
	{
		throw null;
	}

	// Token: 0x060029BF RID: 10687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040027D5 RID: 10197
	public readonly Dictionary<IContainer, GClass671.GClass672> ContainerBones;

	// Token: 0x040027D6 RID: 10198
	private AssetPoolObject assetPoolObject_0;

	// Token: 0x040027D7 RID: 10199
	public GameObject GameObject;

	// Token: 0x020006F5 RID: 1781
	public class GClass672
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsertItem(Item item, GameObject itemView)
		{
			throw null;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveItem()
		{
			throw null;
		}

		// Token: 0x040027D8 RID: 10200
		public Transform Bone;

		// Token: 0x040027D9 RID: 10201
		public Item Item;

		// Token: 0x040027DA RID: 10202
		public Transform ItemView;
	}

	// Token: 0x020006F6 RID: 1782
	[CompilerGenerated]
	[Serializable]
	private sealed class Class369
	{
		// Token: 0x060029C2 RID: 10690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(IContainer x)
		{
			throw null;
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(IContainer x)
		{
			throw null;
		}

		// Token: 0x040027DB RID: 10203
		public static readonly GClass671.Class369 class369_0;

		// Token: 0x040027DC RID: 10204
		public static Func<IContainer, string> func_0;

		// Token: 0x040027DD RID: 10205
		public static Func<IContainer, string> func_1;
	}

	// Token: 0x020006F7 RID: 1783
	[CompilerGenerated]
	private sealed class Class370<T> where T : IContainer
	{
		// Token: 0x060029C4 RID: 10692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<IContainer, GClass671.GClass672> pair)
		{
			throw null;
		}

		// Token: 0x040027DE RID: 10206
		public Func<T, bool> whereFunc;
	}

	// Token: 0x020006F8 RID: 1784
	[CompilerGenerated]
	[Serializable]
	private sealed class Class371<TContainer> where TContainer : IContainer
	{
		// Token: 0x060029C5 RID: 10693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass671.GClass672 method_0(KeyValuePair<IContainer, GClass671.GClass672> pair)
		{
			throw null;
		}

		// Token: 0x040027DF RID: 10207
		public static readonly GClass671.Class371<TContainer> class371_0;

		// Token: 0x040027E0 RID: 10208
		public static Func<KeyValuePair<IContainer, GClass671.GClass672>, GClass671.GClass672> func_0;
	}
}
