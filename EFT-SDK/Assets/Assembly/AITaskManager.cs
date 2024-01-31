using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020004D8 RID: 1240
public class AITaskManager
{
	// Token: 0x06001EED RID: 7917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RegisterDelayedTask(float delay, Action task)
	{
		throw null;
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RegisterDelayedTask(BotOwner bot, float delay, Action task)
	{
		throw null;
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelDelayedTask(int taskId)
	{
		throw null;
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterRegularTask(EAITaskGroupType group, GInterface10 task)
	{
		throw null;
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterRegularTask(GInterface10 regularTask)
	{
		throw null;
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AITaskManager.GClass520 method_2(Action task, float delay, BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(AITaskManager.GClass520 data)
	{
		throw null;
	}

	// Token: 0x040019D4 RID: 6612
	private readonly List<AITaskManager.GClass520> _simpleTasks;

	// Token: 0x040019D5 RID: 6613
	private readonly Dictionary<int, AITaskManager.GClass520> _simpleTaskById;

	// Token: 0x040019D6 RID: 6614
	private int _simpleTasksIdCounter;

	// Token: 0x040019D7 RID: 6615
	private readonly Dictionary<EAITaskGroupType, AITaskManager.Class246> _regularTasks;

	// Token: 0x040019D8 RID: 6616
	private readonly Dictionary<GInterface10, ValueTuple<EAITaskGroupType, int>> _disposeInfoPerUpdatable;

	// Token: 0x040019D9 RID: 6617
	private readonly Queue<AITaskManager.GClass520> _simpleTaskDataPool;

	// Token: 0x020004D9 RID: 1241
	public class GClass520
	{
		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int id, Action task, float delay, float startTime, BotOwner bot)
		{
			throw null;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x040019DA RID: 6618
		public int Id;

		// Token: 0x040019DB RID: 6619
		public Action Task;

		// Token: 0x040019DC RID: 6620
		public float Delay;

		// Token: 0x040019DD RID: 6621
		public float StartTime;

		// Token: 0x040019DE RID: 6622
		public bool IsCancelRequested;

		// Token: 0x040019DF RID: 6623
		public BotOwner Bot;
	}

	// Token: 0x020004DA RID: 1242
	private class Class246
	{
		// Token: 0x06001EFA RID: 7930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int AddNewTask(GInterface10 updatable)
		{
			throw null;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveTask(int id)
		{
			throw null;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateGroup()
		{
			throw null;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x040019E0 RID: 6624
		public readonly float DefaultUpdatePeriod;

		// Token: 0x040019E1 RID: 6625
		public readonly int AverageTaskCount;

		// Token: 0x040019E2 RID: 6626
		public readonly float MaxUpdatePeriod;

		// Token: 0x040019E3 RID: 6627
		public readonly List<AITaskManager.Class246.Class247> Datas;

		// Token: 0x040019E4 RID: 6628
		public readonly Dictionary<int, AITaskManager.Class246.Class247> DataById;

		// Token: 0x040019E5 RID: 6629
		private int int_0;

		// Token: 0x040019E6 RID: 6630
		private int int_1;

		// Token: 0x020004DB RID: 1243
		public class Class247
		{
			// Token: 0x040019E7 RID: 6631
			public int Id;

			// Token: 0x040019E8 RID: 6632
			public GInterface10 Updatable;

			// Token: 0x040019E9 RID: 6633
			public float LastUpdateTime;

			// Token: 0x040019EA RID: 6634
			public bool RemoveRequested;
		}
	}
}
