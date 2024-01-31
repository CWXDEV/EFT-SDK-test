using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AB5 RID: 10933
	public sealed class PlayerLevelPanel : MonoBehaviour
	{
		// Token: 0x0600D94A RID: 55626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(int level, ESideType side)
		{
			throw null;
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetLevelIcon(Image image, int level)
		{
			throw null;
		}

		// Token: 0x0400DC25 RID: 56357
		private const int int_0 = 80;

		// Token: 0x0400DC26 RID: 56358
		[SerializeField]
		private CustomTextMeshProUGUI _level;

		// Token: 0x0400DC27 RID: 56359
		[SerializeField]
		private Image _icon;
	}
}
