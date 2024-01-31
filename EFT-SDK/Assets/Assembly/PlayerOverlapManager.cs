using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000731 RID: 1841
public class PlayerOverlapManager : MonoBehaviour
{
	// Token: 0x1700078F RID: 1935
	// (get) Token: 0x06002B43 RID: 11075 RVA: 0x00002050 File Offset: 0x00000250
	public Collider Collider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000790 RID: 1936
	// (get) Token: 0x06002B44 RID: 11076 RVA: 0x00002050 File Offset: 0x00000250
	public Collider CameraCollider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Collider playerCollider)
	{
		throw null;
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IgnoreCollider(Collider collider, bool ignore = true)
	{
		throw null;
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHeadCollider(Collider colliderForCheck)
	{
		throw null;
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCollider(PlayerOverlapManager.EExtrusionCollider colliderIndex)
	{
		throw null;
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void On()
	{
		throw null;
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetOffsetXZ()
	{
		throw null;
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetOffset()
	{
		throw null;
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Off()
	{
		throw null;
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Calculate(Vector3 motion)
	{
		throw null;
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Calculate(Vector3 motion, Quaternion rotation)
	{
		throw null;
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExtrudeCamera()
	{
		throw null;
	}

	// Token: 0x04002944 RID: 10564
	[SerializeField]
	private ColliderExtrusion _headColliderExtrusion;

	// Token: 0x04002945 RID: 10565
	[SerializeField]
	private ColliderExtrusion _cameraColliderExtrusion;

	// Token: 0x04002946 RID: 10566
	[SerializeField]
	private Collider[] _headColliders;

	// Token: 0x04002947 RID: 10567
	[SerializeField]
	private Transform _proneColliderPivot;

	// Token: 0x04002948 RID: 10568
	private Vector3 vector3_0;

	// Token: 0x04002949 RID: 10569
	private PlayerOverlapManager.EExtrusionCollider eextrusionCollider_0;

	// Token: 0x02000732 RID: 1842
	public enum EExtrusionCollider
	{
		// Token: 0x0400294B RID: 10571
		Default,
		// Token: 0x0400294C RID: 10572
		Prone
	}
}
