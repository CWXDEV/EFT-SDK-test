using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

// Token: 0x02000528 RID: 1320
public class ThrowGrenadePlace : MonoBehaviour, IPositionPoint
{
	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x06002025 RID: 8229 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AIGreanageThrowData GetData()
	{
		throw null;
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(IEnumerable<Door> allDoors)
	{
		throw null;
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValid(string id, bool withSubDoor)
	{
		throw null;
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos()
	{
		throw null;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNowValid()
	{
		throw null;
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Door method_0(AIGreanageThrowData aiGreandeOutData)
	{
		throw null;
	}

	// Token: 0x04001ECB RID: 7883
	public float GrenadeMass;

	// Token: 0x04001ECC RID: 7884
	public float GrenadeForce;

	// Token: 0x04001ECD RID: 7885
	public Transform From;

	// Token: 0x04001ECE RID: 7886
	public Transform Target;

	// Token: 0x04001ECF RID: 7887
	public float AngleForThrow;

	// Token: 0x04001ED0 RID: 7888
	public float ThrowForce;

	// Token: 0x04001ED1 RID: 7889
	public Door Door;

	// Token: 0x04001ED2 RID: 7890
	public bool IsOk;

	// Token: 0x04001ED3 RID: 7891
	public Vector3 DoorPos;

	// Token: 0x04001ED4 RID: 7892
	public bool HaveDoor;

	// Token: 0x04001ED5 RID: 7893
	private readonly Vector3 vector3_0;

	// Token: 0x02000529 RID: 1321
	[CompilerGenerated]
	private sealed class Class254
	{
		// Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Door method_0(Door x1, Door x2)
		{
			throw null;
		}

		// Token: 0x04001ED6 RID: 7894
		public Vector3 pos;
	}
}
