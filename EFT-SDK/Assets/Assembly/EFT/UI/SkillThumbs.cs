using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002B54 RID: 11092
	public sealed class SkillThumbs : SkillContainer<SkillIcon>
	{
		// Token: 0x0600DB7E RID: 56190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(SkillManager skills, DropDownBox sortMethod, DropDownBox filterMethod, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400DF29 RID: 57129
		private SkillTooltip skillTooltip_0;

		// Token: 0x02002B55 RID: 11093
		[CompilerGenerated]
		private sealed class Class2618
		{
			// Token: 0x0600DB80 RID: 56192 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1765 skill, SkillIcon skillIcon)
			{
				throw null;
			}

			// Token: 0x0400DF2A RID: 57130
			public IHealthController healthController;

			// Token: 0x0400DF2B RID: 57131
			public SkillThumbs skillThumbs_0;
		}

		// Token: 0x02002B56 RID: 11094
		[CompilerGenerated]
		private sealed class Class2619
		{
			// Token: 0x0600DB81 RID: 56193 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool hover, PointerEventData eventData)
			{
				throw null;
			}

			// Token: 0x0400DF2C RID: 57132
			public GClass1765 skill;

			// Token: 0x0400DF2D RID: 57133
			public SkillThumbs.Class2618 class2618_0;
		}
	}
}
