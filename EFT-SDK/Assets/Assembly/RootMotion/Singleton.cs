using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02001076 RID: 4214
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x00002050 File Offset: 0x00000250
		public static T instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x040063A6 RID: 25510
		private static T gparam_0;
	}
}
