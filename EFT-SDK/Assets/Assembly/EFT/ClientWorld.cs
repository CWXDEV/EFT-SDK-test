using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Interactive;
using EFT.MovingPlatforms;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x020016C9 RID: 5833
	internal class ClientWorld : World
	{
		// Token: 0x1400017B RID: 379
		// (add) Token: 0x06007DE6 RID: 32230 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007DE7 RID: 32231 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, Turnable.EState> OnRpcLampStateChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400017C RID: 380
		// (add) Token: 0x06007DE8 RID: 32232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007DE9 RID: 32233 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, Vector3> OnRpcWindowHit
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06007DEA RID: 32234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_12(GInterface76 reader, PacketPriority priority)
		{
			throw null;
		}

		// Token: 0x06007DEB RID: 32235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0()
		{
			throw null;
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(GInterface76 reader, PacketPriority priority)
		{
			throw null;
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_14()
		{
			throw null;
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SubscribeToBorderZones(BorderZone[] zones)
		{
			throw null;
		}

		// Token: 0x06007DEF RID: 32239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(ref GStruct118 gameWorldPacket)
		{
			throw null;
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(List<GStruct128> packets)
		{
			throw null;
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(Dictionary<int, WorldInteractiveObject.GStruct384> infos, bool init)
		{
			throw null;
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(List<GStruct124> packets)
		{
			throw null;
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20(GStruct124 packet)
		{
			throw null;
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(List<AirplaneDataPacketStruct> packets)
		{
			throw null;
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22(AirplaneDataPacketStruct packet)
		{
			throw null;
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(GClass720<int, LootItem> lootItems)
		{
			throw null;
		}

		// Token: 0x06007DF8 RID: 32248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24(List<GStruct125> packets, Dictionary<int, ObservedCorpse> observedCorpses)
		{
			throw null;
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25(List<GStruct126> packets, GClass720<int, Throwable> grenades)
		{
			throw null;
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(List<GStruct127> packets, MovingPlatform.GClass2927[] adapters)
		{
			throw null;
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_27()
		{
			throw null;
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task OnDeserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_28(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_29(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_33(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34(GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x040084B9 RID: 33977
		private Dictionary<int, WorldInteractiveObject.GStruct384> dictionary_1;

		// Token: 0x040084BA RID: 33978
		[CompilerGenerated]
		private Action<int, Turnable.EState> action_0;

		// Token: 0x040084BB RID: 33979
		[CompilerGenerated]
		private Action<int, Vector3> action_1;

		// Token: 0x040084BC RID: 33980
		private readonly List<GStruct124> list_7;

		// Token: 0x040084BD RID: 33981
		private readonly List<AirplaneDataPacketStruct> list_8;

		// Token: 0x040084BE RID: 33982
		private readonly ArrayPool<byte> arrayPool_0;

		// Token: 0x020016CA RID: 5834
		[CompilerGenerated]
		private sealed class Class1205
		{
			// Token: 0x06007E05 RID: 32261 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPlayer x)
			{
				throw null;
			}

			// Token: 0x040084BF RID: 33983
			public GStruct128 packet;
		}

		// Token: 0x020016CB RID: 5835
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1206
		{
			// Token: 0x06007E06 RID: 32262 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(LampController x)
			{
				throw null;
			}

			// Token: 0x06007E07 RID: 32263 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(LampController x)
			{
				throw null;
			}

			// Token: 0x06007E08 RID: 32264 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(WindowBreaker x)
			{
				throw null;
			}

			// Token: 0x040084C0 RID: 33984
			public static readonly ClientWorld.Class1206 class1206_0;

			// Token: 0x040084C1 RID: 33985
			public static Func<LampController, bool> func_0;

			// Token: 0x040084C2 RID: 33986
			public static Func<LampController, int> func_1;

			// Token: 0x040084C3 RID: 33987
			public static Func<WindowBreaker, bool> func_2;
		}

		// Token: 0x020016CC RID: 5836
		[CompilerGenerated]
		private sealed class Class1207
		{
			// Token: 0x06007E09 RID: 32265 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040084C4 RID: 33988
			public byte[] bytes;

			// Token: 0x040084C5 RID: 33989
			public GClass1496 itemDescriptor;
		}
	}
}
