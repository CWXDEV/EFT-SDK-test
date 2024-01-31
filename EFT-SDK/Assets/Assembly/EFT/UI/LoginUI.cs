using System;
using System.Runtime.CompilerServices;
using EFT.UI.Settings;

namespace EFT.UI
{
	// Token: 0x02002A67 RID: 10855
	public sealed class LoginUI : MonoBehaviourSingleton<LoginUI>
	{
		// Token: 0x0600D7AA RID: 55210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400DA4E RID: 55886
		public QueueScreen QueueScreen;

		// Token: 0x0400DA4F RID: 55887
		public LoginScreen LoginScreen;

		// Token: 0x0400DA50 RID: 55888
		public ValidateDeviceIdScreen ValidateDeviceIdScreen;

		// Token: 0x0400DA51 RID: 55889
		public WelcomeScreen WelcomeScreen;

		// Token: 0x0400DA52 RID: 55890
		public SetNicknameScreen SetNicknameScreen;

		// Token: 0x0400DA53 RID: 55891
		public SideSelectionScreen SideSelectionScreen;

		// Token: 0x0400DA54 RID: 55892
		public RestorePasswordScreen RestorePasswordScreen;

		// Token: 0x0400DA55 RID: 55893
		public ProfileLoadingScreen ProfileLoadingScreen;
	}
}
