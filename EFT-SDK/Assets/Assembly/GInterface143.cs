using System;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;

// Token: 0x02001812 RID: 6162
public interface GInterface143
{
	// Token: 0x060083CB RID: 33739
	Task<Result<ECaptchaResult>> RequestCaptcha();

	// Token: 0x060083CC RID: 33740
	void RequestCaptcha(object operation, Callback callback);

	// Token: 0x060083CD RID: 33741
	void Activate();

	// Token: 0x060083CE RID: 33742
	void Deactivate();
}
