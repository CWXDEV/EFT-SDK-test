using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using UnityEngine;

// Token: 0x02003093 RID: 12435
public abstract class GClass3208 : AbstractAchievementControllerClass
{
	// Token: 0x0600F3D4 RID: 62420
	public abstract Task<GStruct413<GStruct372<GClass1248>>> FinishAchievement(GClass1248 achievement, bool runNetworkTransaction);

	// Token: 0x0600F3D5 RID: 62421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void TryNotifyConditionalStatusChanged(GClass1248 achievement)
	{
		throw null;
	}

	// Token: 0x0600F3D6 RID: 62422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass1248 achievement)
	{
		throw null;
	}

	// Token: 0x0600F3D7 RID: 62423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void TryNotifyConditionChanged(GClass1248 achievement)
	{
		throw null;
	}

	// Token: 0x0600F3D8 RID: 62424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void TryToInstantComplete(GInterface381 conditional)
	{
		throw null;
	}

	// Token: 0x0600F3D9 RID: 62425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400FA2A RID: 64042
	protected readonly GInterface144 ginterface144_0;

	// Token: 0x0400FA2B RID: 64043
	protected GClass3223<GClass1248> gclass3223_0;

	// Token: 0x02003094 RID: 12436
	[CompilerGenerated]
	private sealed class Class3132
	{
		// Token: 0x0600F3DA RID: 62426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Sprite> res)
		{
			throw null;
		}

		// Token: 0x0400FA2C RID: 64044
		public GClass1248 achievement;

		// Token: 0x0400FA2D RID: 64045
		public GClass3208 gclass3208_0;
	}
}
