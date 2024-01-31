using System;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x02002687 RID: 9863
	public sealed class BTRVehicle : VehicleBase
	{
		// Token: 0x0400C583 RID: 50563
		public Transform bodyViewRoot;

		// Token: 0x0400C584 RID: 50564
		public BTRTurretServer BTRTurret;

		// Token: 0x0400C585 RID: 50565
		public Vector3 botPosition;

		// Token: 0x0400C586 RID: 50566
		[Header("SLOTS INFO")]
		public byte LeftSideState;

		// Token: 0x0400C587 RID: 50567
		public byte LeftSlot0State;

		// Token: 0x0400C588 RID: 50568
		public byte LeftSlot1State;

		// Token: 0x0400C589 RID: 50569
		public byte RightSideState;

		// Token: 0x0400C58A RID: 50570
		public byte RightSlot0State;

		// Token: 0x0400C58B RID: 50571
		public byte RightSlot1State;
	}
}
