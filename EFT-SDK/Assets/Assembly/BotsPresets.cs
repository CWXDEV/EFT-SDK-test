using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;

// Token: 0x0200061A RID: 1562
public class BotsPresets : GClass585
{
	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00002050 File Offset: 0x00000250
	public override int BundlesLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(List<WaveInfo> waves)
	{
		throw null;
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<WaveInfo> method_1(List<WaveInfo> wavesProfiles, out List<WaveInfo> delayed)
	{
		throw null;
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<Profile> CreateProfile(GClass588 data, CancellationToken cancellationToken, bool withDelete)
	{
		throw null;
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task FillCreationDataWithProfiles(GClass588 data, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x04002336 RID: 9014
	private int int_0;

	// Token: 0x04002337 RID: 9015
	private readonly ISession ginterface145_0;

	// Token: 0x04002338 RID: 9016
	private int int_1;

	// Token: 0x04002339 RID: 9017
	private List<WaveInfo> list_1;

	// Token: 0x0400233A RID: 9018
	private const int int_2 = 25;

	// Token: 0x0200061B RID: 1563
	[CompilerGenerated]
	[Serializable]
	private sealed class Class307
	{
		// Token: 0x0400233B RID: 9019
		public static readonly BotsPresets.Class307 class307_0;

		// Token: 0x0400233C RID: 9020
		public static Func<BotWaveDataClass, WaveInfo> func_0;
	}
}
