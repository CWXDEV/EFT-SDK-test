using System;
using System.Runtime.CompilerServices;
using Comfort.Common;

// Token: 0x0200126B RID: 4715
public sealed class AssetsManagerSingletonClass : Singleton<IAssetsManager>
{
	// Token: 0x17000FB0 RID: 4016
	// (get) Token: 0x060062A3 RID: 25251 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060062A4 RID: 25252 RVA: 0x00002050 File Offset: 0x00000250
	public static IAssetsManager Manager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}
}
