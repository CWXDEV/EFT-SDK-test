using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Animations;
using UnityEngine;

// Token: 0x0200091B RID: 2331
[Serializable]
public class TurnAwayEffector : IEffector
{
	// Token: 0x170008F9 RID: 2297
	// (set) Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInPronePose
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170008FA RID: 2298
	// (set) Token: 0x060034A3 RID: 13475 RVA: 0x00002050 File Offset: 0x00000250
	public bool LeftStance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170008FB RID: 2299
	// (set) Token: 0x060034A4 RID: 13476 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsPistol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170008FC RID: 2300
	// (get) Token: 0x060034A5 RID: 13477 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008FD RID: 2301
	// (get) Token: 0x060034A6 RID: 13478 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Rotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008FE RID: 2302
	// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00002050 File Offset: 0x00000250
	public float FovScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170008FF RID: 2303
	// (set) Token: 0x060034A8 RID: 13480 RVA: 0x00002050 File Offset: 0x00000250
	public EPointOfView PointOfView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000900 RID: 2304
	// (get) Token: 0x060034A9 RID: 13481 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CameraShift
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000901 RID: 2305
	// (get) Token: 0x060034AA RID: 13482 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LElbowShift
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000902 RID: 2306
	// (get) Token: 0x060034AB RID: 13483 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 RElbowShift
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerSpring playerSpring)
	{
		throw null;
	}

	// Token: 0x060034AD RID: 13485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdatePreset()
	{
		throw null;
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugOutput()
	{
		throw null;
	}

	// Token: 0x04003566 RID: 13670
	public float OverlapValue;

	// Token: 0x04003567 RID: 13671
	[SerializeField]
	private TurnAwayPose _rifleShift;

	// Token: 0x04003568 RID: 13672
	[SerializeField]
	private TurnAwayPose _pistolShift;

	// Token: 0x04003569 RID: 13673
	[SerializeField]
	private TurnAwayPose _proneShift;

	// Token: 0x0400356A RID: 13674
	[SerializeField]
	private TurnAwayPose[] _elbows;

	// Token: 0x0400356B RID: 13675
	private TurnAwayPose _currentShift;

	// Token: 0x0400356C RID: 13676
	[SerializeField]
	private float _blendSpeed;

	// Token: 0x0400356D RID: 13677
	[SerializeField]
	private float _turnAwayThreshold;

	// Token: 0x0400356E RID: 13678
	[SerializeField]
	private float _turnAwayLeftStanceThreshold;

	// Token: 0x0400356F RID: 13679
	[SerializeField]
	private float _playerOverlapThreshold;

	// Token: 0x04003570 RID: 13680
	[SerializeField]
	private float _playerLeftStanceOverlapThreshold;

	// Token: 0x04003571 RID: 13681
	[SerializeField]
	private float _smoothTimeIn;

	// Token: 0x04003572 RID: 13682
	[SerializeField]
	private float _smoothTimeOut;

	// Token: 0x04003573 RID: 13683
	private EPointOfView _pov;

	// Token: 0x04003574 RID: 13684
	private bool _isPistol;

	// Token: 0x04003575 RID: 13685
	private bool _isInProne;

	// Token: 0x04003576 RID: 13686
	private bool _isLeftStance;

	// Token: 0x04003577 RID: 13687
	public bool IsDirty;

	// Token: 0x04003578 RID: 13688
	private float _fovInput;

	// Token: 0x04003579 RID: 13689
	public bool OverlapsWithPlayer;

	// Token: 0x0400357A RID: 13690
	public float OverlapDepth;

	// Token: 0x0400357B RID: 13691
	public float OriginZShift;

	// Token: 0x0400357C RID: 13692
	private float _fovScale;

	// Token: 0x0400357D RID: 13693
	private float _normalFovScale;

	// Token: 0x0400357E RID: 13694
	public float Overlap;

	// Token: 0x0400357F RID: 13695
	private float _blend;

	// Token: 0x04003580 RID: 13696
	public AnimationCurve CameraShiftCurve;

	// Token: 0x04003581 RID: 13697
	private Vector3 _position;

	// Token: 0x04003582 RID: 13698
	private Vector3 _rotation;

	// Token: 0x04003583 RID: 13699
	private Vector3 _cameraShift;

	// Token: 0x04003584 RID: 13700
	private Vector3 _lElbowShift;

	// Token: 0x04003585 RID: 13701
	private Vector3 _rElbowShift;

	// Token: 0x04003586 RID: 13702
	private float _cameraZShift;

	// Token: 0x04003587 RID: 13703
	private float _maxZShift;

	// Token: 0x04003588 RID: 13704
	[SerializeField]
	private float _cameraShiftAtMaxOverlap;

	// Token: 0x0200091C RID: 2332
	[Serializable]
	public class AnimVal
	{
		// Token: 0x060034B0 RID: 13488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Process(ref Vector3 vec, float value, EPointOfView pov, float weight)
		{
			throw null;
		}

		// Token: 0x04003589 RID: 13705
		public float Intensity;

		// Token: 0x0400358A RID: 13706
		public float AltIntensity;

		// Token: 0x0400358B RID: 13707
		public float Intensity1;

		// Token: 0x0400358C RID: 13708
		public float AltIntensity1;

		// Token: 0x0400358D RID: 13709
		public AnimationCurve Curve;

		// Token: 0x0400358E RID: 13710
		public TurnAwayEffector.AnimVal.ComponentType Component;

		// Token: 0x0400358F RID: 13711
		private int _component;

		// Token: 0x0200091D RID: 2333
		public enum ComponentType
		{
			// Token: 0x04003591 RID: 13713
			X,
			// Token: 0x04003592 RID: 13714
			Y,
			// Token: 0x04003593 RID: 13715
			Z
		}
	}
}
