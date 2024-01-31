using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using JetBrains.Annotations;

// Token: 0x02000D03 RID: 3331
public abstract class GClass952<T> where T : GClass952<T>
{
	// Token: 0x06004709 RID: 18185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IList<IGameSetting> GetSettingsList()
	{
		throw null;
	}

	// Token: 0x0600470A RID: 18186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSameSettings([NotNull] T other)
	{
		throw null;
	}

	// Token: 0x0600470B RID: 18187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakeSettingsFrom([NotNull] T other)
	{
		throw null;
	}

	// Token: 0x0600470C RID: 18188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceApply()
	{
		throw null;
	}

	// Token: 0x0600470D RID: 18189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryForceApplyDiff([NotNull] T other)
	{
		throw null;
	}

	// Token: 0x0600470E RID: 18190
	[NotNull]
	public abstract T Clone();

	// Token: 0x0600470F RID: 18191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected V method_0<U, V>([NotNull] V setting) where V : GameSetting<U>
	{
		throw null;
	}

	// Token: 0x06004710 RID: 18192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameSetting<U> method_1<U>([NotNull] GameSetting<U> setting)
	{
		throw null;
	}

	// Token: 0x06004711 RID: 18193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameSetting<U> method_2<U>(string key, U defaultValue = default(U), Func<U, U> preProcessor = null) where U : IEquatable<U>
	{
		throw null;
	}

	// Token: 0x06004712 RID: 18194 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameSetting<U> method_3<U>(string key, U defaultValue, Func<U, Task<U>> preProcessor) where U : IEquatable<U>
	{
		throw null;
	}

	// Token: 0x06004713 RID: 18195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameSetting<U> method_4<U>(string key, U defaultValue = default(U), Func<U, U> preProcessor = null)
	{
		throw null;
	}

	// Token: 0x06004714 RID: 18196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameSetting<U> method_5<U>(string key, U defaultValue, Func<U, Task<U>> preProcessor)
	{
		throw null;
	}

	// Token: 0x06004715 RID: 18197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ListGameSetting<U> method_6<U>(string key, ListGameSetting<U>.GDelegate28 copyItem = null, ListGameSetting<U>.GDelegate27 equalityCheck = null, Func<List<U>, List<U>> preProcessor = null)
	{
		throw null;
	}

	// Token: 0x06004716 RID: 18198 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(T other)
	{
		throw null;
	}

	// Token: 0x040051E0 RID: 20960
	private readonly List<IGameSetting> list_0;

	// Token: 0x02000D04 RID: 3332
	[CompilerGenerated]
	private sealed class Class673<U>
	{
		// Token: 0x06004717 RID: 18199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<U> method_0(U value)
		{
			throw null;
		}

		// Token: 0x040051E1 RID: 20961
		public Func<U, U> preProcessor;
	}
}
