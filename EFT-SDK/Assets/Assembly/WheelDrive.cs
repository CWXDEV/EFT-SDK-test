using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200064C RID: 1612
public class WheelDrive : MonoBehaviour
{
	// Token: 0x060024EC RID: 9452 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator Sleep()
	{
		throw null;
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Steer(Vector3 point)
	{
		throw null;
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_0(Vector3 a, Vector3 b)
	{
		throw null;
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualBrake()
	{
		throw null;
	}

	// Token: 0x040023DF RID: 9183
	[SerializeField]
	private RigidbodySpawner _rigidSpawner;

	// Token: 0x040023E0 RID: 9184
	[SerializeField]
	private Transform Ballistics;

	// Token: 0x040023E1 RID: 9185
	[SerializeField]
	private RigidbodySpawner _bumperSpawner;

	// Token: 0x040023E2 RID: 9186
	[SerializeField]
	private Collider _chassisCollider;

	// Token: 0x040023E3 RID: 9187
	[SerializeField]
	private Collider _bumperCollider;

	// Token: 0x040023E4 RID: 9188
	public WheelDrive.EGear Gear;

	// Token: 0x040023E5 RID: 9189
	public Vector3 SteerTarget;

	// Token: 0x040023E6 RID: 9190
	public Transform SteerTargetTransform;

	// Token: 0x040023E7 RID: 9191
	public float Torque;

	// Token: 0x040023E8 RID: 9192
	public Vector2 MinSpeedAtDistance;

	// Token: 0x040023E9 RID: 9193
	public Vector2 MaxpeedAtDistance;

	// Token: 0x040023EA RID: 9194
	public float BrakeTorque;

	// Token: 0x040023EB RID: 9195
	public float SteerSpeed;

	// Token: 0x040023EC RID: 9196
	public Vector2 SpeedByTurnAngel;

	// Token: 0x040023ED RID: 9197
	private float float_0;

	// Token: 0x040023EE RID: 9198
	private bool bool_0;

	// Token: 0x040023EF RID: 9199
	public EasySuspension ES;

	// Token: 0x040023F0 RID: 9200
	private Rigidbody rigidbody_0;

	// Token: 0x040023F1 RID: 9201
	private Rigidbody rigidbody_1;

	// Token: 0x040023F2 RID: 9202
	[Tooltip("The vehicle's speed when the physics engine can use different amount of sub-steps (in m/s).")]
	public float criticalSpeed;

	// Token: 0x040023F3 RID: 9203
	[Tooltip("Simulation sub-steps when the speed is above critical.")]
	public int stepsBelow;

	// Token: 0x040023F4 RID: 9204
	[Tooltip("Simulation sub-steps when the speed is below critical.")]
	public int stepsAbove;

	// Token: 0x040023F5 RID: 9205
	private WheelCollider[] wheelCollider_0;

	// Token: 0x040023F6 RID: 9206
	private Vector3 vector3_0;

	// Token: 0x040023F7 RID: 9207
	public WheelCollider[] frontWheels;

	// Token: 0x040023F8 RID: 9208
	public AudioSource AudioSource;

	// Token: 0x040023F9 RID: 9209
	public AudioClip OnStartSound;

	// Token: 0x040023FA RID: 9210
	public Transform[] wheelGraphics;

	// Token: 0x0200064D RID: 1613
	public enum EGear
	{
		// Token: 0x040023FC RID: 9212
		Back,
		// Token: 0x040023FD RID: 9213
		Fwd
	}
}
