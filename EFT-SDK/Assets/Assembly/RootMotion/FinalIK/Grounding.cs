using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200109B RID: 4251
	[Serializable]
	public class Grounding
	{
		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058D6 RID: 22742 RVA: 0x00002050 File Offset: 0x00000250
		public Grounding.Leg[] legs
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

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058D8 RID: 22744 RVA: 0x00002050 File Offset: 0x00000250
		public Grounding.Pelvis pelvis
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

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060058D9 RID: 22745 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058DA RID: 22746 RVA: 0x00002050 File Offset: 0x00000250
		public bool isGrounded
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

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060058DB RID: 22747 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058DC RID: 22748 RVA: 0x00002050 File Offset: 0x00000250
		public Transform root
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060058DD RID: 22749 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058DE RID: 22750 RVA: 0x00002050 File Offset: 0x00000250
		public RaycastHit rootHit
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x00002050 File Offset: 0x00000250
		public bool rootGrounded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			throw null;
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(Transform root, Transform[] feet)
		{
			throw null;
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetLegsPlaneNormal()
		{
			throw null;
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogWarning(string message)
		{
			throw null;
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 up
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			throw null;
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 Flatten(Vector3 v)
		{
			throw null;
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400649C RID: 25756
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		// Token: 0x0400649D RID: 25757
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		// Token: 0x0400649E RID: 25758
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		// Token: 0x0400649F RID: 25759
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		// Token: 0x040064A0 RID: 25760
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		// Token: 0x040064A1 RID: 25761
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		// Token: 0x040064A2 RID: 25762
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		// Token: 0x040064A3 RID: 25763
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		// Token: 0x040064A4 RID: 25764
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		// Token: 0x040064A5 RID: 25765
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		// Token: 0x040064A6 RID: 25766
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		// Token: 0x040064A7 RID: 25767
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		// Token: 0x040064A8 RID: 25768
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		// Token: 0x040064A9 RID: 25769
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		// Token: 0x040064AA RID: 25770
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		// Token: 0x040064AB RID: 25771
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Grounding.Quality quality;

		// Token: 0x040064B1 RID: 25777
		private bool initiated;

		// Token: 0x0200109C RID: 4252
		[Serializable]
		public enum Quality
		{
			// Token: 0x040064B3 RID: 25779
			Fastest,
			// Token: 0x040064B4 RID: 25780
			Simple,
			// Token: 0x040064B5 RID: 25781
			Best
		}

		// Token: 0x0200109D RID: 4253
		public class Leg
		{
			// Token: 0x17000DFE RID: 3582
			// (get) Token: 0x060058EB RID: 22763 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058EC RID: 22764 RVA: 0x00002050 File Offset: 0x00000250
			public bool isGrounded
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

			// Token: 0x17000DFF RID: 3583
			// (get) Token: 0x060058ED RID: 22765 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058EE RID: 22766 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 IKPosition
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

			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x060058EF RID: 22767 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058F0 RID: 22768 RVA: 0x00002050 File Offset: 0x00000250
			public Quaternion rotationOffset
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

			// Token: 0x17000E01 RID: 3585
			// (get) Token: 0x060058F1 RID: 22769 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058F2 RID: 22770 RVA: 0x00002050 File Offset: 0x00000250
			public bool initiated
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

			// Token: 0x17000E02 RID: 3586
			// (get) Token: 0x060058F3 RID: 22771 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058F4 RID: 22772 RVA: 0x00002050 File Offset: 0x00000250
			public float heightFromGround
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

			// Token: 0x17000E03 RID: 3587
			// (get) Token: 0x060058F5 RID: 22773 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058F6 RID: 22774 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 velocity
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

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x060058F7 RID: 22775 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058F8 RID: 22776 RVA: 0x00002050 File Offset: 0x00000250
			public Transform transform
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

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x060058F9 RID: 22777 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060058FA RID: 22778 RVA: 0x00002050 File Offset: 0x00000250
			public float IKOffset
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

			// Token: 0x060058FB RID: 22779 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initiate(Grounding grounding, Transform transform)
			{
				throw null;
			}

			// Token: 0x060058FC RID: 22780 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnEnable()
			{
				throw null;
			}

			// Token: 0x060058FD RID: 22781 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x060058FE RID: 22782 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process()
			{
				throw null;
			}

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x060058FF RID: 22783 RVA: 0x00002050 File Offset: 0x00000250
			public float stepHeightFromGround
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005900 RID: 22784 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private RaycastHit method_0(Vector3 offsetFromHeel)
			{
				throw null;
			}

			// Token: 0x06005901 RID: 22785 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private RaycastHit method_1(Vector3 offsetFromHeel)
			{
				throw null;
			}

			// Token: 0x06005902 RID: 22786 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Vector3 method_2(Vector3 normal)
			{
				throw null;
			}

			// Token: 0x06005903 RID: 22787 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3(Vector3 normal, Vector3 point)
			{
				throw null;
			}

			// Token: 0x06005904 RID: 22788 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
				throw null;
			}

			// Token: 0x06005905 RID: 22789 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_5(Vector3 hitPoint)
			{
				throw null;
			}

			// Token: 0x06005906 RID: 22790 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6()
			{
				throw null;
			}

			// Token: 0x06005907 RID: 22791 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Quaternion method_7()
			{
				throw null;
			}

			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x06005908 RID: 22792 RVA: 0x00002050 File Offset: 0x00000250
			private float Single_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040064B6 RID: 25782
			private Grounding grounding;

			// Token: 0x040064B7 RID: 25783
			private float lastTime;

			// Token: 0x040064B8 RID: 25784
			private float deltaTime;

			// Token: 0x040064B9 RID: 25785
			private Vector3 lastPosition;

			// Token: 0x040064BA RID: 25786
			private Quaternion toHitNormal;

			// Token: 0x040064BB RID: 25787
			private Quaternion r;

			// Token: 0x040064BC RID: 25788
			private RaycastHit heelHit;

			// Token: 0x040064BD RID: 25789
			private Vector3 up;
		}

		// Token: 0x0200109E RID: 4254
		public class Pelvis
		{
			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x06005909 RID: 22793 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600590A RID: 22794 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 IKOffset
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

			// Token: 0x17000E09 RID: 3593
			// (get) Token: 0x0600590B RID: 22795 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600590C RID: 22796 RVA: 0x00002050 File Offset: 0x00000250
			public float heightOffset
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

			// Token: 0x0600590D RID: 22797 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initiate(Grounding grounding)
			{
				throw null;
			}

			// Token: 0x0600590E RID: 22798 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0600590F RID: 22799 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnEnable()
			{
				throw null;
			}

			// Token: 0x06005910 RID: 22800 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
				throw null;
			}

			// Token: 0x040064BE RID: 25790
			private Grounding grounding;

			// Token: 0x040064BF RID: 25791
			private Vector3 lastRootPosition;

			// Token: 0x040064C0 RID: 25792
			private float damperF;

			// Token: 0x040064C1 RID: 25793
			private bool initiated;

			// Token: 0x040064C2 RID: 25794
			private float lastTime;
		}
	}
}
