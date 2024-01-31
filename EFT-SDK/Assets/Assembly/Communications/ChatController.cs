using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Comfort.Common;
using UnityEngine;

namespace Communications
{
	// Token: 0x02000CBC RID: 3260
	[RequireComponent(typeof(ChatClient))]
	internal sealed class ChatController : MonoBehaviour, IChatMember
	{
		// Token: 0x0600461C RID: 17948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ChatController Create(ChatClient chatClient)
		{
			throw null;
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x00002050 File Offset: 0x00000250
		public string ChatId
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

		// Token: 0x0600461F RID: 17951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SessionStart(GClass1839 socialNetwork)
		{
			throw null;
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SessionRestart(string chatId, string ip, int port)
		{
			throw null;
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SessionStop()
		{
			throw null;
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Result<IChatHandle, ChatInfo> result)
		{
			throw null;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Result<IChatHandle, ChatInfo> result)
		{
			throw null;
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ChatMessageClass message, ChatMessageClass replayToMessage, Action callback)
		{
			throw null;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.Receive(Message message)
		{
			throw null;
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.ReceiveReplay(Message message, Message replayMessage)
		{
			throw null;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.Drop()
		{
			throw null;
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.Add(ChatRoomMember[] members)
		{
			throw null;
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.Remove(string[] members)
		{
			throw null;
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.SetBanned(string memberId, DateTime toDateTime)
		{
			throw null;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IChatMember.SetUnbanned(string memberId)
		{
			throw null;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x040050E5 RID: 20709
		private ChatClient chatClient_0;

		// Token: 0x040050E6 RID: 20710
		private GClass1839 gclass1839_0;

		// Token: 0x040050E7 RID: 20711
		private IChatHandle ichatHandle_0;

		// Token: 0x040050E8 RID: 20712
		private GClass940 gclass940_0;

		// Token: 0x040050E9 RID: 20713
		[CompilerGenerated]
		private string string_0;

		// Token: 0x02000CBD RID: 3261
		[CompilerGenerated]
		[Serializable]
		private sealed class Class656
		{
			// Token: 0x0600462D RID: 17965 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_0(ChatRoomMember info)
			{
				throw null;
			}

			// Token: 0x0600462E RID: 17966 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_1(string id)
			{
				throw null;
			}

			// Token: 0x0600462F RID: 17967 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x06004630 RID: 17968 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x06004631 RID: 17969 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x06004632 RID: 17970 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x06004633 RID: 17971 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x06004634 RID: 17972 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_7(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x06004635 RID: 17973 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_8()
			{
				throw null;
			}

			// Token: 0x040050EA RID: 20714
			public static readonly ChatController.Class656 class656_0;

			// Token: 0x040050EB RID: 20715
			public static Func<string, UpdatableChatMember> func_0;

			// Token: 0x040050EC RID: 20716
			public static Func<ChatRoomMember, UpdatableChatMember> func_1;

			// Token: 0x040050ED RID: 20717
			public static Func<UpdatableChatMember, bool> func_2;

			// Token: 0x040050EE RID: 20718
			public static Func<UpdatableChatMember, bool> func_3;

			// Token: 0x040050EF RID: 20719
			public static Func<UpdatableChatMember, bool> func_4;

			// Token: 0x040050F0 RID: 20720
			public static Func<UpdatableChatMember, bool> func_5;

			// Token: 0x040050F1 RID: 20721
			public static Func<UpdatableChatMember, bool> func_6;

			// Token: 0x040050F2 RID: 20722
			public static Func<UpdatableChatMember, bool> func_7;

			// Token: 0x040050F3 RID: 20723
			public static Action action_0;
		}

		// Token: 0x02000CBE RID: 3262
		[CompilerGenerated]
		private sealed class Class657
		{
			// Token: 0x06004636 RID: 17974 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UpdatableChatMember member)
			{
				throw null;
			}

			// Token: 0x040050F4 RID: 20724
			public Message message;
		}

		// Token: 0x02000CBF RID: 3263
		[CompilerGenerated]
		private sealed class Class658
		{
			// Token: 0x06004637 RID: 17975 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UpdatableChatMember member)
			{
				throw null;
			}

			// Token: 0x06004638 RID: 17976 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(UpdatableChatMember member)
			{
				throw null;
			}

			// Token: 0x040050F5 RID: 20725
			public Message replayMessage;

			// Token: 0x040050F6 RID: 20726
			public Message message;
		}

		// Token: 0x02000CC0 RID: 3264
		[CompilerGenerated]
		private sealed class Class659
		{
			// Token: 0x06004639 RID: 17977 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_0(string id)
			{
				throw null;
			}

			// Token: 0x040050F7 RID: 20727
			public ChatRoomMember member;
		}

		// Token: 0x02000CC1 RID: 3265
		[CompilerGenerated]
		private sealed class Class660
		{
			// Token: 0x0600463A RID: 17978 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UpdatableChatMember member)
			{
				throw null;
			}

			// Token: 0x040050F8 RID: 20728
			public string[] members;
		}

		// Token: 0x02000CC2 RID: 3266
		[CompilerGenerated]
		private sealed class Class661
		{
			// Token: 0x0600463B RID: 17979 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x040050F9 RID: 20729
			public string memberId;
		}

		// Token: 0x02000CC3 RID: 3267
		[CompilerGenerated]
		private sealed class Class662
		{
			// Token: 0x0600463C RID: 17980 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x040050FA RID: 20730
			public string memberId;
		}
	}
}
