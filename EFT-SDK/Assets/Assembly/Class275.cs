using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x0200058A RID: 1418
internal class Class275
{
	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
	public WsWebSender Sender
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task EstablishConnectionToUrl(Struct32 connParams)
	{
		throw null;
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CloseConnection()
	{
		throw null;
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> SendRequest<T>(Class266 reqParams)
	{
		throw null;
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNotificationToHandle(string notificationId, Action<string> action)
	{
		throw null;
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveHandlingNotification(string notificationId)
	{
		throw null;
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendNotification<T>(Class266 reqParams)
	{
		throw null;
	}

	// Token: 0x04002063 RID: 8291
	private WsWebSender wsWebSender_0;
}
