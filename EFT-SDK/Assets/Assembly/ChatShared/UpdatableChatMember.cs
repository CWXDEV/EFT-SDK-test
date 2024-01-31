using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT;
using EFT.UI.Ragfair;

namespace ChatShared
{
	// Token: 0x02000CEC RID: 3308
	[Serializable]
	public sealed class UpdatableChatMember : IUpdatable<UpdatableChatMember>
	{
		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x00002050 File Offset: 0x00000250
		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x00002050 File Offset: 0x00000250
		public UpdatableChatMember.UpdatableChatMemberInfo Info
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasNickname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x00002050 File Offset: 0x00000250
		public string LocalizedNickname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static UpdatableChatMember FindOrCreate(string id, Func<string, UpdatableChatMember> constructor)
		{
			throw null;
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFromAnotherItem(UpdatableChatMember other)
		{
			throw null;
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFromChatMember(ChatRoomMember member)
		{
			throw null;
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFromMerchant(Offer.GClass3191 merchant)
		{
			throw null;
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFromTrader(BackendConfigSettingsClass.TraderSettings traderSettings)
		{
			throw null;
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIgnoreStatus(bool status)
		{
			throw null;
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBanStatus(bool status)
		{
			throw null;
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNickname(string nickname)
		{
			throw null;
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCategory(EMemberCategory category)
		{
			throw null;
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Compare(UpdatableChatMember other)
		{
			throw null;
		}

		// Token: 0x040051A9 RID: 20905
		private string _id;

		// Token: 0x040051AA RID: 20906
		public string AccountId;

		// Token: 0x040051AB RID: 20907
		private UpdatableChatMember.UpdatableChatMemberInfo _info;

		// Token: 0x040051AC RID: 20908
		[NonSerialized]
		public BindableEvent OnIgnoreStatusChanged;

		// Token: 0x040051AD RID: 20909
		[NonSerialized]
		public GClass3355<bool> OnPlayerBanStatusChanged;

		// Token: 0x02000CED RID: 3309
		public class UpdatableChatMemberInfo
		{
			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x060046A7 RID: 18087 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsTrader
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040051AE RID: 20910
			public string Nickname;

			// Token: 0x040051AF RID: 20911
			public EChatMemberSide Side;

			// Token: 0x040051B0 RID: 20912
			public int Level;

			// Token: 0x040051B1 RID: 20913
			public EMemberCategory MemberCategory;

			// Token: 0x040051B2 RID: 20914
			public bool Ignored;

			// Token: 0x040051B3 RID: 20915
			public bool Banned;
		}
	}
}
