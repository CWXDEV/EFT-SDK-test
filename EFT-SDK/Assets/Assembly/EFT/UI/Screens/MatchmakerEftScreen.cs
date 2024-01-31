using System;
using System.Runtime.CompilerServices;
using EFT.UI.Matchmaker;

namespace EFT.UI.Screens
{
	// Token: 0x02002CFF RID: 11519
	public abstract class MatchmakerEftScreen<TController, TScreen> : EftScreen<TController, TScreen> where TController : GClass3148<TController, TScreen> where TScreen : EftScreen<TController, TScreen>
	{
		// Token: 0x0600E26E RID: 57966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TController controller)
		{
			throw null;
		}

		// Token: 0x0600E26F RID: 57967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InviteAcceptedHandler()
		{
			throw null;
		}

		// Token: 0x0600E270 RID: 57968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void MatchingTypeUpdateHandler(EMatchingType matchingType)
		{
			throw null;
		}

		// Token: 0x0600E271 RID: 57969 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400E767 RID: 59239
		protected GClass3166 MatchmakerPlayersController;
	}
}
