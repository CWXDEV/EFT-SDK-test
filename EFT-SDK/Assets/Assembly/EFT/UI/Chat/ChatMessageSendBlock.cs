using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E65 RID: 11877
	public sealed class ChatMessageSendBlock : UIElement
	{
		// Token: 0x0600EA74 RID: 60020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social, GClass940 dialogue, Action onTransferAll)
		{
			throw null;
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseMessageSendBlock(GClass940 dialogue)
		{
			throw null;
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EA7A RID: 60026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(KeyValuePair<GClass940, ChatMessageClass> dialogue)
		{
			throw null;
		}

		// Token: 0x0600EA7C RID: 60028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5([CanBeNull] ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400EEFC RID: 61180
		[SerializeField]
		private DefaultUIButton _receiveAllButton;

		// Token: 0x0400EEFD RID: 61181
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400EEFE RID: 61182
		[SerializeField]
		private GameObject _enterMessagePanel;

		// Token: 0x0400EEFF RID: 61183
		[SerializeField]
		private GameObject _messageSendBlockPanel;

		// Token: 0x0400EF00 RID: 61184
		[SerializeField]
		private CustomTextMeshProUGUI _messageBlockLabel;

		// Token: 0x0400EF01 RID: 61185
		private GClass940 gclass940_0;

		// Token: 0x0400EF02 RID: 61186
		private Action action_0;

		// Token: 0x0400EF03 RID: 61187
		private float float_0;

		// Token: 0x0400EF04 RID: 61188
		private GClass1839 gclass1839_0;

		// Token: 0x02002E66 RID: 11878
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2908
		{
			// Token: 0x0600EA7F RID: 60031 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ChatMessageClass message)
			{
				throw null;
			}

			// Token: 0x0600EA80 RID: 60032 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DateTime method_1(ChatMessageClass message)
			{
				throw null;
			}

			// Token: 0x0400EF05 RID: 61189
			public static readonly ChatMessageSendBlock.Class2908 class2908_0;

			// Token: 0x0400EF06 RID: 61190
			public static Func<ChatMessageClass, bool> func_0;

			// Token: 0x0400EF07 RID: 61191
			public static Func<ChatMessageClass, DateTime> func_1;
		}
	}
}
