using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT
{
	// Token: 0x02001697 RID: 5783
	[Serializable]
	public class ResourceKey
	{
		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06007D20 RID: 32032 RVA: 0x00002050 File Offset: 0x00000250
		public string FileName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToAssetName()
		{
			throw null;
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Equals(ResourceKey other)
		{
			throw null;
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06007D24 RID: 32036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06007D26 RID: 32038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEmpty()
		{
			throw null;
		}

		// Token: 0x040083E0 RID: 33760
		public string path;

		// Token: 0x040083E1 RID: 33761
		public string rcid;
	}
}
