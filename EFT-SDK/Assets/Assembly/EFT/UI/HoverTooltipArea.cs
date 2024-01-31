using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002B08 RID: 11016
	public class HoverTooltipArea : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x00002050 File Offset: 0x00000250
		private float? Nullable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600DA9C RID: 55964 RVA: 0x00002050 File Offset: 0x00000250
		private string String_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x00002050 File Offset: 0x00000250
		public CanvasGroup CanvasGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DA9E RID: 55966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DA9F RID: 55967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(SimpleTooltip tooltip, string text, bool rawText = false)
		{
			throw null;
		}

		// Token: 0x0600DAA0 RID: 55968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMessageText(string text, bool rawText = false)
		{
			throw null;
		}

		// Token: 0x0600DAA1 RID: 55969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMessageText(Func<string> textGetter)
		{
			throw null;
		}

		// Token: 0x0600DAA2 RID: 55970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnlockStatus(bool value)
		{
			throw null;
		}

		// Token: 0x0600DAA6 RID: 55974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationFocus(bool inFocus)
		{
			throw null;
		}

		// Token: 0x0600DAA7 RID: 55975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0400DDB0 RID: 56752
		[SerializeField]
		private string _message;

		// Token: 0x0400DDB1 RID: 56753
		[SerializeField]
		private float _delay;

		// Token: 0x0400DDB2 RID: 56754
		[SerializeField]
		private bool _limitTooltipWidth;

		// Token: 0x0400DDB3 RID: 56755
		[SerializeField]
		private bool _customOffset;

		// Token: 0x0400DDB4 RID: 56756
		[SerializeField]
		private Vector2 _offset;

		// Token: 0x0400DDB5 RID: 56757
		private Func<string> func_0;

		// Token: 0x0400DDB6 RID: 56758
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400DDB7 RID: 56759
		private CanvasGroup canvasGroup_0;

		// Token: 0x0400DDB8 RID: 56760
		private bool bool_0;

		// Token: 0x0400DDB9 RID: 56761
		private bool bool_1;
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw new NotImplementedException();
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			throw new NotImplementedException();
		}
	}
}
