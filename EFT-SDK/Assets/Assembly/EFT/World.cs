using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Interactive;
using EFT.SynchronizableObjects;
using EFT.Vehicle;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x02001266 RID: 4710
	internal abstract class World : MonoBehaviour
	{
		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06006277 RID: 25207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006278 RID: 25208 RVA: 0x00002050 File Offset: 0x00000250
		public bool WorldSpawned
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06006279 RID: 25209 RVA: 0x00002050 File Offset: 0x00000250
		internal static NetworkHash128 NetworkHash128_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T smethod_0<T>(IDictionary<string, int> interactables, GClass1636 channels, bool crypted) where T : World
		{
			throw null;
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void vmethod_0()
		{
			throw null;
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal NetworkReader method_0(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600627F RID: 25215 RVA: 0x00002050 File Offset: 0x00000250
		internal static World World_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void smethod_1()
		{
			throw null;
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(GClass1199 loot)
		{
			throw null;
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLampChangeStatePacket(int netId, Turnable.EState state)
		{
			throw null;
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddWindowBreakPacket(int netId, in Vector3 hitPosition)
		{
			throw null;
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddInteractiveObjectsStatusPacket(ArraySegment<byte> segment)
		{
			throw null;
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddUpdateExfiltrationPointPacket(string pointName, EExfiltrationStatus command, List<string> queuedPlayers)
		{
			throw null;
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4()
		{
			throw null;
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddSpawnQuestLootPacket(byte[] item)
		{
			throw null;
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSerialize(NetworkWriter writer, string profileId)
		{
			throw null;
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task OnDeserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterNetworkInteractionObjects(IDictionary<string, int> interactables = null)
		{
			throw null;
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterWorldInteractionObject(WorldInteractiveObject worldInteractiveObject)
		{
			throw null;
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorldInteractiveObject FindDoor(string doorId)
		{
			throw null;
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExfiltrationPointUpdate(ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SubscribeToBorderZones(BorderZone[] zones)
		{
			throw null;
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EmptySubWorld()
		{
			throw null;
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NextSubWorld()
		{
			throw null;
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnSubWorld(Task<Func<TimeSpan>> task)
		{
			throw null;
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_5()
		{
			throw null;
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6()
		{
			throw null;
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task AwaitSpawnCompletion()
		{
			throw null;
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(NetworkWriter writer, string profileId)
		{
			throw null;
		}

		// Token: 0x04006EF9 RID: 28409
		protected readonly int[] int_0;

		// Token: 0x04006EFA RID: 28410
		protected const int int_1 = 2700;

		// Token: 0x04006EFB RID: 28411
		public const int SERIALIZATION_BUFFER_SIZE = 65536;

		// Token: 0x04006EFC RID: 28412
		private readonly List<BTRVehicle> list_0;

		// Token: 0x04006EFD RID: 28413
		private readonly List<WindowBreaker> list_1;

		// Token: 0x04006EFE RID: 28414
		private readonly List<GStruct33> list_2;

		// Token: 0x04006EFF RID: 28415
		protected readonly List<WorldInteractiveObject.GStruct384> list_3;

		// Token: 0x04006F00 RID: 28416
		private List<SynchronizableObject> list_4;

		// Token: 0x04006F01 RID: 28417
		public IDictionary<string, int> Interactables;

		// Token: 0x04006F02 RID: 28418
		protected WorldInteractiveObject[] worldInteractiveObject_0;

		// Token: 0x04006F03 RID: 28419
		private Dictionary<string, WorldInteractiveObject> dictionary_0;

		// Token: 0x04006F04 RID: 28420
		private GClass1636 gclass1636_0;

		// Token: 0x04006F05 RID: 28421
		protected readonly List<SubWorld> list_5;

		// Token: 0x04006F06 RID: 28422
		private int int_2;

		// Token: 0x04006F07 RID: 28423
		private int int_3;

		// Token: 0x04006F08 RID: 28424
		private readonly GClass1199 gclass1199_0;

		// Token: 0x04006F09 RID: 28425
		protected GClass1650 gclass1650_0;

		// Token: 0x04006F0A RID: 28426
		public GStruct118 _previousPacket;

		// Token: 0x04006F0B RID: 28427
		public GStruct118 _packet;

		// Token: 0x04006F0C RID: 28428
		protected GameWorld gameWorld_0;

		// Token: 0x04006F0D RID: 28429
		private bool bool_0;

		// Token: 0x04006F0E RID: 28430
		private readonly TaskCompletionSource<object> taskCompletionSource_0;

		// Token: 0x04006F0F RID: 28431
		private readonly Queue<Task<Func<TimeSpan>>> queue_0;

		// Token: 0x04006F10 RID: 28432
		private Task task_0;

		// Token: 0x04006F11 RID: 28433
		private int int_4;

		// Token: 0x04006F12 RID: 28434
		private List<TaskCompletionSource<object>> list_6;

		// Token: 0x04006F13 RID: 28435
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04006F14 RID: 28436
		private readonly Queue<byte[]> queue_1;

		// Token: 0x04006F15 RID: 28437
		private Task task_1;

		// Token: 0x02001268 RID: 4712
		[CompilerGenerated]
		[Serializable]
		private sealed class Class904
		{
			// Token: 0x0600629E RID: 25246 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TimeSpan method_0()
			{
				throw null;
			}

			// Token: 0x04006F1A RID: 28442
			public static readonly World.Class904 class904_0;

			// Token: 0x04006F1B RID: 28443
			public static Func<TimeSpan> func_0;
		}
	}
}
