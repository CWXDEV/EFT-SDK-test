using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006F0 RID: 1776
public class PlayerMotor : MonoBehaviour
{
	// Token: 0x17000738 RID: 1848
	// (get) Token: 0x060029A5 RID: 10661 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsGrounded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000739 RID: 1849
	// (get) Token: 0x060029A6 RID: 10662 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029A7 RID: 10663 RVA: 0x00002050 File Offset: 0x00000250
	public Vector2 MovementDirection
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

	// Token: 0x1700073A RID: 1850
	// (get) Token: 0x060029A8 RID: 10664 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00002050 File Offset: 0x00000250
	public float PoseLevel
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

	// Token: 0x1700073B RID: 1851
	// (get) Token: 0x060029AA RID: 10666 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029AB RID: 10667 RVA: 0x00002050 File Offset: 0x00000250
	public float Speed
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

	// Token: 0x060029AC RID: 10668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGrounded()
	{
		throw null;
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Move(Vector2 direction, float speed)
	{
		throw null;
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetYaw(float yaw)
	{
		throw null;
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Vector3 ConvertToWorldXZCoordintaes(Vector3 vector)
	{
		throw null;
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGUI()
	{
		throw null;
	}

	// Token: 0x040027C2 RID: 10178
	public Vector3 LocalVelocity;

	// Token: 0x040027C3 RID: 10179
	private RaycastHit raycastHit_0;

	// Token: 0x040027C4 RID: 10180
	[SerializeField]
	private float _checkGroundedRayDistance;

	// Token: 0x040027C5 RID: 10181
	private Animator animator_0;

	// Token: 0x040027C6 RID: 10182
	private Vector2 vector2_0;

	// Token: 0x040027C7 RID: 10183
	private float float_0;

	// Token: 0x040027C8 RID: 10184
	private float float_1;

	// Token: 0x040027C9 RID: 10185
	private Rigidbody rigidbody_0;

	// Token: 0x040027CA RID: 10186
	private float float_2;

	// Token: 0x020006F1 RID: 1777
	public static class GClass668
	{
		// Token: 0x040027CB RID: 10187
		public const float PRONE_POSE = 0f;

		// Token: 0x040027CC RID: 10188
		public const float CROUCH_POSE = 0.5f;

		// Token: 0x040027CD RID: 10189
		public const float STAND_POSE = 1f;

		// Token: 0x040027CE RID: 10190
		public const float SPEED_MIN = 0f;

		// Token: 0x040027CF RID: 10191
		public const float SPEED_MAX = 1f;

		// Token: 0x040027D0 RID: 10192
		public const string POSE_LEVEL_PARAM_NAME = "Level";

		// Token: 0x040027D1 RID: 10193
		public const string DIRECTION_X_PARAM_NAME = "Direct_X";

		// Token: 0x040027D2 RID: 10194
		public const string DIRECTION_Y_PARAM_NAME = "Direct_Y";

		// Token: 0x040027D3 RID: 10195
		public const string SPEED_PARAM_NAME = "Speed";
	}
}
