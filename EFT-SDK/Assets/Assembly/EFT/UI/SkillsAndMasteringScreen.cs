using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B5A RID: 11098
	public class SkillsAndMasteringScreen : UIElement
	{
		// Token: 0x0600DB86 RID: 56198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB87 RID: 56199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile profile, GInterface313 inventoryController, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0400DF40 RID: 57152
		[SerializeField]
		private PlayerExperiencePanel _playerExperiencePanel;

		// Token: 0x0400DF41 RID: 57153
		[SerializeField]
		private SkillsScreen _skillsScreen;

		// Token: 0x0400DF42 RID: 57154
		[SerializeField]
		private MasteringScreen _masteringScreen;

		// Token: 0x0400DF43 RID: 57155
		[SerializeField]
		private Tab _skillsTab;

		// Token: 0x0400DF44 RID: 57156
		[SerializeField]
		private Tab _masteringTab;

		// Token: 0x0400DF45 RID: 57157
		private GClass3065 gclass3065_0;

		// Token: 0x02002B5B RID: 11099
		public sealed class GClass3061 : GClass3058<SkillsAndMasteringScreen>
		{
			// Token: 0x0600DB88 RID: 56200 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400DF46 RID: 57158
			private readonly Profile profile_0;

			// Token: 0x0400DF47 RID: 57159
			private readonly GInterface313 ginterface313_0;

			// Token: 0x0400DF48 RID: 57160
			private readonly IHealthController ihealthController_0;
		}

		// Token: 0x02002B5C RID: 11100
		[CompilerGenerated]
		private sealed class Class2622
		{
			// Token: 0x0600DB89 RID: 56201 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(SkillsScreen x)
			{
				throw null;
			}

			// Token: 0x0600DB8A RID: 56202 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(MasteringScreen x)
			{
				throw null;
			}

			// Token: 0x0600DB8B RID: 56203 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400DF49 RID: 57161
			public Profile profile;

			// Token: 0x0400DF4A RID: 57162
			public IHealthController healthController;

			// Token: 0x0400DF4B RID: 57163
			public GInterface313 inventoryController;

			// Token: 0x0400DF4C RID: 57164
			public SkillsAndMasteringScreen skillsAndMasteringScreen_0;
		}
	}
}
