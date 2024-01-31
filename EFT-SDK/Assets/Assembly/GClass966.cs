using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x02000D15 RID: 3349
public sealed class GClass966<T> : GInterface47<T> where T : GClass952<T>, new()
{
	// Token: 0x17000B54 RID: 2900
	// (get) Token: 0x06004743 RID: 18243 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyList<GClass951<T>> Presets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004744 RID: 18244 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RefreshPresetList()
	{
		throw null;
	}

	// Token: 0x06004745 RID: 18245 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass951<T>> CreateNewPreset(string name, T settingsGroup)
	{
		throw null;
	}

	// Token: 0x06004746 RID: 18246 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RemovePreset(GClass951<T> preset)
	{
		throw null;
	}

	// Token: 0x06004747 RID: 18247 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass951<T> method_0(string path)
	{
		throw null;
	}

	// Token: 0x06004748 RID: 18248 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass951<T> method_1(string path, string name)
	{
		throw null;
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_2(string path)
	{
		throw null;
	}

	// Token: 0x0600474A RID: 18250 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_3(string name)
	{
		throw null;
	}

	// Token: 0x04005211 RID: 21009
	private const string string_0 = ".ini";

	// Token: 0x04005212 RID: 21010
	private List<GClass951<T>> list_0;

	// Token: 0x04005213 RID: 21011
	private readonly string string_1;

	// Token: 0x04005214 RID: 21012
	private readonly GClass958[] gclass958_0;

	// Token: 0x04005215 RID: 21013
	private readonly GClass958.GInterface50 ginterface50_0;
}
