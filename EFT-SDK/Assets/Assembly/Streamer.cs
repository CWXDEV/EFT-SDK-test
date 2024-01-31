using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BD0 RID: 3024
public class Streamer : MonoBehaviour
{
	// Token: 0x060041EC RID: 16876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0(Streamer.Scene scene)
	{
		throw null;
	}

	// Token: 0x060041EF RID: 16879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Streamer.Scene scene)
	{
		throw null;
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_2(Streamer.Scene scene)
	{
		throw null;
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_3(Streamer.Chunk chunk)
	{
		throw null;
	}

	// Token: 0x04004ADF RID: 19167
	public Transform Player;

	// Token: 0x04004AE0 RID: 19168
	[Range(0f, 0.5f)]
	public float Backlash;

	// Token: 0x04004AE1 RID: 19169
	public int MaxPerformanceRaiting;

	// Token: 0x04004AE2 RID: 19170
	public Streamer.Scene[] Scenes;

	// Token: 0x04004AE3 RID: 19171
	private readonly Queue<Streamer.Scene> queue_0;

	// Token: 0x04004AE4 RID: 19172
	private readonly HashSet<Streamer.Scene> hashSet_0;

	// Token: 0x04004AE5 RID: 19173
	private bool bool_0;

	// Token: 0x02000BD1 RID: 3025
	[Serializable]
	public class Scene
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041F3 RID: 16883 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Distances
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04004AE6 RID: 19174
		public string Name;

		// Token: 0x04004AE7 RID: 19175
		public string Path;

		// Token: 0x04004AE8 RID: 19176
		public Streamer.Chunk[] Chunks;

		// Token: 0x04004AE9 RID: 19177
		public const float DefaultDistance = 150f;

		// Token: 0x04004AEA RID: 19178
		public float Distance;

		// Token: 0x04004AEB RID: 19179
		public GameObject[] LODs;

		// Token: 0x04004AEC RID: 19180
		[HideInInspector]
		public Bounds Bounds;

		// Token: 0x04004AED RID: 19181
		[HideInInspector]
		public Streamer.LoadingState State;

		// Token: 0x04004AEE RID: 19182
		[HideInInspector]
		public GameObject[] LODsInstances;
	}

	// Token: 0x02000BD2 RID: 3026
	[Serializable]
	public class Chunk
	{
		// Token: 0x04004AEF RID: 19183
		public string Name;

		// Token: 0x04004AF0 RID: 19184
		public string Path;

		// Token: 0x04004AF1 RID: 19185
		[HideInInspector]
		public Streamer.LoadingState State;
	}

	// Token: 0x02000BD3 RID: 3027
	public enum LoadingState
	{
		// Token: 0x04004AF3 RID: 19187
		Loading,
		// Token: 0x04004AF4 RID: 19188
		Loaded,
		// Token: 0x04004AF5 RID: 19189
		NotLoaded
	}

	// Token: 0x02000BD4 RID: 3028
	[CompilerGenerated]
	[Serializable]
	private sealed class Class617
	{
		// Token: 0x060041F4 RID: 16884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AsyncOperation method_0(Streamer.Chunk chunk)
		{
			throw null;
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(AsyncOperation operation)
		{
			throw null;
		}

		// Token: 0x04004AF6 RID: 19190
		public static readonly Streamer.Class617 class617_0;

		// Token: 0x04004AF7 RID: 19191
		public static Func<Streamer.Chunk, AsyncOperation> func_0;

		// Token: 0x04004AF8 RID: 19192
		public static Func<AsyncOperation, bool> func_1;
	}
}
