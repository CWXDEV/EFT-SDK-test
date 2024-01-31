using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyMotion
{
	// Token: 0x020031AB RID: 12715
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x0600FA93 RID: 64147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string StaticToString()
		{
			throw null;
		}

		// Token: 0x0600FA94 RID: 64148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600FA95 RID: 64149 RVA: 0x00002050 File Offset: 0x00000250
		public int Number
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600FA96 RID: 64150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static VersionInfo Current()
		{
			throw null;
		}

		// Token: 0x0600FA97 RID: 64151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Matches(VersionInfo version)
		{
			throw null;
		}

		// Token: 0x0400FEAA RID: 65194
		public const byte Major = 1;

		// Token: 0x0400FEAB RID: 65195
		public const byte Minor = 8;

		// Token: 0x0400FEAC RID: 65196
		public const byte Release = 1;

		// Token: 0x0400FEAD RID: 65197
		private static string StageSuffix;

		// Token: 0x0400FEAE RID: 65198
		private static string TrialSuffix;

		// Token: 0x0400FEAF RID: 65199
		[SerializeField]
		private int m_major;

		// Token: 0x0400FEB0 RID: 65200
		[SerializeField]
		private int m_minor;

		// Token: 0x0400FEB1 RID: 65201
		[SerializeField]
		private int m_release;
	}
}
