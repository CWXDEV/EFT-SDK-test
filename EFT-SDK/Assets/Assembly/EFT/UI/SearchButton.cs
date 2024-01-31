using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002949 RID: 10569
	public class SearchButton : Button
	{
		// Token: 0x0600D2D0 RID: 53968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D2D1 RID: 53969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Action<bool> onSearchStatusChanged)
		{
			throw null;
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnabled(bool value)
		{
			throw null;
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSearchStatus(bool active, bool changeButtonEnabling = true)
		{
			throw null;
		}

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D2D6 RID: 53974 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400D45B RID: 54363
		private const string string_0 = "SEARCHING...";

		// Token: 0x0400D45C RID: 54364
		private const string string_1 = "SEARCH";

		// Token: 0x0400D45D RID: 54365
		[SerializeField]
		private CustomTextMeshProUGUI _buttonCaption;

		// Token: 0x0400D45E RID: 54366
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400D45F RID: 54367
		[SerializeField]
		private GameObject _searchIcon;

		// Token: 0x0400D460 RID: 54368
		[SerializeField]
		private Button _stopSearchButton;

		// Token: 0x0400D461 RID: 54369
		private bool bool_0;

		// Token: 0x0400D462 RID: 54370
		private Action<bool> action_0;
	}
}
