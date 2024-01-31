using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using JetBrains.Annotations;

// Token: 0x02001987 RID: 6535
public sealed class SharedGameSettingsClass
{
	// Token: 0x06008BE7 RID: 35815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0()
	{
		throw null;
	}

	// Token: 0x06008BE8 RID: 35816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GInterface48 smethod_0<T>(string name, GClass958[] fallbackProviders, [CanBeNull] GClass958.GInterface50 jsonSerializer = null) where T : GClass952<T>
	{
		throw null;
	}

	// Token: 0x06008BE9 RID: 35817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GameSetting<float> setting, string description = null, string additionalKey = null)
	{
		throw null;
	}

	// Token: 0x06008BEA RID: 35818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GameSetting<bool> setting, string description = null, string additionalKey = null)
	{
		throw null;
	}

	// Token: 0x06008BEB RID: 35819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3<T>(GameSetting<T> setting, string description = null, string additionalKey = null) where T : struct, Enum
	{
		throw null;
	}

	// Token: 0x06008BEC RID: 35820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4<T>(GameSetting<T> setting, string description = null, string additionalKey = null)
	{
		throw null;
	}

	// Token: 0x06008BED RID: 35821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06008BEE RID: 35822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task<bool> smethod_1(SharedGameSettingsClass.GClass1873<GClass957> loadedSettings)
	{
		throw null;
	}

	// Token: 0x06008BEF RID: 35823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateMergedControls(GClass957 settings)
	{
		throw null;
	}

	// Token: 0x06008BF0 RID: 35824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<SharedGameSettingsClass> InstantiateSingleton()
	{
		throw null;
	}

	// Token: 0x06008BF1 RID: 35825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearSettings()
	{
		throw null;
	}

	// Token: 0x0400918A RID: 37258
	private static readonly string string_0;

	// Token: 0x0400918B RID: 37259
	private static readonly string string_1;

	// Token: 0x0400918C RID: 37260
	private static readonly GClass964 gclass964_0;

	// Token: 0x0400918D RID: 37261
	public readonly SharedGameSettingsClass.GClass1874<GClass956, GClass947> Game;

	// Token: 0x0400918E RID: 37262
	public readonly SharedGameSettingsClass.GClass1874<GClass953, GClass943> Sound;

	// Token: 0x0400918F RID: 37263
	public readonly SharedGameSettingsClass.GClass1873<GClass954> PostFx;

	// Token: 0x04009190 RID: 37264
	public readonly SharedGameSettingsClass.GClass1874<GClass955, GClass946> Graphics;

	// Token: 0x04009191 RID: 37265
	public readonly SharedGameSettingsClass.GClass1874<GClass957, GClass948> Control;

	// Token: 0x04009192 RID: 37266
	private readonly List<string> list_0;

	// Token: 0x04009193 RID: 37267
	private readonly GClass961 gclass961_0;

	// Token: 0x04009194 RID: 37268
	private static readonly GClass1871[] gclass1871_0;

	// Token: 0x02001988 RID: 6536
	public sealed class GClass1874<T, U> : SharedGameSettingsClass.GClass1873<T> where T : GClass952<T> where U : GClass942<T>
	{
		// Token: 0x06008BF2 RID: 35826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task Load(GInterface48 defaultProvider = null)
		{
			throw null;
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(GInterface48 defaultProvider)
		{
			throw null;
		}

		// Token: 0x04009195 RID: 37269
		[NotNull]
		public readonly U Controller;
	}

	// Token: 0x0200198A RID: 6538
	public class GClass1873<T> where T : GClass952<T>
	{
		// Token: 0x06008BF6 RID: 35830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task TakeSettingsFrom(T otherGroup)
		{
			throw null;
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task RevertToDefault()
		{
			throw null;
		}

		// Token: 0x06008BF8 RID: 35832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task Load([CanBeNull] GInterface48 defaultProvider = null)
		{
			throw null;
		}

		// Token: 0x06008BF9 RID: 35833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Save()
		{
			throw null;
		}

		// Token: 0x0400919B RID: 37275
		public readonly T Settings;

		// Token: 0x0400919C RID: 37276
		public readonly T Default;

		// Token: 0x0400919D RID: 37277
		private readonly GInterface48 ginterface48_0;

		// Token: 0x0400919E RID: 37278
		private readonly SharedGameSettingsClass.GClass1873<T>.GDelegate67 gdelegate67_0;

		// Token: 0x0200198B RID: 6539
		// (Invoke) Token: 0x06008BFA RID: 35834
		[CanBeNull]
		public delegate Task<bool> GDelegate67(SharedGameSettingsClass.GClass1873<T> loadedSettings);
	}

	// Token: 0x02001990 RID: 6544
	[CompilerGenerated]
	private sealed class Class1528<T>
	{
		// Token: 0x06008C05 RID: 35845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string key)
		{
			throw null;
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(T v)
		{
			throw null;
		}

		// Token: 0x040091B5 RID: 37301
		public GameSetting<T> setting;

		// Token: 0x040091B6 RID: 37302
		public SharedGameSettingsClass gclass1872_0;

		// Token: 0x040091B7 RID: 37303
		public string description;
	}
}
