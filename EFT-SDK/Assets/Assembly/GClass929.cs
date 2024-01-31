using System;
using System.Runtime.CompilerServices;
using ChatShared;
using EFT;

// Token: 0x02000CD8 RID: 3288
public class GClass929 : ChatRoomMember, ISerializer<UpdatableChatMember>
{
	// Token: 0x06004663 RID: 18019 RVA: 0x00002050 File Offset: 0x00000250
	public UpdatableChatMember Deserialize()
	{
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(UpdatableChatMember t)
	{
		throw null;
	}

	// Token: 0x02000CD9 RID: 3289
	[CompilerGenerated]
	[Serializable]
	private sealed class Class664
	{
		// Token: 0x06004664 RID: 18020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal UpdatableChatMember method_0(string id)
		{
			throw null;
		}

		// Token: 0x04005133 RID: 20787
		public static readonly GClass929.Class664 class664_0;

		// Token: 0x04005134 RID: 20788
		public static Func<string, UpdatableChatMember> func_0;
	}
}
