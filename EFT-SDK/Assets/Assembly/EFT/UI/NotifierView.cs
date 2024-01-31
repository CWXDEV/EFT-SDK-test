using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Communications;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AA5 RID: 10917
	public sealed class NotifierView : UIElement, GInterface365
	{
		// Token: 0x0600D90A RID: 55562 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D90B RID: 55563 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600D90C RID: 55564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		// Token: 0x0600D90D RID: 55565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProfileChangeHandlerState(NotifierView.GInterface366 profileChangeHandler, bool active)
		{
			throw null;
		}

		// Token: 0x0600D90E RID: 55566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(NotificationClass notification)
		{
			throw null;
		}

		// Token: 0x0600D90F RID: 55567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		BaseNotificationView GInterface365.CreateNotificationView<T>(T notification)
		{
			throw null;
		}

		// Token: 0x0600D910 RID: 55568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		BaseNotificationView GInterface365.CreateDefaultView(NotificationClass notification)
		{
			throw null;
		}

		// Token: 0x0600D911 RID: 55569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(BaseNotificationView notificationView)
		{
			throw null;
		}

		// Token: 0x0600D912 RID: 55570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(BaseNotificationView baseNotificationView)
		{
			throw null;
		}

		// Token: 0x0600D913 RID: 55571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(NotificationClass notification)
		{
			throw null;
		}

		// Token: 0x0600D914 RID: 55572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D915 RID: 55573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400DBDC RID: 56284
		private const string string_0 = "UI/Messaging/applied_profile_changes";

		// Token: 0x0400DBDD RID: 56285
		[SerializeField]
		private BaseNotificationView _defaultNotificationTemplate;

		// Token: 0x0400DBDE RID: 56286
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400DBDF RID: 56287
		[SerializeField]
		private BaseNotificationView[] _notificationTemplates;

		// Token: 0x0400DBE0 RID: 56288
		private NotificationManagerClass gclass2040_0;

		// Token: 0x0400DBE1 RID: 56289
		private const int int_0 = 4;

		// Token: 0x0400DBE2 RID: 56290
		private readonly Queue<BaseNotificationView> queue_0;

		// Token: 0x0400DBE3 RID: 56291
		private readonly List<BaseNotificationView> list_0;

		// Token: 0x0400DBE4 RID: 56292
		private NotifierView.GInterface366 ginterface366_0;

		// Token: 0x0400DBE5 RID: 56293
		private GClass3087 gclass3087_0;

		// Token: 0x02002AA6 RID: 10918
		public interface GInterface366
		{
			// Token: 0x0600D917 RID: 55575
			void OnProfileChangeApplied(ENotificationRequirements requirements);
		}

		// Token: 0x02002AA7 RID: 10919
		[CompilerGenerated]
		private sealed class Class2551
		{
			// Token: 0x0600D918 RID: 55576 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BaseNotificationView x)
			{
				throw null;
			}

			// Token: 0x0400DBE6 RID: 56294
			public NotificationClass notification;
		}

		// Token: 0x02002AA8 RID: 10920
		[CompilerGenerated]
		private sealed class Class2552
		{
			// Token: 0x0600D919 RID: 55577 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DBE7 RID: 56295
			public List<GClass1960> notifications;

			// Token: 0x0400DBE8 RID: 56296
			public NotifierView notifierView_0;

			// Token: 0x0400DBE9 RID: 56297
			public ENotificationRequirements requirement;
		}

		// Token: 0x02002AA9 RID: 10921
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2553
		{
			// Token: 0x0600D91A RID: 55578 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(GClass1960 n)
			{
				throw null;
			}

			// Token: 0x0600D91B RID: 55579 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ENotificationRequirements method_1(GClass1960 n)
			{
				throw null;
			}

			// Token: 0x0400DBEA RID: 56298
			public static readonly NotifierView.Class2553 class2553_0;

			// Token: 0x0400DBEB RID: 56299
			public static Func<GClass1960, string> func_0;

			// Token: 0x0400DBEC RID: 56300
			public static Func<GClass1960, ENotificationRequirements> func_1;
		}
	}
}
