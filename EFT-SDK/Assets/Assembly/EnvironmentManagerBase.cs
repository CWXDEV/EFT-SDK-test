using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.EnvironmentEffect;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200062C RID: 1580
public class EnvironmentManagerBase : MonoBehaviour
{
	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x0600242A RID: 9258 RVA: 0x00002050 File Offset: 0x00000250
	public static EnvironmentManagerBase Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Init()
	{
		throw null;
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitIndoors()
	{
		throw null;
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0()
	{
		throw null;
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IndoorTrigger method_1(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int TryFindEnvironmentIdByPos(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SetTriggerForPlayer(IPlayer player, IndoorTrigger trigger)
	{
		throw null;
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x04002375 RID: 9077
	protected Dictionary<int, IndoorTrigger> _cachedPlayerTrigger;

	// Token: 0x04002376 RID: 9078
	protected TriggerGroup _rootTriggerGroup;

	// Token: 0x04002377 RID: 9079
	private bool bool_0;

	// Token: 0x04002378 RID: 9080
	private bool bool_1;

	// Token: 0x04002379 RID: 9081
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400237A RID: 9082
	protected static EnvironmentManagerBase _instance;

	// Token: 0x0200062D RID: 1581
	public interface GInterface21
	{
		// Token: 0x06002434 RID: 9268
		void Reinit();

		// Token: 0x06002435 RID: 9269
		IndoorTrigger Check(Vector3 pos);
	}
}
