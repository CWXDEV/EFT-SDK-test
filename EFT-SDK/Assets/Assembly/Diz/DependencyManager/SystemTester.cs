using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Diz.DependencyManager
{
	// Token: 0x0200312C RID: 12588
	public class SystemTester : MonoBehaviour
	{
		// Token: 0x0600F6AC RID: 63148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600F6AD RID: 63149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400FC3C RID: 64572
		public DependencyGraph<TestLoadable> System;

		// Token: 0x0400FC3D RID: 64573
		private TestLoadable[] testLoadable_0;

		// Token: 0x0200312D RID: 12589
		[CompilerGenerated]
		private sealed class Class3179
		{
			// Token: 0x0600F6AE RID: 63150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(TestLoadable t)
			{
				throw null;
			}

			// Token: 0x0400FC3E RID: 64574
			public TestLoadable l;

			// Token: 0x0400FC3F RID: 64575
			public SystemTester systemTester_0;
		}
	}
}
