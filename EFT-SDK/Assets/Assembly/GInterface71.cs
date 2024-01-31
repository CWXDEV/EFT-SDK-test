using System;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000F4C RID: 3916
public interface GInterface71
{
	// Token: 0x17000CC5 RID: 3269
	// (get) Token: 0x06005214 RID: 21012
	IAnimator FastAnimator { get; }

	// Token: 0x17000CC6 RID: 3270
	// (get) Token: 0x06005215 RID: 21013
	PlayableGraph Graph { get; }

	// Token: 0x17000CC7 RID: 3271
	// (get) Token: 0x06005216 RID: 21014
	int LayersCount { get; }

	// Token: 0x17000CC8 RID: 3272
	// (get) Token: 0x06005217 RID: 21015
	bool ManualUpdateMode { get; }

	// Token: 0x06005218 RID: 21016
	void Play();

	// Token: 0x06005219 RID: 21017
	void Stop();

	// Token: 0x0600521A RID: 21018
	void Process(bool isVisible, float dt);

	// Token: 0x0600521B RID: 21019
	void SetLayerWeight(int layerIndex, float weight);

	// Token: 0x0600521C RID: 21020
	float GetLayerWeight(int layerIndex);

	// Token: 0x0600521D RID: 21021
	void RaiseImmediateTransitionHappened(int layerIndex);

	// Token: 0x0600521E RID: 21022
	void SetCuller(GInterface72 culler);

	// Token: 0x0600521F RID: 21023
	GInterface73 GetLayerProcessor(int layerIndex);

	// Token: 0x06005220 RID: 21024
	AnimationClip GetClipByIndex(int layerIndex, int clipIndex);
}
