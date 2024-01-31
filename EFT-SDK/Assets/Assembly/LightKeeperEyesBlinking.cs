using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200094F RID: 2383
public class LightKeeperEyesBlinking : MonoBehaviour
{
	// Token: 0x0600359F RID: 13727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060035A0 RID: 13728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0()
	{
		throw null;
	}

	// Token: 0x040036B8 RID: 14008
	[SerializeField]
	private SkinnedMeshRenderer _headMesh;

	// Token: 0x040036B9 RID: 14009
	[SerializeField]
	private LightKeeperEyeTargetFollower _eyeTargetFollower;

	// Token: 0x040036BA RID: 14010
	[SerializeField]
	private float minDelayBetweenBlinking;

	// Token: 0x040036BB RID: 14011
	[SerializeField]
	private float maxDelayBetweenBlinking;

	// Token: 0x040036BC RID: 14012
	[SerializeField]
	private float minBlinkTime;

	// Token: 0x040036BD RID: 14013
	[SerializeField]
	private float maxBlinkTime;

	// Token: 0x040036BE RID: 14014
	[SerializeField]
	private float minTimeForClosedEyes;

	// Token: 0x040036BF RID: 14015
	[SerializeField]
	private float maxTimeForClosedEyes;

	// Token: 0x040036C0 RID: 14016
	[SerializeField]
	private string leftEyeBlinkShape;

	// Token: 0x040036C1 RID: 14017
	[SerializeField]
	private string rightEyeBlinkShape;

	// Token: 0x040036C2 RID: 14018
	private Dictionary<string, int> dictionary_0;

	// Token: 0x040036C3 RID: 14019
	private Coroutine coroutine_0;

	// Token: 0x040036C4 RID: 14020
	private WaitForSeconds waitForSeconds_0;
}
