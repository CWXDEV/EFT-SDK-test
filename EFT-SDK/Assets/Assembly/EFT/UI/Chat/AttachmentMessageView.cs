using System;
using System.Runtime.CompilerServices;
using ChatShared;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E56 RID: 11862
	public sealed class AttachmentMessageView : MessageView
	{
		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x00002050 File Offset: 0x00000250
		private DateTime DateTime_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600EA48 RID: 59976 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EA4A RID: 59978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ChatMessageClass chatMessage, UpdatableChatMember member, [CanBeNull] GClass939 quote, Action<ChatMessageClass, Vector2> onMessageClicked, Action<ChatMessageClass> onMessageDoubleClicked, Action<ChatMessageClass> onItemsTransfer, Action<string> onOfferSelected)
		{
			throw null;
		}

		// Token: 0x0600EA4C RID: 59980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EMessageType type)
		{
			throw null;
		}

		// Token: 0x0600EA4D RID: 59981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EMessageType type)
		{
			throw null;
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EA4F RID: 59983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600EA50 RID: 59984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EA51 RID: 59985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateMessageStatus()
		{
			throw null;
		}

		// Token: 0x0600EA53 RID: 59987 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400EEAA RID: 61098
		[SerializeField]
		private DefaultUIButton _transferButtonSpawner;

		// Token: 0x0400EEAB RID: 61099
		[SerializeField]
		private LocalizedText _receivedLabel;

		// Token: 0x0400EEAC RID: 61100
		[SerializeField]
		private LocalizedText _outOfTimeLabel;

		// Token: 0x0400EEAD RID: 61101
		[SerializeField]
		private TextMeshProUGUI _timeToGetLabel;

		// Token: 0x0400EEAE RID: 61102
		[SerializeField]
		private Image _messageIcon;

		// Token: 0x0400EEAF RID: 61103
		[SerializeField]
		private Sprite _insuranceIcon;

		// Token: 0x0400EEB0 RID: 61104
		[SerializeField]
		private Sprite _questIcon;

		// Token: 0x0400EEB1 RID: 61105
		[SerializeField]
		private Sprite _systemIcon;

		// Token: 0x0400EEB2 RID: 61106
		[SerializeField]
		private Sprite _deliveryIcon;

		// Token: 0x0400EEB3 RID: 61107
		[SerializeField]
		private TextMeshProUGUI _messageDescriptionLabel;

		// Token: 0x0400EEB4 RID: 61108
		[SerializeField]
		private Color _insuranceTextColor;

		// Token: 0x0400EEB5 RID: 61109
		[SerializeField]
		private Color _questTextColor;

		// Token: 0x0400EEB6 RID: 61110
		[SerializeField]
		private Color _systemTextColor;

		// Token: 0x0400EEB7 RID: 61111
		[SerializeField]
		private Image _messageBackground;

		// Token: 0x0400EEB8 RID: 61112
		[SerializeField]
		private GameObject _insuranceLimiter;

		// Token: 0x0400EEB9 RID: 61113
		[SerializeField]
		private GameObject _messageAttachmentsObject;

		// Token: 0x0400EEBA RID: 61114
		[SerializeField]
		private Color _insuranceColor;

		// Token: 0x0400EEBB RID: 61115
		[SerializeField]
		private Color _questColor;

		// Token: 0x0400EEBC RID: 61116
		[SerializeField]
		private Color _systemColor;

		// Token: 0x0400EEBD RID: 61117
		[SerializeField]
		private Color _deliveryColor;

		// Token: 0x0400EEBE RID: 61118
		private Action action_3;

		// Token: 0x0400EEBF RID: 61119
		private Action<ChatMessageClass> action_4;

		// Token: 0x0400EEC0 RID: 61120
		private DateTime dateTime_0;

		// Token: 0x0400EEC1 RID: 61121
		private TimeSpan timeSpan_0;

		// Token: 0x0400EEC2 RID: 61122
		private long long_0;
	}
}
