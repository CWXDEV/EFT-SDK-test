using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.Animations;
using UnityEngine;

// Token: 0x0200090A RID: 2314
[Serializable]
public class ForceEffector : IEffector
{
	// Token: 0x0600345B RID: 13403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerSpring playerSpring)
	{
		throw null;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugOutput()
	{
		throw null;
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddForce(Vector3 direction, float strength = 1f, float hands = 1f, float camera = 1f)
	{
		throw null;
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddForce(float strength = 1f, float hands = 1f, float camera = 1f)
	{
		throw null;
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Vector3 force, float hitPower = 1f)
	{
		throw null;
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator GrenadeShake_CO(float strength)
	{
		throw null;
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HardShake(float strength)
	{
		throw null;
	}

	// Token: 0x040034E0 RID: 13536
	public float Intensity;

	// Token: 0x040034E1 RID: 13537
	public ForceEffector.Val[] Vals;

	// Token: 0x040034E2 RID: 13538
	private bool _initialized;

	// Token: 0x040034E3 RID: 13539
	private Vector3 _force;

	// Token: 0x040034E4 RID: 13540
	private Vector3 _forceSum;

	// Token: 0x040034E5 RID: 13541
	private int _framesLeft;

	// Token: 0x040034E6 RID: 13542
	private Spring CameraRotationSpring;

	// Token: 0x040034E7 RID: 13543
	private Spring CameraPositionSpring;

	// Token: 0x040034E8 RID: 13544
	private Spring HandsRotationSpring;

	// Token: 0x040034E9 RID: 13545
	[SerializeField]
	private float _eulersNoiseXYMaxValue;

	// Token: 0x040034EA RID: 13546
	[SerializeField]
	private float _eulersNoiseZMaxValue;

	// Token: 0x040034EB RID: 13547
	[SerializeField]
	private float _deltaRandom;

	// Token: 0x040034EC RID: 13548
	public float WiggleMagnitude;

	// Token: 0x0200090B RID: 2315
	[Serializable]
	public class Val
	{
		// Token: 0x06003463 RID: 13411 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(Spring rootRotation, Spring handsPosition, Spring handsRotation)
		{
			throw null;
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process(Vector3 force)
		{
			throw null;
		}

		// Token: 0x040034ED RID: 13549
		public ComponentType From;

		// Token: 0x040034EE RID: 13550
		public Target To;

		// Token: 0x040034EF RID: 13551
		public ComponentType Component;

		// Token: 0x040034F0 RID: 13552
		public float Intensity;

		// Token: 0x040034F1 RID: 13553
		private Spring _target;

		// Token: 0x040034F2 RID: 13554
		private int _component;

		// Token: 0x040034F3 RID: 13555
		private int _fromComponent;
	}
}
