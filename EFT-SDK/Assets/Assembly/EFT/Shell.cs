using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001574 RID: 5492
	public class Shell : BouncingObject
	{
		// Token: 0x060075C4 RID: 30148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivatePhysics(Vector3 beginPoint, Vector3 velocity, Vector3 rotationVector, Vector3 weaponForward)
		{
			throw null;
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisablePhysics()
		{
			throw null;
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCaliber(ECaliber caliber)
		{
			throw null;
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnBounce(Collider collider)
		{
			throw null;
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060075C9 RID: 30153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060075CA RID: 30154 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface137 CollisionListener
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

		// Token: 0x060075CB RID: 30155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x04007BC7 RID: 31687
		private const float float_5 = 100f;

		// Token: 0x04007BC8 RID: 31688
		[SerializeField]
		private ECaliber _caliber;

		// Token: 0x04007BC9 RID: 31689
		private Vector3 vector3_2;

		// Token: 0x04007BCA RID: 31690
		[CompilerGenerated]
		private GInterface137 ginterface137_0;
	}
}
