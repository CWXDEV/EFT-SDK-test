using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020012BB RID: 4795
public sealed class GClass1446<T> : JsonConverter<T> where T : Enum
{
	// Token: 0x0600638E RID: 25486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		throw null;
	}
}
