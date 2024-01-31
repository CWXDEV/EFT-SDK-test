using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028ED RID: 10477
	[RequireComponent(typeof(BattleUIComponentAnimation))]
	public sealed class AzimuthPanel : UIElement
	{
		// Token: 0x0600D129 RID: 53545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Func<int> azimuthFunc)
		{
			throw null;
		}

		// Token: 0x0600D12A RID: 53546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D12B RID: 53547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600D12D RID: 53549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D21D RID: 53789
		[SerializeField]
		private TextMeshProUGUI _azimuthField;

		// Token: 0x0400D21E RID: 53790
		private BattleUIComponentAnimation battleUIComponentAnimation_0;

		// Token: 0x0400D21F RID: 53791
		private Func<int> func_0;

		// Token: 0x0400D220 RID: 53792
		private int int_0;
	}
}
