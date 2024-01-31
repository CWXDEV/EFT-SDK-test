using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.Communications;
using UnityEngine;

// Token: 0x02001CB3 RID: 7347
public sealed class NotificationManagerClass
{
	// Token: 0x17001782 RID: 6018
	// (get) Token: 0x06009955 RID: 39253 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009956 RID: 39254 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
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

	// Token: 0x17001783 RID: 6019
	// (get) Token: 0x06009957 RID: 39255 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009958 RID: 39256 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_1
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

	// Token: 0x140001CB RID: 459
	// (add) Token: 0x06009959 RID: 39257 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600995A RID: 39258 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<NotificationClass> OnNotificationReceived
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

	// Token: 0x0600995B RID: 39259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(GInterface144 backEndSession, ENotificationTransportType transportType)
	{
		throw null;
	}

	// Token: 0x0600995C RID: 39260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x0600995D RID: 39261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deactivate()
	{
		throw null;
	}

	// Token: 0x0600995E RID: 39262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeTransport(ENotificationTransportType transportType)
	{
		throw null;
	}

	// Token: 0x0600995F RID: 39263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(NotificationClass notification)
	{
		throw null;
	}

	// Token: 0x06009960 RID: 39264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(ENotificationTransportType transportType)
	{
		throw null;
	}

	// Token: 0x06009961 RID: 39265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06009962 RID: 39266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06009963 RID: 39267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(long responseCode, string message)
	{
		throw null;
	}

	// Token: 0x06009964 RID: 39268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(long responseCode, byte[] bytes)
	{
		throw null;
	}

	// Token: 0x06009965 RID: 39269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(byte[] bytes)
	{
		throw null;
	}

	// Token: 0x06009966 RID: 39270 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private NotificationManagerClass.EProcessError method_7(string message)
	{
		throw null;
	}

	// Token: 0x06009967 RID: 39271 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(long responseCode)
	{
		throw null;
	}

	// Token: 0x06009968 RID: 39272 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(bool withDelay = false)
	{
		throw null;
	}

	// Token: 0x06009969 RID: 39273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x0600996A RID: 39274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisplayMessageNotification(string message, ENotificationDurationType duration = ENotificationDurationType.Default, ENotificationIconType iconType = ENotificationIconType.Default, Color? textColor = null)
	{
		throw null;
	}

	// Token: 0x0600996B RID: 39275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisplayWarningNotification(string message, ENotificationDurationType duration = ENotificationDurationType.Default)
	{
		throw null;
	}

	// Token: 0x0600996C RID: 39276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisplaySingletonWarningNotification(string message)
	{
		throw null;
	}

	// Token: 0x0600996D RID: 39277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisplayNotification(NotificationClass notification)
	{
		throw null;
	}

	// Token: 0x0600996E RID: 39278 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(Result<GClass1227> result)
	{
		throw null;
	}

	// Token: 0x0400A0BF RID: 41151
	public static readonly LoggerClass Logger;

	// Token: 0x0400A0C0 RID: 41152
	private const int int_0 = 100;

	// Token: 0x0400A0C1 RID: 41153
	private const char char_0 = '\n';

	// Token: 0x0400A0C2 RID: 41154
	private const string string_0 = "default_id";

	// Token: 0x0400A0C3 RID: 41155
	private const string string_1 = "channel deleted";

	// Token: 0x0400A0C4 RID: 41156
	private readonly long[] long_0;

	// Token: 0x0400A0C5 RID: 41157
	private readonly long[] long_1;

	// Token: 0x0400A0C6 RID: 41158
	private readonly ENotificationType[] enotificationType_0;

	// Token: 0x0400A0C7 RID: 41159
	private readonly NotificationManagerClass.Class1726 class1726_0;

	// Token: 0x0400A0C8 RID: 41160
	private readonly NotificationManagerClass.Class1725 class1725_0;

	// Token: 0x0400A0C9 RID: 41161
	private string string_2;

	// Token: 0x0400A0CA RID: 41162
	private GClass1227 gclass1227_0;

	// Token: 0x0400A0CB RID: 41163
	private IConnectionHandler ginterface177_0;

	// Token: 0x0400A0CC RID: 41164
	private GInterface144 ginterface144_0;

	// Token: 0x0400A0CD RID: 41165
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400A0CE RID: 41166
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x0400A0CF RID: 41167
	public readonly List<GClass1960> ProfileChangeNotifications;

	// Token: 0x0400A0D0 RID: 41168
	public readonly List<NotificationClass> Notifications;

	// Token: 0x0400A0D1 RID: 41169
	[CompilerGenerated]
	private Action<NotificationClass> action_0;

	// Token: 0x02001CB4 RID: 7348
	private sealed class Class1725
	{
		// Token: 0x0600996F RID: 39279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x06009970 RID: 39280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(bool update = true)
		{
			throw null;
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_1(bool update = true)
		{
			throw null;
		}

		// Token: 0x0400A0D2 RID: 41170
		private const int int_0 = 60;

		// Token: 0x0400A0D3 RID: 41171
		private const int int_1 = 120;

		// Token: 0x0400A0D4 RID: 41172
		private const int int_2 = 30;

		// Token: 0x0400A0D5 RID: 41173
		private int int_3;
	}

	// Token: 0x02001CB5 RID: 7349
	private sealed class Class1726
	{
		// Token: 0x06009972 RID: 39282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(bool messageReceived = true)
		{
			throw null;
		}

		// Token: 0x0400A0D6 RID: 41174
		private const int int_0 = 60;

		// Token: 0x0400A0D7 RID: 41175
		private const float float_0 = 0.5f;

		// Token: 0x0400A0D8 RID: 41176
		private int int_1;

		// Token: 0x0400A0D9 RID: 41177
		private float float_1;
	}

	// Token: 0x02001CB6 RID: 7350
	private sealed class Class349 : LoggerClass
	{
	}

	// Token: 0x02001CB7 RID: 7351
	private enum EProcessError
	{
		// Token: 0x0400A0DB RID: 41179
		None,
		// Token: 0x0400A0DC RID: 41180
		ParseError,
		// Token: 0x0400A0DD RID: 41181
		ChannelDeleted,
		// Token: 0x0400A0DE RID: 41182
		NotificationCreateFailed
	}
}
