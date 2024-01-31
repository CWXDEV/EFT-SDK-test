using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CW2.Animations
{
	// Token: 0x02000C88 RID: 3208
	public class PhysicsSimulator : MonoBehaviour
	{
		// Token: 0x0600454C RID: 17740 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Awake")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string name, float value)
		{
			throw null;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x04004FD0 RID: 20432
		public Vector3 Pivot;

		// Token: 0x04004FD1 RID: 20433
		public PhysicsSimulator.Spring PositionSpring;

		// Token: 0x04004FD2 RID: 20434
		public PhysicsSimulator.Spring RotationSpring;

		// Token: 0x04004FD3 RID: 20435
		public PhysicsSimulator.RandomDevice[] RandomDevices;

		// Token: 0x04004FD4 RID: 20436
		public PhysicsSimulator.CurveDevice[] CurveDevices;

		// Token: 0x04004FD5 RID: 20437
		public PhysicsSimulator.InputDevice[] InputDevices;

		// Token: 0x04004FD6 RID: 20438
		public PhysicsSimulator.ScriptValueDevice[] ScriptValueDevices;

		// Token: 0x04004FD7 RID: 20439
		public PhysicsSimulator.UnityValueDevice[] UnityValueDevices;

		// Token: 0x04004FD8 RID: 20440
		[HideInInspector]
		public Vector3 Position;

		// Token: 0x04004FD9 RID: 20441
		[HideInInspector]
		public Vector3 PositionVelocity;

		// Token: 0x04004FDA RID: 20442
		[HideInInspector]
		public Vector3 Rotation;

		// Token: 0x04004FDB RID: 20443
		[HideInInspector]
		public Vector3 RotationVelocity;

		// Token: 0x04004FDC RID: 20444
		private Dictionary<string, PhysicsSimulator.ScriptValueDevice> dictionary_0;

		// Token: 0x02000C89 RID: 3209
		[Serializable]
		public class RandomDevice
		{
			// Token: 0x0600454F RID: 17743 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initialize()
			{
				throw null;
			}

			// Token: 0x06004550 RID: 17744 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process(PhysicsSimulator physicsSimulator)
			{
				throw null;
			}

			// Token: 0x04004FDD RID: 20445
			public float Frequency;

			// Token: 0x04004FDE RID: 20446
			public float Intensity;

			// Token: 0x04004FDF RID: 20447
			public float IntensityShift;

			// Token: 0x04004FE0 RID: 20448
			public float TimeShift;

			// Token: 0x04004FE1 RID: 20449
			public bool RandomTimeShift;

			// Token: 0x04004FE2 RID: 20450
			public bool SmoothStart;

			// Token: 0x04004FE3 RID: 20451
			public PhysicsSimulator.Val ValueConfiguration;

			// Token: 0x04004FE4 RID: 20452
			private float _rndSeed;

			// Token: 0x04004FE5 RID: 20453
			private float _startT;
		}

		// Token: 0x02000C8A RID: 3210
		[Serializable]
		public class CurveDevice
		{
			// Token: 0x06004551 RID: 17745 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initialize()
			{
				throw null;
			}

			// Token: 0x06004552 RID: 17746 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process(PhysicsSimulator physicsSimulator)
			{
				throw null;
			}

			// Token: 0x04004FE6 RID: 20454
			public AnimationCurve Curve;

			// Token: 0x04004FE7 RID: 20455
			public float Frequency;

			// Token: 0x04004FE8 RID: 20456
			public float Intensity;

			// Token: 0x04004FE9 RID: 20457
			public float TimeShift;

			// Token: 0x04004FEA RID: 20458
			public float IntensityShift;

			// Token: 0x04004FEB RID: 20459
			public PhysicsSimulator.Val ValueConfiguration;
		}

		// Token: 0x02000C8B RID: 3211
		[Serializable]
		public class InputDevice
		{
			// Token: 0x06004553 RID: 17747 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initialize()
			{
				throw null;
			}

			// Token: 0x06004554 RID: 17748 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process(PhysicsSimulator physicsSimulator)
			{
				throw null;
			}

			// Token: 0x04004FEC RID: 20460
			public string AxisName;

			// Token: 0x04004FED RID: 20461
			public float Intensity;

			// Token: 0x04004FEE RID: 20462
			public float IntensityShift;

			// Token: 0x04004FEF RID: 20463
			public PhysicsSimulator.Val ValueConfiguration;
		}

		// Token: 0x02000C8C RID: 3212
		[Serializable]
		public class ScriptValueDevice
		{
			// Token: 0x06004555 RID: 17749 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initialize()
			{
				throw null;
			}

			// Token: 0x06004556 RID: 17750 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Add(PhysicsSimulator physicsSimulator, float value)
			{
				throw null;
			}

			// Token: 0x04004FF0 RID: 20464
			public string ValueName;

			// Token: 0x04004FF1 RID: 20465
			public float Intensity;

			// Token: 0x04004FF2 RID: 20466
			public float IntensityShift;

			// Token: 0x04004FF3 RID: 20467
			public PhysicsSimulator.Val ValueConfiguration;
		}

		// Token: 0x02000C8D RID: 3213
		[Serializable]
		public class UnityValueDevice
		{
			// Token: 0x06004557 RID: 17751 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initialize()
			{
				throw null;
			}

			// Token: 0x06004558 RID: 17752 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process(PhysicsSimulator physicsSimulator)
			{
				throw null;
			}

			// Token: 0x04004FF4 RID: 20468
			public PhysicsSimulator.UnityValueDevice.Values ValueType;

			// Token: 0x04004FF5 RID: 20469
			public float Intensity;

			// Token: 0x04004FF6 RID: 20470
			public float IntensityShift;

			// Token: 0x04004FF7 RID: 20471
			public PhysicsSimulator.Val ValueConfiguration;

			// Token: 0x04004FF8 RID: 20472
			private static Func<float>[] _values;

			// Token: 0x02000C8E RID: 3214
			public enum Values
			{
				// Token: 0x04004FFA RID: 20474
				MousePosX,
				// Token: 0x04004FFB RID: 20475
				MousePosY
			}

			// Token: 0x02000C8F RID: 3215
			[CompilerGenerated]
			[Serializable]
			private sealed class Class642
			{
				// Token: 0x06004559 RID: 17753 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_0()
				{
					throw null;
				}

				// Token: 0x0600455A RID: 17754 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_1()
				{
					throw null;
				}

				// Token: 0x04004FFC RID: 20476
				public static readonly PhysicsSimulator.UnityValueDevice.Class642 class642_0;
			}
		}

		// Token: 0x02000C90 RID: 3216
		[Serializable]
		public class Spring
		{
			// Token: 0x0600455B RID: 17755 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixedUpdate(ref Vector3 velocity, ref Vector3 current)
			{
				throw null;
			}

			// Token: 0x0600455C RID: 17756 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static Vector3 smethod_0(Vector3 vec, float limit)
			{
				throw null;
			}

			// Token: 0x04004FFD RID: 20477
			[HideInInspector]
			public Vector3 Zero;

			// Token: 0x04004FFE RID: 20478
			public float ReturnSpeed;

			// Token: 0x04004FFF RID: 20479
			public float Damping;

			// Token: 0x04005000 RID: 20480
			public Vector3 Min;

			// Token: 0x04005001 RID: 20481
			public Vector3 Max;

			// Token: 0x04005002 RID: 20482
			public float VelocityMax;
		}

		// Token: 0x02000C91 RID: 3217
		[Serializable]
		public class Val
		{
			// Token: 0x0600455D RID: 17757 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initialize()
			{
				throw null;
			}

			// Token: 0x0600455E RID: 17758 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Process(PhysicsSimulator physicsSimulator, float val)
			{
				throw null;
			}

			// Token: 0x04005003 RID: 20483
			public PhysicsSimulator.Val.TargetType Target;

			// Token: 0x04005004 RID: 20484
			public PhysicsSimulator.Val.OperationType Operation;

			// Token: 0x04005005 RID: 20485
			public PhysicsSimulator.Val.ComponentType Component;

			// Token: 0x04005006 RID: 20486
			private Func<float, float, float> _operation;

			// Token: 0x04005007 RID: 20487
			private Func<PhysicsSimulator, Vector3> _targetGet;

			// Token: 0x04005008 RID: 20488
			private Action<PhysicsSimulator, Vector3> _targetSet;

			// Token: 0x04005009 RID: 20489
			private int _component;

			// Token: 0x0400500A RID: 20490
			private static Func<float, float, float>[] _operations;

			// Token: 0x0400500B RID: 20491
			private static Func<PhysicsSimulator, Vector3>[] _targetGets;

			// Token: 0x0400500C RID: 20492
			private static Action<PhysicsSimulator, Vector3>[] _targetSets;

			// Token: 0x02000C92 RID: 3218
			public enum TargetType
			{
				// Token: 0x0400500E RID: 20494
				Position,
				// Token: 0x0400500F RID: 20495
				PositionVelocity,
				// Token: 0x04005010 RID: 20496
				Rotation,
				// Token: 0x04005011 RID: 20497
				RotationVelocity
			}

			// Token: 0x02000C93 RID: 3219
			public enum ComponentType
			{
				// Token: 0x04005013 RID: 20499
				X,
				// Token: 0x04005014 RID: 20500
				Y,
				// Token: 0x04005015 RID: 20501
				Z
			}

			// Token: 0x02000C94 RID: 3220
			public enum OperationType
			{
				// Token: 0x04005017 RID: 20503
				Set,
				// Token: 0x04005018 RID: 20504
				Add,
				// Token: 0x04005019 RID: 20505
				Mult,
				// Token: 0x0400501A RID: 20506
				Clamp,
				// Token: 0x0400501B RID: 20507
				Min,
				// Token: 0x0400501C RID: 20508
				Max
			}

			// Token: 0x02000C95 RID: 3221
			[CompilerGenerated]
			[Serializable]
			private sealed class Class643
			{
				// Token: 0x0600455F RID: 17759 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_0(float f, float f1)
				{
					throw null;
				}

				// Token: 0x06004560 RID: 17760 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_1(float f, float f1)
				{
					throw null;
				}

				// Token: 0x06004561 RID: 17761 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_2(float f, float f1)
				{
					throw null;
				}

				// Token: 0x06004562 RID: 17762 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal float method_3(float f, float f1)
				{
					throw null;
				}

				// Token: 0x06004563 RID: 17763 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Vector3 method_4(PhysicsSimulator s)
				{
					throw null;
				}

				// Token: 0x06004564 RID: 17764 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Vector3 method_5(PhysicsSimulator s)
				{
					throw null;
				}

				// Token: 0x06004565 RID: 17765 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Vector3 method_6(PhysicsSimulator s)
				{
					throw null;
				}

				// Token: 0x06004566 RID: 17766 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Vector3 method_7(PhysicsSimulator s)
				{
					throw null;
				}

				// Token: 0x06004567 RID: 17767 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_8(PhysicsSimulator s, Vector3 v)
				{
					throw null;
				}

				// Token: 0x06004568 RID: 17768 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_9(PhysicsSimulator s, Vector3 v)
				{
					throw null;
				}

				// Token: 0x06004569 RID: 17769 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_10(PhysicsSimulator s, Vector3 v)
				{
					throw null;
				}

				// Token: 0x0600456A RID: 17770 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_11(PhysicsSimulator s, Vector3 v)
				{
					throw null;
				}

				// Token: 0x0400501D RID: 20509
				public static readonly PhysicsSimulator.Val.Class643 class643_0;
			}
		}
	}
}
