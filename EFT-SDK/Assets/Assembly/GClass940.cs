using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using Comfort.Common;
using Diz.Binding;

// Token: 0x02000CEA RID: 3306
public class GClass940 : IUpdatable<GClass940>
{
	// Token: 0x17000B3B RID: 2875
	// (get) Token: 0x06004685 RID: 18053 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004686 RID: 18054 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasMessagesWithRewards
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000B3C RID: 2876
	// (get) Token: 0x06004687 RID: 18055 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004688 RID: 18056 RVA: 0x00002050 File Offset: 0x00000250
	public bool MessagesLoaded
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

	// Token: 0x17000B3D RID: 2877
	// (get) Token: 0x06004689 RID: 18057 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600468A RID: 18058 RVA: 0x00002050 File Offset: 0x00000250
	public bool FullyRead
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

	// Token: 0x17000B3E RID: 2878
	// (get) Token: 0x0600468B RID: 18059 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600468C RID: 18060 RVA: 0x00002050 File Offset: 0x00000250
	public bool Updating
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

	// Token: 0x17000B3F RID: 2879
	// (get) Token: 0x0600468D RID: 18061 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyRewardMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B40 RID: 2880
	// (get) Token: 0x0600468E RID: 18062 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMultiUsersDialog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSendMessage(GClass1839 socialNetwork, out string error)
	{
		throw null;
	}

	// Token: 0x06004690 RID: 18064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDialogMessages(ISession session, double time)
	{
		throw null;
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectDialogue(bool value)
	{
		throw null;
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDialogue()
	{
		throw null;
	}

	// Token: 0x06004693 RID: 18067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compare(GClass940 other)
	{
		throw null;
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromAnotherItem(GClass940 other)
	{
		throw null;
	}

	// Token: 0x06004695 RID: 18069 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Result<GClass932> result)
	{
		throw null;
	}

	// Token: 0x0400518E RID: 20878
	[NonSerialized]
	public GClass3355<bool> OnDialogueSelected;

	// Token: 0x0400518F RID: 20879
	[NonSerialized]
	public BindableEvent OnDialogueRemoved;

	// Token: 0x04005190 RID: 20880
	[NonSerialized]
	public GClass3355<bool> OnDialoguePinStatusChanged;

	// Token: 0x04005191 RID: 20881
	[NonSerialized]
	public GClass3355<ChatMessageClass> OnLastMessageUpdated;

	// Token: 0x04005192 RID: 20882
	[NonSerialized]
	public GClass3355<bool> OnDialogueLoadingStatus;

	// Token: 0x04005193 RID: 20883
	[NonSerialized]
	public BindableEvent OnDialogueAttachmentsChanged;

	// Token: 0x04005194 RID: 20884
	public string _id;

	// Token: 0x04005195 RID: 20885
	public EMessageType Type;

	// Token: 0x04005196 RID: 20886
	public ChatMessageClass Message;

	// Token: 0x04005197 RID: 20887
	public DateTime? DeleteTime;

	// Token: 0x04005198 RID: 20888
	public int New;

	// Token: 0x04005199 RID: 20889
	public int AttachmentsNew;

	// Token: 0x0400519A RID: 20890
	public UpdatableChatMember Profile;

	// Token: 0x0400519B RID: 20891
	public string Owner;

	// Token: 0x0400519C RID: 20892
	public string Name;

	// Token: 0x0400519D RID: 20893
	public bool Pinned;

	// Token: 0x0400519E RID: 20894
	public GClass3364<UpdatableChatMember> ActiveUsers;

	// Token: 0x0400519F RID: 20895
	public LinkedList<UpdatableChatMember> SessionMentionedUsers;

	// Token: 0x040051A0 RID: 20896
	public GClass3364<ChatMessageClass> ChatMessages;

	// Token: 0x040051A1 RID: 20897
	private bool bool_0;

	// Token: 0x040051A2 RID: 20898
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040051A3 RID: 20899
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x040051A4 RID: 20900
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x02000CEB RID: 3307
	[CompilerGenerated]
	[Serializable]
	private sealed class Class669
	{
		// Token: 0x06004696 RID: 18070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ChatMessageClass x)
		{
			throw null;
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(UpdatableChatMember x)
		{
			throw null;
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal UpdatableChatMember method_2(string id)
		{
			throw null;
		}

		// Token: 0x040051A5 RID: 20901
		public static readonly GClass940.Class669 class669_0;

		// Token: 0x040051A6 RID: 20902
		public static Func<ChatMessageClass, bool> func_0;

		// Token: 0x040051A7 RID: 20903
		public static Func<UpdatableChatMember, bool> func_1;

		// Token: 0x040051A8 RID: 20904
		public static Func<string, UpdatableChatMember> func_2;
	}
}
