using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02001E1C RID: 7708
[JsonObject]
[JsonConverter(typeof(GClass2131))]
public sealed class GClass2132<T> : Dictionary<string, T> where T : IConvertible
{
	// Token: 0x06009E6F RID: 40559 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x0400A69E RID: 42654
	[JsonExtensionData]
	private Dictionary<string, JToken> dictionary_0;
}
