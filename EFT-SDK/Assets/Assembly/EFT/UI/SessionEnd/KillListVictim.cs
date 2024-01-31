using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CE4 RID: 11492
	public sealed class KillListVictim : UIElement
	{
		// Token: 0x0600E21C RID: 57884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(VictimStats victim, bool knownName, int number)
		{
			throw null;
		}

		// Token: 0x0400E6CD RID: 59085
		private const string string_0 = "Headshot";

		// Token: 0x0400E6CE RID: 59086
		private const string string_1 = "Killed";

		// Token: 0x0400E6CF RID: 59087
		private const string string_2 = "Unknown weapon";

		// Token: 0x0400E6D0 RID: 59088
		[SerializeField]
		private CustomTextMeshProUGUI _number;

		// Token: 0x0400E6D1 RID: 59089
		[SerializeField]
		private CustomTextMeshProUGUI _timestamp;

		// Token: 0x0400E6D2 RID: 59090
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400E6D3 RID: 59091
		[SerializeField]
		private CustomTextMeshProUGUI _level;

		// Token: 0x0400E6D4 RID: 59092
		[SerializeField]
		private CustomTextMeshProUGUI _faction;

		// Token: 0x0400E6D5 RID: 59093
		[SerializeField]
		private CustomTextMeshProUGUI _status;

		// Token: 0x0400E6D6 RID: 59094
		[SerializeField]
		private GameObject _separator;

		// Token: 0x0400E6D7 RID: 59095
		[SerializeField]
		private Color _pmcColor;

		// Token: 0x0400E6D8 RID: 59096
		[SerializeField]
		private Color _scavColor;
	}
}
