using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A70 RID: 10864
	public class LocationWarningPanel : UIElement
	{
		// Token: 0x0600D7C0 RID: 55232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetByRules(LocationSettingsClass.Location.LocationRules rules)
		{
			throw null;
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetByLevel(bool unavailableByLevel, int minLocationLevel, int maxLocationLevel, int minPlayerLevel, int maxPlayerLevel)
		{
			throw null;
		}

		// Token: 0x0400DA82 RID: 55938
		[SerializeField]
		private CustomTextMeshProUGUI _description;
	}
}
