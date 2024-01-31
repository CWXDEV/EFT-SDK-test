using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EEF RID: 7919
	public class OneOffWeaponSettings : MonoBehaviour
	{
		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x00002050 File Offset: 0x00000250
		public GameObject SpawneAmmo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600A393 RID: 41875 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanAim
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400AABF RID: 43711
		[SerializeField]
		private GameObject _ammo;

		// Token: 0x0400AAC0 RID: 43712
		[SerializeField]
		private bool _canAim;
	}
}
