using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B7A RID: 7034
	public sealed class BonusesPanelSettings : SerializedScriptableObject
	{
		// Token: 0x170016AE RID: 5806
		public Sprite this[Enum status]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009AE5 RID: 39653
		public Dictionary<EBonusType, Sprite> BonusTypeMap;

		// Token: 0x04009AE6 RID: 39654
		public Dictionary<ESkillClass, Sprite> SkillTypeMap;

		// Token: 0x04009AE7 RID: 39655
		public Dictionary<ESkillId, Sprite> SkillIdMap;
	}
}
