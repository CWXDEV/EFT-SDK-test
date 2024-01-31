using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E76 RID: 11894
	public class ChatFriendsPanel : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600EAD4 RID: 60116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EAD5 RID: 60117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social)
		{
			throw null;
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool status)
		{
			throw null;
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EAD9 RID: 60121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EADA RID: 60122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EADB RID: 60123 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(string arg)
		{
			throw null;
		}

		// Token: 0x0600EADE RID: 60126 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400EF9C RID: 61340
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400EF9D RID: 61341
		[SerializeField]
		private FriendsListContentButton _friendsButton;

		// Token: 0x0400EF9E RID: 61342
		[SerializeField]
		private FriendsListContentButton _requestsButton;

		// Token: 0x0400EF9F RID: 61343
		[SerializeField]
		private ChatFriendsListPanel _chatFriendsListPanel;

		// Token: 0x0400EFA0 RID: 61344
		[SerializeField]
		private ChatFriendsRequestsPanel _chatFriendsRequestsPanel;

		// Token: 0x0400EFA1 RID: 61345
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400EFA2 RID: 61346
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400EFA3 RID: 61347
		[SerializeField]
		private GameObject _searchIcon;

		// Token: 0x0400EFA4 RID: 61348
		[SerializeField]
		private ValidationInputField _friendsInputField;

		// Token: 0x0400EFA5 RID: 61349
		[SerializeField]
		private ChatMembersPanel _chatMembersPanel;

		// Token: 0x0400EFA6 RID: 61350
		private const int int_0 = 1;

		// Token: 0x0400EFA7 RID: 61351
		private GClass1839 gclass1839_0;

		// Token: 0x0400EFA8 RID: 61352
		private bool bool_0;

		// Token: 0x0400EFA9 RID: 61353
		private float float_0;
	}
}
