using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

// Token: 0x02000D05 RID: 3333
public abstract class GClass958 : GInterface48
{
	// Token: 0x06004718 RID: 18200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> Load<T>(T settingsGroup) where T : GClass952<T>
	{
		throw null;
	}

	// Token: 0x06004719 RID: 18201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Save<T>(T settingsGroup) where T : GClass952<T>
	{
		throw null;
	}

	// Token: 0x0600471A RID: 18202
	protected abstract Task<JObject> LoadJson();

	// Token: 0x0600471B RID: 18203
	protected abstract Task SaveJson([NotNull] JObject json);

	// Token: 0x0600471C RID: 18204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<JObject> method_0()
	{
		throw null;
	}

	// Token: 0x040051E2 RID: 20962
	private readonly GClass958.GInterface50 ginterface50_0;

	// Token: 0x040051E3 RID: 20963
	private readonly GClass958[] gclass958_0;

	// Token: 0x02000D06 RID: 3334
	public interface GInterface50
	{
		// Token: 0x0600471D RID: 18205
		[NotNull]
		T Populate<T>([CanBeNull] JObject json, [NotNull] T item, out bool needReSave);

		// Token: 0x0600471E RID: 18206
		[NotNull]
		JObject PrepareToSave<T>([NotNull] T item);
	}
}
