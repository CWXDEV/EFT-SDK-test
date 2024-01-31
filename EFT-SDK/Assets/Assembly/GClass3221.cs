using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Quests;

// Token: 0x0200300C RID: 12300
public sealed class GClass3221 : Dictionary<EQuestStatus, GClass3365>, ISerializer<GClass3220>
{
	// Token: 0x0600F20B RID: 61963 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3220 Deserialize()
	{
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(GClass3220 t)
	{
		throw null;
	}

	// Token: 0x0200300D RID: 12301
	[CompilerGenerated]
	private sealed class Class3068
	{
		// Token: 0x0600F20C RID: 61964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition x)
		{
			throw null;
		}

		// Token: 0x0400F83B RID: 63547
		public Condition condition;
	}

	// Token: 0x0200300E RID: 12302
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3069
	{
		// Token: 0x0600F20D RID: 61965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EQuestStatus method_0(KeyValuePair<EQuestStatus, GClass3365> x)
		{
			throw null;
		}

		// Token: 0x0600F20E RID: 61966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass3365 method_1(KeyValuePair<EQuestStatus, GClass3365> x)
		{
			throw null;
		}

		// Token: 0x0400F83C RID: 63548
		public static readonly GClass3221.Class3069 class3069_0;

		// Token: 0x0400F83D RID: 63549
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, EQuestStatus> func_0;

		// Token: 0x0400F83E RID: 63550
		public static Func<KeyValuePair<EQuestStatus, GClass3365>, GClass3365> func_1;
	}
}
