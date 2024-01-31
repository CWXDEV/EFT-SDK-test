using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Diz.Binding;
using EFT.Communications;
using EFT.InventoryLogic;

// Token: 0x02000CE6 RID: 3302
public sealed class ChatMessageClass : IUpdatable<ChatMessageClass>
{
	// Token: 0x17000B33 RID: 2867
	// (get) Token: 0x06004672 RID: 18034 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B34 RID: 2868
	// (get) Token: 0x06004673 RID: 18035 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyNonQuestItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B35 RID: 2869
	// (get) Token: 0x06004674 RID: 18036 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyQuestItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B36 RID: 2870
	// (get) Token: 0x06004675 RID: 18037 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime ExpirationTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B37 RID: 2871
	// (get) Token: 0x06004676 RID: 18038 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasProfileEvents
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B38 RID: 2872
	// (get) Token: 0x06004677 RID: 18039 RVA: 0x00002050 File Offset: 0x00000250
	public bool DisplayRewardStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B39 RID: 2873
	// (get) Token: 0x06004678 RID: 18040 RVA: 0x00002050 File Offset: 0x00000250
	public string SystemText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B3A RID: 2874
	// (get) Token: 0x06004679 RID: 18041 RVA: 0x00002050 File Offset: 0x00000250
	public bool ParseLocalizationForMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ParsedText()
	{
		throw null;
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ParsedText(string startingValue, EViewRule viewRule)
	{
		throw null;
	}

	// Token: 0x0600467C RID: 18044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_0(string color, string link)
	{
		throw null;
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compare(ChatMessageClass other)
	{
		throw null;
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ChatMessageClass FindOrCreate(string id, Func<ChatMessageClass> constructor)
	{
		throw null;
	}

	// Token: 0x0600467F RID: 18047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromAnotherItem(ChatMessageClass other)
	{
		throw null;
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatMessageClass ToSystemMessage()
	{
		throw null;
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatMessageClass ToSystemMessageWithParams()
	{
		throw null;
	}

	// Token: 0x04005174 RID: 20852
	private const string string_0 = "<.*?>";

	// Token: 0x04005175 RID: 20853
	private const string string_1 = "#4db1d0";

	// Token: 0x04005176 RID: 20854
	public string _id;

	// Token: 0x04005177 RID: 20855
	public string templateId;

	// Token: 0x04005178 RID: 20856
	public GClass931 systemData;

	// Token: 0x04005179 RID: 20857
	public EMessageType Type;

	// Token: 0x0400517A RID: 20858
	public string Text;

	// Token: 0x0400517B RID: 20859
	public DateTime LocalDateTime;

	// Token: 0x0400517C RID: 20860
	public DateTime UtcDateTime;

	// Token: 0x0400517D RID: 20861
	public UpdatableChatMember Member;

	// Token: 0x0400517E RID: 20862
	public ChatMessageClass ReplyTo;

	// Token: 0x0400517F RID: 20863
	public ChatMessageClass.GClass938 Params;

	// Token: 0x04005180 RID: 20864
	public long MaxStorageTime;

	// Token: 0x04005181 RID: 20865
	public GClass936 Items;

	// Token: 0x04005182 RID: 20866
	public ProfileChangeEvent[] ProfileChangeEvents;

	// Token: 0x04005183 RID: 20867
	public bool HasRewards;

	// Token: 0x04005184 RID: 20868
	[NonSerialized]
	public BindableEvent UpdateRewardStatus;

	// Token: 0x02000CE7 RID: 3303
	public class GClass938
	{
		// Token: 0x04005185 RID: 20869
		public EMessageParamsAction Action;

		// Token: 0x04005186 RID: 20870
		public UpdatableChatMember Member;

		// Token: 0x04005187 RID: 20871
		public UpdatableChatMember[] Users;
	}

	// Token: 0x02000CE8 RID: 3304
	[CompilerGenerated]
	[Serializable]
	private sealed class Class668
	{
		// Token: 0x06004682 RID: 18050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item item)
		{
			throw null;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item item)
		{
			throw null;
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ProfileChangeEvent @event)
		{
			throw null;
		}

		// Token: 0x04005188 RID: 20872
		public static readonly ChatMessageClass.Class668 class668_0;

		// Token: 0x04005189 RID: 20873
		public static Func<Item, bool> func_0;

		// Token: 0x0400518A RID: 20874
		public static Func<Item, bool> func_1;

		// Token: 0x0400518B RID: 20875
		public static Func<ProfileChangeEvent, bool> func_2;
	}
}
