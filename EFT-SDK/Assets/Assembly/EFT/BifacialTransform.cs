using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020015CE RID: 5582
	[Serializable]
	public class BifacialTransform
	{
		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06007991 RID: 31121 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007992 RID: 31122 RVA: 0x00002050 File Offset: 0x00000250
		public bool UseImitation
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

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007994 RID: 31124 RVA: 0x00002050 File Offset: 0x00000250
		public bool AccumulatePositionAndRotation
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

		// Token: 0x06007995 RID: 31125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetImitators(Func<Vector3> positionImitator, Action<Vector3> positionSetImitator, Func<Quaternion> rotationImitator, Action<Quaternion> rotationSetImitator, Action<Vector3, Quaternion> positionAndRotationSetImitator, Func<Vector3> localPositionImitator, Action<Vector3> localPositionSetImitator, Func<Quaternion> localRotationImitator, Action<Quaternion> localRotationSetImitator, Func<Vector3> forwardImitator, Func<Vector3> upImitator, Func<Vector3> rightImitator, Func<Vector3> eulerAnglesImitator, Func<Vector3, Vector3> transformPointImitator, Func<Vector3, Vector3> inverseTransformPointImitator, Func<Vector3, Vector3> transformVectorImitator, Func<Vector3, Vector3> inverseTransformVectorImitator, Action<Vector3, Vector3> lookAtImitator)
		{
			throw null;
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007997 RID: 31127 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 position
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

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06007998 RID: 31128 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007999 RID: 31129 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion rotation
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

		// Token: 0x0600799A RID: 31130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector3 position, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyAccumulatedPositionAndRotation()
		{
			throw null;
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600799E RID: 31134 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 localPosition
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

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x0600799F RID: 31135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060079A0 RID: 31136 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion localRotation
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

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060079A1 RID: 31137 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 forward
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060079A2 RID: 31138 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 up
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060079A3 RID: 31139 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 right
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 eulerAngles
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 TransformPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			throw null;
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			throw null;
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyImitators(BifacialTransform donor)
		{
			throw null;
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SyncOriginal()
		{
			throw null;
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SyncImitators()
		{
			throw null;
		}

		// Token: 0x04007E61 RID: 32353
		[SerializeField]
		public Transform Original;

		// Token: 0x04007E62 RID: 32354
		private Func<Vector3> _positionImitator;

		// Token: 0x04007E63 RID: 32355
		private Action<Vector3> _positionSetImitator;

		// Token: 0x04007E64 RID: 32356
		private Func<Quaternion> _rotationImitator;

		// Token: 0x04007E65 RID: 32357
		private Action<Quaternion> _rotationSetImitator;

		// Token: 0x04007E66 RID: 32358
		private Action<Vector3, Quaternion> _positionAndRotationSetImitator;

		// Token: 0x04007E67 RID: 32359
		private Func<Vector3> _localPositionImitator;

		// Token: 0x04007E68 RID: 32360
		private Action<Vector3> _localPositionSetImitator;

		// Token: 0x04007E69 RID: 32361
		private Func<Quaternion> _localRotationImitator;

		// Token: 0x04007E6A RID: 32362
		private Action<Quaternion> _localRotationSetImitator;

		// Token: 0x04007E6B RID: 32363
		private Func<Vector3> _forwardImitator;

		// Token: 0x04007E6C RID: 32364
		private Func<Vector3> _upImitator;

		// Token: 0x04007E6D RID: 32365
		private Func<Vector3> _rightImitator;

		// Token: 0x04007E6E RID: 32366
		private Func<Vector3> _eulerAnglesImitator;

		// Token: 0x04007E6F RID: 32367
		private Func<Vector3, Vector3> _transformPointImitator;

		// Token: 0x04007E70 RID: 32368
		private Func<Vector3, Vector3> _inverseTransformVectorImitator;

		// Token: 0x04007E71 RID: 32369
		private Func<Vector3, Vector3> _transformVectorImitator;

		// Token: 0x04007E72 RID: 32370
		private Func<Vector3, Vector3> _inverseTransformPointImitator;

		// Token: 0x04007E73 RID: 32371
		private Action<Vector3, Vector3> _lookAtImitator;

		// Token: 0x04007E74 RID: 32372
		private bool _useImitation;

		// Token: 0x04007E75 RID: 32373
		private bool _accumulatePositionAndRotation;

		// Token: 0x04007E76 RID: 32374
		private Vector3 _accumulatedPosition;

		// Token: 0x04007E77 RID: 32375
		private Quaternion _accumulatedRotation;
	}
}
