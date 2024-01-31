using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200065B RID: 1627
public class GameObjectsToggleByDistance : MonoBehaviour
{
	// Token: 0x06002558 RID: 9560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleCheck(bool toggle)
	{
		throw null;
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool toggle)
	{
		throw null;
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1()
	{
		throw null;
	}

	// Token: 0x04002479 RID: 9337
	[Tooltip("Default state of game objects enable or disable")]
	[SerializeField]
	private bool defaultObjectsState;

	// Token: 0x0400247A RID: 9338
	[SerializeField]
	private List<GameObject> objectsForToggle;

	// Token: 0x0400247B RID: 9339
	[SerializeField]
	private Transform pointForCalculation;

	// Token: 0x0400247C RID: 9340
	[SerializeField]
	private float distanceForToggle;

	// Token: 0x0400247D RID: 9341
	[SerializeField]
	private bool autoStart;

	// Token: 0x0400247E RID: 9342
	private Coroutine coroutine_0;

	// Token: 0x0400247F RID: 9343
	private float float_0;

	// Token: 0x04002480 RID: 9344
	private List<Transform> list_0;

	// Token: 0x04002481 RID: 9345
	private WaitForEndOfFrame waitForEndOfFrame_0;
}
