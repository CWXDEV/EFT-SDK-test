using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AB4 RID: 10932
	public class PlayerExperiencePanel : UIElement
	{
		// Token: 0x0600D949 RID: 55625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(int baseTotal, int targetExperience)
		{
			throw null;
		}

		// Token: 0x0400DC1F RID: 56351
		[SerializeField]
		private PlayerLevelPanel _currentLevel;

		// Token: 0x0400DC20 RID: 56352
		[SerializeField]
		private PlayerLevelPanel _nextLevel;

		// Token: 0x0400DC21 RID: 56353
		[SerializeField]
		private CustomTextMeshProUGUI _currentExperience;

		// Token: 0x0400DC22 RID: 56354
		[SerializeField]
		private CustomTextMeshProUGUI _remainingExperience;

		// Token: 0x0400DC23 RID: 56355
		[SerializeField]
		private CustomTextMeshProUGUI _newExperience;

		// Token: 0x0400DC24 RID: 56356
		[SerializeField]
		private TwoValueBar _experienceBar;
	}
}
