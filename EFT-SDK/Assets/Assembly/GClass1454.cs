using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x020024CB RID: 9419
public class GClass1454 : GClass1453<ItemTemplate, string>
{
	// Token: 0x0600BCAB RID: 48299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string TypeToKey(Type serializedType)
	{
		throw null;
	}

	// Token: 0x0600BCAC RID: 48300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Type KeyToType(string serializedType)
	{
		throw null;
	}

	// Token: 0x0600BCAD RID: 48301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ItemTemplate Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x0400BF6A RID: 49002
	public string _id;

	// Token: 0x0400BF6B RID: 49003
	public string _name;

	// Token: 0x0400BF6C RID: 49004
	public NodeType _type;

	// Token: 0x0400BF6D RID: 49005
	public GClass1186[] _items;
}
