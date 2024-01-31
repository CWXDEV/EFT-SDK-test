using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x020022A2 RID: 8866
	public sealed class RadioTransmitterRecodableComponent : RecodableComponent
	{
		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x0600B436 RID: 46134 RVA: 0x00002050 File Offset: 0x00000250
		public RadioTransmitterStatus Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x0600B437 RID: 46135 RVA: 0x00002050 File Offset: 0x00000250
		public RadioTransmitterHandlerClass Handler
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400028E RID: 654
		// (add) Token: 0x0600B438 RID: 46136 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600B439 RID: 46137 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnRadioTransmitterStateChanged
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

		// Token: 0x1400028F RID: 655
		// (add) Token: 0x0600B43A RID: 46138 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600B43B RID: 46139 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<RadioTransmitterStatus> OnRadioTransmitterStatusChanged
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

		// Token: 0x0600B43C RID: 46140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEncoded(bool value)
		{
			throw null;
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStatus(RadioTransmitterStatus status)
		{
			throw null;
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeHandler(Player player)
		{
			throw null;
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string GetAttributeValue()
		{
			throw null;
		}

		// Token: 0x0400B859 RID: 47193
		private const string string_0 = "RadioTransmitter/AttributeValues/Blocked";

		// Token: 0x0400B85A RID: 47194
		private RadioTransmitterStatus radioTransmitterStatus_0;

		// Token: 0x0400B85B RID: 47195
		private RadioTransmitterHandlerClass gclass1481_0;

		// Token: 0x0400B85C RID: 47196
		[CompilerGenerated]
		private Action<bool> action_1;

		// Token: 0x0400B85D RID: 47197
		[CompilerGenerated]
		private Action<RadioTransmitterStatus> action_2;
	}
}
