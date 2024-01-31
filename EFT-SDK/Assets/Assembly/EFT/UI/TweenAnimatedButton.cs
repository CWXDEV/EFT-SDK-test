using System;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002919 RID: 10521
	public sealed class TweenAnimatedButton : SerializedMonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x140002E0 RID: 736
		// (add) Token: 0x0600D209 RID: 53769 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D20A RID: 53770 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnClick
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

		// Token: 0x140002E1 RID: 737
		// (add) Token: 0x0600D20B RID: 53771 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D20C RID: 53772 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnMouseEnter
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

		// Token: 0x140002E2 RID: 738
		// (add) Token: 0x0600D20D RID: 53773 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D20E RID: 53774 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnMouseExit
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

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x0600D20F RID: 53775 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D210 RID: 53776 RVA: 0x00002050 File Offset: 0x00000250
		public bool Interactable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600D211 RID: 53777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600D212 RID: 53778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D216 RID: 53782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D217 RID: 53783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400D368 RID: 54120
		[SerializeField]
		private GInterface359 _animation;

		// Token: 0x0400D369 RID: 54121
		[SerializeField]
		private bool _interactable;

		// Token: 0x0400D36A RID: 54122
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400D36B RID: 54123
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x0400D36C RID: 54124
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x0400D36D RID: 54125
		private bool bool_0;

		// Token: 0x0400D36E RID: 54126
		private bool bool_1;
	}
}
