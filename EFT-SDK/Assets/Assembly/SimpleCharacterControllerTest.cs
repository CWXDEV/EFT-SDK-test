using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006D1 RID: 1745
public class SimpleCharacterControllerTest : MonoBehaviour
{
	// Token: 0x06002790 RID: 10128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0400269C RID: 9884
	private SimpleCharacterController simpleCharacterController_0;

	// Token: 0x0400269D RID: 9885
	[SerializeField]
	private CapsuleCollider _mainCollider;

	// Token: 0x0400269E RID: 9886
	private Vector3 vector3_0;

	// Token: 0x0400269F RID: 9887
	public bool IsGrounded;
}
