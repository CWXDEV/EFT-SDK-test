using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200096B RID: 2411
public abstract class GClass813<T, U> : IDisposable where U : GInterface35
{
	// Token: 0x17000953 RID: 2387
	// (get) Token: 0x0600367A RID: 13946 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual GInterface36 ShaderReplacer
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000954 RID: 2388
	// (get) Token: 0x0600367B RID: 13947
	protected abstract string Folder { get; }

	// Token: 0x17000955 RID: 2389
	// (get) Token: 0x0600367C RID: 13948 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual string IconCameraName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000956 RID: 2390
	// (get) Token: 0x0600367D RID: 13949 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual Camera RenderCamera
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600367E RID: 13950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Init()
	{
		throw null;
	}

	// Token: 0x0600367F RID: 13951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearMemoryCache()
	{
		throw null;
	}

	// Token: 0x06003680 RID: 13952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0()
	{
		throw null;
	}

	// Token: 0x06003681 RID: 13953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Sprite> GetItemSpriteAsync(T item, GStruct23 size)
	{
		throw null;
	}

	// Token: 0x06003682 RID: 13954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Task method_1(U icon, T item, GStruct23 size, bool saveToFile, bool requireZeroMip)
	{
		throw null;
	}

	// Token: 0x06003683 RID: 13955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GameObject model, in GStruct23 textureSize, PreviewPivot previewPivot)
	{
		throw null;
	}

	// Token: 0x06003684 RID: 13956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Texture2D method_3(in GStruct23 size)
	{
		throw null;
	}

	// Token: 0x06003685 RID: 13957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D smethod_0(int width, int height)
	{
		throw null;
	}

	// Token: 0x06003686 RID: 13958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sprite method_4(GameObject model, in GStruct23 size, PreviewPivot previewPivot)
	{
		throw null;
	}

	// Token: 0x06003687 RID: 13959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(U icon)
	{
		throw null;
	}

	// Token: 0x06003688 RID: 13960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Task method_6(U icon, string iconPath, GStruct23 size)
	{
		throw null;
	}

	// Token: 0x06003689 RID: 13961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_7(int hash, out U icon)
	{
		throw null;
	}

	// Token: 0x0600368A RID: 13962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_8(int hash, out string path)
	{
		throw null;
	}

	// Token: 0x0600368B RID: 13963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_9(int fileId)
	{
		throw null;
	}

	// Token: 0x0600368C RID: 13964
	protected abstract Task<GClass813<T, U>.RenderModelResult> RenderModel(T item, GClass813<T, U>.SpriteFactory spriteFactory);

	// Token: 0x0600368D RID: 13965
	protected abstract void PoseModelByPivot(GameObject model, Camera camera, float cameraAspect, PreviewPivot.IconSettings settings);

	// Token: 0x0600368E RID: 13966
	protected abstract void PoseModelByBounds(GameObject model, Camera camera, in Bounds bounds);

	// Token: 0x0600368F RID: 13967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Bounds GetBounds(GameObject model)
	{
		throw null;
	}

	// Token: 0x06003690 RID: 13968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(U icon)
	{
		throw null;
	}

	// Token: 0x06003691 RID: 13969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x06003692 RID: 13970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Sprite smethod_2(Texture2D texture)
	{
		throw null;
	}

	// Token: 0x06003693 RID: 13971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x0400376A RID: 14186
	private const int int_0 = 2;

	// Token: 0x0400376B RID: 14187
	private readonly Dictionary<int, U> dictionary_0;

	// Token: 0x0400376C RID: 14188
	private readonly Dictionary<int, int> dictionary_1;

	// Token: 0x0400376D RID: 14189
	[CompilerGenerated]
	private readonly GInterface36 ginterface36_0;

	// Token: 0x0400376E RID: 14190
	private readonly string string_0;

	// Token: 0x0400376F RID: 14191
	private readonly string string_1;

	// Token: 0x04003770 RID: 14192
	private int? nullable_0;

	// Token: 0x04003771 RID: 14193
	private bool bool_0;

	// Token: 0x04003772 RID: 14194
	private int int_1;

	// Token: 0x04003773 RID: 14195
	private int int_2;

	// Token: 0x04003774 RID: 14196
	private Camera camera_0;

	// Token: 0x04003775 RID: 14197
	private bool bool_1;

	// Token: 0x04003776 RID: 14198
	private IconShadow iconShadow_0;

