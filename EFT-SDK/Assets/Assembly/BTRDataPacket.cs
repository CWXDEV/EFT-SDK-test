using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02002681 RID: 9857
public struct BTRDataPacket
{
	// Token: 0x0600C37F RID: 50047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600C380 RID: 50048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0400C54B RID: 50507
	public Vector3 position;

	// Token: 0x0400C54C RID: 50508
	public Quaternion rotation;

	// Token: 0x0400C54D RID: 50509
	public Quaternion turretRotation;

	// Token: 0x0400C54E RID: 50510
	public Quaternion gunsBlockRotation;

	// Token: 0x0400C54F RID: 50511
	public byte State;

	// Token: 0x0400C550 RID: 50512
	public byte RouteState;

	// Token: 0x0400C551 RID: 50513
	public byte LeftSideState;

	// Token: 0x0400C552 RID: 50514
	public byte LeftSlot0State;

	// Token: 0x0400C553 RID: 50515
	public byte LeftSlot1State;

	// Token: 0x0400C554 RID: 50516
	public byte RightSideState;

	// Token: 0x0400C555 RID: 50517
	public byte RightSlot0State;

	// Token: 0x0400C556 RID: 50518
	public byte RightSlot1State;

	// Token: 0x0400C557 RID: 50519
	public float currentSpeed;

	// Token: 0x0400C558 RID: 50520
	public float timeToEndPause;

	// Token: 0x0400C559 RID: 50521
	public byte moveDirection;

	// Token: 0x0400C55A RID: 50522
	public float MoveSpeed;

	// Token: 0x0400C55B RID: 50523
	public int BtrBotId;
}
