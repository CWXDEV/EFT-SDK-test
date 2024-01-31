using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;

// Token: 0x02000CEF RID: 3311
public abstract class GClass942<T> : IDisposable, GInterface49<T> where T : GClass952<T>
{
	// Token: 0x17000B46 RID: 2886
	// (get) Token: 0x060046AA RID: 18090 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060046AB RID: 18091 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000B47 RID: 2887
	// (get) Token: 0x060046AC RID: 18092 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsBound
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060046AD RID: 18093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindTo(T settingsGroup, bool previewMode = false)
	{
		throw null;
	}

	// Token: 0x060046AE RID: 18094
	protected abstract void CreateBindings();

	// Token: 0x060046AF RID: 18095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0<U>(GameSetting<U> gameSetting, Action<U> handler)
	{
		throw null;
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1<U>(GameSetting<U> gameSetting, Action<U> handler)
	{
		throw null;
	}

	// Token: 0x060046B1 RID: 18097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Action action)
	{
		throw null;
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040051BA RID: 20922
	protected T gparam_0;

	// Token: 0x040051BB RID: 20923
	protected bool bool_0;

	// Token: 0x040051BC RID: 20924
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040051BD RID: 20925
	private readonly List<Action> list_0;
	public T SettingsGroupFactory()
	{
		throw new NotImplementedException();
	}
}
