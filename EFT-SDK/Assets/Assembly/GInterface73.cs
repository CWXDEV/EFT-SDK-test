using System;
using System.Collections.Generic;
using UnityEngine.Animations;

// Token: 0x02000F51 RID: 3921
public interface GInterface73
{
	// Token: 0x17000CCF RID: 3279
	// (get) Token: 0x06005239 RID: 21049
	int NodesCount { get; }

	// Token: 0x17000CD0 RID: 3280
	// (get) Token: 0x0600523A RID: 21050
	int LayerIndex { get; }

	// Token: 0x17000CD1 RID: 3281
	// (get) Token: 0x0600523B RID: 21051
	AnimationMixerPlayable Mixer { get; }

	// Token: 0x0600523C RID: 21052
	void EnableProfiling(bool val);

	// Token: 0x0600523D RID: 21053
	List<GStruct106> GetLastProcessedActiveNodes();

	// Token: 0x0600523E RID: 21054
	bool IsNextStateClip(int clipIndex);

	// Token: 0x0600523F RID: 21055
	float GetNodeTime(int clipIndex);

	// Token: 0x06005240 RID: 21056
	float GetNodePreviousTime(int clipIndex);

	// Token: 0x06005241 RID: 21057
	void RaiseImmediateTransitionHappened();
}
