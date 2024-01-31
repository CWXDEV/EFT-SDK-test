using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;

// Token: 0x02002878 RID: 10360
public class GClass3005
{
	// Token: 0x0600CEF9 RID: 52985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetAssetPoolObjectType(ResourceType resourceType)
	{
		throw null;
	}

	// Token: 0x0600CEFA RID: 52986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGameObjectActiveInPool(Type poolObjectType)
	{
		throw null;
	}

	// Token: 0x0400CFBA RID: 53178
	public static GClass3005.GStruct394[] ComponentsToAdd;

	// Token: 0x0400CFBB RID: 53179
	public static Dictionary<ResourceType, Type> AssetPoolObjectTypes;

	// Token: 0x02002879 RID: 10361
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct394
	{
		// Token: 0x0600CEFB RID: 52987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Suited(ResourceType type, PoolManager.AssemblyType assemblyType)
		{
			throw null;
		}

		// Token: 0x0400CFBC RID: 53180
		public Type Type;

		// Token: 0x0400CFBD RID: 53181
		public ResourceType ResourseTypeMask;

		// Token: 0x0400CFBE RID: 53182
		public bool AddInLocalGame;

		// Token: 0x0400CFBF RID: 53183
		public bool AddInOnlineGame;
	}
}
