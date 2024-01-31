using System;
using System.Runtime.CompilerServices;
using EFT.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B9E RID: 11166
	public class QuestRequirementView : MonoBehaviour
	{
		// Token: 0x0600DC50 RID: 56400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GClass1246 quest, Condition condition)
		{
			throw null;
		}

		// Token: 0x0400E075 RID: 57461
		[SerializeField]
		private Image _icon;

		// Token: 0x0400E076 RID: 57462
		[SerializeField]
		private CustomTextMeshProUGUI _text;

		// Token: 0x0400E077 RID: 57463
		[SerializeField]
		private Image _checkMark;

		// Token: 0x0400E078 RID: 57464
		[SerializeField]
		private SpriteMap _icons;

		// Token: 0x0400E079 RID: 57465
		[SerializeField]
		private ColorMap _colors;
	}
}
