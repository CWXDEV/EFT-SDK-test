using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ChatShared;
using Comfort.Common;
using Comfort.Communication;
using Comfort.Net;
using UnityEngine;

namespace Communications
{
	// Token: 0x02000CB8 RID: 3256
	internal sealed class ChatClient : MonoBehaviourSingleton<ChatClient>, IUnityScheduller
	{
		// Token: 0x060045FD RID: 17917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatClient smethod_0(string versionId, GameObject gameObject = null, CommunicatorFactory communicatorFactory = null)
		{
			throw null;
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045FF RID: 17919 RVA: 0x00002050 File Offset: 0x00000250
		public IChatsSession Session
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004601 RID: 17921 RVA: 0x00002050 File Offset: 0x00000250
		public ChatController ChatController
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x06004602 RID: 17922 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004603 RID: 17923 RVA: 0x00002050 File Offset: 0x00000250
		public event Action Event
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

		// Token: 0x06004604 RID: 17924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(ISession backEndSession)
		{
			throw null;
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Result<ChatServerClass[]> result)
		{
			throw null;
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reconnect(string ip, int port)
		{
			throw null;
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3()
		{
			throw null;
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IConnection connection)
		{
			throw null;
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(ConnectionStateChangedEventArgs args)
		{
			throw null;
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(StatusChangedEventArgs args)
		{
			throw null;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_8()
		{
			throw null;
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(string error)
		{
			throw null;
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		Coroutine IUnityScheduller.StartCoroutine(IEnumerator enumerator)
		{
			throw null;
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(object sender, ConnectionClosedEventArgs e)
		{
			throw null;
		}

		// Token: 0x040050D4 RID: 20692
		private string string_0;

		// Token: 0x040050D5 RID: 20693
		private ICommunicator icommunicator_0;

		// Token: 0x040050D6 RID: 20694
		private ITcpClient itcpClient_0;

		// Token: 0x040050D7 RID: 20695
		private ISession ginterface145_0;

		// Token: 0x040050D8 RID: 20696
		private string string_1;

		// Token: 0x040050D9 RID: 20697
		private int int_0;

		// Token: 0x040050DA RID: 20698
		[CompilerGenerated]
		private IChatsSession ichatsSession_0;

		// Token: 0x040050DB RID: 20699
		[CompilerGenerated]
		private ChatController chatController_0;

		// Token: 0x040050DC RID: 20700
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x02000CB9 RID: 3257
		[CompilerGenerated]
		[Serializable]
		private sealed class Class653
		{
			// Token: 0x06004613 RID: 17939 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DateTime method_0(ChatServerClass item)
			{
				throw null;
			}

			// Token: 0x040050DD RID: 20701
			public static readonly ChatClient.Class653 class653_0;

			// Token: 0x040050DE RID: 20702
			public static Func<ChatServerClass, DateTime> func_0;
		}
	}
}
