using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.UI.Settings;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028CC RID: 10444
	public sealed class BodyPartImage : UIElement
	{
		// Token: 0x0600D08F RID: 53391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400D170 RID: 53616
		private const float float_0 = 0.5f;

		// Token: 0x0400D171 RID: 53617
		[SerializeField]
		private Image _bodyPartImage;

		// Token: 0x0400D172 RID: 53618
		private IHealthController ihealthController_0;

		// Token: 0x0400D173 RID: 53619
		private EBodyPart ebodyPart_0;

		// Token: 0x0400D174 RID: 53620
		private float float_1;

		// Token: 0x0400D175 RID: 53621
		private EHealthColorScheme ehealthColorScheme_0;
	}
}
