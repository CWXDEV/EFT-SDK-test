using System;

namespace AnimationEventSystem
{
	// Token: 0x0200101D RID: 4125
	public interface IAnimatorEventParameter
	{
		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06005637 RID: 22071
		bool BoolParam { get; }

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06005638 RID: 22072
		float FloatParam { get; }

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06005639 RID: 22073
		int IntParam { get; }

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x0600563A RID: 22074
		string StringParam { get; }

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x0600563B RID: 22075
		EAnimationEventParamType ParamType { get; }
	}
}
