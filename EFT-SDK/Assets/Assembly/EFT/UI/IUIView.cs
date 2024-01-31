using System;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C3C RID: 11324
	public interface IUIView : IDisposable
	{
		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x0600DF29 RID: 57129
		GameObject GameObject { get; }

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x0600DF2A RID: 57130
		Transform Transform { get; }
	}
}
