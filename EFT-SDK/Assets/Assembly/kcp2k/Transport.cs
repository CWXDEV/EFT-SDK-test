using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace kcp2k
{
	// Token: 0x02000F18 RID: 3864
	public abstract class Transport : MonoBehaviour
	{
		// Token: 0x060050FC RID: 20732
		public abstract bool Available();

		// Token: 0x060050FD RID: 20733
		public abstract bool ClientConnected();

		// Token: 0x060050FE RID: 20734
		public abstract void ClientConnect(string address);

		// Token: 0x060050FF RID: 20735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClientConnect(Uri uri)
		{
			throw null;
		}

		// Token: 0x06005100 RID: 20736
		public abstract void ClientSend(ArraySegment<byte> segment, int channelId = 0);

		// Token: 0x06005101 RID: 20737
		public abstract void ClientDisconnect();

		// Token: 0x06005102 RID: 20738
		public abstract Uri ServerUri();

		// Token: 0x06005103 RID: 20739
		public abstract bool ServerActive();

		// Token: 0x06005104 RID: 20740
		public abstract void ServerStart();

		// Token: 0x06005105 RID: 20741
		public abstract void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId = 0);

		// Token: 0x06005106 RID: 20742
		public abstract void ServerDisconnect(int connectionId);

		// Token: 0x06005107 RID: 20743
		public abstract string ServerGetClientAddress(int connectionId);

		// Token: 0x06005108 RID: 20744
		public abstract void ServerStop();

		// Token: 0x06005109 RID: 20745
		public abstract int GetMaxPacketSize(int channelId = 0);

		// Token: 0x0600510A RID: 20746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetBatchThreshold(int channelId = 0)
		{
			throw null;
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClientEarlyUpdate()
		{
			throw null;
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ServerEarlyUpdate()
		{
			throw null;
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClientLateUpdate()
		{
			throw null;
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ServerLateUpdate()
		{
			throw null;
		}

		// Token: 0x06005111 RID: 20753
		public abstract void Shutdown();

		// Token: 0x06005112 RID: 20754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x04005D34 RID: 23860
		public static Transport activeTransport;

		// Token: 0x04005D35 RID: 23861
		public Action OnClientConnected;

		// Token: 0x04005D36 RID: 23862
		public Action<ArraySegment<byte>, int> OnClientDataReceived;

		// Token: 0x04005D37 RID: 23863
		public Action<ArraySegment<byte>, int> OnClientDataSent;

		// Token: 0x04005D38 RID: 23864
		public Action<TransportError, string> OnClientError;

		// Token: 0x04005D39 RID: 23865
		public Action OnClientDisconnected;

		// Token: 0x04005D3A RID: 23866
		public Action<int> OnServerConnected;

		// Token: 0x04005D3B RID: 23867
		public Action<int, ArraySegment<byte>, int> OnServerDataReceived;

		// Token: 0x04005D3C RID: 23868
		public Action<int, ArraySegment<byte>, int> OnServerDataSent;

		// Token: 0x04005D3D RID: 23869
		public Action<int, TransportError, string> OnServerError;

		// Token: 0x04005D3E RID: 23870
		public Action<int> OnServerDisconnected;
	}
}
