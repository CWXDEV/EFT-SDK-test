using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200132D RID: 4909
public class GClass1484
{
	// Token: 0x1400011E RID: 286
	// (add) Token: 0x06006573 RID: 25971 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06006574 RID: 25972 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> OnRegister
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

	// Token: 0x1400011F RID: 287
	// (add) Token: 0x06006575 RID: 25973 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06006576 RID: 25974 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<string> OnRemove
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

	// Token: 0x06006577 RID: 25975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetById(string id, out Item item)
	{
		throw null;
	}

	// Token: 0x06006578 RID: 25976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetById(string id)
	{
		throw null;
	}

	// Token: 0x06006579 RID: 25977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register(Item item)
	{
		throw null;
	}

	// Token: 0x0600657A RID: 25978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(string id)
	{
		throw null;
	}

	// Token: 0x0600657B RID: 25979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(Item item)
	{
		throw null;
	}

	// Token: 0x0600657C RID: 25980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x040071F3 RID: 29171
	private readonly Dictionary<string, Item> dictionary_0;

	// Token: 0x040071F4 RID: 29172
	[CompilerGenerated]
	private Action<Item> action_0;

	// Token: 0x040071F5 RID: 29173
	[CompilerGenerated]
	private Action<string> action_1;
}
