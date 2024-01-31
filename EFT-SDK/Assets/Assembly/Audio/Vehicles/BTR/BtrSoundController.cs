using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.Data;
using EFT.GlobalEvents;
using EFT.Vehicle;
using UnityEngine;

namespace Audio.Vehicles.BTR
{
	// Token: 0x02000D21 RID: 3361
	[Serializable]
	public class BtrSoundController : MonoBehaviour
	{
		// Token: 0x06004781 RID: 18305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(BTRView btrView, float goInDurationMs, float goOutDurationMs)
		{
			throw null;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(BtrPauseMoveEvent moveEvent)
		{
			throw null;
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransitToEnvironment(EnvironmentType environment, bool fast = false, Action callback = null)
		{
			throw null;
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_4(EnvironmentType environment, bool fast)
		{
			throw null;
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_5(EnvironmentType environment, float transitionTime, Action callback = null)
		{
			throw null;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(EnvironmentType environment, float t)
		{
			throw null;
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400525A RID: 21082
		private const float MIN_TRANSITION_TIME = 0.1f;

		// Token: 0x0400525B RID: 21083
		[SerializeField]
		private VehicleMovementSoundContext _indoorSoundContext;

		// Token: 0x0400525C RID: 21084
		[SerializeField]
		private VehicleMovementSoundContext _outdoorSoundContext;

		// Token: 0x0400525D RID: 21085
		[SerializeField]
		private BtrDriverSoundBankContainer _btrDriverSoundContainer;

		// Token: 0x0400525E RID: 21086
		[SerializeField]
		private Transform _driverTransform;

		// Token: 0x0400525F RID: 21087
		private readonly Dictionary<EnvironmentType, VehicleMovementSoundContext> _contextByEnvironment;

		// Token: 0x04005260 RID: 21088
		private GInterface57 _phraseController;

		// Token: 0x04005261 RID: 21089
		private Coroutine _transitionCoroutine;

		// Token: 0x04005262 RID: 21090
		private BTRView _btrView;

		// Token: 0x04005263 RID: 21091
		private bool _initialized;

		// Token: 0x04005264 RID: 21092
		private float _currentNormalizedSpeed;

		// Token: 0x04005265 RID: 21093
		private float _goInDurationSeconds;

		// Token: 0x04005266 RID: 21094
		private float _goOutDurationSeconds;

		// Token: 0x04005267 RID: 21095
		private Action _unsubscribeOnDestroy;
	}
}
