using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Comfort.Common;
using Comfort.Communication;

// Token: 0x02000CCE RID: 3278
public sealed class GClass925 : IChatsSession
{
	// Token: 0x06004659 RID: 18009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass925 Create(Delegate[] delegates)
	{
		throw null;
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IChatsSession.Start(IChatMember member, Callback<IChatHandle, ChatInfo> callback)
	{
		throw null;
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IChatsSession.Start(IChatMember member, string chatId, Callback<IChatHandle, ChatInfo> callback)
	{
		throw null;
	}

	// Token: 0x0600465C RID: 18012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IChatsSession.Close(Action callback)
	{
		throw null;
	}

	// Token: 0x0600465D RID: 18013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IChatsSession.Ban(string profileId, TimeSpan timeSpan, string description, Callback<DateTime> callback)
	{
		throw null;
	}

	// Token: 0x0600465E RID: 18014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IChatsSession.Unban(string profileId, string description, Callback callback)
	{
		throw null;
	}
}
