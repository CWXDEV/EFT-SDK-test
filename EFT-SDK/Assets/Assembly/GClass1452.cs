using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020012C5 RID: 4805
public sealed class GClass1452<T> : JsonConverter where T : struct, Enum
{
	// Token: 0x060063A3 RID: 25507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x060063A4 RID: 25508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		throw null;
	}

	// Token: 0x060063A5 RID: 25509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanConvert(Type objectType)
	{
		throw null;
	}

	// Token: 0x0400702C RID: 28716
	private static readonly Type type_0;

	// Token: 0x0400702D RID: 28717
	private readonly Dictionary<string, T> dictionary_0;

	// Token: 0x0400702E RID: 28718
	private readonly Dictionary<T, string> dictionary_1;
}
