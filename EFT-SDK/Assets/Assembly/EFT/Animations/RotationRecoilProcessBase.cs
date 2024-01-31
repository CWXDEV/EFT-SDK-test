using System;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EFC RID: 7932
	[Serializable]
	public class RotationRecoilProcessBase : RecoilProcessBase
	{
		// Token: 0x0400AB51 RID: 43857
		[Tooltip("Максимальный базовый угол разброса вращения оружия от отдачи, применяеться при подсчете базового угла отдачи во время инициализации оружия")]
		public int MaxRecoilRotationAngle;
	}
}
