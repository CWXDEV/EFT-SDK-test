using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.GlobalEvents
{
	// Token: 0x0200261F RID: 9759
	public class CommonEventData : IDisposable, GInterface348, GInterface349
	{
		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600C1D4 RID: 49620 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C1D5 RID: 49621 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsUpdated
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

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Add<T>() where T : GInterface341
		{
			throw null;
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Add(Type type)
		{
			throw null;
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Create<T>() where T : GClass2885
		{
			throw null;
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GInterface341 Create(Type type)
		{
			throw null;
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispatch(Dictionary<string, object> eventData)
		{
			throw null;
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispatch<T>(T eventObject) where T : GInterface341
		{
			throw null;
		}

		// Token: 0x0600C1DC RID: 49628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispatch(Type type, GInterface341 eventObject)
		{
			throw null;
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGet<T>(out List<T> eventList) where T : GInterface341
		{
			throw null;
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGet(string eventName, out List<GInterface341> eventList)
		{
			throw null;
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool TryGet<T>(Type type, out List<T> eventList)
		{
			throw null;
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply()
		{
			throw null;
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref GInterface79 writerStream, bool isFullUpdate = false)
		{
			throw null;
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(ref GInterface76 readerStream)
		{
			throw null;
		}

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400C3D3 RID: 50131
		private const int POOL_SIZE = 20;

		// Token: 0x0400C3D5 RID: 50133
		private readonly Dictionary<Type, List<GInterface341>> _events;

		// Token: 0x0400C3D6 RID: 50134
		[JsonIgnore]
		private readonly Dictionary<Type, List<GInterface341>> _eventsToApply;

		// Token: 0x0400C3D7 RID: 50135
		[JsonIgnore]
		private readonly Dictionary<Type, GClass737<GInterface341>> _pools;

		// Token: 0x0400C3D8 RID: 50136
		[JsonIgnore]
		private readonly Dictionary<Type, int> _serializeSentEventMap;

		// Token: 0x0400C3D9 RID: 50137
		[JsonIgnore]
		private readonly Dictionary<int, Type> _deserializeSentEventMap;

		// Token: 0x0400C3DA RID: 50138
		[JsonIgnore]
		private readonly Dictionary<string, Type> _nameEventMap;

		// Token: 0x0400C3DB RID: 50139
		private int _nextEventID;

		// Token: 0x02002620 RID: 9760
		[CompilerGenerated]
		private sealed class Class2196
		{
			// Token: 0x0400C3DC RID: 50140
			public Type type;
		}
	}
}
