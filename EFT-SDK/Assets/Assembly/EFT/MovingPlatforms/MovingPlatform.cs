using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.MovingPlatforms
{
	// Token: 0x020026D7 RID: 9943
	public abstract class MovingPlatform : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x0600C52A RID: 50474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C52B RID: 50475 RVA: 0x00002050 File Offset: 0x00000250
		public bool Initialized
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

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x0600C52C RID: 50476 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C52D RID: 50477 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Vector3[] CachedDirections
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

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x0600C52E RID: 50478 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentRouteTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x0600C52F RID: 50479 RVA: 0x00002050 File Offset: 0x00000250
		public float NormalCurvePosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600C530 RID: 50480 RVA: 0x00002050 File Offset: 0x00000250
		public float Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600C531 RID: 50481 RVA: 0x00002050 File Offset: 0x00000250
		public float CTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float CurveApproxLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x0600C533 RID: 50483 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600C534 RID: 50484 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C535 RID: 50485 RVA: 0x00002050 File Offset: 0x00000250
		public virtual BezierSpline Spline
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

		// Token: 0x0600C536 RID: 50486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(DateTime depart)
		{
			throw null;
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CalculateLength()
		{
			throw null;
		}

		// Token: 0x0600C538 RID: 50488
		public abstract void PlaceAtStartPosition();

		// Token: 0x0600C539 RID: 50489
		public abstract void PlaceAtEndPosition();

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600C53A RID: 50490 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion RotationAtCurrentDistance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion RotationAtDistance(float distance)
		{
			throw null;
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Jitter(ref Vector3 position, ref Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Move(bool force = false)
		{
			throw null;
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void StorePassengers()
		{
			throw null;
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdatePassengerPositions()
		{
			throw null;
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C545 RID: 50501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnRouteFinished()
		{
			throw null;
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0600C547 RID: 50503 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C548 RID: 50504 RVA: 0x00002050 File Offset: 0x00000250
		bool IPhysicsTrigger.enabled
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

		// Token: 0x0400C6FF RID: 50943
		[FormerlySerializedAs("Spline")]
		[SerializeField]
		private BezierSpline _spline;

		// Token: 0x0400C700 RID: 50944
		[SerializeField]
		private float _approxLength;

		// Token: 0x0400C701 RID: 50945
		[SerializeField]
		protected float _routeDuration;

		// Token: 0x0400C702 RID: 50946
		[SerializeField]
		private int DebugViewSteps;

		// Token: 0x0400C703 RID: 50947
		[SerializeField]
		protected Vector3 _forwardRotation;

		// Token: 0x0400C704 RID: 50948
		[SerializeField]
		protected float _currentDistance;

		// Token: 0x0400C705 RID: 50949
		[SerializeField]
		protected float _currentTime;

		// Token: 0x0400C706 RID: 50950
		[SerializeField]
		protected Vector3 _contactPoint;

		// Token: 0x0400C707 RID: 50951
		public AnimationCurve MovementCurve;

		// Token: 0x0400C708 RID: 50952
		public GClass3357<Player> Passengers;

		// Token: 0x0400C709 RID: 50953
		public float Precision;

		// Token: 0x0400C70A RID: 50954
		[HideInInspector]
		protected Transform Transform;

		// Token: 0x0400C70B RID: 50955
		public MovingPlatform.PreciseInterpolator LinearInterpolator;

		// Token: 0x0400C70C RID: 50956
		public BoxCollider Area;

		// Token: 0x0400C710 RID: 50960
		public Vector3 JitterDirection;

		// Token: 0x0400C711 RID: 50961
		public Vector3 JitterAngle;

		// Token: 0x0400C712 RID: 50962
		public float JitterPeriod;

		// Token: 0x0400C713 RID: 50963
		private Quaternion _oldRotation;

		// Token: 0x0400C714 RID: 50964
		private readonly List<Vector3> _passengerPositions;

		// Token: 0x0400C715 RID: 50965
		private DateTime _depart;

		// Token: 0x020026D8 RID: 9944
		public interface GInterface347
		{
			// Token: 0x0600C54A RID: 50506
			void GetOff(MovingPlatform platform);
		}

		// Token: 0x020026D9 RID: 9945
		public class GClass2927
		{
			// Token: 0x17002344 RID: 9028
			// (get) Token: 0x0600C54B RID: 50507 RVA: 0x00002050 File Offset: 0x00000250
			public bool HasNetPacket
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600C54C RID: 50508 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GStruct127 GetNetPacket()
			{
				throw null;
			}

			// Token: 0x0600C54D RID: 50509 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreNetPacket(GStruct127 packet)
			{
				throw null;
			}

			// Token: 0x0600C54E RID: 50510 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ApplyStoredPackets()
			{
				throw null;
			}

			// Token: 0x0400C716 RID: 50966
			public Locomotive Platform;

			// Token: 0x0400C717 RID: 50967
			public byte Id;

			// Token: 0x0400C718 RID: 50968
			private GStruct127 gstruct127_0;

			// Token: 0x0400C719 RID: 50969
			public const float SYNC_SMOOTHNESS = 1.5f;

			// Token: 0x0400C71A RID: 50970
			private float float_0;

			// Token: 0x0400C71B RID: 50971
			private bool bool_0;
		}

		// Token: 0x020026DA RID: 9946
		[Serializable]
		public class PreciseInterpolator
		{
			// Token: 0x0600C54F RID: 50511 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetPosition(Vector3 initial, float distance, out float blendFactor)
			{
				throw null;
			}

			// Token: 0x0600C550 RID: 50512 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetPosition(Vector3 initial, float distance)
			{
				throw null;
			}

			// Token: 0x0400C71C RID: 50972
			public float Distance1;

			// Token: 0x0400C71D RID: 50973
			public float Distance2;

			// Token: 0x0400C71E RID: 50974
			public Vector3 Point1;

			// Token: 0x0400C71F RID: 50975
			public Vector3 Point2;
		}
	}
}
