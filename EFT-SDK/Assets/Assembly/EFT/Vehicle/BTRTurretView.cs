using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x02002685 RID: 9861
	public class BTRTurretView : MonoBehaviour
	{
		// Token: 0x0600C39B RID: 50075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C39D RID: 50077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AttachBot(int btrBotId)
		{
			throw null;
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(int btrBotId)
		{
			throw null;
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTurretRotation(Quaternion eulerAngles)
		{
			throw null;
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGunsBlockRotation(Quaternion eulerAngles)
		{
			throw null;
		}

		// Token: 0x0400C573 RID: 50547
		public Transform gunsBlockRoot;

		// Token: 0x0400C574 RID: 50548
		public Transform machineGunRoot;

		// Token: 0x0400C575 RID: 50549
		public Transform machineGunLaunchPoint;

		// Token: 0x0400C576 RID: 50550
		public Transform GunRoot;

		// Token: 0x0400C577 RID: 50551
		public Transform BotRoot;

		// Token: 0x0400C578 RID: 50552
		private Quaternion quaternion_0;

		// Token: 0x0400C579 RID: 50553
		private Quaternion quaternion_1;

		// Token: 0x0400C57A RID: 50554
		public float rotateLerpValue;

		// Token: 0x0400C57B RID: 50555
		private ValueTuple<ObservedPlayerView, bool> valueTuple_0;
	}
}
