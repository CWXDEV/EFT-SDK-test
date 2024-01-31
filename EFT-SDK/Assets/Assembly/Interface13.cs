using System;
using UnityEngine.Rendering;

// Token: 0x02001DC4 RID: 7620
internal interface Interface13 : IDisposable, Interface12
{
	// Token: 0x06009CDE RID: 40158
	void DrawDistantShadow(CommandBuffer commandBuffer, uint impostorsPerFrame, out int impostorsRest);

	// Token: 0x06009CDF RID: 40159
	void OnPreCull(CommandBuffer commandBuffer);

	// Token: 0x06009CE0 RID: 40160
	void Refresh();

	// Token: 0x06009CE1 RID: 40161
	void EnablesChanged();
}
