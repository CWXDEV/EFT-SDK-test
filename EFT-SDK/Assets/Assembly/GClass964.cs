using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02000D0C RID: 3340
public sealed class GClass964 : GClass958.GInterface50
{
	// Token: 0x0600472D RID: 18221 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Populate<T>(JObject json, T item, out bool needReSave)
	{
		throw null;
	}

	// Token: 0x0600472E RID: 18222 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public JObject PrepareToSave<T>(T item)
	{
		throw null;
	}

	// Token: 0x040051F7 RID: 20983
	private readonly JsonSerializer jsonSerializer_0;
}
