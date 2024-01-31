using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B5D RID: 11101
	[UsedImplicitly]
	public sealed class SkillsScreen : UIElement
	{
		// Token: 0x0600DB8C RID: 56204 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB8D RID: 56205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0600DB8E RID: 56206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400DF4D RID: 57165
		[SerializeField]
		private SkillList _skillList;

		// Token: 0x0400DF4E RID: 57166
		[SerializeField]
		private SkillThumbs _skillThumbs;

		// Token: 0x0400DF4F RID: 57167
		[SerializeField]
		private DropDownBox _sortMethod;

		// Token: 0x0400DF50 RID: 57168
		[SerializeField]
		private DropDownBox _filterMethod;

		// Token: 0x0400DF51 RID: 57169
		[SerializeField]
		private Tab _listTab;

		// Token: 0x0400DF52 RID: 57170
		[SerializeField]
		private Tab _thumbsTab;

		// Token: 0x0400DF53 RID: 57171
		private GClass3065 gclass3065_0;

		// Token: 0x02002B5E RID: 11102
		[CompilerGenerated]
		private sealed class Class2623
		{
			// Token: 0x0600DB8F RID: 56207 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(SkillList x)
			{
				throw null;
			}

			// Token: 0x0600DB90 RID: 56208 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(SkillThumbs x)
			{
				throw null;
			}

			// Token: 0x0400DF54 RID: 57172
			public Profile profile;

			// Token: 0x0400DF55 RID: 57173
			public SkillsScreen skillsScreen_0;

			// Token: 0x0400DF56 RID: 57174
			public IHealthController healthController;
		}
	}
}
