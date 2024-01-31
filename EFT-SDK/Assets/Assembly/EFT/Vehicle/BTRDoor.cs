using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x0200265C RID: 9820
	[Serializable]
	public class BTRDoor : IDisposable
	{
		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x0600C2B6 RID: 49846 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2B7 RID: 49847 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsOpen
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		// Token: 0x0600C2B9 RID: 49849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(bool isOn, bool initial)
		{
			throw null;
		}

		// Token: 0x0600C2BA RID: 49850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnd(bool onEnabled, bool isOn)
		{
			throw null;
		}

		// Token: 0x0600C2BC RID: 49852 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float x)
		{
			throw null;
		}

		// Token: 0x0400C484 RID: 50308
		public Quaternion CloseRotation;

		// Token: 0x0400C485 RID: 50309
		public Quaternion OpenRotation;

		// Token: 0x0400C486 RID: 50310
		public Transform HingeTransform;

		// Token: 0x0400C487 RID: 50311
		public HysteresisFilter Filter;
	}
}
