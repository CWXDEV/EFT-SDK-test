using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Test
{
	// Token: 0x02001985 RID: 6533
	public class CPUOverload : MonoBehaviour
	{
		// Token: 0x06008BE5 RID: 35813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetOverload(int ms)
		{
			throw null;
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04009184 RID: 37252
		private static GameObject gameObject_0;

		// Token: 0x04009185 RID: 37253
		private static int int_0;
	}
}
