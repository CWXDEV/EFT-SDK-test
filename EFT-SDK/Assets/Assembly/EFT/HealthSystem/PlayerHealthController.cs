using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InventoryLogic;

namespace EFT.HealthSystem
{
	// Token: 0x02002219 RID: 8729
	public class PlayerHealthController : ActiveHealthController
	{
		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x0600B1FA RID: 45562 RVA: 0x00002050 File Offset: 0x00000250
		public override Player Player
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ManualEffectUpdate(ActiveHealthController.GClass2411 effect, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ApplyItem(Item item, EBodyPart bodyPart, float? amount = null)
		{
			throw null;
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CancelApplyingItem()
		{
			throw null;
		}

		// Token: 0x0400B6AA RID: 46762
		private Player _player;

		// Token: 0x0400B6AB RID: 46763
		private bool _started;

		// Token: 0x0200221A RID: 8730
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1924
		{
			// Token: 0x0600B1FF RID: 45567 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface130> hands)
			{
				throw null;
			}

			// Token: 0x0600B200 RID: 45568 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<GInterface130> hands)
			{
				throw null;
			}

			// Token: 0x0400B6AC RID: 46764
			public static readonly PlayerHealthController.Class1924 class1924_0;

			// Token: 0x0400B6AD RID: 46765
			public static Callback<GInterface130> callback_0;

			// Token: 0x0400B6AE RID: 46766
			public static Callback<GInterface130> callback_1;
		}
	}
}
