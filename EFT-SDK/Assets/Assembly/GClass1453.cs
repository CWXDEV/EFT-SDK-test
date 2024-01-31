using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x020012C6 RID: 4806
public abstract class GClass1453<T, U>
{
	// Token: 0x060063A6 RID: 25510
	protected abstract U TypeToKey(Type type);

	// Token: 0x060063A7 RID: 25511
	protected abstract Type KeyToType(U type);

	// Token: 0x060063A8 RID: 25512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x060063A9 RID: 25513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Serialize(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x0400702F RID: 28719
	public U _parent;

	// Token: 0x04007030 RID: 28720
	public JToken _props;
}
