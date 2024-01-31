using System;
using System.Runtime.CompilerServices;
using ChatShared;
using EFT;
using EFT.Communications;
using Newtonsoft.Json;

// Token: 0x02000CDA RID: 3290
public class GClass932
{
	// Token: 0x04005135 RID: 20789
	public ChatMessageClass[] messages;

	// Token: 0x04005136 RID: 20790
	public UpdatableChatMember[] profiles;

	// Token: 0x04005137 RID: 20791
	public bool hasMessagesWithRewards;

	// Token: 0x02000CDB RID: 3291
	public class GClass933 : ISerializer<ChatMessageClass.GClass938>
	{
		// Token: 0x06004665 RID: 18021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatMessageClass.GClass938 Deserialize()
		{
			throw null;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private UpdatableChatMember method_0(string memberId)
		{
			throw null;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Serialize(ChatMessageClass.GClass938 t)
		{
			throw null;
		}

		// Token: 0x04005138 RID: 20792
		public string Action;

		// Token: 0x04005139 RID: 20793
		public string uid;

		// Token: 0x0400513A RID: 20794
		public string uid2;

		// Token: 0x0400513B RID: 20795
		public string[] users;

		// Token: 0x0400513C RID: 20796
		public UpdatableChatMember profile;

		// Token: 0x02000CDC RID: 3292
		[CompilerGenerated]
		[Serializable]
		private sealed class Class665
		{
			// Token: 0x06004668 RID: 18024 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_0(string id)
			{
				throw null;
			}

			// Token: 0x0400513D RID: 20797
			public static readonly GClass932.GClass933.Class665 class665_0;

			// Token: 0x0400513E RID: 20798
			public static Func<string, UpdatableChatMember> func_0;
		}
	}

	// Token: 0x02000CDD RID: 3293
	public class GClass934 : ISerializer<GClass936>
	{
		// Token: 0x06004669 RID: 18025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass936 Deserialize()
		{
			throw null;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Serialize(GClass936 t)
		{
			throw null;
		}

		// Token: 0x0400513F RID: 20799
		[JsonProperty("stash")]
		public string StashId;

		// Token: 0x04005140 RID: 20800
		[JsonProperty("data")]
		public GClass1186[] Items;

		// Token: 0x02000CDE RID: 3294
		[CompilerGenerated]
		[Serializable]
		private sealed class Class666
		{
			// Token: 0x0600466B RID: 18027 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1186 x)
			{
				throw null;
			}

			// Token: 0x04005141 RID: 20801
			public static readonly GClass932.GClass934.Class666 class666_0;

			// Token: 0x04005142 RID: 20802
			public static Func<GClass1186, bool> func_0;
		}
	}

	// Token: 0x02000CDF RID: 3295
	public class GClass935 : ISerializer<ChatMessageClass>
	{
		// Token: 0x0600466C RID: 18028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatMessageClass Deserialize()
		{
			throw null;
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Serialize(ChatMessageClass t)
		{
			throw null;
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ChatMessageClass method_0()
		{
			throw null;
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(ProfileChangeEvent @event)
		{
			throw null;
		}

		// Token: 0x04005143 RID: 20803
		public string _id;

		// Token: 0x04005144 RID: 20804
		public string templateId;

		// Token: 0x04005145 RID: 20805
		public GClass931 systemData;

		// Token: 0x04005146 RID: 20806
		public int type;

		// Token: 0x04005147 RID: 20807
		public string text;

		// Token: 0x04005148 RID: 20808
		public double dt;

		// Token: 0x04005149 RID: 20809
		public string uid;

		// Token: 0x0400514A RID: 20810
		public bool hasRewards;

		// Token: 0x0400514B RID: 20811
		public long maxStorageTime;

		// Token: 0x0400514C RID: 20812
		public ChatMessageClass replyTo;

		// Token: 0x0400514D RID: 20813
		public ChatMessageClass.GClass938 @params;

		// Token: 0x0400514E RID: 20814
		public GClass936 items;

		// Token: 0x0400514F RID: 20815
		public ProfileChangeEvent[] ProfileChangeEvents;

		// Token: 0x02000CE0 RID: 3296
		[CompilerGenerated]
		[Serializable]
		private sealed class Class667
		{
			// Token: 0x06004670 RID: 18032 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_0(string id)
			{
				throw null;
			}

			// Token: 0x04005150 RID: 20816
			public static readonly GClass932.GClass935.Class667 class667_0;

			// Token: 0x04005151 RID: 20817
			public static Func<string, UpdatableChatMember> func_0;
		}
	}
}
