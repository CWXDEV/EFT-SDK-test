using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AF9 RID: 11001
	public class StatItemView : UIElement
	{
		// Token: 0x0600DA70 RID: 55920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ProfileStats.GClass690 statItem)
		{
			throw null;
		}

		// Token: 0x0600DA71 RID: 55921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(ProfileStats.EStatType statType)
		{
			throw null;
		}

		// Token: 0x0400DD6B RID: 56683
		public const string UNITS_LITERS = "UI/ProfileStats/Liters";

		// Token: 0x0400DD6C RID: 56684
		public const string UNITS_METERS = "UI/ProfileStats/Meters";

		// Token: 0x0400DD6D RID: 56685
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x0400DD6E RID: 56686
		[SerializeField]
		private CustomTextMeshProUGUI _value;
	}
}