	// Token: 0x04003777 RID: 14199
	private Light[] light_0;

	// Token: 0x04003778 RID: 14200
	private CommandBuffer commandBuffer_0;

	// Token: 0x04003779 RID: 14201
	private CommandBuffer commandBuffer_1;

	// Token: 0x0400377A RID: 14202
	protected GClass820 gclass820_0;

	// Token: 0x0200096C RID: 2412
	// (Invoke) Token: 0x06003694 RID: 13972
	protected delegate Task<Sprite> SpriteFactory(GameObject model, PreviewPivot pivot);

	// Token: 0x0200096D RID: 2413
	protected struct RenderModelResult
	{
		// Token: 0x0400377B RID: 14203
		public Sprite sprite;

		// Token: 0x0400377C RID: 14204
		public bool zeroMipWasLoaded;
	}

	// Token: 0x0200096E RID: 2414
	[StructLayout(LayoutKind.Auto)]
	public struct Struct91
	{
		// Token: 0x06003697 RID: 13975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GClass813<T, U>.Struct91 Store()
		{
			throw null;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Reset()
		{
			throw null;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Restore()
		{
			throw null;
		}

		// Token: 0x0400377D RID: 14205
		public Color AmbientEquatorColor;

		// Token: 0x0400377E RID: 14206
		public Color AmbientGroundColor;

		// Token: 0x0400377F RID: 14207
		public float AmbientIntensity;

		// Token: 0x04003780 RID: 14208
		public Color AmbientLight;

		// Token: 0x04003781 RID: 14209
		public AmbientMode AmbientMode;

		// Token: 0x04003782 RID: 14210
		public Color AmbientSkyColor;

		// Token: 0x04003783 RID: 14211
		public bool Fog;
	}

	// Token: 0x02000971 RID: 2417
	[CompilerGenerated]
	private sealed class Class506
	{
		// Token: 0x0600369E RID: 13982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<Sprite> method_0(GameObject model, PreviewPivot pivot)
		{
			throw null;
		}

		// Token: 0x0400378F RID: 14223
		public GClass813<T, U> gclass813_0;

		// Token: 0x04003790 RID: 14224
		public GStruct23 size;

		// Token: 0x02000972 RID: 2418
		[StructLayout(LayoutKind.Auto)]
		public struct Struct94 : IAsyncStateMachine
		{
			// Token: 0x0600369F RID: 13983 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.MoveNext()
			{
				throw null;
			}

			// Token: 0x060036A0 RID: 13984 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04003791 RID: 14225
			public int int_0;

			// Token: 0x04003792 RID: 14226
			public AsyncTaskMethodBuilder<Sprite> asyncTaskMethodBuilder_0;

			// Token: 0x04003793 RID: 14227
			public GClass813<T, U>.Class506 class506_0;

			// Token: 0x04003794 RID: 14228
			public GameObject model;

			// Token: 0x04003795 RID: 14229
			public PreviewPivot pivot;

			// Token: 0x04003796 RID: 14230
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000974 RID: 2420
	[CompilerGenerated]
	private sealed class Class507
	{
		// Token: 0x060036A3 RID: 13987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<Sprite> method_0(GameObject model, PreviewPivot pivot)
		{
			throw null;
		}

		// Token: 0x0400379D RID: 14237
		public GClass813<T, U> gclass813_0;

		// Token: 0x0400379E RID: 14238
		public GStruct23 size;

		// Token: 0x02000975 RID: 2421
		[StructLayout(LayoutKind.Auto)]
		public struct Struct96 : IAsyncStateMachine
		{
			// Token: 0x060036A4 RID: 13988 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.MoveNext()
			{
				throw null;
			}

			// Token: 0x060036A5 RID: 13989 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400379F RID: 14239
			public int int_0;

			// Token: 0x040037A0 RID: 14240
			public AsyncTaskMethodBuilder<Sprite> asyncTaskMethodBuilder_0;

			// Token: 0x040037A1 RID: 14241
			public GClass813<T, U>.Class507 class507_0;

			// Token: 0x040037A2 RID: 14242
			public GameObject model;

			// Token: 0x040037A3 RID: 14243
			public PreviewPivot pivot;

			// Token: 0x040037A4 RID: 14244
			private Sprite sprite_0;

			// Token: 0x040037A5 RID: 14245
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040037A6 RID: 14246
			private object object_0;
		}
	}
}
