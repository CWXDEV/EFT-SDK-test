using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AB6 RID: 10934
	public class PlayerNamePanel : MonoBehaviour
	{
		// Token: 0x0600D94C RID: 55628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(Profile profile)
		{
			throw null;
		}

		// Token: 0x0600D94D RID: 55629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(bool showDetails, EMemberCategory category, string nickname, int textSize = 23)
		{
			throw null;
		}

		// Token: 0x0400DC28 RID: 56360
		public const string MAIN_CHARACTER_DESCRIPTION = "YOUR MAIN CHARACTER";

		// Token: 0x0400DC29 RID: 56361
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DC2A RID: 56362
		[SerializeField]
		private CustomTextMeshProUGUI _description;

		// Token: 0x0400DC2B RID: 56363
		[SerializeField]
		private ChatSpecialIcon _icon;
	}
}
