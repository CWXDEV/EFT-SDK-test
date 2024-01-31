using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DBF RID: 11711
	public sealed class RaidReadyPlayerPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x14000341 RID: 833
		// (add) Token: 0x0600E633 RID: 58931 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E634 RID: 58932 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass1207, Vector2> OnPlayerClick
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

		// Token: 0x0600E635 RID: 58933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1207 player, bool yourPanel, bool friendPanel, GClass3357<GClass1210> invites)
		{
			throw null;
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLookingForGroupStatus()
		{
			throw null;
		}

		// Token: 0x0600E637 RID: 58935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInviteSentStatus(bool value)
		{
			throw null;
		}

		// Token: 0x0600E638 RID: 58936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E639 RID: 58937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E63A RID: 58938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E63B RID: 58939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E63C RID: 58940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E63D RID: 58941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400EB3B RID: 60219
		[CompilerGenerated]
		private Action<GClass1207, Vector2> action_0;

		// Token: 0x0400EB3C RID: 60220
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400EB3D RID: 60221
		[SerializeField]
		private Color _defaultImageColor;

		// Token: 0x0400EB3E RID: 60222
		[SerializeField]
		private Color _yourImageColor;

		// Token: 0x0400EB3F RID: 60223
		[SerializeField]
		private Color _selectedImageColor;

		// Token: 0x0400EB40 RID: 60224
		[SerializeField]
		private ChatSpecialIcon _icon;

		// Token: 0x0400EB41 RID: 60225
		[SerializeField]
		private CustomTextMeshProUGUI _nameLabel;

		// Token: 0x0400EB42 RID: 60226
		[SerializeField]
		private CustomTextMeshProUGUI _sideLabel;

		// Token: 0x0400EB43 RID: 60227
		[SerializeField]
		private CustomTextMeshProUGUI _statusLabel;

		// Token: 0x0400EB44 RID: 60228
		[SerializeField]
		private GameObject _inviteSentGameObject;

		// Token: 0x0400EB45 RID: 60229
		[SerializeField]
		private GameObject _lookingForGroupGameObject;

		// Token: 0x0400EB46 RID: 60230
		private GClass1207 gclass1207_0;

		// Token: 0x0400EB47 RID: 60231
		private bool bool_0;

		// Token: 0x0400EB48 RID: 60232
		private bool bool_1;

		// Token: 0x02002DC0 RID: 11712
		[CompilerGenerated]
		private sealed class Class2852
		{
			// Token: 0x0600E63E RID: 58942 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E63F RID: 58943 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass1210 invite)
			{
				throw null;
			}

			// Token: 0x0400EB49 RID: 60233
			public RaidReadyPlayerPanel raidReadyPlayerPanel_0;

			// Token: 0x0400EB4A RID: 60234
			public GClass3357<GClass1210> invites;

			// Token: 0x0400EB4B RID: 60235
			public GClass1207 player;

			// Token: 0x0400EB4C RID: 60236
			public Func<GClass1210, bool> func_0;
		}
	}
}
