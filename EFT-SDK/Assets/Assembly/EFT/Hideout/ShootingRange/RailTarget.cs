using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C71 RID: 7281
	[RequireComponent(typeof(FoldingTarget))]
	public class RailTarget : MonoBehaviour, GInterface176
	{
		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06009803 RID: 38915 RVA: 0x00002050 File Offset: 0x00000250
		public int Row
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x00002050 File Offset: 0x00000250
		public bool Unfolded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06009805 RID: 38917 RVA: 0x00002050 File Offset: 0x00000250
		public bool Folded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x00002050 File Offset: 0x00000250
		public bool Ready
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x140001C5 RID: 453
		// (add) Token: 0x06009809 RID: 38921 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600980A RID: 38922 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<RailTarget, TargetColliderType, int> OnHitTarget
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600980C RID: 38924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(TargetColliderType targetColliderType, int segmentTarget)
		{
			throw null;
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMovementSpeed(int currentMovementSpeed)
		{
			throw null;
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Fold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06009810 RID: 38928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unfold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Rocking(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06009814 RID: 38932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06009815 RID: 38933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryShooting(CancellationToken token, out Task task)
		{
			throw null;
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tween method_4()
		{
			throw null;
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tween method_5()
		{
			throw null;
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tween method_6(float duration)
		{
			throw null;
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tween method_8(float duration)
		{
			throw null;
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_10(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryResetShooting(CancellationToken token, out Task tween)
		{
			throw null;
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_14(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryInspect(CancellationToken token, out Task task)
		{
			throw null;
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_18(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21()
		{
			throw null;
		}

		// Token: 0x0600982A RID: 38954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryResetInspect(CancellationToken token, out Task tween)
		{
			throw null;
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task RestoreInspect(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryRestoreInspect(CancellationToken token, out Task tween)
		{
			throw null;
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShootingStart(int speed)
		{
			throw null;
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShootingStop()
		{
			throw null;
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InspectStart()
		{
			throw null;
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InspectStop()
		{
			throw null;
		}

		// Token: 0x04009F73 RID: 40819
		[Space]
		[SerializeField]
		private int _row;

		// Token: 0x04009F74 RID: 40820
		[Space]
		[SerializeField]
		private Transform _leftPoint;

		// Token: 0x04009F75 RID: 40821
		[SerializeField]
		private Transform _rightPoint;

		// Token: 0x04009F76 RID: 40822
		[SerializeField]
		private Transform _frontPoint;

		// Token: 0x04009F77 RID: 40823
		[SerializeField]
		[Space]
		private float _lowMovementSpeed;

		// Token: 0x04009F78 RID: 40824
		[SerializeField]
		private float _mediumMovementSpeed;

		// Token: 0x04009F79 RID: 40825
		[SerializeField]
		private float _highMovementSpeed;

		// Token: 0x04009F7A RID: 40826
		[SerializeField]
		private float _inspectMovementSpeed;

		// Token: 0x04009F7B RID: 40827
		[SerializeField]
		private PaperTarget _paperTarget;

		// Token: 0x04009F7C RID: 40828
		[Space]
		[SerializeField]
		private Transform _target;

		// Token: 0x04009F7D RID: 40829
		[SerializeField]
		private Transform _rail;

		// Token: 0x04009F7E RID: 40830
		[SerializeField]
		[Space]
		private AudioSource _shootingStartAudio;

		// Token: 0x04009F7F RID: 40831
		[SerializeField]
		private AudioSource _shootingStopAudio;

		// Token: 0x04009F80 RID: 40832
		[SerializeField]
		private AudioSource _shootingLoopAudio;

		// Token: 0x04009F81 RID: 40833
		[SerializeField]
		private AudioSource[] _inspectLoopAudios;

		// Token: 0x04009F82 RID: 40834
		private Vector3 _defaultTargetPosition;

		// Token: 0x04009F83 RID: 40835
		private Vector3 _defaultRailPosition;

		// Token: 0x04009F84 RID: 40836
		private RailTarget.HorizontalDirection _targetDirection;

		// Token: 0x04009F85 RID: 40837
		private RailTarget.VerticalDirection _railDirection;

		// Token: 0x04009F86 RID: 40838
		private int CurrentIndexMovementSpeed;

		// Token: 0x04009F87 RID: 40839
		private float[] _movementSpeeds;

		// Token: 0x04009F88 RID: 40840
		private RailTarget.MovementType _currentMovement;

		// Token: 0x04009F89 RID: 40841
		private Sequence _currentSequence;

		// Token: 0x04009F8A RID: 40842
		private FoldingTarget _foldingTarget;

		// Token: 0x04009F8C RID: 40844
		private readonly float _defaultShootingLoopPitch;

		// Token: 0x04009F8D RID: 40845
		private readonly float _shootingLoopPitchIncrease;

		// Token: 0x02001C72 RID: 7282
		public enum MovementSpeed
		{
			// Token: 0x04009F8F RID: 40847
			Low,
			// Token: 0x04009F90 RID: 40848
			Medium,
			// Token: 0x04009F91 RID: 40849
			High
		}

		// Token: 0x02001C73 RID: 7283
		private enum HorizontalDirection
		{
			// Token: 0x04009F93 RID: 40851
			Right,
			// Token: 0x04009F94 RID: 40852
			Left
		}

		// Token: 0x02001C74 RID: 7284
		private enum VerticalDirection
		{
			// Token: 0x04009F96 RID: 40854
			Forward,
			// Token: 0x04009F97 RID: 40855
			Backward
		}

		// Token: 0x02001C75 RID: 7285
		private enum MovementType
		{
			// Token: 0x04009F99 RID: 40857
			Default,
			// Token: 0x04009F9A RID: 40858
			Horizontal,
			// Token: 0x04009F9B RID: 40859
			Vertical
		}
	}
}
