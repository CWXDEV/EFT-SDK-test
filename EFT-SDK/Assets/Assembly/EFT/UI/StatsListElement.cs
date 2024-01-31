using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002909 RID: 10505
	public class StatsListElement : MonoBehaviour
	{
		// Token: 0x0600D1B1 RID: 53681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ProfileStats.GClass690 statInfo)
		{
			throw null;
		}

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string caption)
		{
			throw null;
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string statFieldId, string xp, [CanBeNull] string value)
		{
			throw null;
		}

		// Token: 0x0400D2BD RID: 53949
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x0400D2BE RID: 53950
		[SerializeField]
		private CustomTextMeshProUGUI _statFieldId;

		// Token: 0x0400D2BF RID: 53951
		[SerializeField]
		private CustomTextMeshProUGUI _xp;

		// Token: 0x0400D2C0 RID: 53952
		[SerializeField]
		private CustomTextMeshProUGUI _value;

		// Token: 0x0400D2C1 RID: 53953
		[SerializeField]
		private Image _xpIcon;
	}
}
