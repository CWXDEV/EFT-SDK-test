using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002992 RID: 10642
	public sealed class GroupMemberView : ButtonFeedback, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x140002E6 RID: 742
		// (add) Token: 0x0600D3B2 RID: 54194 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D3B3 RID: 54195 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass1206, PointerEventData> OnGroupMemberClick
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

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1206 player, BindableState<GClass1207> groupOwner)
		{
			throw null;
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1206 player)
		{
			throw null;
		}

		// Token: 0x0600D3B6 RID: 54198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass1206 player)
		{
			throw null;
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool hover)
		{
			throw null;
		}

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400D611 RID: 54801
		[CompilerGenerated]
		private Action<GClass1206, PointerEventData> action_0;

		// Token: 0x0400D612 RID: 54802
		[SerializeField]
		private Image _bgImage;

		// Token: 0x0400D613 RID: 54803
		[SerializeField]
		private Image _border;

		// Token: 0x0400D614 RID: 54804
		[SerializeField]
		private Image _borderLeader;

		// Token: 0x0400D615 RID: 54805
		[SerializeField]
		private Sprite _bgIdle;

		// Token: 0x0400D616 RID: 54806
		[SerializeField]
		private Sprite _bgHover;

		// Token: 0x0400D617 RID: 54807
		[SerializeField]
		private Sprite _borderIdle;

		// Token: 0x0400D618 RID: 54808
		[SerializeField]
		private Sprite _borderHover;

		// Token: 0x0400D619 RID: 54809
		[SerializeField]
		private Sprite _borderLeaderIdle;

		// Token: 0x0400D61A RID: 54810
		[SerializeField]
		private Sprite _borderLeaderHover;

		// Token: 0x0400D61B RID: 54811
		[SerializeField]
		private TextMeshProUGUI _nicknameLetter;

		// Token: 0x0400D61C RID: 54812
		[SerializeField]
		private ChatSpecialIcon _playerNickname;

		// Token: 0x0400D61D RID: 54813
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400D61E RID: 54814
		private GClass1206 gclass1206_0;

		// Token: 0x0400D61F RID: 54815
		private bool bool_0;

		// Token: 0x02002993 RID: 10643
		[CompilerGenerated]
		private sealed class Class2434
		{
			// Token: 0x0600D3BB RID: 54203 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1207 owner)
			{
				throw null;
			}

			// Token: 0x0400D620 RID: 54816
			public GroupMemberView groupMemberView_0;

			// Token: 0x0400D621 RID: 54817
			public GClass1206 player;
		}
	}
}
