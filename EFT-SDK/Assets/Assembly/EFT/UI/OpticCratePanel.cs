using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002900 RID: 10496
	[RequireComponent(typeof(BattleUIComponentAnimation))]
	public class OpticCratePanel : UIElement
	{
		// Token: 0x0600D18B RID: 53643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string message)
		{
			throw null;
		}

		// Token: 0x0600D18C RID: 53644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D18D RID: 53645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D279 RID: 53881
		[SerializeField]
		private CustomTextMeshProUGUI _currentCrate;

		// Token: 0x0400D27A RID: 53882
		private BattleUIComponentAnimation battleUIComponentAnimation_0;
	}
}
