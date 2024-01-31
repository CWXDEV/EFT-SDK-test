using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EFT.Game.Spawning
{
	// Token: 0x020026A2 RID: 9890
	[ExecuteInEditMode]
	public sealed class SpawnPointMarker : MonoBehaviour, IPositionPoint, ISpawnPointCollider
	{
		// Token: 0x0600C415 RID: 50197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TryCreate(SpawnPointParams[] parameters, Transform parent = null)
		{
			throw null;
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SpawnPointMarker Create(SpawnPointParams @params, Transform parent = null)
		{
			throw null;
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SpawnPointMarker Create(SpawnPointParams @params, GameObject go)
		{
			throw null;
		}

		// Token: 0x0600C418 RID: 50200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600C41A RID: 50202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0600C41C RID: 50204 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C41D RID: 50205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x0600C41E RID: 50206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_2()
		{
			throw null;
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600C41F RID: 50207 RVA: 0x00002050 File Offset: 0x00000250
		public ISpawnPoint SpawnPoint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600C420 RID: 50208 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C421 RID: 50209 RVA: 0x00002050 File Offset: 0x00000250
		public string Id
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

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600C422 RID: 50210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C423 RID: 50211 RVA: 0x00002050 File Offset: 0x00000250
		public BotZone BotZone
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

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600C424 RID: 50212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C425 RID: 50213 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSideMask Sides
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

		// Token: 0x0600C426 RID: 50214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ISpawnPointCollider.Contains(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600C427 RID: 50215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string DebugInfo()
		{
			throw null;
		}

		// Token: 0x0600C428 RID: 50216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpawnPointParams CreateSpawnPointParams()
		{
			throw null;
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FixParams(in SpawnPointParams @params, LoggerClass logger)
		{
			throw null;
		}

		// Token: 0x0600C42A RID: 50218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FixCollider(ISpawnColliderParams @params)
		{
			throw null;
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(string message, ref SpawnPointMarker.Struct763 struct763_0)
		{
			throw null;
		}

		// Token: 0x0400C5DB RID: 50651
		public Color Color;

		// Token: 0x0400C5DC RID: 50652
		[SerializeField]
		private SpawnPoint _spawnPoint;

		// Token: 0x0400C5DD RID: 50653
		[SerializeField]
		private Collider _collider;

		// Token: 0x0400C5DE RID: 50654
		private string string_0;

		// Token: 0x020026A3 RID: 9891
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2213
		{
			// Token: 0x0600C42C RID: 50220 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(SpawnPointMarker marker)
			{
				throw null;
			}

			// Token: 0x0400C5DF RID: 50655
			public static readonly SpawnPointMarker.Class2213 class2213_0;

			// Token: 0x0400C5E0 RID: 50656
			public static Func<SpawnPointMarker, string> func_0;
		}

		// Token: 0x020026A4 RID: 9892
		[CompilerGenerated]
		private sealed class Class2214
		{
			// Token: 0x0600C42D RID: 50221 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BotZone x)
			{
				throw null;
			}

			// Token: 0x0400C5E1 RID: 50657
			public SpawnPointParams @params;
		}

		// Token: 0x020026A5 RID: 9893
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct763
		{
			// Token: 0x0400C5E2 RID: 50658
			public LoggerClass logger;

			// Token: 0x0400C5E3 RID: 50659
			public SpawnPointMarker spawnPointMarker_0;
		}
	}
}
