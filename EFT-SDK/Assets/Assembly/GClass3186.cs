using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using EFT.UI;

// Token: 0x02002F22 RID: 12066
public class GClass3186 : GInterface379
{
	// Token: 0x14000353 RID: 851
	// (add) Token: 0x0600EE2D RID: 60973 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE2E RID: 60974 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<PocketMapConfig> BundleReceived
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0600EE2F RID: 60975 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestBundle(int scalePreset)
	{
		throw null;
	}

	// Token: 0x0600EE30 RID: 60976 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadMapBundle()
	{
		throw null;
	}

	// Token: 0x0400F364 RID: 62308
	[CompilerGenerated]
	private Action<PocketMapConfig> action_0;

	// Token: 0x0400F365 RID: 62309
	private string string_0;

	// Token: 0x0400F366 RID: 62310
	private List<GClass3186.GClass3187> list_0;

	// Token: 0x02002F23 RID: 12067
	public class GClass3187
	{
		// Token: 0x0600EE31 RID: 60977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Load(string bundleName, Action loadedMap)
		{
			throw null;
		}

		// Token: 0x0600EE32 RID: 60978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CancelAndRelease()
		{
			throw null;
		}

		// Token: 0x0400F367 RID: 62311
		public PocketMapConfig pocketMapConfig;

		// Token: 0x0400F368 RID: 62312
		public CancellationTokenSource loadingCancellation;

		// Token: 0x0400F369 RID: 62313
		public DependencyGraph<IEasyBundle>.GClass3388 currentMapToken;

		// Token: 0x02002F24 RID: 12068
		[CompilerGenerated]
		private sealed class Class2980
		{
			// Token: 0x0600EE33 RID: 60979 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400F36A RID: 62314
			public GClass3186.GClass3187 gclass3187_0;

			// Token: 0x0400F36B RID: 62315
			public string bundleName;

			// Token: 0x0400F36C RID: 62316
			public Action loadedMap;
		}
	}

	// Token: 0x02002F25 RID: 12069
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2981
	{

		// Token: 0x0400F36D RID: 62317
		public static readonly GClass3186.Class2981 class2981_0;

		// Token: 0x0400F36E RID: 62318
		public static Action<PocketMapConfig> action_0;
	}

	// Token: 0x02002F26 RID: 12070
	[CompilerGenerated]
	private sealed class Class2982
	{
		// Token: 0x0600EE35 RID: 60981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400F36F RID: 62319
		public GClass3186 gclass3186_0;

		// Token: 0x0400F370 RID: 62320
		public GClass3186.GClass3187 loadingBundle;
	}
}
