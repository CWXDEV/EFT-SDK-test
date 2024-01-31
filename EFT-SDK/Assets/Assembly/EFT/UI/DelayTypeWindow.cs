using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002942 RID: 10562
	public sealed class DelayTypeWindow : MessageWindow
	{
		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool CloseOnAccept
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D2BB RID: 53947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string title, string message, string traderId, Action acceptAction, float time = 0f)
		{
			throw null;
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4(string text)
		{
			throw null;
		}

		// Token: 0x0600D2BD RID: 53949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FinishAnimating()
		{
			throw null;
		}

		// Token: 0x0400D441 RID: 54337
		private const float float_1 = 0.02f;

		// Token: 0x0400D442 RID: 54338
		[SerializeField]
		private Image _traderImage;

		// Token: 0x0400D443 RID: 54339
		private Coroutine coroutine_1;

		// Token: 0x0400D444 RID: 54340
		private bool bool_1;
	}
}
