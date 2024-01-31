using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002911 RID: 10513
	public class TMP_InputFieldNoScroll : TMP_InputField
	{
		// Token: 0x0600D1D6 RID: 53718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Action<PointerEventData> onScroll)
		{
			throw null;
		}

		// Token: 0x0600D1D7 RID: 53719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnScroll([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400D325 RID: 54053
		private Action<PointerEventData> action_0;
	}
}
