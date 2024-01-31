using System;
using System.Collections.Generic;
using AnimationEventSystem;

// Token: 0x02001592 RID: 5522
public interface GInterface139
{
	// Token: 0x1700128D RID: 4749
	// (get) Token: 0x0600767E RID: 30334
	Dictionary<int, Action<IAnimatorEventParameter>> BindedFunctions { get; }
}
