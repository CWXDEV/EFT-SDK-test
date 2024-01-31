using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x020026ED RID: 9965
public class GClass1456 : GClass1453<GClass2932, string>
{
	// Token: 0x0600C57E RID: 50558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string TypeToKey(Type serializedType)
	{
		throw null;
	}

	// Token: 0x0600C57F RID: 50559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Type KeyToType(string serializedType)
	{
		throw null;
	}

	// Token: 0x0600C580 RID: 50560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass2932 Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x0400C762 RID: 51042
	public string _id;

	// Token: 0x0400C763 RID: 51043
	public string _name;

	// Token: 0x0400C764 RID: 51044
	public NodeType _type;
}
