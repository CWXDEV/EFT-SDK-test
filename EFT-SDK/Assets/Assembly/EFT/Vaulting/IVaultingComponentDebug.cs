using System;
using EFT.Vaulting.Controllers;
using EFT.Vaulting.Models;
using UnityEngine;

namespace EFT.Vaulting
{
	// Token: 0x02001E6E RID: 7790
	public interface IVaultingComponentDebug
	{
		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06009FCC RID: 40908
		IVaultingModelDebug VaultingModelDebug { get; }

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06009FCD RID: 40909
		VaultingController VaultingController { get; }

		// Token: 0x06009FCE RID: 40910
		void SetCurrentMove(Vector3? move);
	}
}
