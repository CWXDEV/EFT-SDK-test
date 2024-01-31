using System;
using System.Runtime.CompilerServices;
using ChatShared;
using EFT;

// Token: 0x02000CD1 RID: 3281
public class GClass928 : ISerializer<GClass927>
{
	// Token: 0x0600465F RID: 18015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass927 Deserialize()
	{
		throw null;
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(GClass927 t)
	{
		throw null;
	}

	// Token: 0x04005110 RID: 20752
	public string _id;

	// Token: 0x04005111 RID: 20753
	public string from;

	// Token: 0x04005112 RID: 20754
	public string to;

	// Token: 0x04005113 RID: 20755
	public double date;

	// Token: 0x04005114 RID: 20756
	public UpdatableChatMember profile;

	// Token: 0x02000CD2 RID: 3282
	[CompilerGenerated]
	[Serializable]
	private sealed class Class663
	{
		// Token: 0x06004661 RID: 18017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal UpdatableChatMember method_0(string id)
		{
			throw null;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal UpdatableChatMember method_1(string id)
		{
			throw null;
		}

		// Token: 0x04005115 RID: 20757
		public static readonly GClass928.Class663 class663_0;

		// Token: 0x04005116 RID: 20758
		public static Func<string, UpdatableChatMember> func_0;

		// Token: 0x04005117 RID: 20759
		public static Func<string, UpdatableChatMember> func_1;
	}
}
