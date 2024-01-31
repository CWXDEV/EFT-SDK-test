using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x0200125F RID: 4703
	internal sealed class SubWorld : MonoBehaviour
	{
		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06006264 RID: 25188 RVA: 0x00002050 File Offset: 0x00000250
		internal static NetworkHash128 NetworkHash128_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubWorld smethod_0(GameWorld gameWorld, World world, int index, ArrayPool<byte> serializationPool)
		{
			throw null;
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TimeSpan method_0(Stopwatch stopwatch, GClass1199 loot, GClass1391[] info)
		{
			throw null;
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootItemPositionClass[] Chunk(IEnumerable<LootItemPositionClass> loot)
		{
			throw null;
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkWriter OnSerializeLoot(LootItemPositionClass[] loot)
		{
			throw null;
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<NetworkWriter> OnSerializeSearchLoot(LootItemPositionClass[] loot)
		{
			throw null;
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeserializeLoot(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeserializeSearchLoot(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Func<TimeSpan> method_1()
		{
			throw null;
		}

		// Token: 0x04006ED3 RID: 28371
		private GameWorld gameWorld_0;

		// Token: 0x04006ED4 RID: 28372
		private World world_0;

		// Token: 0x04006ED5 RID: 28373
		private int int_0;

		// Token: 0x04006ED6 RID: 28374
		internal static readonly int int_1;

		// Token: 0x04006ED7 RID: 28375
		private ArrayPool<byte> arrayPool_0;

		// Token: 0x04006ED8 RID: 28376
		private const int int_2 = 18;

		// Token: 0x04006ED9 RID: 28377
		private const int int_3 = 65501;

		// Token: 0x04006EDA RID: 28378
		private byte[] byte_0;

		// Token: 0x04006EDB RID: 28379
		private readonly List<byte[]> list_0;

		// Token: 0x02001260 RID: 4704
		[CompilerGenerated]
		[Serializable]
		private sealed class Class901
		{
			// Token: 0x0600626D RID: 25197 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x0600626E RID: 25198 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_1(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x04006EDC RID: 28380
			public static readonly SubWorld.Class901 class901_0;

			// Token: 0x04006EDD RID: 28381
			public static Func<LootItemPositionClass, Item> func_0;

			// Token: 0x04006EDE RID: 28382
			public static Func<LootItemPositionClass, Item> func_1;
		}

		// Token: 0x02001262 RID: 4706
		[CompilerGenerated]
		private sealed class Class903
		{
			// Token: 0x06006274 RID: 25204 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TimeSpan method_0()
			{
				throw null;
			}

			// Token: 0x04006EE9 RID: 28393
			public Stopwatch stopwatch;

			// Token: 0x04006EEA RID: 28394
			public GClass1199 loot;

			// Token: 0x04006EEB RID: 28395
			public List<GClass1391> searchableItemInfos;

			// Token: 0x04006EEC RID: 28396
			public SubWorld subWorld_0;
		}
	}
}
