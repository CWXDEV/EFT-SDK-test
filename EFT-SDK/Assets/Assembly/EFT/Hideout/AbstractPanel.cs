using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI;

namespace EFT.Hideout
{
	// Token: 0x02001B52 RID: 6994
	public abstract class AbstractPanel<T> : UIElement, IDisposable, GInterface171, IUIView
	{
		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009375 RID: 37749 RVA: 0x00002050 File Offset: 0x00000250
		private T Info
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

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06009376 RID: 37750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009377 RID: 37751 RVA: 0x00002050 File Offset: 0x00000250
		private ELevelType LevelType
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

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06009378 RID: 37752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009379 RID: 37753 RVA: 0x00002050 File Offset: 0x00000250
		private Stage Stage
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

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600937A RID: 37754 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600937B RID: 37755 RVA: 0x00002050 File Offset: 0x00000250
		private RelatedData RelatedData
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

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600937D RID: 37757 RVA: 0x00002050 File Offset: 0x00000250
		private AreaData AreaData
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

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x0600937E RID: 37758 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600937F RID: 37759 RVA: 0x00002050 File Offset: 0x00000250
		private InventoryControllerClass InventoryController
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

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009381 RID: 37761 RVA: 0x00002050 File Offset: 0x00000250
		private ISession Session
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

		// Token: 0x06009382 RID: 37762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task Show(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x06009383 RID: 37763
		public abstract Task ShowContents();

		// Token: 0x06009384 RID: 37764
		public abstract void SetInfo();

		// Token: 0x040099F3 RID: 39411
		[CompilerGenerated]
		private T gparam_0;

		// Token: 0x040099F4 RID: 39412
		[CompilerGenerated]
		private ELevelType elevelType_0;

		// Token: 0x040099F5 RID: 39413
		[CompilerGenerated]
		private Stage stage_0;

		// Token: 0x040099F6 RID: 39414
		[CompilerGenerated]
		private RelatedData relatedData_0;

		// Token: 0x040099F7 RID: 39415
		[CompilerGenerated]
		private AreaData areaData_0;

		// Token: 0x040099F8 RID: 39416
		[CompilerGenerated]
		private InventoryControllerClass gclass2757_0;

		// Token: 0x040099F9 RID: 39417
		[CompilerGenerated]
		private ISession ginterface145_0;
	}
}
