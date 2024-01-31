using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Communications
{
	// Token: 0x02001CB0 RID: 7344
	[Serializable]
	public sealed class ProfileChangeEvent
	{
		// Token: 0x140001CA RID: 458
		// (add) Token: 0x06009948 RID: 39240 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009949 RID: 39241 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnUpdate
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

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x00002050 File Offset: 0x00000250
		public string EntityName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x0600994B RID: 39243 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Redeem()
		{
			throw null;
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Restore()
		{
			throw null;
		}

		// Token: 0x0400A0B1 RID: 41137
		[JsonProperty("_id")]
		public string Id;

		// Token: 0x0400A0B2 RID: 41138
		public string MessageId;

		// Token: 0x0400A0B3 RID: 41139
		public ENotificationType Type;

		// Token: 0x0400A0B4 RID: 41140
		public string Entity;

		// Token: 0x0400A0B5 RID: 41141
		public double? Value;

		// Token: 0x0400A0B6 RID: 41142
		public bool Redeemed;

		// Token: 0x02001CB1 RID: 7345
		private enum EAuxiliaryTypes
		{
			// Token: 0x0400A0B8 RID: 41144
			ProfileUnlock,
			// Token: 0x0400A0B9 RID: 41145
			LockTrader,
			// Token: 0x0400A0BA RID: 41146
			AssortmentLockRule,
			// Token: 0x0400A0BB RID: 41147
			ForgetItems
		}
	}
}
