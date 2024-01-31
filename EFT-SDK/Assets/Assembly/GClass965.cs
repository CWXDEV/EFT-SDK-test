using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02000D0D RID: 3341
public sealed class GClass965 : GClass958.GInterface50
{
	// Token: 0x0600472F RID: 18223 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Populate<T>(JObject json, T item, out bool needReSave)
	{
		throw null;
	}

	// Token: 0x06004730 RID: 18224 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public JObject PrepareToSave<T>(T item)
	{
		throw null;
	}

	// Token: 0x06004731 RID: 18225 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0([NotNull] JObject json)
	{
		throw null;
	}

	// Token: 0x040051F8 RID: 20984
	public const string VERSION_KEY = "Version";

	// Token: 0x040051F9 RID: 20985
	private readonly uint uint_0;

	// Token: 0x040051FA RID: 20986
	private readonly GClass965.GInterface51[] ginterface51_0;

	// Token: 0x040051FB RID: 20987
	private readonly JProperty jproperty_0;

	// Token: 0x040051FC RID: 20988
	private readonly JsonSerializer jsonSerializer_0;

	// Token: 0x02000D0E RID: 3342
	public interface GInterface51
	{
		// Token: 0x06004732 RID: 18226
		void Upgrade(JObject data);
	}
}
