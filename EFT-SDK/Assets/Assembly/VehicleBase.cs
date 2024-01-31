using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using EFT.Vehicle;
using UnityEngine;

// Token: 0x02000657 RID: 1623
public class VehicleBase : MonoBehaviour, GInterface22
{
	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x0600250E RID: 9486 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600250F RID: 9487 RVA: 0x00002050 File Offset: 0x00000250
	public EBtrState BtrState
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x06002510 RID: 9488 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002511 RID: 9489 RVA: 0x00002050 File Offset: 0x00000250
	public EVehicleRouteState VehicleRouteState
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06002512 RID: 9490 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002513 RID: 9491 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsPaid
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x06002514 RID: 9492 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002515 RID: 9493 RVA: 0x00002050 File Offset: 0x00000250
	public PathConfig CurrentPathConfig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x06002516 RID: 9494 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002517 RID: 9495 RVA: 0x00002050 File Offset: 0x00000250
	public MoveByPathType MoveByPathType
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06002518 RID: 9496 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002519 RID: 9497 RVA: 0x00002050 File Offset: 0x00000250
	public EVehicleMoveDirection VehicleMoveDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Start()
	{
		throw null;
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool IsDoorsClosed()
	{
		throw null;
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialization(MapPathConfig mapPathsConfig)
	{
		throw null;
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnInEnterPoint()
	{
		throw null;
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnInPoint(int index)
	{
		throw null;
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveEnable()
	{
		throw null;
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveDisable()
	{
		throw null;
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveToDestination(string destinationID)
	{
		throw null;
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MovePauseOn(float pauseDuration)
	{
		throw null;
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MovePauseOff()
	{
		throw null;
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ExtractPassengers()
	{
		throw null;
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveProcess()
	{
		throw null;
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PauseProcess()
	{
		throw null;
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600252D RID: 9517 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4(float newSpeed)
	{
		throw null;
	}

	// Token: 0x0600252E RID: 9518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_8()
	{
		throw null;
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_9()
	{
		throw null;
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_10()
	{
		throw null;
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(PathDestination pathDestination)
	{
		throw null;
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnIncomingToDestination(string pathID)
	{
		throw null;
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_13(PathPartBase pathPart)
	{
		throw null;
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15(PathDestination pathDestination)
	{
		throw null;
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_16(PathSpline nextPathSpline)
	{
		throw null;
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17(BezierSpline spline)
	{
		throw null;
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(bool needReverse)
	{
		throw null;
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19()
	{
		throw null;
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckNeedReverse(PathDestination pathDestination, PathSpline spline)
	{
		throw null;
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_20()
	{
		throw null;
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21()
	{
		throw null;
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22()
	{
		throw null;
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_24(float newSpeed)
	{
		throw null;
	}

	// Token: 0x04002418 RID: 9240
	[CompilerGenerated]
	private EBtrState ebtrState_0;

	// Token: 0x04002419 RID: 9241
	[CompilerGenerated]
	private EVehicleRouteState evehicleRouteState_0;

	// Token: 0x0400241A RID: 9242
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400241B RID: 9243
	public BTRBodySpring bodySpring;

	// Token: 0x0400241C RID: 9244
	public float currentSpeed;

	// Token: 0x0400241D RID: 9245
	public float previousCurrentSpeed;

	// Token: 0x0400241E RID: 9246
	private float float_0;

	// Token: 0x0400241F RID: 9247
	private float float_1;

	// Token: 0x04002420 RID: 9248
	private int int_0;

	// Token: 0x04002421 RID: 9249
	public float realAcceleration;

	// Token: 0x04002422 RID: 9250
	private float float_2;

	// Token: 0x04002423 RID: 9251
	private float float_3;

	// Token: 0x04002424 RID: 9252
	private int int_1;

	// Token: 0x04002425 RID: 9253
	public float timeToEndPause;

	// Token: 0x04002426 RID: 9254
	public MapPathConfig MapPathConfig;

	// Token: 0x04002427 RID: 9255
	[SerializeField]
	public PathConfig _currentPathConfig;

	// Token: 0x04002428 RID: 9256
	[CompilerGenerated]
	private MoveByPathType moveByPathType_0;

	// Token: 0x04002429 RID: 9257
	private Dictionary<string, PathPartBase> dictionary_0;

	// Token: 0x0400242A RID: 9258
	public GameObject turnCheckerObject;

	// Token: 0x0400242B RID: 9259
	public GameObject surfaceCheckerCenter;

	// Token: 0x0400242C RID: 9260
	public GameObject SurfaceCheckerFront;

	// Token: 0x0400242D RID: 9261
	public GameObject SurfaceCheckerBack;

	// Token: 0x0400242E RID: 9262
	public LayerMask surfaceMask;

	// Token: 0x0400242F RID: 9263
	public bool lookForward;

	// Token: 0x04002430 RID: 9264
	[CompilerGenerated]
	private EVehicleMoveDirection evehicleMoveDirection_0;

	// Token: 0x04002431 RID: 9265
	public float moveSpeed;

	// Token: 0x04002432 RID: 9266
	public float readyToDeparture;

	// Token: 0x04002433 RID: 9267
	public float checkTurnDistanceTime;

	// Token: 0x04002434 RID: 9268
	public float turnCheckSensitivity;

	// Token: 0x04002435 RID: 9269
	public float decreaseSpeedOnTurnLimit;

	// Token: 0x04002436 RID: 9270
	public float endSplineDecelerationDistance;

	// Token: 0x04002437 RID: 9271
	public float accelerationSpeed;

	// Token: 0x04002438 RID: 9272
	public float decelerationSpeed;

	// Token: 0x04002439 RID: 9273
	public float horizontalRotateLerp;

	// Token: 0x0400243A RID: 9274
	public float verticalRotateLerp;

	// Token: 0x0400243B RID: 9275
	public float snappingThresholdDistance;

	// Token: 0x0400243C RID: 9276
	private PathSpline pathSpline_0;

	// Token: 0x0400243D RID: 9277
	private PathSpline pathSpline_1;

	// Token: 0x0400243E RID: 9278
	private PathDestination pathDestination_0;

	// Token: 0x0400243F RID: 9279
	private PathDestination pathDestination_1;

	// Token: 0x04002440 RID: 9280
	private PathReverseData pathReverseData_0;

	// Token: 0x04002441 RID: 9281
	private PathReversePart pathReversePart_0;

	// Token: 0x04002442 RID: 9282
	private bool bool_1;

	// Token: 0x04002443 RID: 9283
	private bool bool_2;

	// Token: 0x04002444 RID: 9284
	private bool bool_3;

	// Token: 0x04002445 RID: 9285
	private bool bool_4;

	// Token: 0x04002446 RID: 9286
	private bool bool_5;

	// Token: 0x04002447 RID: 9287
	private bool bool_6;

	// Token: 0x04002448 RID: 9288
	private bool bool_7;

	// Token: 0x04002449 RID: 9289
	private float float_4;

	// Token: 0x0400244A RID: 9290
	private float float_5;

	// Token: 0x0400244B RID: 9291
	private float float_6;

	// Token: 0x0400244C RID: 9292
	private float float_7;

	// Token: 0x0400244D RID: 9293
	private float float_8;

	// Token: 0x0400244E RID: 9294
	private float float_9;

	// Token: 0x0400244F RID: 9295
	private float float_10;

	// Token: 0x04002450 RID: 9296
	private float float_11;

	// Token: 0x04002451 RID: 9297
	private int int_2;

	// Token: 0x04002452 RID: 9298
	private int int_3;

	// Token: 0x04002453 RID: 9299
	private int int_4;

	// Token: 0x04002454 RID: 9300
	private float float_12;

	// Token: 0x04002455 RID: 9301
	private float float_13;

	// Token: 0x04002456 RID: 9302
	private Vector3 vector3_0;

	// Token: 0x04002457 RID: 9303
	public Vector2 pauseDurationRange;

	// Token: 0x04002458 RID: 9304
	private bool bool_8;

	// Token: 0x04002459 RID: 9305
	private bool bool_9;

	// Token: 0x0400245A RID: 9306
	private float float_14;

	// Token: 0x0400245B RID: 9307
	private float float_15;

	// Token: 0x0400245C RID: 9308
	public GDelegate23 IncomingToDestinationEvent;

	// Token: 0x0400245D RID: 9309
	public GDelegate22 ReadyToDepartureEvent;
}
